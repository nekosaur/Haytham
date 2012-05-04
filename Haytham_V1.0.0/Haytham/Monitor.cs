
//<copyright file="Monitor.cs" company="ITU">
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
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;//point
using Emgu.CV.Structure;
using Emgu.CV;

namespace Haytham
{
    public class Monitor
    {
        public struct ScreenGazeData
        {
            public string tag { get; set; }
            public Point centerPosition { get; set; }

        }
        public ImageProcessing_Emgu EmgImgProcssing = new ImageProcessing_Emgu();
        public DetectActiveScreen DAS = new DetectActiveScreen();

        public Point ScreenGazeDataWhenVolumeStart = new Point(0, 0);
        public Point ScreenGazeDataWhenGestureStart = new Point(0, 0);
        public Point ScreenGazeDataMedianOfGesture = new Point(0, 0);

        public ScreenGazeData[] screenGazeData = new ScreenGazeData[500];

        public Point[] ScreenCorners = new Point[4];
        //public Matrix<double> ScreenCorners = new Matrix<double>(2, 4);

        public double RectangleArea = 0;
        public int Real_Monitor_W;// = 1440;//1920;// 1280;//;//Default
        public int Real_Monitor_H;//= 900;//1080;//2024;//;//Default

        //public Point[] ProjectedScreenCorners = new Point[4];//for test

        public Matrix<double> Homography = new Matrix<double>(3, 3);

        public Blob_Aforge ScreenBlob = null;
        private Point[] D3D_array = new Point[100];


        public bool DetectScreen(Image<Bgr, Byte> inputimg)
        {
            bool rectangleIsFound = false;

            #region Canny

            Image<Bgr, Byte> img = new Image<Bgr, byte>(inputimg.Bitmap);//??????????????????????????????????????????????????????????????mishe ba khatte oain edgham kard?



            //Convert the image to grayscale and filter out the noise
            Image<Gray, Byte> gray = img.Convert<Gray, Byte>();
            Gray cannyThreshold = new Gray(METState.Current.SceneBThreshold);//Gray(180);
            Gray cannyThresholdLinking = new Gray(METState.Current.SceneGThreshold);//Gray(120);

            METState.Current.ProcessTimeSceneBranch.Timer("cannyEdges", "Start");

            Image<Gray, Byte> cannyEdges = gray.PyrDown().Canny(cannyThreshold, cannyThresholdLinking).PyrUp().Dilate(1);//.Erode(1);//
            METState.Current.ProcessTimeSceneBranch.Timer("cannyEdges", "Stop");

            #endregion Canny




            #region Contour
            List<MCvBox2D> boxList = new List<MCvBox2D>(); //a box is a rotated rectangle
            double MinArea = ((double)METState.Current.screenMinSize / 100.0) * METState.Current.SceneImageOrginal.Width
                * ((double)METState.Current.screenMinSize / 100.0) * METState.Current.SceneImageOrginal.Height;



            METState.Current.ProcessTimeSceneBranch.Timer("Contours", "Start");

            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation


                for (Contour<Point> contours = cannyEdges.FindContours(
                      Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE,
                      Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST,
                      storage);
                   contours != null;
                   contours = contours.HNext)
                {

                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.08, storage);//0.08 has been tested and works well with ...d, cannyThresholdLinking).PyrUp().Dilate(1)

                    if (currentContour.Total == 4 && currentContour.Area > MinArea) //selecting the bigest contour
                    {

                        rectangleIsFound = true;

                        MinArea = currentContour.Area;

                        RectangleArea = currentContour.Area;


                        #region determine if all the angles in the contour are within [80, 100] degree
                        // bool isRectangle = true;
                        //Point[] pts = currentContour.ToArray();
                        //LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                        //for (int i = 0; i < edges.Length; i++)
                        //{
                        //    double angle = Math.Abs(
                        //       edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                        //    if (angle < 80 || angle > 100)
                        //    {
                        //        isRectangle = false;
                        //        break;
                        //    }
                        //}
                        #endregion

                        for (int i = 0; i < 4; i++)
                        {
                            ScreenCorners[i].X = currentContour[i].X;
                            ScreenCorners[i].Y = currentContour[i].Y;

                        }
                    }


                }
            SortMonitorCorners();

            METState.Current.ProcessTimeSceneBranch.Timer("Contours", "Stop");

            #endregion Contour




            #region draw rectangles
            //Image<Bgr, Byte> RectangleImage = img.CopyBlank();

            //foreach (MCvBox2D box in boxList)
            //{
            //    RectangleImage.Draw(box, new Bgr(Color.DarkOrange), 2);


            //}
            //METState.Current.SceneImageForShow = METState.Current.SceneImageForShow.Add(RectangleImage);

            #endregion draw rectangles

            #region draw screen
            if (METState.Current.showEdges)
            {
                //  METState.Current.SceneImageProcessed = new Image<Bgr, byte>(cannyEdges.Bitmap);
                //  EmgImgProcssing.DrawRectangle(METState.Current.SceneImageProcessed, ScreenCorners, 0, true, "Area = " + RectangleArea);
                METState.Current.SceneImageForShow = METState.Current.SceneImageForShow.Or(new Image<Bgr, byte>(cannyEdges.Bitmap));
            }

            if (METState.Current.showScreen)
            {
                //show min size rect
                if (METState.Current.showScreenSize)
                {
                    PointF RECTcenter = new PointF(METState.Current.SceneImageForShow.Width / 2, METState.Current.SceneImageForShow.Height / 2);
                    SizeF RECTsize = new SizeF(((float)(METState.Current.screenMinSize) / 100.0f) * METState.Current.SceneImageForShow.Width, ((float)(METState.Current.screenMinSize) / 100.0f) * METState.Current.SceneImageForShow.Height);
                    EmgImgProcssing.DrawRectangle(METState.Current.SceneImageForShow, RECTcenter, RECTsize);
                }

                //Show found screen
                if (rectangleIsFound)
                {
                    EmgImgProcssing.DrawRectangle(METState.Current.SceneImageForShow, ScreenCorners, 0, true,"Screen");//"Area = " + RectangleArea
                }
            }

            #endregion draw Screen
            return rectangleIsFound;


        }

        public void IdentifyScreen( Image<Bgr, Byte> inputimg)
        {

            Size ROI_Size = new Size(ScreenCorners[1].X - ScreenCorners[0].X, ScreenCorners[2].Y - ScreenCorners[0].Y);

            Point ROI_Corner = new Point(ScreenCorners[0].X, ScreenCorners[0].Y);

            Rectangle ROI_Rect = new Rectangle(ROI_Corner, ROI_Size);

            DAS.Detect(inputimg, ROI_Rect);

        }
   
        public void screenGazeData_Shift()
        {

            for (int i = screenGazeData.Length - 1; i > 0; i--) { screenGazeData[i] = screenGazeData[i - 1]; }


        }
        public Point CalculateScreenGazeMedian(int frames, int startFrom)
        {
            Point M = new Point();
            int[] Cx = new int[frames];
            int[] Cy = new int[frames];


            for (int i = 0; i < frames; i++)
            {
                Cx[i] = screenGazeData[startFrom + i].centerPosition.X;
                Cy[i] = screenGazeData[startFrom + i].centerPosition.Y;

            }

            M.X = (int)FindMedian(Cx);
            M.Y = (int)FindMedian(Cy);
            return M;
        }
        public Point GetD3D()
        {
            Point D3D = new Point(0, 0);
            Double RL = 0;
            Double TD = 0;

            RL = Math.Sqrt(Math.Pow(ScreenCorners[1].X - ScreenCorners[2].X, 2) + Math.Pow(ScreenCorners[1].Y - ScreenCorners[2].Y, 2))
            - Math.Sqrt(Math.Pow(ScreenCorners[0].X - ScreenCorners[3].X, 2) + Math.Pow(ScreenCorners[0].Y - ScreenCorners[3].Y, 2));


            TD = Math.Sqrt(Math.Pow(ScreenCorners[1].X - ScreenCorners[0].X, 2) + Math.Pow(ScreenCorners[1].Y - ScreenCorners[0].Y, 2))
            - Math.Sqrt(Math.Pow(ScreenCorners[2].X - ScreenCorners[3].X, 2) + Math.Pow(ScreenCorners[2].Y - ScreenCorners[3].Y, 2));

            //shift D3D_array
            for (int i = D3D_array.Length - 1; i > 0; i--)
            {
                D3D_array[i] = D3D_array[i - 1];
            }

            D3D_array[0].X = (int)RL * 6;
            D3D_array[0].Y = (int)TD * 6;

            //median
            Point M = new Point();
            int frames = 15;
            int[] D3Dx = new int[frames];
            int[] D3Dy = new int[frames];


            for (int i = 0; i < frames; i++)
            {
                D3Dx[i] = D3D_array[i].X;
                D3Dy[i] = D3D_array[i].Y;

            }

            M.X = (int)FindMedian(D3Dx);
            M.Y = (int)FindMedian(D3Dy);



            D3D.X = M.X;
            D3D.Y = M.Y;

            return D3D;
        }
        public static double FindMedian(int[] numbers)
        {

            //middle value has the middle value incase of an even number of elemenets,

            //the value returned by ceiling function

            //or Floor value incase of an odd array.

            double median = 0;

            int middleValue = 0;

            decimal half = 0;



            Array.Sort(numbers);

            half = (numbers.Length - 1) / 2;

            if (numbers.Length % 2 == 1)
            {

                median = numbers[Convert.ToInt32(Math.Ceiling(half))];
            }

            else
            {
                middleValue = Convert.ToInt32(Math.Floor(half));

                median = (double)(numbers[middleValue] + numbers[middleValue + 1]) / 2;
            }

            return median;

        }

        //public void BlobDetect(Image<Gray , Byte> inputimg)
        //{
        //    ///Blob Detection

        //    //Blob_Aforge PupilBlob;
        //    ScreenBlob = new Blob_Aforge(inputimg.Bitmap, 15, 150, 15, 150, 0.5, 4);//should be defined in each frame
        //    if (ScreenBlob.blobs_Filtered.Count > 3)
        //    {

        //        ScreenCorners[0].X = ScreenBlob.blobs_Filtered[0].CenterOfGravity.X;//ULx   (int)or Convert.ToInt32(
        //        ScreenCorners[0].Y = ScreenBlob.blobs_Filtered[0].CenterOfGravity.Y;//ULy

        //        ScreenCorners[1].X = ScreenBlob.blobs_Filtered[1].CenterOfGravity.X;//URx
        //        ScreenCorners[1].Y = ScreenBlob.blobs_Filtered[1].CenterOfGravity.Y;//URy

        //        ScreenCorners[2].X = ScreenBlob.blobs_Filtered[2].CenterOfGravity.X;//DLx
        //        ScreenCorners[2].Y = ScreenBlob.blobs_Filtered[2].CenterOfGravity.Y;//DLy

        //        ScreenCorners[3].X = ScreenBlob.blobs_Filtered[3].CenterOfGravity.X;//DRx
        //        ScreenCorners[3].Y = ScreenBlob.blobs_Filtered[3].CenterOfGravity.Y;//DRy


        //    }
        // }
        public void SortMonitorCorners()
        {
            // METState.Current.ProcessTimeSceneBranch.Timer("SortMonitorCorners", "Start");

            int Mean_X = 0;
            int Mean_Y = 0;
            Point[] SortedScreenCorners = new Point[4];

            for (int i = 0; i < 4; i++)
            {
                Mean_X += ScreenCorners[i].X;
                Mean_Y += ScreenCorners[i].Y;

            }
            Mean_X /= 4;
            Mean_Y /= 4;

            //1    2
            //4    3
            for (int i = 0; i < 4; i++)
            {
                if (ScreenCorners[i].X < Mean_X & ScreenCorners[i].Y < Mean_Y) SortedScreenCorners[0] = ScreenCorners[i];
                if (ScreenCorners[i].X > Mean_X & ScreenCorners[i].Y < Mean_Y) SortedScreenCorners[1] = ScreenCorners[i];
                if (ScreenCorners[i].X > Mean_X & ScreenCorners[i].Y > Mean_Y) SortedScreenCorners[2] = ScreenCorners[i];
                if (ScreenCorners[i].X < Mean_X & ScreenCorners[i].Y > Mean_Y) SortedScreenCorners[3] = ScreenCorners[i];

            }

            ScreenCorners = SortedScreenCorners;
            // METState.Current.ProcessTimeSceneBranch.Timer("SortMonitorCorners", "Stop");


        }
        public void CalculateMonitorGazePoint()
        {
            // METState.Current.ProcessTimeSceneBranch.Timer("CalculateMonitorGazePoint", "Start");
            METState.Current.SceneToMonitor_Mapping.CalibrationType = Calibration.calibration_type.calib_Homography;

            // Matrix<double> src = new Matrix<double>(3, 4);
            //Matrix<double> dst = new Matrix<double>(3, 4);
            //if (ScreenCorners.Count() == 4)
            //{
            for (int i = 0; i < 4; i++)
            {

                METState.Current.SceneToMonitor_Mapping.Source[0, i] = ScreenCorners[i].X;
                METState.Current.SceneToMonitor_Mapping.Source[1, i] = ScreenCorners[i].Y;
                //METState.Current.SceneToMonitor_Mapping.Source[2, i] = 1;

            }

            //     1       2
            //     4       3

            METState.Current.SceneToMonitor_Mapping.Destination[0, 0] = 0;
            METState.Current.SceneToMonitor_Mapping.Destination[1, 0] = 0;
            // dst[2, 0] = 1;

            METState.Current.SceneToMonitor_Mapping.Destination[0, 1] = Real_Monitor_W;
            METState.Current.SceneToMonitor_Mapping.Destination[1, 1] = 0;
            // dst[2, 1] = 1;

            METState.Current.SceneToMonitor_Mapping.Destination[0, 2] = Real_Monitor_W;
            METState.Current.SceneToMonitor_Mapping.Destination[1, 2] = Real_Monitor_H;
            //dst[2, 2] = 1;

            METState.Current.SceneToMonitor_Mapping.Destination[0, 3] = 0;
            METState.Current.SceneToMonitor_Mapping.Destination[1, 3] = Real_Monitor_H;
            //dst[2, 3] = 1;

            METState.Current.SceneToMonitor_Mapping.Calibrate();


            #region test
            // test corners projection
            //for (int i = 0; i < 4; i++)
            //{
            //    src2[0, 0] =  ScreenCorners[i].X;
            //    src2[1, 0] =  ScreenCorners[i].Y;
            //    src2[2, 0] = 1;
            //    dst2 =  Homography * src2;
            //     ProjectedScreenCorners[i].X = (int)Convert.ChangeType(dst2[0, 0] / dst2[2, 0], typeof(int));
            //     ProjectedScreenCorners[i].Y = (int)Convert.ChangeType(dst2[1, 0] / dst2[2, 0], typeof(int));
            //}
            #endregion
            Point MonitorGaze;
            MonitorGaze = METState.Current.SceneToMonitor_Mapping.Map(METState.Current.Gaze.X, METState.Current.Gaze.Y, 0, 0);

            // METState.Current.ProcessTimeSceneBranch.Timer("CalculateMonitorGazePoint", "Stop");


            //Debug.WriteLine( screenGazeData[0].centerPosition.ToString() + "," +  screenGazeData[0].tag);
            screenGazeData_Shift();


            screenGazeData[0].centerPosition = MonitorGaze;
            screenGazeData[0].tag = "";


            // }
        }
        public bool WasGazeFixed()
        {
            bool OK = false;
            try
            {
                // calculate the lenght of the gesture (frames)
                int totalframes = 1;

                for (int i = 2; (i < screenGazeData.Length); i++)
                {
                    if (screenGazeData[i].tag == "Start") break;

                    totalframes++;

                }


                //Calculate the median of the midle part (1/4,<1/4,1/4>,1/4)
                // Point mediantemp = CalculateScreenGazeMedian(totalframes / 2, totalframes / 4);
                Point mediantemp = CalculateScreenGazeMedian(totalframes, 0);

                Debug.WriteLine("Gaze at the end of the gesture: " + screenGazeData[0].centerPosition.ToString());


                double distance = Math.Sqrt((Math.Pow((mediantemp.X - ScreenGazeDataWhenGestureStart.X), 2)) + (Math.Pow((mediantemp.Y - ScreenGazeDataWhenGestureStart.Y), 2)));

                if (distance < 530 & distance != 0)//400
                {
                    OK = true;
                }
                else
                {
                    OK = false;
                }
                if (OK) ScreenGazeDataMedianOfGesture = CalculateScreenGazeMedian(2, totalframes);
            }
            catch (Exception e)
            { }
            return OK;
        }
        public string RecognizeGazedZone()
        {
            string zone = "";
            if (ScreenGazeDataMedianOfGesture.X < ((Real_Monitor_W / 3) + 300) & ScreenGazeDataMedianOfGesture.X > ((Real_Monitor_W / 3) - 300) & ScreenGazeDataMedianOfGesture.Y > (Real_Monitor_H / 2) - 110 & ScreenGazeDataMedianOfGesture.Y < (Real_Monitor_H / 2) + 110) zone = "ImageZone";
            else if (ScreenGazeDataMedianOfGesture.X > 2 * Real_Monitor_W / 3 & ScreenGazeDataMedianOfGesture.X < Real_Monitor_W & ScreenGazeDataMedianOfGesture.Y < (Real_Monitor_H / 2)) zone = "MusicZone";
            else if (ScreenGazeDataMedianOfGesture.X > 2 * Real_Monitor_W / 3 & ScreenGazeDataMedianOfGesture.X < Real_Monitor_W & ScreenGazeDataMedianOfGesture.Y > (Real_Monitor_H / 2)) zone = "VolumeZone";
            return zone;
        }
        public bool IsGazeInsideMonitor()
        {

            SortMonitorCorners();

            // bayad daghigh shavad felan alaki dakhel boodan ra check mikonam
            bool itis = false;

            if ((ScreenCorners[0].X + ScreenCorners[3].X) / 2 < METState.Current.Gaze.X &
                (ScreenCorners[1].X + ScreenCorners[2].X) / 2 > METState.Current.Gaze.X &
                (ScreenCorners[2].Y + ScreenCorners[3].Y) / 2 > METState.Current.Gaze.Y &
                (ScreenCorners[0].Y + ScreenCorners[1].Y) / 2 < METState.Current.Gaze.Y)
                itis = true;

            return itis;

        }
    }
}
