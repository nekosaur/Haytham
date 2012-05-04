﻿
//<copyright file="METCore.cs" company="ITU">
//This file is part of Haytham 
//Copyright (C) 2012 Diako Mardanbegi
// ------------------------------------------------------------------------
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ------------------------------------------------------------------------
// </copyright>
// <author>Diako Mardanbegi</author>
// <email>dima@itu.dk</email>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using AForge.Video.DirectShow;
using AForge.Video;

using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;


namespace Haytham
{

    public class METCore
    {
        public _SendToForm SendToForm;

        public event TrackerEventHandler TrackerEventEye;
        public event TrackerEventHandler TrackerEventScene;
        public ImageProcessing_Emgu EmgImgProcssing = new ImageProcessing_Emgu();


        public void EyeFrameCaptured(object sender, NewFrameEventArgs eventArgs)
        {
            System.Drawing.Bitmap TempImage;
            TempImage = (Bitmap)eventArgs.Frame.Clone();

            METState.Current.EyeImageOrginal = new Image<Bgr, Byte>((Bitmap)TempImage);
            METState.Current.EyeImageForShow = new Image<Bgr, Byte>((Bitmap)TempImage);

            METEventArg metEventArg = new METEventArg();
            metEventArg.AdditionalArg = "Eye";
            metEventArg.image = new Image<Bgr, byte>((Bitmap)TempImage);



            OnTrackerEventEye(metEventArg);


        }
        public void SceneFrameCaptured(object sender, NewFrameEventArgs eventArgs)
        {

            System.Drawing.Bitmap TempImage;
            TempImage = (Bitmap)eventArgs.Frame.Clone();

            METState.Current.SceneImageForShow = new Image<Bgr, Byte>((Bitmap)TempImage);
            METState.Current.SceneImageOrginal = new Image<Bgr, Byte>((Bitmap)TempImage);

            # region Distortion
            if (METState.Current.sceneCameraUnDistortion && METState.Current.SceneVideoFile == null)
            {

                #region UnDistortion

                METState.Current.ProcessTimeSceneBranch.Timer("UnDistortion", "Start");

                Matrix<float> mapx = new Matrix<float>(new Size(TempImage.Width, TempImage.Height));
                Matrix<float> mapy = new Matrix<float>(new Size(TempImage.Width, TempImage.Height));

                METState.Current.intrinsic_param.InitUndistortMap(TempImage.Width, TempImage.Height, out mapx, out mapy);  //DA FINIRE



                // Image<Bgr, byte> img = chessboard.Clone();
                CvInvoke.cvRemap(METState.Current.SceneImageForShow.Ptr, METState.Current.SceneImageOrginal.Ptr, mapx.Ptr, mapy.Ptr, /*8*/(int)Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, new MCvScalar(0));

                METState.Current.ProcessTimeSceneBranch.Timer("UnDistortion", "Stop");

                #endregion UnDistortion
                METState.Current.SceneImageForShow = new Image<Bgr, Byte>(METState.Current.SceneImageOrginal.Bitmap);
            }
            # endregion Distortion

            METEventArg metEventArg = new METEventArg();
            metEventArg.AdditionalArg = "Scene";
            metEventArg.image = METState.Current.SceneImageOrginal;
            METState.Current.METCoreObject.OnTrackerEventScene(metEventArg);
        }


        public void MainMethodEye(object sender, METEventArg e)
        {

            METState.Current.ProcessTimeEyeBranch.Timer("Total", "Start");

            METState.Current.eye.eyeData_Shift();//Prepare eyeDataArray for new frame

            #region set pupil threshold first time
            //should be improved.................
            if (METState.Current.firstPupilDetection)
            {
                METState.Current.firstPupilDetection = false;
                Image<Gray, Byte> GrayImg = e.image.Convert<Gray, Byte>();
                // gather statistics
                AForge.Imaging.ImageStatistics stat = new AForge.Imaging.ImageStatistics(GrayImg.Bitmap);
                // get red channel's histogram
                AForge.Math.Histogram b = stat.Gray;
                // check mean value of red channel
                // Debug.WriteLine(b.Mean + "," + b.StdDev + "," + b.Min);
                //
                METState.Current.PupilThreshold = (int)b.Mean / 2;
                SendToForm(METState.Current.PupilThreshold, "PupilThreshold");

            }
            #endregion set pupil threshold first time

            #region find glint
            if (METState.Current.detectGlint)
            {
                METState.Current.ProcessTimeEyeBranch.Timer("Find Glint", "Start");
                if ((!METState.Current.detectPupil) | (METState.Current.detectPupil & METState.Current.eye.eyeData[1].pupilFound))
                {
                    METState.Current.eye.FindGlint(e.image, METState.Current.glintThreshold);// Glintcenter=(0,0) if there is no glint
                    // if (!METState.Current.detectPupil) EmgImgProcssing.DrawCircle(METState.Current.EyeImageForShow, METState.Current.EyeImageForShow.Width / 2, METState.Current.EyeImageForShow.Height / 2, (int)(METState.Current.IrisDiameter));
                }
                if (METState.Current.eye.eyeData[0].glintCenter != new Point(0, 0)) SendToForm(METState.Current.eye.eyeData[0].glintCenter, "lblGC");
                else SendToForm("NoGlint", "lblGC");

                METState.Current.ProcessTimeEyeBranch.Timer("Find Glint", "Stop");
            }
            #endregion find glint

            #region find pupil

            if (METState.Current.detectPupil)
            {


                METState.Current.ProcessTimeEyeBranch.Timer("Find Pupil", "Start");

                METState.Current.eye.FindPupil(e.image, METState.Current.PupilThreshold);

                #region Draw Iris
                if (METState.Current.showIris)
                {
                    SizeF size = new SizeF((METState.Current.eye.GetPupilEllipseSizeMedian(10).Width / METState.Current.eye.GetPupilEllipseSizeMedian(10).Height) * (float)METState.Current.IrisDiameter, (float)METState.Current.IrisDiameter);
                    if (size.Width == 0 | float.IsNaN(size.Width)) size = new SizeF((float)METState.Current.IrisDiameter, (float)METState.Current.IrisDiameter);//for the first frames where median is 0 or NoN


                    if (METState.Current.eye.LargScan == false && METState.Current.eye.eyeData[0].pupilFound)
                    {
                        METState.Current.CounterBeforeDrawingIrisCircle = 0;
                        Ellipse IrisEllipse = new Emgu.CV.Structure.Ellipse(new PointF(METState.Current.eye.eyeData[0].pupilCenter.X, METState.Current.eye.eyeData[0].pupilCenter.Y), size, METState.Current.eye.eyeData[0].pupilEllipse.MCvBox2D.angle - 90);
                        EmgImgProcssing.DrawEllipse(METState.Current.EyeImageForShow, IrisEllipse, new Bgr(100, 100, 100));
                    }
                    else
                    {
                        #region wait
                        bool wait = false;
                        if (METState.Current.CounterBeforeDrawingIrisCircle < 10)
                        {
                            METState.Current.CounterBeforeDrawingIrisCircle++;
                            wait = true;
                        }

                        #endregion wait

                        if (!wait) EmgImgProcssing.DrawIrisCircle(METState.Current.EyeImageForShow, METState.Current.EyeImageForShow.Width / 2, METState.Current.EyeImageForShow.Height / 2, (int)(METState.Current.IrisDiameter));


                    }

                }
                #endregion Draw Iris

                if (METState.Current.eye.eyeData[0].pupilFound) SendToForm(METState.Current.eye.eyeData[0].pupilCenter, "lblPC");
                else SendToForm("NoPupil", "lblPC");


                METState.Current.ProcessTimeEyeBranch.Timer("Find Pupil", "Stop");


                #region Plot graph
                //chart

                if (METState.Current.enablePlot)
                    {

                        METState.Current.ProcessTimeEyeBranch.Timer("Plot", "Start");
                        if (METState.Current.eye.eyeData[0].pupilFound)
                        {
                            SendToForm(METState.Current.eye.eyeData[0].pupilCenter.X, "Chart1");
                            SendToForm(METState.Current.eye.eyeData[0].pupilCenter.Y, "Chart2");
                            SendToForm(METState.Current.eye.eyeData[0].pupilDiameter, "Chart3");

                        }
                        else
                        {
                            SendToForm(Double.NaN, "Chart1");
                            SendToForm(Double.NaN, "Chart2");
                            SendToForm(Double.NaN, "Chart3");

                        }
                        METState.Current.ProcessTimeEyeBranch.Timer("Plot", "Stop");
                    }
                #endregion Plot
               
            }
            #endregion find pupil

            #region set data for mapping
            if (METState.Current.calibration_eyeFeature == METState.Calibration_EyeFeature.Pupil)
            {

                METState.Current.eyeFeature = METState.Current.eye.eyeData[0].pupilCenter;
                if (METState.Current.GazeSmoother) METState.Current.eyeFeature = METState.Current.eye.GetPupilCenterMedian(20);
            }
            else if (METState.Current.calibration_eyeFeature == METState.Calibration_EyeFeature.PupilGlintVector)
            {
                METState.Current.eyeFeature.X = METState.Current.eye.eyeData[0].glintCenter.X - METState.Current.eye.eyeData[0].pupilCenter.X;
                METState.Current.eyeFeature.Y = METState.Current.eye.eyeData[0].glintCenter.Y - METState.Current.eye.eyeData[0].pupilCenter.Y;
                if (METState.Current.GazeSmoother) METState.Current.eyeFeature = METState.Current.eye.GetPupilGlintVectorMedian(20);

            }


            #endregion set data for mapping

            #region glint Drawing (injast chon mikham rooye drawing pupil biofte)

            if (METState.Current.detectGlint && METState.Current.eye.eyeData[0].glintCenter != new Point(0, 0))
            {
                if (METState.Current.showGlint)
                {
                    try
                    {
                        CvInvoke.cvSetImageROI(METState.Current.EyeImageForShow, METState.Current.eye.glintROI);
                        Image<Bgr, Byte> temp = EmgImgProcssing.ColoredMask((Bitmap)METState.Current.eye.glintBlob.image, METState.Current.EyeImageForShow, new Bgr(System.Drawing.Color.DarkBlue), false);
                        CvInvoke.cvCopy(temp.Ptr, METState.Current.EyeImageForShow.Ptr, new IntPtr());
                        CvInvoke.cvResetImageROI(METState.Current.EyeImageForShow);
                    }
                    catch (Exception err)
                    {
                       // System.Windows.Forms.MessageBox.Show(err.ToString());

                    }


                    #region draw circle around glint blobs

                    //Point bc = new Point();
                    //for (int i = 0; i < METState.Current.eye.glintBlob.blobs_Filtered.Count(); i++)
                    //{
                    //    bc = METState.Current.eye.correctGlintPoint(METState.Current.eye.glintBlob.blobs_Filtered[i].CenterOfGravity);
                    //    EmgImgProcssing.DrawCircle(METState.Current.EyeImageForShow, bc.X, bc.Y, Color.Red);
                    //}

                    #endregion draw circle around glint blobs


                    if (METState.Current.eye.eyeData[0].glintCenter.X != 0)//glint found
                    {

                        if (METState.Current.detectPupil & METState.Current.eye.eyeData[1].pupilFound)
                            EmgImgProcssing.DrawLine(METState.Current.EyeImageForShow, METState.Current.eye.eyeData[0].glintCenter, METState.Current.eye.eyeData[0].pupilCenter, Color.Black);
                        else if (!METState.Current.detectPupil)
                            EmgImgProcssing.DrawCross(METState.Current.EyeImageForShow, METState.Current.eye.eyeData[0].glintCenter.X, METState.Current.eye.eyeData[0].glintCenter.Y, Color.Green);
                    }
                }
            }

            #endregion glint  Drawing (injast chon mikham rooye drawing pupil biofte)

            #region Record Eye Data
            if (METState.Current.EyeIsRecording == true)
            {
                METState.Current.ProcessTimeEyeBranch.Timer("Record Eye Data", "Start");


                METState.Current.EyeVideoWriterFrameNumber += 1;
                METState.Current.EyeVideoWriter.WriteFrame<Bgr, Byte>(METState.Current.EyeImageForShow);

                //text file
                string GazeDataLine = METState.Current.eye.eyeData[0].pupilCenter.X + "," + METState.Current.eye.eyeData[0].pupilCenter.Y + "," + METState.Current.eye.eyeData[0].pupilDiameter;// +"," + METState.Current.Gaze.X + "," + METState.Current.Gaze.Y;
                if (METState.Current.TextFileDataExport != null) METState.Current.TextFileDataExport.WriteLine(GazeDataLine);
                METState.Current.ProcessTimeEyeBranch.Timer("Record Eye Data", "Stop");

            }
            #endregion Record Eye Data

            METState.Current.ProcessTimeEyeBranch.Timer("Total", "Stop");
            SendToForm("", "textBoxTimerEye");//update the timer text box and show the ProcessTimeEyeBranch
            METState.Current.ProcessTimeEyeBranch.TimerResults.Clear();
        }
        public void MainMethodScene(object sender, METEventArg e)
        {
            METState.Current.ProcessTimeSceneBranch.Timer("Total", "Start");

            #region Gaze estimation on scene
            if (METState.Current.EyeToScene_Mapping.Calibrated == true) CalculateGazeOnScene();
            #endregion Gaze estimation on scene

            #region screen

            if (METState.Current.SceneDetection)
            {

                METState.Current.ProcessTimeSceneBranch.Timer("Screen Detection", "Start");
                bool detected = METState.Current.monitor.DetectScreen(e.image);
                METState.Current.monitor.DAS.NoRectangle_FrameCounter = detected ? 0 : METState.Current.monitor.DAS.NoRectangle_FrameCounter+1;

                METState.Current.ProcessTimeSceneBranch.Timer("Screen Detection", "Stop");

                #region only when screen found and screen is connected

                if (METState.Current.server.CountTVClients() != 0 || METState.Current.server.CountMonitorClients() != 0)
                {

                    #region identification

                    METState.Current.ProcessTimeSceneBranch.Timer("Screen identification", "Start");
                    METState.Current.monitor.IdentifyScreen(e.image);
                    METState.Current.ProcessTimeSceneBranch.Timer("Screen identification", "Stop");

                    #endregion identification



                    #region  Mapping of PoR from Scene to screen & D3D

                    if (detected && METState.Current.ControlClientMouse && METState.Current.EyeToScene_Mapping.Calibrated && METState.Current.eye.eyeData[0].pupilFound && METState.Current.monitor.IsGazeInsideMonitor())
                    {
                        METState.Current.monitor.CalculateMonitorGazePoint();
                        //System.Windows.Forms.Cursor.Position = new Point(Convert.ToInt32(METState.Current.Monitor_1_Gaze.X), Convert.ToInt32(METState.Current.Monitor_1_Gaze.Y)); 

                        METState.Current.server.SendToClient("cursor", "Monitor", false, METState.Current.server.GetCondition(METState.Current.server.activeScreen, "Gaze"));

                        Point mediantemp = new Point(0, 0);
                        if (METState.Current.clientMouseSmoothing) mediantemp = METState.Current.monitor.CalculateScreenGazeMedian(10, 0);
                        else mediantemp = METState.Current.monitor.screenGazeData[0].centerPosition;

                        METState.Current.server.SendToClient(mediantemp.X.ToString(), "Monitor", false, METState.Current.server.GetCondition(METState.Current.server.activeScreen, "Gaze"));
                        METState.Current.server.SendToClient(mediantemp.Y.ToString(), "Monitor", false, METState.Current.server.GetCondition(METState.Current.server.activeScreen, "Gaze"));

                        #region 3D (calculate the angle of view based on the rectangle shape)
                        if (METState.Current.server.GetCondition(METState.Current.server.activeScreen, "D3D"))
                        {
                            METState.Current.server.SendToClient("D3D", "Monitor", false, true);
                            Point D3D = METState.Current.monitor.GetD3D();
                            METState.Current.server.SendToClient(D3D.X.ToString(), "Monitor", false, true);
                            METState.Current.server.SendToClient(D3D.Y.ToString(), "Monitor", false, true);
                        }
                        #endregion 3D (calculate the angle of view based on the rectangle shape)
                    }
                    #endregion  Mapping of PoR from Scene to screen


                }
                #endregion only when screen found and screen is connected


            }
            #endregion screen

            #region Draw gaze cross on image
            if (METState.Current.ShowGaze) EmgImgProcssing.DrawCross(METState.Current.SceneImageForShow, METState.Current.Gaze.X, METState.Current.Gaze.Y, Color.Red);
            #endregion Draw gaze cross on image

            #region  Gaze Point Optic Flow ///didn't work. but it was a good idea keep it in your mind


            //Point ROIc = new Point( METState.Current.Gaze.X, METState.Current.Gaze.Y);
            //Size ROIsize = new Size(50,50);
            //bool GazeOpticFlowReady =true;
            //Size winsize = new Size(5, 5);
            //if (ROIc.X -ROIsize.Width< 0) GazeOpticFlowReady = false;
            //if (ROIc.Y-ROIsize.Height < 0) GazeOpticFlowReady = false;
            //if (ROIc.X + ROIsize.Width  > img.Width ) GazeOpticFlowReady = false;
            //if (ROIc.Y + ROIsize.Height > img.Height) GazeOpticFlowReady = false;

            //if (GazeOpticFlowReady)
            //{
            //    GazePointOpticFlow.process(img, ROIc, ROIsize, winsize, METState.Current.SceneImageForShow, true, "",2);
            //    SendToForm(GazePointOpticFlow.AverageVelocityAmount.ToString(), "pbGazeOpticFlow");

            //    if (GazePointOpticFlow.AverageVelocityAmount > METState.Current.vel_GazeOpticThresh )
            //    {
            //        GazePointOpticFlow.Draw("Rejected");
            //        METState.Current.ErrorSound.Play();
            //    }
            //}
            #endregion

            #region Record Scene Data
            if (METState.Current.SceneIsRecording == true)
            {
                METState.Current.ProcessTimeSceneBranch.Timer("Record Scene Data", "Start");

                METState.Current.SceneVideoWriterFrameNumber += 1;
                METState.Current.SceneVideoWriter.WriteFrame<Bgr, Byte>(METState.Current.SceneImageForShow);

                //Capture frames
                // METState.Current.SceneImageForShow.Save(METState.Current.GazeData.filenamewithoutextension + "_" + METState.Current.SceneVideoWriterFrameNumber +".jpg");
                METState.Current.ProcessTimeSceneBranch.Timer("Record Scene Data", "Stop");

            }

            #endregion Record Scene Data

            METState.Current.ProcessTimeSceneBranch.Timer("Total", "Stop");
            SendToForm("", "textBoxTimerScene");
            METState.Current.ProcessTimeSceneBranch.TimerResults.Clear();
        }

        public void OnTrackerEventEye(METEventArg e)//protected virtual
        {
            if (TrackerEventEye != null)
            {
                MainMethodEye(this, e);

                if (METState.Current.syncCameras && (METState.Current.SceneCamera != null && METState.Current.SceneCamera.IsRunning) || (METState.Current.SceneVideoFile != null && METState.Current.SceneVideoFile.IsRunning))
                {

                    try
                    {
                        METState.Current.camera1Acquired.WaitOne();
                    }
                    catch (Exception err)
                    { }

                }
                TrackerEventEye(this, e);//Raise the event

            }
        }
        public void OnTrackerEventScene(METEventArg e)//protected virtual
        {

            if (TrackerEventScene != null)
            {
                MainMethodScene(this, e);



                try
                {
                    METState.Current.camera1Acquired.Set();
                }
                catch (Exception err)
                { }
                TrackerEventScene(this, e);//Raise the event


            }
        }

        public void CalculateGazeOnScene()
        {
            //Point gaze = new Point();

            //if (METState.Current.MakeLinear == false) gaze = METState.Current.EyeToScene_Mapping.Map(METState.Current.pupil.eyeResult.X, METState.Current.pupil.eyeResult.Y, METState.Current.GazeErrorX, METState.Current.GazeErrorY);
            METState.Current.Gaze = METState.Current.EyeToScene_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, METState.Current.GazeErrorX, METState.Current.GazeErrorY);

            //METState.Current.Gaze.X = gaze.X;
            //METState.Current.Gaze.Y = gaze.Y;

        }

        public void SaveCameraCalibrationData()
        {
            #region Save Data
            //Intrinsic
            TextFile parms = new TextFile("SceneCameraParameters");

            parms.WriteLine("Intrinsic Parameters");



            for (int j = 0; j < METState.Current.intrinsic_param.IntrinsicMatrix.Width; j++)
            {
                for (int i = 0; i < METState.Current.intrinsic_param.IntrinsicMatrix.Height; i++)
                {
                    if (i != 0) parms.Write(" , ");


                    parms.Write(METState.Current.intrinsic_param.IntrinsicMatrix[i, j].ToString());
                }
                parms.WriteLine(" ");
            }


            //Extrinsic
            // parms.WriteLine("Intrinsic Parameters");
            //....

            parms.CloseFile();



            //Save Corners for the next time
            TextFile PointsData = new TextFile("CameraCalibrationData_image_points");

            PointsData.WriteLine("Camera Calibration Data image_points");

            for (int j = 0; j < METState.Current.image_points.GetLength(0); j++)
            {
                for (int i = 0; i < METState.Current.image_points[0].GetLength(0); i++)
                {

                    PointsData.WriteLine(METState.Current.image_points[j][i].X.ToString());
                    PointsData.WriteLine(METState.Current.image_points[j][i].Y.ToString());

                }
            }
            PointsData.WriteLine("End Of CameraCalibrationData_image_points");
            PointsData.CloseFile();

            PointsData = new TextFile("CameraCalibrationData_object_points");

            PointsData.WriteLine("Camera Calibration Data object_points");


            for (int j = 0; j < METState.Current.object_points.GetLength(0); j++)
            {
                for (int i = 0; i < METState.Current.object_points[0].GetLength(0); i++)
                {

                    PointsData.WriteLine(METState.Current.object_points[j][i].x.ToString());
                    PointsData.WriteLine(METState.Current.object_points[j][i].y.ToString());
                    PointsData.WriteLine(METState.Current.object_points[j][i].z.ToString());

                }
            }
            PointsData.WriteLine("End Of CameraCalibrationData_object_points");

            PointsData.CloseFile();
            #endregion
        }
        public bool LoadCameraCalibrationData()
        {
            bool ok = true;

            #region Load SceneCameraParameters of last cameraCalibration time
            try
            {
                //Set Variables
                METState.Current.sceneCameraUnDistortion = false;
                SendToForm(false, "UnDistortion");

                METState.Current.sceneCameraCalibrating = true;
                METState.Current.cameraCalibrationSamplesCount = 0;
                METState.Current.corners = new PointF[METState.Current.ChessBoard_W * METState.Current.ChessBoard_H];
                METState.Current.intrinsic_param = new IntrinsicCameraParameters();
                METState.Current.extrinsic_param = new ExtrinsicCameraParameters[METState.Current.cameraCalibrationSamples];


                //Preparing the objects
                METState.Current.object_points = new MCvPoint3D32f[METState.Current.cameraCalibrationSamples][];
                METState.Current.image_points = new PointF[METState.Current.cameraCalibrationSamples][];


                for (int i = 0; i < 10; i++)
                {
                    // for (int j = 0; j < METState.Current.ChessBoard_W* METState.Current.ChessBoard_H; j++)
                    // {

                    METState.Current.image_points[i] = new PointF[METState.Current.ChessBoard_W * METState.Current.ChessBoard_H];
                    // }
                    METState.Current.object_points[i] = new MCvPoint3D32f[METState.Current.ChessBoard_W * METState.Current.ChessBoard_H];

                }

                //Load Data
                StreamReader SW = new StreamReader("CameraCalibrationData_image_points.txt");
                string firstline = SW.ReadLine();
                for (int j = 0; j < METState.Current.cameraCalibrationSamples; j++)
                {
                    for (int i = 0; i < METState.Current.ChessBoard_W * METState.Current.ChessBoard_H; i++)
                    {

                        METState.Current.image_points[j][i].X = float.Parse(SW.ReadLine());
                        METState.Current.image_points[j][i].Y = float.Parse(SW.ReadLine());

                    }
                }
                // System.Windows.Forms. MessageBox.Show(SW.ReadLine());
                SW.Close();

                SW = new StreamReader("CameraCalibrationData_object_points.txt");
                firstline = SW.ReadLine();
                for (int j = 0; j < METState.Current.cameraCalibrationSamples; j++)
                {
                    for (int i = 0; i < METState.Current.ChessBoard_W * METState.Current.ChessBoard_H; i++)
                    {

                        METState.Current.object_points[j][i].x = float.Parse(SW.ReadLine());
                        METState.Current.object_points[j][i].y = float.Parse(SW.ReadLine());
                        METState.Current.object_points[j][i].z = float.Parse(SW.ReadLine());

                    }
                }
                //  System.Windows.Forms.MessageBox.Show(SW.ReadLine());

                SW.Close();




            }
            catch (Exception er)
            {
                System.Windows.Forms.MessageBox.Show(er.Message.ToString());

                ok = false;
            }

            #endregion Load SceneCameraParameters of last cameraCalibration time

            return ok;
        }

    }
}