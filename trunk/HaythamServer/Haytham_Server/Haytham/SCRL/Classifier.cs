using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Media.Animation;
using System.Windows;

namespace Haytham.SCRL
{



   public static class Classifier
   {
       public static event EventHandler<PerformanceEventArgs> DataUpdate;

       public static int  range=500;
       public static EyeData[] eyeData = new EyeData[range];

      static float left_eyeFeature = 1;
      static float right_eyeFeature = 1;
       static void OnDataUpdate( )
      {
          var handler = DataUpdate;
          if (handler != null)
          {
              handler(null, new PerformanceEventArgs( ));
          }
      }

       
       public static void  Reset(){

           eyeData = new EyeData[range];

       }



        public  struct EyeData
        {

            //
            // Summary:
            //     Gets or sets the captured time of this point.
            //
            // Returns:
            //     captured time of this point.
     
            public string tag { get; set; }

         
            //public float eyeFeature { get; set; }
            public float LR { get; set; }

            public float delta { get; set; }

            public float stroke { get; set; }
          
        }

       static float counter_temp=0;
       public static void eyeData_Update(AForge.Point eyeFeature_smooth, AForge.Point eyeFeature)
       {


           //shift
           for (int i = eyeData.Length - 1; i > 0; i--) { eyeData[i] = eyeData[i - 1]; }
           eyeData[0] = new EyeData();

           eyeData[0].tag = METState.Current.SCRL_Flag;
           //add

           if (METState.Current.SCRL_State == METState.SCRL_States.Left) left_eyeFeature = eyeFeature_smooth.X;
           else if (METState.Current.SCRL_State == METState.SCRL_States.Right) right_eyeFeature = eyeFeature_smooth.X;

           //eyeData[0].eyeFeature = eyeFeature.X;

           if (METState.Current.SCRL_State == METState.SCRL_States.Rolling)
           {
               
               //mapping
               eyeData[0].LR = ((100 / (right_eyeFeature - left_eyeFeature)) * (eyeFeature.X - left_eyeFeature));
               
               //data cleaning
               //if (eyeData[0].eyeFeature < left_eyeFeature || eyeData[0].eyeFeature > right_eyeFeature) eyeData[0].eyeFeature = 0;
               if (eyeData[0].LR < 0 || eyeData[0].LR > 100) eyeData[0].LR = 0;


               //displacement
               eyeData[0].delta = eyeData[0].LR != 0 ? (-eyeData[0].LR + eyeData[1].LR) : 0;//Don't count a 0 data az a big jump towards the left


               int compare =(int) (eyeData[0].delta * eyeData[1].delta);

               if (compare < 0) eyeData[0].stroke = 0;
               else if (compare > 0) eyeData[0].stroke = eyeData[1].stroke + eyeData[0].delta;
               else
               {
                   //if the previous delta was 0 then we should:
                   //- compare to the last non zero frame
                   //- if we had too many zeros in the sequence just reset the stroke then
                   int maxZeros = 2;
                   for (int i = 0; i < maxZeros; i++)
                   {
                       int compare2 =(int)( eyeData[0].delta * eyeData[i].delta);
                       if (compare2 > 0)
                       {
                           eyeData[0].stroke = eyeData[i].stroke + eyeData[0].delta;
                           break;
                       }
                       else if (compare2 < 0 || i == maxZeros) eyeData[0].stroke = 0;
                   }

               }


   
                   Console.WriteLine(String.Format(" {0,-10} | {1,-10} | {2,5}", Math.Round(eyeData[0].LR, 2), Math.Round(eyeData[0].delta, 2), Math.Round(eyeData[0].stroke, 2) ));


                   if (eyeData[0].stroke > METState.Current.SCRL_Threshold && eyeData[0].LR < 40)
               {


                   //Update WPF
                   OnDataUpdate();

                   ////Just to make sure that we don't double detect this event
                 
                       for (int i = 0; i < 20; i++)
                       {
                           eyeData[i].stroke = 0;
                           eyeData[i].delta = 0;
                   
                       }




                 
                  
        
               }

           


           }

       }

       
  
       
    }
}
