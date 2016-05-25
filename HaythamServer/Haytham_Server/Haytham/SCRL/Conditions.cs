using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haytham.SCRL
{
     public static class  Conditions
    {


        public static float speed;// [Pixes/s]
        public static float speed_mind;// [Pixes/s]

        public static float image_scale = 0.4F;// this is defined as image_width/display_with 
        //public static float border_scale = 0.1F;// this is defined as border_width/image_with 
        public static float border_scale = 0.02F;// this is defined as border_width/display_with 

        public static float speed_pixel_per_milisec = 0F;

        public static int images_count = 40;// total number of iamges 

        public static int[] target_indices=new int[0];  // index of the target images starting from 0. Make sure that i<images_count !!
public static int[] randomImages_1;
public static int[] targetImages_1;

        

public static int image_sequence;

public static int conditions_total = 6;

public static float speed_low = 1400;
public static float speed_m = 2200;
public static float speed_high = 2600;

 

public static class IMG_Scale
{
    public static float image_scale_low = 0.3F;
    public static float image_scale_m = 0.6F;
}        

         public static void SetCondition( int condition)
        {
 

            switch (condition)
            {
    

                case 1:
                    speed = speed_low;
                    image_scale = IMG_Scale.image_scale_low;
                    break;
                case 2:
                    speed = speed_low;
                    image_scale =IMG_Scale. image_scale_m;
                    break;

                case 3:
                    speed = speed_m;
                    image_scale =IMG_Scale. image_scale_low;
                    break;
                case 4:
                    speed = speed_m;
                    image_scale = IMG_Scale. image_scale_m;
                    break;

                case 5:
                    speed = speed_high;
                    image_scale = IMG_Scale. image_scale_low;
                    break;
                case 6:
                    speed = speed_high;
                    image_scale =IMG_Scale. image_scale_m;
                    break;

            }

          
             


        }

      public static int GetImageSequence(int participant, int condition)
        {
            image_sequence = (((condition - 1) + (participant - 1) % conditions_total) % conditions_total) + 1;

            //Here choose a number between 1 to conditions_total based on the participant number and the condition
            return image_sequence; // 0 is for debugging
        }



      public static void SetImageSequence(int img_order)
        {
            switch (img_order)
            {


                case 1:


                    target_indices = new int[] { 
      3, 5, 12, 20, 23, 30, 38
    };
                    randomImages_1 = new int[] {
      49, 94, 19, 5, 65, 72, 33, 60, 71, 82, 22, 26, 20, 30, 42, 68, 39, 99, 80, 15, 95, 54, 4, 13, 58, 89, 93, 40, 12, 83, 25, 96, 7, 57, 36, 67, 74, 61, 51, 44, 18, 69, 10, 3, 75, 27, 47, 53, 64, 91, 73, 1, 2, 98, 6, 76, 92, 41, 77, 32, 11, 87, 34, 16, 79, 9, 48, 84, 37, 86, 21, 29, 28, 90, 46, 63, 50, 56, 52, 43
    };
                    targetImages_1 = new int[] {
      24, 4, 1, 8, 23, 18, 6, 30, 26, 15, 13, 17, 5, 10, 3, 2, 16, 19, 14, 27, 21, 9, 7, 22, 25, 11, 20, 29, 12, 28
    };
                    break;
                case 2:


                    target_indices = new int[] { 
      4, 6, 10, 14, 20, 28, 37
    };
                    randomImages_1 = new int[] {
      22, 70, 31, 96, 80, 23, 38, 75, 19, 3, 1, 48, 42, 58, 12, 85, 5, 53, 71, 34, 74, 86, 24, 9, 93, 82, 14, 17, 29, 89, 35, 90, 92, 88, 30, 46, 51, 57, 95, 13, 99, 78, 32, 87, 4, 44, 47, 7, 39, 73, 97, 59, 72, 43, 16, 8, 94, 21, 84, 36, 27, 91, 56, 54, 100, 67, 40, 41, 2, 63, 61, 20, 83, 10, 66, 79, 64, 50, 45, 18, 6, 37, 11, 55, 76, 26, 77, 60, 25, 68, 52, 28, 15, 62, 81, 69, 33, 98, 49, 65
    };
                    targetImages_1 = new int[] {
      1, 23, 18, 21, 13, 25, 14, 30, 4, 10, 27, 28, 16, 29, 12, 22, 8, 26, 9, 7, 3, 20, 5, 2, 17, 11, 19, 15, 6, 24
    };
                    break;
                case 3:


                    target_indices = new int[] { 
      2, 7, 14, 20, 23, 30, 38
    };
                    randomImages_1 = new int[] {
      81, 66, 8, 26, 50, 40, 97, 22, 24, 32, 29, 63, 34, 25, 89, 39, 4, 69, 60, 46, 35, 43, 23, 64, 70, 28, 41, 53, 30, 31, 17, 27, 36, 21, 67, 100, 65, 94, 71, 38, 72, 11, 42, 54, 57, 88, 82, 12, 80, 48, 95, 92, 78, 44, 16, 15, 93, 77, 87, 73, 3, 6, 62, 49, 18, 20, 14, 1, 37, 91, 33, 55, 19, 56, 61, 52, 13, 76, 45, 98, 85, 2, 58, 90, 75, 68, 51, 84, 79, 7, 86, 74, 83, 47, 96, 5, 99, 10, 9, 59
    };
                    targetImages_1 = new int[] {
      22, 1, 2, 7, 15, 18, 27, 11, 17, 10, 26, 6, 30, 20, 23, 28, 21, 29, 4, 12, 5, 9, 8, 14, 13, 16, 3, 19, 25, 24
    };
                    break;

                case 4:
                    target_indices = new int[] { 
      5,9,13,20,30,34,39
     };
                    randomImages_1 = new int[] {
          83, 46, 84, 48, 94, 24, 87, 79, 99, 61, 22, 3, 35, 6, 9, 27, 10, 75, 67, 30, 64, 55, 76, 38, 5, 43, 74, 20, 71, 93, 4, 42, 2, 7, 51, 63, 89, 50, 41, 68, 33, 31, 11, 53, 88, 28, 39, 69, 34, 14, 18, 52, 72, 37, 66, 96, 77, 16, 90, 82, 8, 56, 40, 32, 29, 44, 45, 97, 26, 49, 17, 62, 1, 70, 59, 100, 58, 78, 54, 25, 15, 13, 47, 81, 65, 19, 95, 21, 86, 85, 12, 23, 60, 57, 73, 91, 80, 36, 92, 98
 
     };
                    targetImages_1 = new int[] {
          16,3,1,22,26,24,13,9,23,25,28,20,6,8,19,17,15,30,11,14,4,27,29,12,2,21,10,5,7,18
 
    };
                    break;

                case 5:
                    target_indices = new int[] {
      2,6,10,15,21,32,38
     };
                    randomImages_1 = new int[] {
         65,26,50,22,34,97,88,75,94,42,47,87,30,59,23,40,63,73,49,8,35,83,9,76,19,21,41,46,45,57,80,51,31,39,36,18,68,4,44,85,13,95,2,86,16,64,92,81,62,15,90,91,99,82,37,25,84,7,48,3,98,56,6,77,55,58,11,17,1,5,10,20,79,70,60,72,89,78,96,53,93,100,69,43,52,27,66,71,32,33,28,54,29,74,61,24,67,12,38,14

     };
                    targetImages_1 = new int[] {
         19,16,4,28,30,7,6,9,29,26,2,25,27,10,23,22,8,18,13,14,1,21,3,12,5,17,24,11,15,20
  
    };
                    break;

                case 6:
                    target_indices = new int[] {
      4,10,14,20,25,30,36
     };
                    randomImages_1 = new int[] {
         72,43,81,58,82,79,70,100,95,36,12,23,69,21,14,56,76,24,25,60,27,67,9,65,29,94,31,11,74,5,53,39,77,64,75,80,48,16,98,41,45,83,61,85,38,4,49,46,15,99,90,20,84,68,55,71,18,92,34,88,52,2,32,28,22,51,73,6,97,42,62,1,17,93,57,78,89,19,35,8,13,33,30,54,96,37,3,91,87,59,66,26,50,40,10,47,63,44,86,7
  
    };
                    targetImages_1 = new int[] {
            18,23,6,4,11,5,24,20,2,8,7,12,27,16,29,13,15,19,10,21,22,1,14,17,25,9,26,3,30,28

    };
                    break;
                case 7:
                    target_indices = new int[] {
      2,6,12,19,28,34,38
      };
                    randomImages_1 = new int[] {
          80,31,71,95,98,69,26,39,78,7,99,48,3,25,73,53,35,86,14,88,87,74,6,32,36,47,72,42,12,57,45,79,10,41,9,23,65,4,91,94,21,24,100,92,44,20,59,83,29,15,33,70,67,18,64,1,68,17,84,55,2,54,93,49,51,19,28,34,56,30,11,82,75,5,13,46,16,22,76,96,66,62,85,60,37,43,77,89,50,81,61,40,27,90,38,52,8,58,63,97

        };
                    targetImages_1 = new int[] {
        26,24,16,4,29,7,14,28,25,18,2,30,13,5,20,23,12,3,1,9,21,11,10,15,27,8,19,22,6,17

    };
                    break;
                case 8:
                    target_indices = new int[] {
      1,6,13,22,28,34,39
    };
                    randomImages_1 = new int[] {
            49,86,18,17,95,19,56,47,96,64,15,34,57,82,54,2,22,60,52,41,90,67,81,23,42,1,83,6,12,98,88,84,61,92,50,35,38,73,26,66,62,44,79,40,21,27,10,33,87,100,65,69,25,75,39,30,48,45,31,80,89,94,16,71,51,11,53,29,68,78,20,36,93,14,32,8,59,76,46,5,55,7,85,58,70,72,97,43,9,77,37,28,99,4,3,24,63,13,74,91

     };
                    targetImages_1 = new int[] {
           19,16,12,25,2,10,15,11,9,5,14,24,29,1,6,13,27,17,30,7,22,26,28,4,21,20,3,8,18,23

    };
                    break;
                case 9:
                    target_indices = new int[] {
      3,9,12,18,24,29,36
    };
                    randomImages_1 = new int[] {
           86,40,47,14,13,34,81,66,83,7,67,58,93,61,23,21,15,80,12,11,53,76,3,88,69,91,79,45,73,72,77,18,96,22,55,98,48,10,2,43,89,85,92,95,97,1,57,37,49,62,41,64,51,32,52,6,44,78,70,82,35,24,54,74,20,39,38,33,17,30,27,46,26,94,75,50,99,56,19,60,71,100,36,9,31,87,4,16,84,29,68,5,65,8,42,28,25,90,63,59
 
     };
                    targetImages_1 = new int[] {
           17,13,9,18,27,15,8,5,23,21,24,14,16,26,29,11,28,22,25,1,4,19,12,6,30,20,10,3,2,7

    };
                    break;
            }
        }



    }
}
