using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Haytham.Glass.Experiments
{
    public class Sampling_Scene
    {
        int wait = 5000;
        int[] calibPoints;
        int current_indx = 0;


        Point[] target_in_image;
        AForge.Point[] pcr;
        AForge.Point[] gaze_before;
        AForge.Point[] gaze_after;


        public Sampling_Scene(int n, int m)
        {
            CalibExp.processTime.Timer("Scene", "Start");




            setPoints(n, m);

            int N = n * m;
            target_in_image = new Point[N];
            pcr = new AForge.Point[N];
            gaze_before = new AForge.Point[N];
            gaze_after = new AForge.Point[N];

            //prepare for the first point
            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_scene, new Point(current_indx, calibPoints[current_indx]));




        }
        public void UserIsReady()
        {

            //wait for the user to fixate on the first target
            Thread.Sleep(wait);

            METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_scene, new Point(-1, -1));




        }



        public void ProcessImg(Image img)
        {
            //Store the corresponding eye and gaze imidiately 
          
            pcr[current_indx] = CalibExp.eye_Feature;
            gaze_before[current_indx] = CalibExp.gaze_scene_before_eye_to_eye;
            gaze_after[current_indx] = CalibExp.gaze_scene_after_eye_to_eye;



            //here we need to wait for the conductor to click on the corresponding target int the received image



        }
        public void GetSample(Point target)
        {
            //Store the target pos and continue the sampling process 
            target_in_image[current_indx] = target;

            if (current_indx + 1 < calibPoints.Length)
            {
                //prepare for the next point
                current_indx++;
                METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_scene, new Point(current_indx, calibPoints[current_indx]));
            }
            else
            {


                CalibrateOwn();


                CalibExp.processTime.Timer("Scene", "Stop");

                //Export all data to the txt file
                Export_to_scene_folder(CalibExp.user_folder);
                Export_to_resultAll(CalibExp.folder);



                //Finish

                METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Experiment_scene, new Point(-2, -2));//point x (th) of y (total)
                CalibExp.scene_is_sampling = false;
                

            }



        }
        private void CalibrateOwn()
        {
            CalibExp.EyeToScene_Mapping.GazeErrorX = 0;
            CalibExp.EyeToScene_Mapping.GazeErrorY = 0;
            CalibExp.EyeToScene_Mapping.Calibrated = false;

           
                CalibExp.EyeToScene_Mapping.CalibrationType = Calibration.calibration_type.calib_Polynomial;


                for (int i = 0; i < 9; i++)
                {


                    CalibExp.EyeToScene_Mapping.Destination[0, i] = target_in_image[i].X;
                    CalibExp.EyeToScene_Mapping.Destination[1, i] = target_in_image[i].Y;
                    CalibExp.EyeToScene_Mapping.Source[0, i] = pcr[i].X;
                    CalibExp.EyeToScene_Mapping.Source[1, i] = pcr[i].Y;
                }
            


            CalibExp.EyeToScene_Mapping.Calibrate();
            CalibExp.EyeToScene_Mapping.Calibrated = true;

        }
        private int SearchArray(int[] arr, int val)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val) return i;

            }

            return -1;
        }
        private void setPoints(int n, int m)// grid of n*m points
        {


            calibPoints = new int[m * n];




            for (int i = 0; i < n * m; i++)
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





        private void Export_to_scene_folder(string dir_path)
        {

            TextFile mtxtFile = new TextFile(dir_path + "\\scene");
            string GazeDataLine = "pointNumber, pcr_X , pcr_Y , target_X, target_Y,  gaze_before_X , gaze_before_Y,gaze_after_X , gaze_after_Y,gaze_own_X,gaze_own_Y, ,";
            mtxtFile.WriteLine(GazeDataLine);
            for (int i = 0; i < calibPoints.Length; i++)
            {

                AForge.Point gaze_own = CalibExp.EyeToScene_Mapping.Map(pcr[i].X, pcr[i].Y, CalibExp.EyeToScene_Mapping.GazeErrorX, CalibExp.EyeToScene_Mapping.GazeErrorY);

                GazeDataLine =
                 (calibPoints[i] + 1)
                  + "," + pcr[i].X
                  + "," + pcr[i].Y
                  + "," + target_in_image[i].X
                  + "," + target_in_image[i].Y
                  + "," + gaze_before[i].X
                  + "," + gaze_before[i].Y
                  + "," + gaze_after[i].X
                  + "," + gaze_after[i].Y
                  + "," + gaze_own.X
                  + "," + gaze_own.Y

                  ;


                mtxtFile.WriteLine(GazeDataLine);

            }
            mtxtFile.CloseFile();

        }
        private void Export_to_resultAll(string dir_path)
        {

            string line = "";
            //create new if th file not exist
            if (!File.Exists(dir_path + "ResultsAll_scene.txt"))
            {

               
                TextFile mtxtFile = new TextFile(CalibExp.folder + "\\ResultsAll_scene");




                for (int i = 0; i < calibPoints.Length; i++)
                {


                    String data = "Target " + (i + 1) + ",,,,,,,,,,,,,";
                    line = line + data;



                }

                mtxtFile.WriteLine(line);

                line = "";
                for (int i = 0; i < calibPoints.Length; i++)
                {


                    String data = "participant, pcr_X , pcr_Y , target_X, target_Y,  gaze_before_X , gaze_before_Y,gaze_after_X , gaze_after_Y,gaze_own_X,gaze_own_Y,calib_time,,";
                    line = line + data;



                }

                mtxtFile.WriteLine(line);

                mtxtFile.CloseFile();
            }




            line = "";
            for (int i = 0; i < calibPoints.Length; i++)
            {
                int indx = SearchArray(calibPoints, i);

                AForge.Point gaze_own = CalibExp.EyeToScene_Mapping.Map(pcr[indx].X, pcr[indx].Y, CalibExp.EyeToScene_Mapping.GazeErrorX, CalibExp.EyeToScene_Mapping.GazeErrorY);

                string data =

                    "," + pcr[indx].X
                   + "," + pcr[indx].Y
                   + "," + target_in_image[indx].X
                   + "," + target_in_image[indx].Y
                   + "," + gaze_before[indx].X
                   + "," + gaze_before[indx].Y
                   + "," + gaze_after[indx].X
                   + "," + gaze_after[indx].Y
                     + "," + gaze_own.X
                   + "," + gaze_own.Y
                    + "," + CalibExp.processTime.TimerResults["Scene"].ToString()
             
                   +",,"
                 

                   ;


                line = line + data;

            }

            Add(CalibExp.folder + "\\ResultsAll_scene.txt", line);




        }
        public void Add(string filename, string asd)
        {
            StreamWriter file2 = new StreamWriter(filename, true);
            file2.WriteLine(asd);
            file2.Close();



        }
    }
}