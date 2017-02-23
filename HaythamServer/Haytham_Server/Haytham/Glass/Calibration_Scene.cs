using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace Haytham.Glass.Experiments
{
    public class Calibration_Scene
    {
        int wait = 5000;
        int[] calibPoints ;
       
        public Boolean is_sampling = false;
        public Calibration tempCalibration;
        int frN = 8;
        public int numberOfPictures;
        private int failedBlobDetectionCount = 0;
        private int failedBlobDetectionCount_Max = 2;

        public Calibration_Scene()
        {
        }

        public Calibration_Scene(int n, int m)
        {
            numberOfPictures = n * m;

            // METState.Current.GlassServer.client.numberOfPictures = 4;
            tempCalibration = new Calibration("EyeToScene");

            if (numberOfPictures==4)
                tempCalibration.CalibrationType = Calibration.calibration_type.calib_Homography;
            else if (numberOfPictures==16)
                tempCalibration.CalibrationType = Calibration.calibration_type.calib_Polynomial;

            tempCalibration.ScenePoints = new List<AForge.Point>();
            tempCalibration.GazeErrorX = 0;
            tempCalibration.GazeErrorY = 0;

            tempCalibration.CalibrationTarget = 0;
            tempCalibration.Calibrated = false;

            setPoints(n, m);

            //prepare for the first point
            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(tempCalibration.CalibrationTarget, calibPoints[tempCalibration.CalibrationTarget]));
        }

        public void UserIsReady()
        {
            //wait for the user to fixate on the first target
            Thread.Sleep(wait);

            //take picture
            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-1, -1));
        }

        public void ProcessImg(Image img)
        {
            //Store the corresponding eye and gaze imidiately 

            //get eye sample.       EYE FEATURE IS BEEN ALREADY AVERAGED inside the EYE calss
            tempCalibration.Source[0, tempCalibration.CalibrationTarget] = METState.Current.eyeFeature.X;
            tempCalibration.Source[1, tempCalibration.CalibrationTarget] = METState.Current.eyeFeature.Y;

            if (METState.Current.Scene_Calibration_Target_AutomaticDetection)
            {
                Point result = DetectTarget(img,calibPoints[ tempCalibration.CalibrationTarget]+1);// this function should be able to detect one or n points otherwise it returns -1
                GetSample(result);
            }
            else  //here we need to wait for the conductor to click on the corresponding target int the received image
            {

            }
        }
        public void CorrectOffset()
        { 
            //mode = Mode.mainLoop;

            //METState.Current.GlassFrontView_Resolution = new Size(bitmap.Width, bitmap.Height);

            //Point[] result = processImg(bitmap);
            //currentImage = bitmap;

            //if (result[0].X != -1 && result[0].Y != -1 && (result.Count() == 1 || result.Count() == 9))//if target is detected in the image
            //{

            //    failedBlobDetectionCount = 0;

            //    AForge.Point targetInTheMiddle = new AForge.Point(0, 0);
            //    if (result.Count() == 1)
            //        targetInTheMiddle = new AForge.Point(result[0].X, result[0].Y);
            //    else if (result.Count() == 9)
            //        targetInTheMiddle = new AForge.Point(result[4].X, result[4].Y);


            //    if (METState.Current.EyeToScene_Mapping.Calibrated)
            //    {
            //         AForge.Point normalizedEye = METState.Current.EyeToEye_Mapping.Calibrated ? METState.Current.EyeToEye_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, 0, 0) : METState.Current.eyeFeature;

            //        AForge.Point Gaze = METState.Current.EyeToScene_Mapping.Map(normalizedEye.X, normalizedEye.Y, targetInTheMiddle.X, targetInTheMiddle.Y);

            //        METState.Current.EyeToScene_Mapping.GazeErrorX = Gaze.X;// 
            //        METState.Current.EyeToScene_Mapping.GazeErrorY = Gaze.Y;//
            //    }
                                           


            //    correctOffset_Scene = false;


            //}
            //else
            //{
            //    failedBlobDetectionCount++;

            //    if (failedBlobDetectionCount <= failedBlobDetectionCount_Max)
            //    {
            //        //tell the user to look at the next target
            //        server.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-5, -5));//point x (th) of y (total)

            //        //wait between points
            //        Thread.Sleep(wait);

            //    }
            //    else
            //    {
            //        failedBlobDetectionCount = 0;
            //        //Calibration terminated!
            //        server.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-3, -3));//point x (th) of y (total)


            //    }
            //}
        }

        private Point DetectTarget(Image img, int num)
        {
            try
            {
                Haytham.Glass.SceneImage test = new Haytham.Glass.SceneImage();

                Point testPoint = test.getCalibrationTarget(img, 200, num, false);
               
                //METState.Current.METCoreObject.SendToForm(test.result_Image, "imScene");
                
                METState.Current.GlassServer.client.currentImage =new Bitmap(test.result_Image);//This crashes the program

                return testPoint;
            }
            catch (Exception err)
            {
                return new Point(-1, -1);
            }
        }

        private Point[] DetectTarget(Image img)
        {
            Haytham.Glass.SceneImage test = new Haytham.Glass.SceneImage();

            Point[] testPoint = test.getCalibrationTargets(img, 200, false);

            METState.Current.METCoreObject.SendToForm(test.result_Image, "imScene");

            return testPoint;
        }

        public void GetSample(Point target)
        {
            if (target.X != -1 && target.Y != -1)//if (-1,-1) : target is not detected in the image
            {
                failedBlobDetectionCount = 0;

                tempCalibration.ScenePoints.Add(new AForge.Point(target.X, target.Y));
                tempCalibration.Destination[0, tempCalibration.CalibrationTarget] = target.X;
                tempCalibration.Destination[1, tempCalibration.CalibrationTarget] = target.Y;

                tempCalibration.CalibrationTarget++;

                if (tempCalibration.CalibrationTarget == numberOfPictures)
                {
                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-2, -2));//DONE

                    tempCalibration.CalibrationTarget = 0;
                    tempCalibration.Calibrate();
                    tempCalibration.Calibrated = true;

                    METState.Current.EyeToScene_Mapping = tempCalibration;
                    Finish();
                }
                else
                {
                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(tempCalibration.CalibrationTarget, calibPoints[tempCalibration.CalibrationTarget]));
                }
            }

            else if (target.X == -1 && target.Y == -1)
            {
                failedBlobDetectionCount++;

                if (failedBlobDetectionCount <= failedBlobDetectionCount_Max)
                {
                    //tell the user to look at the next target
                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-5, -5));
                }
                else
                {
                    failedBlobDetectionCount = 0;
                    //Calibration terminated!
                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Scene, new Point(-3, -3));

                    Finish();
                }
            }
        }

        private void Finish()
        {
           // METState.Current.GlassServer.client.myGlassReady_State = myGlass.Client.Ready_State.Finished;
            is_sampling = false; 
        }

        private int SearchArray(int[] arr,int val)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] == val) return i;
            }

            return -1;
        }

        private void setPoints(int n, int m)// grid of n*m points
        {
            calibPoints = new int[m * n];
           
            for (int i = 0; i < n*m; i++)
            {
                calibPoints[i] = i; 
            }

            calibPoints = ShuffleArray(calibPoints);
        }

        int[] ShuffleArray(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
        }
    }
}