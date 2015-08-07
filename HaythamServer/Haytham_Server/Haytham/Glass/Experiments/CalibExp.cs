using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using myGlass;

namespace Haytham.Glass.Experiments
{
   public static class CalibExp
    {

      
       public static Sampling_Display mySampling_Display;
       public static Sampling_Scene mySampling_Scene;

       public static Boolean scene_is_sampling = false;


       public static string user_folder = "";
       public static string folder = "";

       public static AForge.Point eye_Feature = new AForge.Point();

       public static AForge.Point gaze_display_before_eye_to_eye = new AForge.Point();
       public static AForge.Point gaze_display_after_eye_to_eye = new AForge.Point();
      
       public static AForge.Point gaze_scene_before_eye_to_eye = new AForge.Point();
       public static AForge.Point gaze_scene_after_eye_to_eye = new AForge.Point();
     
       public static Calibration EyeToDisplay_Mapping_4points = new Calibration("EyeToDisplay_4_exp_temp");
       public static Calibration EyeToDisplay_Mapping_9points = new Calibration("EyeToDisplay_9_exp_temp");

       public static Calibration EyeToScene_Mapping = new Calibration("EyeToScene_exp_temp");

       public static ProcessTime processTime = new ProcessTime();


       public static void RecordGazeData(AForge.Point eyeFeature)
        {
            AForge.Point normalizedEye = METState.Current.EyeToEye_Mapping.Calibrated ?
                       METState.Current.EyeToEye_Mapping.Map(eyeFeature.X, eyeFeature.Y, 0, 0) :
                       eyeFeature;

            eye_Feature = eyeFeature;

            if (METState.Current.EyeToDisplay_Mapping.Calibrated)
            {
                gaze_display_after_eye_to_eye = METState.Current.EyeToDisplay_Mapping.Map(normalizedEye.X, normalizedEye.Y, METState.Current.EyeToDisplay_Mapping.GazeErrorX, METState.Current.EyeToDisplay_Mapping.GazeErrorY);
                gaze_display_before_eye_to_eye = METState.Current.EyeToDisplay_Mapping.Map(eyeFeature.X, eyeFeature.Y, METState.Current.EyeToDisplay_Mapping.GazeErrorX, METState.Current.EyeToDisplay_Mapping.GazeErrorY);
               
            
            }

            if (METState.Current.EyeToScene_Mapping.Calibrated)
            {
                gaze_scene_after_eye_to_eye = METState.Current.EyeToScene_Mapping.Map(normalizedEye.X, normalizedEye.Y, METState.Current.EyeToScene_Mapping.GazeErrorX, METState.Current.EyeToScene_Mapping.GazeErrorY);
                gaze_scene_before_eye_to_eye = METState.Current.EyeToScene_Mapping.Map(eyeFeature.X, eyeFeature.Y, METState.Current.EyeToScene_Mapping.GazeErrorX, METState.Current.EyeToScene_Mapping.GazeErrorY);
              
                      }



        }
      

        public static void ProcessJson(myJsonClass mjson)
        {




            folder = @"fromGlass\experiment_calib\";
            user_folder = Path.Combine( @"fromGlass\experiment_calib\", mjson.name );
            if (!Directory.Exists(user_folder)) Directory.CreateDirectory(user_folder);
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);


           myJsonClass temp = mjson;

            System.Web.Script.Serialization.JavaScriptSerializer jSearializer =
            new System.Web.Script.Serialization.JavaScriptSerializer();
            String s = jSearializer.Serialize(temp.texts);

            System.IO.File.WriteAllText(Path.Combine(user_folder, temp.name + ".txt"), s);
           
        }
       

    }
}
