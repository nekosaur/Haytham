using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Haytham.SCRL
{
    public class PerformanceEventArgs : EventArgs
    {
        
        public PerformanceEventArgs()
        {

        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SCRL_Mind : Window
    {

     

        // const string _imagePath = @"C:\Users\Steven Jeuris\Desktop\ScrollingImages\ImageScroller\Images";


        TranslateTransform _scroll = new TranslateTransform();

        ScaleTransform _scale = new ScaleTransform();

        TransformGroup _group = new TransformGroup();


        // bool temp = mycursor.updatePointerImage();
    
        int participant;
        int condition_width_speed;
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        SetupImages setupImages = new SetupImages();

       
        Storyboard storyboard_circles;
        Storyboard storyboard_scroll;
       

        double border_width ;
        double totalImageWidth;
        double image_H_scale = 0.7;



        /// <summary>
        /// Only use this constructor when you want to generate images of the sequenses
        /// </summary>      
        public SCRL_Mind(string user,METState.SCRL_demos demo)
        { // This sets up all the stuff in the .xaml file.


            METState.Current.SCRL_images_result_names  = new Dictionary<string, int>();
            METState.Current.METCoreObject.SendToForm("demo not finished!", "label_SCRL");
            Classifier.Reset();

            METState.Current. demos_mode = demo;
            METState.Current.eye.headGesture.Gesture += new HeadGesture.GestureHandler(this.HandleGesture);

            participant = int.Parse(user.Trim(new Char[] { 'p' }));

      
            Classifier.DataUpdate += HandleDataUpdate;


            Conditions.image_scale = 0.5F;
            Conditions.border_scale = 0.1F;



            //setup images

            BitmapImage[] imgs = new BitmapImage [1];
            if (METState.Current.demos_mode == METState.SCRL_demos.MindReading)
            {
                Conditions.images_count = 50;
                 imgs = setupImages.setImages( Conditions.images_count,

               "MindReading images\\MindReading\\Angelina_Jolie",
                  "MindReading images\\MindReading\\Arnold_Schwarzenegger",
                  "MindReading images\\MindReading\\Bill_Clinton",
                  "MindReading images\\MindReading\\George_W_Bush",

               "MindReading images\\MindReading\\random images");

            }
            else if (METState.Current.demos_mode == METState.SCRL_demos.Facebook)
            {
                Conditions.images_count = 40;
                imgs =METState.Current.SCRL_stopMode==METState.SCRL_StopMode.Manual?
                    setupImages.setImages(Conditions.images_count, "MindReading images\\facebook\\manual"):
                    setupImages.setImages(Conditions.images_count, "MindReading images\\facebook\\eyegrip");
            }
            else if (METState.Current.demos_mode == METState.SCRL_demos.MenuScrollViewer)
            {
                Conditions.images_count = 14;

                imgs = METState.Current.SCRL_stopMode == METState.SCRL_StopMode.Manual ?
                   setupImages.setImages(Conditions.images_count, "MindReading images\\MenuScrollViewer\\manual") :
                   setupImages.setImages(Conditions.images_count, "MindReading images\\MenuScrollViewer\\eyegrip");
            }


            
            // Load images into memory.
            List<Image> images = new List<Image>();
            foreach (BitmapImage img in imgs)
            {
                Image image = new Image();

                image.Source = img;
                images.Add(image);


            }

            InitializeComponent();


            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenhight = System.Windows.SystemParameters.PrimaryScreenHeight;

            this.SetValue(Window.WidthProperty, screenWidth);
            this.SetValue(Window.HeightProperty, screenhight);

            

            double offset = 0;
            int i = 0;
            METState.Current.SCRL_window_H = (double)this.GetValue(Window.HeightProperty);// Application.Current.MainWindow.Height;
            METState.Current.SCRL_window_W = (double)this.GetValue(Window.WidthProperty);// Application.Current.MainWindow.Width;

            METState.Current.SCRL_image_width = (double)(Conditions.image_scale * METState.Current.SCRL_window_W);
            border_width = (double)(Conditions.border_scale * METState.Current.SCRL_window_W);



            //Making the roll for saving the image
            // SaveImageRoll(imgs,"MindReading");


            // Add images and position in canvas.
            foreach (Image image in images)
            {

                image.Stretch = Stretch.Fill;

                // double imgWidth = image.Source.Width;
                //ImageCanvas.Background = new SolidColorBrush(Colors.Black);
                
                //image.Tag=

                ImageCanvas.Children.Add(image);
                // Position horizontally.


                //image.SetValue(Image.WidthProperty, 200);



                image.SetValue(Canvas.HeightProperty, image_H_scale * METState.Current.SCRL_window_H);
                image.SetValue(Canvas.WidthProperty, METState.Current.SCRL_image_width);


                offset = METState.Current.SCRL_window_W + border_width + i * (border_width + METState.Current.SCRL_image_width);

                
                image.SetValue(Canvas.LeftProperty, offset);
                double top = 0;
                top = METState.Current.SCRL_window_H / 2 - image.Height / 2;
                image.SetValue(Canvas.TopProperty, top);


                i = i + 1;
            }

            totalImageWidth = 1 * METState.Current.SCRL_window_W + border_width + images.Count * (border_width + METState.Current.SCRL_image_width);


            PrepareRecording();


           
            METState.Current.SCRL_State = METState.SCRL_States.Left;

            Console.WriteLine("-------------------------------");
            Console.WriteLine(String.Format(" {0,-10} | {1,-10} | {2,5}", "LR_Gaze", " Delta", " Stroke"));
            Console.WriteLine("-------------------------------");



            _group.Children.Add(_scroll);
            _group.Children.Add(_scale);

            ImageCanvas.RenderTransform = _group;


            //Calculating the duration
            double dur = totalImageWidth / (Conditions.speed_mind);
            DoubleAnimation animation_scroll = new DoubleAnimation { Duration = TimeSpan.FromSeconds(dur), From = 0, To = -totalImageWidth };


            if (METState.Current.SCRL_stopMode == METState.SCRL_StopMode.Manual)
            {
                //Scroll(animation_scroll, true);
                ShowCircles(animation_scroll, new TimeSpan(0, 0, 1));
            }
            else
            {
                ShowCircles(animation_scroll,  new TimeSpan(0, 0, 3));
            }

        }


        private void SaveImageRoll(BitmapImage[] imgs, string name)
        {



            System.Drawing.Bitmap img_roll = CombineBitmap(imgs, (int)border_width, (int)METState.Current.SCRL_image_width, (int)METState.Current.SCRL_image_height);

            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Create an Encoder object based on the GUID
            // for the Quality parameter category.
            System.Drawing.Imaging.Encoder myEncoder =
                System.Drawing.Imaging.Encoder.Quality;

            // Create an EncoderParameters object.
            // An EncoderParameters object has an array of EncoderParameter
            // objects. In this case, there is only one
            // EncoderParameter object in the array.
            EncoderParameters myEncoderParameters = new EncoderParameters(1);

            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;
       


            if (!Directory.Exists(@"SCRL_images\seq\")) Directory.CreateDirectory(@"SCRL_images\seq\");
            String SuspiciousPath = Path.Combine(@"SCRL_images\seq\" + name +".jpg");

            img_roll.Save(SuspiciousPath, jpgEncoder, myEncoderParameters);
            //img_roll.Save(SuspiciousPath);

        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }


        private void ShowCircles(DoubleAnimation animation_scroll, TimeSpan duration)
        {


            // Create a storyboard to contain the animations.
            storyboard_circles = new Storyboard();
        

            // Create a DoubleAnimation to fade the not selected option control
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = 0.4;
            animation.To = 1.0;
            animation.Duration = new Duration(duration);
            // Configure the animation to target de property Opacity
            Storyboard.SetTargetName(animation, el.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Control.OpacityProperty));

            // Add the animation to the storyboard
            storyboard_circles.Children.Add(animation);





            el.SetValue(Canvas.LeftProperty, METState.Current.circle_center_offset);
            el.SetValue(Canvas.TopProperty, METState.Current.SCRL_window_H / 2);
            if (METState.Current.SCRL_State == METState.SCRL_States.Left) METState.Current.SCRL_Flag = "Left";

            animation.Completed += (s, e) =>
            {

                if (METState.Current.SCRL_State == METState.SCRL_States.Left)
                {
                    //your completed action here

                    el.SetValue(Canvas.LeftProperty, METState.Current.SCRL_window_W - METState.Current.circle_center_offset - (double)el.GetValue(Canvas.WidthProperty));
                    el.SetValue(Canvas.TopProperty, METState.Current.SCRL_window_H / 2);

                    if (METState.Current.SCRL_State == METState.SCRL_States.Left) { METState.Current.SCRL_Flag = "Right"; METState.Current.SCRL_State = METState.SCRL_States.Right; }

                    storyboard_circles.Begin(this);
                }
                else if (METState.Current.SCRL_State == METState.SCRL_States.Right)
                {


                    Scroll(animation_scroll,true);

                }
                //else if (METState.Current.SCRL_State == METState.SCRL_States.None)
                //{
                //    CloseWindow();


                //}
            };

            // Begin the storyboard
            storyboard_circles.Begin(this);

        }

        private void Scroll(DoubleAnimation animation,bool ToTheEnd)
        {


            //_scale = new ScaleTransform(1,1);
            // _group.Children[1].SetValue( ScaleTransform.ScaleXProperty, (double)1);
            // _group.Children[1].SetValue(ScaleTransform.ScaleYProperty, (double)1);
            // ImageCanvas.SetValue(ScaleTransform.ScaleXProperty, (double)1);
            // ImageCanvas.SetValue(ScaleTransform.ScaleYProperty, (double)1);

          
            storyboard_scroll = new Storyboard();
        
            //_scale.ScaleX=1;
            //_scale.ScaleY=1;

 

            METState.Current.SCRL_Flag = "";

            Storyboard.SetTarget(animation, ImageCanvas);

            Storyboard.SetTargetProperty(animation, new PropertyPath("RenderTransform.Children[0].X"));

            storyboard_scroll.Children.Add(animation);

            //Adding Zoom animation to the storyboard for the MenuScrollViewer demo

            if (!ToTheEnd)
            {
                if (METState.Current.demos_mode == METState.SCRL_demos.MenuScrollViewer) ZoomIn(true);
            }
            else
            {
                if (METState.Current.demos_mode == METState.SCRL_demos.MenuScrollViewer) ZoomIn(false);

                METState.Current.SCRL_State = METState.SCRL_States.Rolling;
                animation.Completed += (s_scroll, e_scroll) =>
                {
                    ScrollFinished();
                };
            }


            storyboard_scroll.Begin();
        }

        private void ZoomIn(bool In)
        {



            DoubleAnimation growAnimation_X = new DoubleAnimation { Duration = TimeSpan.FromSeconds(1), From = In ? 1 : 1.55, To = In ?  1.55:1, EasingFunction = new QuinticEase { EasingMode = EasingMode.EaseOut } };
            DoubleAnimation growAnimation_Y = new DoubleAnimation { Duration = TimeSpan.FromSeconds(1), From = In ? 1 : 1.4, To =In?  1.4:1, EasingFunction = new QuinticEase { EasingMode = EasingMode.EaseOut } };

            ImageCanvas.RenderTransformOrigin = new Point(0.5, 0.5);

            Storyboard.SetTargetProperty(growAnimation_X, new PropertyPath("RenderTransform.Children[1].ScaleX"));
            Storyboard.SetTarget(growAnimation_X, ImageCanvas);
            storyboard_scroll.Children.Add(growAnimation_X);

            Storyboard.SetTargetProperty(growAnimation_Y, new PropertyPath("RenderTransform.Children[1].ScaleY"));
            Storyboard.SetTarget(growAnimation_Y, ImageCanvas);
            storyboard_scroll.Children.Add(growAnimation_Y);
        }
        private void HandleDataUpdate(object sender, PerformanceEventArgs e)
        {
            if (METState.Current.SCRL_State == METState.SCRL_States.Rolling && METState.Current.SCRL_stopMode == METState.SCRL_StopMode.EyeGrip)


                Dispatcher.BeginInvoke((Action)(() => DoSomething()));
        }

        private void DoSomething()
        {
            //This will stop the classifier and it's also used in the keyEvent handler 
            METState.Current.SCRL_State = METState.SCRL_States.stopped;

            double stopPos =  _scroll.X;

            int indx = GetTargetIndex(stopPos);

            GetItemName(indx);



         
            if (METState.Current.demos_mode == METState.SCRL_demos.MindReading) METState.Current.SCRL_State = METState.SCRL_States.Rolling;
            else if (METState.Current.demos_mode != METState.SCRL_demos.MindReading)//Only for other demos
            {

                storyboard_scroll.Stop();

                //storyboard_scroll.Children.Clear();
                _scroll.X = stopPos;

                ElasticEase ease = new ElasticEase();
                ease.EasingMode = EasingMode.EaseOut;
                ease.Oscillations = 2;
                ease.Springiness = 8;

                //finding the pos that brings the target in the middle of the screen
                double desiredPos =
                    indx * (border_width + METState.Current.SCRL_image_width) +
                    METState.Current.SCRL_window_W / 2 + border_width +
                    METState.Current.SCRL_image_width / 2;
                desiredPos = -desiredPos;


                DoubleAnimation animation_scroll = new DoubleAnimation { Duration = TimeSpan.FromSeconds(1), From = stopPos, To = desiredPos, EasingFunction = ease };

                Scroll(animation_scroll, false);

            }
        }
        private int GetTargetIndex(double stopPos)
        {


     
            double[] LR_images_t2 = new double[METState.Current.SCRL_images_final_names.Length];

            for (int i = 0; i < METState.Current.SCRL_images_final_names.Length; i++)
            {

                LR_images_t2[i] = Get_LR_of_each_image(i, stopPos);
            }


            int targetIndex =METState.Current. SCRL_stopMode==METState.SCRL_StopMode.EyeGrip? Get_closest_item(LR_images_t2,Classifier. eyeData[0].LR):Get_closest_item(LR_images_t2, 50);

            Console.Write(" target at pos " + LR_images_t2[targetIndex]);


            return targetIndex;
        }
        public double Get_LR_of_each_image(int i, double stopPos)
        {
            ////TODO: Get the correct value from the wpf object
            double circle_r = 64 / 2;
            double e = METState.Current.circle_center_offset + circle_r;//center of the circle from the edges

            double LR = ((100) / (2 * e - METState.Current.SCRL_window_W)) * (-stopPos - (METState.Current.SCRL_image_width / 2 + i * METState.Current.SCRL_image_width + (i + 1) * border_width) - e) + 100;

            return Math.Round(LR, 2);

        }
        public  int Get_closest_item(double[] list, float value)
        {

            double dis = 100000;
            int index_of_min = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (Math.Abs(list[i] - value) < dis)
                {
                    index_of_min = i;
                    dis = Math.Abs(list[i] - value);
                }

            }

            return index_of_min;
        }

        private void GetItemName(int targetIndex)
        {

            string name = METState.Current.SCRL_images_final_names[targetIndex];
      
            Console.Write(" is " + name);
            Console.Write("  (stopped by " + METState.Current.SCRL_stopMode.ToString() + ")");


                  //     "MindReading images\\MindReading\\Angelina_Jolie",
                  //"MindReading images\\MindReading\\Arnold_Schwarzenegger",
                  //"MindReading images\\MindReading\\Bill_Clinton",
                  //"MindReading images\\MindReading\\George_W_Bush",

            if (name.StartsWith("Angelina_Jolie") || name.StartsWith("Arnold_Schwarzenegger") || name.StartsWith("Bill_Clinton") || name.StartsWith("George_W_Bush") )
            {
            if (METState.Current.SCRL_images_result_names.ContainsKey(name))
                METState.Current.SCRL_images_result_names[name] = METState.Current.SCRL_images_result_names[name] + 1;
            else
                METState.Current.SCRL_images_result_names.Add(name, 1);
            }

            //update the result label
            KeyValuePair<string, int> max = new KeyValuePair<string, int>();
            foreach (var kvp in METState.Current.SCRL_images_result_names)
            {
                if (kvp.Value > max.Value)
                    max = kvp;
            }
            METState.Current.METCoreObject.SendToForm(max.Key, "label_SCRL");
        }

        private void ScrollFinished()
        {

            KeyValuePair<string, int> max = new KeyValuePair<string, int>();
            foreach (var kvp in METState.Current.SCRL_images_result_names)
            {
                if (kvp.Value > max.Value)
                    max = kvp;
            }
            METState.Current.METCoreObject.SendToForm(max.Key, "label_SCRL");


            Console.WriteLine("-------------------------------");
            Console.WriteLine("The winner is:        " + max.Key);
            Console.WriteLine("-------------------------------");

            storyboard_scroll.Stop();
            storyboard_scroll = null;

            CloseWindow();
            

        }
        private void CloseWindow()
        {
            Classifier.DataUpdate -= HandleDataUpdate;


            if (METState.Current.SCRL_DataExport_Eye != null)
            {



                METState.Current.SCRL_DataExport_Eye.CloseFile();
                METState.Current.SCRL_DataExport_Eye = null;

                METState.Current.SCRL_DataExport_ImageRoll.Close();
                METState.Current.SCRL_DataExport_ImageRoll = null;

            }

            METState.Current.SCRL_State = METState.SCRL_States.None;


            this.Close();

        }
        private void PrepareRecording()
        {
            string c = "MindReading";
            String SuspiciousPath = Path.Combine(@"SCRL_images\result\" + c);


            if (!Directory.Exists(SuspiciousPath)) Directory.CreateDirectory(SuspiciousPath);



            if (METState.Current.SCRL_DataExport_Eye == null)// Record
            {


                METState.Current.SCRL_DataExport_Eye = new TextFile(SuspiciousPath + "/p" + participant + "_" + METState.Current.demos_mode.ToString());

                METState.Current.SCRL_DataExport_ImageRoll = new System.IO.StreamWriter(SuspiciousPath + "/p" + participant +  "_" + METState.Current.demos_mode.ToString()+".csv");

                //// Write headdings of SCRL_DataExport_ImageRoll

                int[] indices = SCRL.Conditions.target_indices;
                
                METState.Current.SCRL_DataExport_ImageRoll.Write(
                    "Speed," + SCRL.Conditions.speed_mind
                   + "\n Image_scale," + SCRL.Conditions.image_scale
                   + "\n Border_scale," + SCRL.Conditions.border_scale
                   + "\n Window Width," + METState.Current.SCRL_window_W + "\n Window Height," + METState.Current.SCRL_window_H
                   + "\n" + "Target index," + string.Join(",", indices)
                
                   + "\n speed_condition," + condition_width_speed);

                

                //// Write headdings of SCRL_DataExport_Eye
                string GazeDataLine = "Time  , Pupil Center X , Pupil Center Y , Glint Center X , Glint Center Y , Pupil Diameter , Flag";
                METState.Current.SCRL_DataExport_Eye.WriteLine(GazeDataLine);

               





            }
        }

        public System.Drawing.Bitmap CombineBitmap(BitmapImage[] bitmaps, int border_width, int image_width, int image_height)
        {





            int img_top = Convert.ToInt16(METState.Current.SCRL_window_H / 2 - image_height / 2);
        


            //// We define a CELL as an image with border around it. width of a cell is == 0.5*border_width+ image_width+0.5*border_width
            int cell_width = image_width + border_width;



            //read all images into memory
            int w = (int)((bitmaps.Length) * cell_width + 2 * METState.Current.SCRL_window_W);
            int h = Convert.ToInt32(METState.Current.SCRL_window_H);
           
            System.Drawing.Bitmap finalImage = new System.Drawing.Bitmap(w,h );

            try
            {



                //get a graphics object from the image so we can draw on it
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(finalImage))
                {
                    //set background color
                    g.Clear(System.Drawing.Color.Black);


                    //go through each image and draw it on the final image
                    for (int i = 0; i < bitmaps.Length; i++)
                    {
                        g.DrawImage(BitmapImage2Bitmap(bitmaps[i]), (int)METState.Current.SCRL_window_W + border_width + i * cell_width, img_top, image_width, image_height);
                    }



                }

                return finalImage;
            }
            catch (Exception ex)
            {
                if (finalImage != null)
                    finalImage.Dispose();

                throw ex;
            }
  
        }

        private System.Drawing. Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            // BitmapImage bitmapImage = new BitmapImage(new Uri("../Images/test.png", UriKind.Relative));

            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);

                return new System.Drawing.Bitmap(bitmap);
            }
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        private BitmapImage Bitmap2BitmapImage(System.Drawing.Bitmap bitmap)
        {
            IntPtr hBitmap = bitmap.GetHbitmap();
            BitmapImage retval;

            try
            {
                retval = (BitmapImage)System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                             hBitmap,
                             IntPtr.Zero,
                             Int32Rect.Empty,
                             BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(hBitmap);
            }

            return retval;
        }


        private void ImageCanvas_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Escape)
            {
                if (storyboard_circles != null) storyboard_circles.Stop();
                if (storyboard_scroll != null) ScrollFinished();
      
                CloseWindow();


            }

            else if (e.Key == System.Windows.Input.Key.Space)
            {
                METState.Current.SCRL_Flag = " -> Space Pressed";
                
                if (METState.Current.SCRL_State == METState.SCRL_States.stopped)
                {
                    //storyboard_scroll.Stop();
                    //storyboard_scroll.Children.Clear();
                    moveAgain();
                }
                else if (METState.Current.SCRL_State == METState.SCRL_States.Rolling && METState.Current.SCRL_stopMode == METState.SCRL_StopMode.Manual)
                {
                    //storyboard_scroll.Stop();
                    //storyboard_scroll.Children.Clear();

                     Dispatcher.BeginInvoke((Action)(() => DoSomething()));


                }

            }
            else if ((e.Key == System.Windows.Input.Key.Right || e.Key == System.Windows.Input.Key.Left) && METState.Current.SCRL_State == METState.SCRL_States.stopped)
            {
                
                //SCRL_scroll.Stop();
                //SCRL_scroll.Children.Clear();

                double dis = METState.Current.SCRL_image_width + border_width;

                dis = e.Key == System.Windows.Input.Key.Right ? _scroll.X - dis : _scroll.X + dis;

                ElasticEase ease = new ElasticEase();
                ease.EasingMode = EasingMode.EaseOut;
                ease.Oscillations = 1;
                ease.Springiness = 8;



                DoubleAnimation animation_scroll = new DoubleAnimation { Duration = TimeSpan.FromSeconds(1), From = _scroll.X, To = dis, EasingFunction = ease };

                Scroll(animation_scroll,false);
            }

        }
        private void HandleGesture(object sender, HeadGestureEventArgs e)
        {
            
            if (e.Gesture == "TL")
            {
                Dispatcher.BeginInvoke(new Action(delegate
                {
                    moveAgain();
                }));
            }
        }
        private void moveAgain()
        {
            if (METState.Current.SCRL_State == METState.SCRL_States.stopped)
            {
                //storyboard_scroll.Children.Clear();
                //storyboard_scroll.Stop();               
                
                double dur = (totalImageWidth + _scroll.X) / (Conditions.speed_mind);

                DoubleAnimation animation_scroll = new DoubleAnimation { Duration = TimeSpan.FromSeconds(dur), From = _scroll.X, To = -totalImageWidth };

                Scroll(animation_scroll,true);

            }
        }

        private void ImageCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            this.PreviewKeyUp += ImageCanvas_PreviewKeyUp;
            this.Focusable = true;
            this.Focus();
        }

   
    }
}
