
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Media.Imaging;
  using System.Collections.Generic;
namespace Haytham.SCRL
{
  
    public static class Extensions
    {
        //=========================================================================
        // Removes all instances of [itemToRemove] from array [original]
        // Returns the new array, without modifying [original] directly
        // .Net2.0-compatible
        public static T[] RemoveFromArray<T>(this T[] original, T itemToRemove)
        {
            int numIdx = System.Array.IndexOf(original, itemToRemove);
            if (numIdx == -1) return original;
            List<T> tmp = new List<T>(original);
            tmp.RemoveAt(numIdx);
            return tmp.ToArray();
        }
    }
  public  class SetupImages
    {

      public BitmapImage[] setImages(  int imagesCount, String randomFolder)
      {
          String[] names = new String[imagesCount];
          BitmapImage[] images = new BitmapImage[imagesCount];

     

          // creating an array with random images. no target image will be added at this point
            String temp = @"SCRL_images\" + randomFolder;
            DirectoryInfo d = new DirectoryInfo(temp);
            FileInfo[] files = d.GetFiles("*.tif");

               int[] indices =UniqueRandom(1,files.Length).ToArray();

           
              
               for (int i = 0; i < imagesCount; i++)
               {

                   //println(nameList);
                   //println(indices[i]);
                   names[i] = randomFolder + "/" + files[indices[i]-1];
               }
           




          //load images once

          for (int i = 0; i < names.Length; i++)
          {
              var path = Path.Combine(Environment.CurrentDirectory, @"SCRL_images\" + names[i]);

              images[i] = new BitmapImage(new Uri(path));


          }
          for (int i = 0; i < names.Length; i++)
          {
              names[i] = Path.GetFileNameWithoutExtension(names[i]);
              System.Console.WriteLine(i + ": " + names[i]);

          }
          METState.Current.SCRL_images_final = images;
          METState.Current.SCRL_images_final_names = names;

          return images;


      }

        public BitmapImage[] setImages(int[] targetIndices, int imagesCount, int[] targetImages, int[] randomImages, String targetFolder, String randomFolder)
        {

            String[] names = new String[imagesCount];
            BitmapImage[] images = new BitmapImage[imagesCount];

            // creating an array with random images. no target image will be added at this point
            names = Create_array_of_images(randomFolder, randomImages, imagesCount);

            // adding target images to the list
            String[] target_array_temp = Create_array_of_images(targetFolder, targetImages, targetIndices.Length);



            //putting the target images (their names) into the main array
            for (int i = 0; i < targetIndices.Length; i++)
            {
                try
                {

                    if (i < names.Length) names[targetIndices[i]] = target_array_temp[i];
                }
                catch (Exception e)
                {
                    //e.printStackTrace();
                    //println("PLEASE DOUBLE CHECK THE TARGET_INDICES ARRAY. INDICES MUST BE LESS THAN " + images_count);
                    //exit();
                }
            }

            for (int i = 0; i < names.Length; i++)
            {
                //println(i + ": " + names[i]);
            }



            //load images once

            for (int i = 0; i < names.Length; i++)
            {
                var path = Path.Combine(Environment.CurrentDirectory, @"SCRL_images\" + names[i]);

                images[i] = new BitmapImage(new Uri(path));


            }

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Path.GetFileNameWithoutExtension(names[i]);
                System.Console.WriteLine(i + ": " + names[i]);

            }

            METState.Current.SCRL_images_final = images;
            METState.Current.SCRL_images_final_names = names;

            return images;
        }



        public BitmapImage[] setImages(int imagesCount, String targetFolder_1, String targetFolder_2, String targetFolder_3, String targetFolder_4, String randomFolder)
        {
            String[] names = new String[imagesCount];
            BitmapImage[] images = new BitmapImage[imagesCount];



            // creating an array with random images. no target image will be added at this point
            String temp = @"SCRL_images\" + randomFolder;
            DirectoryInfo d = new DirectoryInfo(temp);
            FileInfo[] files = d.GetFiles("*.jpg");

            int[] indices = UniqueRandom(1, files.Length).ToArray();



            for (int i = 0; i < imagesCount ; i++)
            {

                //println(nameList);
                //println(indices[i]);
                names[i] = randomFolder + "/" + files[indices[i]-1];
            }
            //  indecies of targets_in_random
            int[] indices_targets_in_random = UniqueRandom(0, imagesCount-1).ToArray();


          

            // target 1 
            temp = @"SCRL_images\" + targetFolder_1;
             d = new DirectoryInfo(temp);
             FileInfo[] files_t1 = d.GetFiles("*.jpg");
             int[] indices_t1 = UniqueRandom(1, files_t1.Length).ToArray();

            // target 2
            temp = @"SCRL_images\" + targetFolder_2;
            d = new DirectoryInfo(temp);
            FileInfo[] files_t2 = d.GetFiles("*.jpg");
            int[] indices_t2 = UniqueRandom(1, files_t2.Length).ToArray();

            // target 3 
            temp = @"SCRL_images\" + targetFolder_3;
            d = new DirectoryInfo(temp);
            FileInfo[] files_t3 = d.GetFiles("*.jpg");
            int[] indices_t3 = UniqueRandom(1, files_t3.Length).ToArray();

            // target 4
            temp = @"SCRL_images\" + targetFolder_4;
            d = new DirectoryInfo(temp);
            FileInfo[] files_t4 = d.GetFiles("*.jpg");
            int[] indices_t4 = UniqueRandom(1, files_t4.Length).ToArray();


            int target_total = 4;

            //putting the target images (their names) into the main array
            int j = 0;
            for (int i = 0; i < target_total; i++)
            {
                
                names[indices_targets_in_random[j]] = targetFolder_1 + "/" + files_t1[indices_t1[i]-1];
                names[indices_targets_in_random[j+1]] = targetFolder_2 + "/" + files_t2[indices_t2[i]-1];
                names[indices_targets_in_random[j+2]] = targetFolder_3 + "/" + files_t3[indices_t3[i]-1];
                names[indices_targets_in_random[j+3]] = targetFolder_4 + "/" + files_t4[indices_t4[i]-1];

                indices_targets_in_random.RemoveFromArray(i);
                indices_targets_in_random.RemoveFromArray(i+1);
                indices_targets_in_random.RemoveFromArray(i+2);
                indices_targets_in_random.RemoveFromArray(i+3);

                j = j + 4;
            }







            //load images once

            for (int i = 0; i < names.Length; i++)
            {
                string path = Path.Combine(Environment.CurrentDirectory, @"SCRL_images\" + names[i]);

                images[i] = new BitmapImage(new Uri(path));


            }


            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Path.GetFileNameWithoutExtension(names[i]);
                System.Console.WriteLine(i + ": " + names[i]);

            }

            METState.Current.SCRL_images_final = images;
            METState.Current.SCRL_images_final_names = names;
            return images;
        }




        String[] Create_array_of_images(String folder, int[] indices, int imagesCount)
        {

            String[] output = new String[imagesCount];
            String temp = @"SCRL_images\" + folder;
            DirectoryInfo d = new DirectoryInfo(temp);

            FileInfo[] files = d.GetFiles("*.jpg");

            for (int i = 0; i < imagesCount; i++)
            {

                //println(nameList);
                //println(indices[i]);
                output[i] = folder + "/" + files[indices[i]];
            }

            return output;
        }

        int Find_item_in_array(String[] array, String item)
        {

            for (int i = 0; i < array.Length; i++)
            {
                String a = array[i];

                if (a != null && a.Equals(item) == true)
                {
                    //println("image not found");
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Returns all numbers, between min and max inclusive, once in a random sequence.
        /// </summary>
        IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
        {
            List<int> candidates = new List<int>();
            for (int i = minInclusive; i <= maxInclusive; i++)
            {
                candidates.Add(i);
            }
            Random rnd = new Random();
            while (candidates.Count > 0)
            {
                int index = rnd.Next(candidates.Count);
                yield return candidates[index];
                candidates.RemoveAt(index);
            }
        }

    }



}
