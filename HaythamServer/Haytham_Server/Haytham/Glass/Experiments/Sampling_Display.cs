
//<copyright file="RemoteCalibration.cs" company="ITU">
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Haytham.Glass.Experiments;


namespace Haytham
{
    public  class Sampling_Display 
    {
           private TextFile mtxtFile;
        public Timer timerSpeed = new Timer();
        //public Dictionary<int, Point> calibPoints = new Dictionary<int, Point>();
        Point[] calibPoints=new Point[1];
        int[] pointIndex = new int[1];
        int indexCounter = 0;
        int N;
        public AnimatedCursor mycursor;
        
        public Rectangle PresentationScreen;

        AForge.Point[] pcr;
        AForge.Point[] gaze_before;
        AForge.Point[] gaze_after;


        private void setPoints(int n, int m)// grid of n*m points
        {
            int N = n * m;
            pcr = new AForge.Point[N];
            gaze_before = new AForge.Point[N];
            gaze_after = new AForge.Point[N];
         
            int offset = 80; //pixel offset from the borders of the screen


             calibPoints = new Point[N];
            pointIndex=new int[N];
            for (int i = 0; i <N; i++)
            {
                pointIndex[i] = i;
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {


                for (int j = 0; j < m; j++)
                {
                    calibPoints[count] = new Point(((PresentationScreen.Width - 2 * offset) / (m - 1)) * j + offset, ((PresentationScreen.Height - 2 * offset) / (n - 1)) * i + offset);



                    count++;
                }

            }

            pointIndex = ShuffleArray(pointIndex);

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

        public Sampling_Display(int n, int m, Rectangle rect )
        {
            CalibExp.processTime.Timer("Display", "Start");

            PresentationScreen = rect;
            setPoints(n, m);

           
  



            System.Threading.Thread run_thread = new System.Threading.Thread(new System.Threading.ThreadStart(Run));
            run_thread.Start();

        }

        void Run()
        {


            mycursor = new AnimatedCursor();
            mycursor.coordinates = calibPoints[pointIndex[0]];



            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_Display, mycursor.coordinates);
            

            METState.Current.mCursor.CursorShown = false;//hide cursor

            timerSpeed.Interval = 50;
            timerSpeed.Enabled = true;
            timerSpeed.Tick += new EventHandler(timerSpeed_Tick);
            mycursor.ShowDialog();

        }

        void timerSpeed_Tick(object sender, EventArgs e)
        {
            if (METState.Current.remoteOrMobile == METState.RemoteOrMobile.GoogleGalss
                &&( !Haytham.METState.Current.GlassServer.client.tcpClient.Connected
                || METState.Current.GlassServer.client.myGlassReady_State == myGlass.Client.Ready_State.Error))
            {

                finish();

                timerSpeed.Enabled = false;
                return;
            }
              bool temp = mycursor.updatePointerImage();
                if (temp) getSample();
            

        }

        public void getSample()
        {


            SaveGazeData(indexCounter);




            if ((calibPoints.Length - 1) > indexCounter)
            {
                 //Show the next target
                indexCounter++;
                mycursor.coordinates = calibPoints[pointIndex[indexCounter]];



                METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_Display, mycursor.coordinates);

            }
            else
            {
              
                METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_Display, new Point(-2, -2));





                CalibrateOwn9();

                CalibExp.processTime.Timer("Display", "Stop");

                Export_to_scene_folder(CalibExp.user_folder);
                Export_to_resultAll(CalibExp.folder);



                finish();

                timerSpeed.Enabled = false;

            }
      


        
        }
        private void CalibrateOwn9()
        {

            //Calibrate own

            CalibExp.EyeToDisplay_Mapping_9points.GazeErrorX = 0;
            CalibExp.EyeToDisplay_Mapping_9points.GazeErrorY = 0;
            CalibExp.EyeToDisplay_Mapping_9points.Calibrated = false;

                CalibExp.EyeToDisplay_Mapping_9points.CalibrationType = Calibration.calibration_type.calib_Polynomial;


                for (int i = 0; i < 9; i++)
                {


                    CalibExp.EyeToDisplay_Mapping_9points.Destination[0, i] = calibPoints[i].X;
                    CalibExp.EyeToDisplay_Mapping_9points.Destination[1, i] = calibPoints[i].Y;
                    CalibExp.EyeToDisplay_Mapping_9points.Source[0, i] = pcr[i].X;
                    CalibExp.EyeToDisplay_Mapping_9points.Source[1, i] = pcr[i].Y;
                }
            


            CalibExp.EyeToDisplay_Mapping_9points.Calibrate();
            CalibExp.EyeToDisplay_Mapping_9points.Calibrated = true;

        }
        public void SaveGazeData(int counter)
        {

         
           int frN = 8;

           int indx = pointIndex[counter];

           pcr[indx] = CalibExp.eye_Feature;
           gaze_before[indx] = CalibExp.gaze_display_before_eye_to_eye;
           gaze_after[indx] = CalibExp.gaze_display_after_eye_to_eye;


           

        }
       
        public void finish()
        {
            METState.Current.mCursor.CursorShown = true;
            //mycursor.Dispose();
            mycursor.Hide();

          

        }


        private void Export_to_scene_folder(string dir_path)
        {

            TextFile mtxtFile = new TextFile(dir_path + "\\display");
            string GazeDataLine = "pointNumber, pcr_X , pcr_Y , target_X, target_Y,  gaze_before_X , gaze_before_Y,gaze_after_X , gaze_after_Y,gaze_own4_X,gaze_own4_Y,gaze_own9_X,gaze_own9_Y, ,";
            mtxtFile.WriteLine(GazeDataLine);
            for (int i = 0; i < calibPoints.Length; i++)
            {

                 AForge.Point gaze_own4;
            if (CalibExp.EyeToDisplay_Mapping_4points.Calibrated)   gaze_own4 = CalibExp.EyeToDisplay_Mapping_4points.Map(pcr[i].X, pcr[i].Y, CalibExp.EyeToDisplay_Mapping_4points.GazeErrorX, CalibExp.EyeToDisplay_Mapping_4points.GazeErrorY);
            else     gaze_own4 =new AForge.Point(0,0);

                AForge.Point gaze_own9 = CalibExp.EyeToDisplay_Mapping_9points.Map(pcr[i].X, pcr[i].Y, CalibExp.EyeToDisplay_Mapping_9points.GazeErrorX, CalibExp.EyeToDisplay_Mapping_9points.GazeErrorY);
               
                int indx = pointIndex[i];

                GazeDataLine =
                 (indx + 1)
                  + "," + pcr[i].X
                  + "," + pcr[i].Y
               + "," + calibPoints[indx].X
               + "," + calibPoints[indx].Y
               + "," + gaze_before[indx].X
               + "," + gaze_before[indx].Y
               + "," + gaze_after[indx].X
               + "," + gaze_after[indx].Y
               + "," + gaze_own4.X
               + "," + gaze_own4.Y
               + "," + gaze_own9.X
               + "," + gaze_own9.Y


                  ;


                mtxtFile.WriteLine(GazeDataLine);

            }
            mtxtFile.CloseFile();

            
        }
        private void Export_to_resultAll(string dir_path)
        {

            string line = "";
            //create new if th file not exist
            if (!File.Exists(dir_path + "ResultsAll_display.txt"))
            {



                 mtxtFile = new TextFile(CalibExp.folder + "\\ResultsAll_display");


                for (int i = 0; i < calibPoints.Length; i++)
                {


                    String data = "Target " + (i + 1) + ",,,,,,,,,,,,,,,";
                    line = line + data;



                }

                mtxtFile.WriteLine(line);

                line = "";
                for (int i = 0; i < calibPoints.Length; i++)
                {


                    String data = "participant, pcr_X , pcr_Y , target_X, target_Y,  gaze_before_X , gaze_before_Y,gaze_after_X , gaze_after_Y, gaze_own4_X , gaze_own4_Y, gaze_own9_X , gaze_own9_Y,calib_time,,";
                    line = line + data;



                }

                mtxtFile.WriteLine(line);

                mtxtFile.CloseFile();
            }




            line = "";
            for (int i = 0; i < calibPoints.Length; i++)
            {

                AForge.Point gaze_own4;
                if (CalibExp.EyeToDisplay_Mapping_4points.Calibrated) gaze_own4 = CalibExp.EyeToDisplay_Mapping_4points.Map(pcr[i].X, pcr[i].Y, CalibExp.EyeToDisplay_Mapping_4points.GazeErrorX, CalibExp.EyeToDisplay_Mapping_4points.GazeErrorY);
                else gaze_own4 = new AForge.Point(0, 0);
                
                AForge.Point gaze_own9 = CalibExp.EyeToDisplay_Mapping_9points.Map(pcr[i].X, pcr[i].Y, CalibExp.EyeToDisplay_Mapping_9points.GazeErrorX, CalibExp.EyeToDisplay_Mapping_9points.GazeErrorY);
          
                string data =
                   
                     "," + pcr[i].X
                   + "," + pcr[i].Y
                   + "," + calibPoints[i].X
                   + "," + calibPoints[i].Y
                   + "," + gaze_before[i].X
                   + "," + gaze_before[i].Y
                   + "," + gaze_after[i].X
                   + "," + gaze_after[i].Y
                   + "," + gaze_own4.X
                   + "," + gaze_own4.Y
                   + "," + gaze_own9.X
                   + "," + gaze_own9.Y
                    + "," + CalibExp.processTime.TimerResults["Display"].ToString()
                  
                   +",,"
                   ;


                line = line + data;

            }

            Add(CalibExp.folder + "\\ResultsAll_display.txt", line);




        }
        public void Add(string filename, string asd)
        {
            StreamWriter file2 = new StreamWriter(filename, true);
            file2.WriteLine(asd);
            file2.Close();



        }

    }
}
