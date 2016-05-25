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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowSCRL : Window
    {
        // const string _imagePath = @"C:\Users\Steven Jeuris\Desktop\ScrollingImages\ImageScroller\Images";

        TranslateTransform _scroll = new TranslateTransform();
        // bool temp = mycursor.updatePointerImage();

        int participant;
        int condition_width_speed;
        System.Windows.Threading.DispatcherTimer dispatcherTimer;
        SetupImages setupImages = new SetupImages();

 
        double border_width ;
        double totalImageWidth;
        double image_H_scale = 0.7;

        /// <summary>
        /// Only use this constructor when you want to generate images of the sequenses
        /// </summary>
        public MainWindowSCRL()
        {
            // This sets up all the stuff in the .xaml file.
            InitializeComponent();

            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenhight = System.Windows.SystemParameters.PrimaryScreenHeight;

            this.SetValue(Window.WidthProperty, screenWidth);
            this.SetValue(Window.HeightProperty, screenhight);

            METState.Current.SCRL_window_H = (double)this.GetValue(Window.HeightProperty);// Application.Current.MainWindow.Height;
            METState.Current.SCRL_window_W = (double)this.GetValue(Window.WidthProperty);// Application.Current.MainWindow.Width;

            //W = 1600;
            //H = 900;

            int si = 1;

            Type type = typeof(Conditions.IMG_Scale); // MyClass is static class with static properties
            foreach (var imgScale in type.GetFields())
            {

                Conditions.image_scale = (float)imgScale.GetValue(null);




                for (int i = 1; i <= Conditions.conditions_total; i++)
                {



                    Conditions.image_sequence = i;
                    Conditions.SetImageSequence(i);


                    //setup images

                    BitmapImage[] imgs = setupImages.setImages(Conditions.target_indices,
                          Conditions.images_count,
                          Conditions.targetImages_1,
                          Conditions.randomImages_1, "target images", "random images");


                    METState.Current.SCRL_image_width = (double)(Conditions.image_scale * METState.Current.SCRL_window_W);
                    METState.Current.SCRL_image_height = Convert.ToInt16(image_H_scale * METState.Current.SCRL_window_H);

           
                    border_width = (double)(Conditions.border_scale * METState.Current.SCRL_window_W);


                    string name = "seq" + SCRL.Conditions.image_sequence + "_" + si;

                    SaveImageRoll(imgs, name);
                }
                si = si + 1;
            }

        }
        public MainWindowSCRL(string condition)
        {
            //string condition = "p1c1";
            int p = condition.IndexOf("p");
            int c = condition.IndexOf("c");

            participant = int.Parse(condition.Substring(p + 1, c - 1));
            condition_width_speed = int.Parse(condition.Substring(c + 1));

            BitmapImage[] imgs = CreateImageRoll_2(participant, condition_width_speed);



           
            // Load images into memory.
            List<Image> images = new List<Image>();
            foreach (BitmapImage img in imgs)
            {
                Image image = new Image();

                image.Source = img;
                images.Add(image);


            }

            // This sets up all the stuff in the .xaml file.
            InitializeComponent();

            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenhight = System.Windows.SystemParameters.PrimaryScreenHeight;

            this.SetValue(Window.WidthProperty, screenWidth);
            this.SetValue(Window.HeightProperty, screenhight);

    
           // Application.Current.MainWindow.Height = screenhight;
         //Application.Current.MainWindow.Width = screenWidth;
            



            double offset = 0;
            int i = 0;
            METState.Current.SCRL_window_H = (double)this.GetValue(Window.HeightProperty);// Application.Current.MainWindow.Height;
             METState.Current.SCRL_window_W = (double)this.GetValue(Window.WidthProperty);// Application.Current.MainWindow.Width;

             double initial_offest = METState.Current.SCRL_window_W;
             
            METState.Current.SCRL_image_width = (double)(Conditions.image_scale * METState.Current.SCRL_window_W);
         
            border_width = (double)(Conditions.border_scale * METState.Current.SCRL_window_W);



            //Making the roll for saving the image
            //SaveImageRoll(imgs);


            // Add images and position in canvas.
            foreach (Image image in images)
            {

                image.Stretch = Stretch.Fill;

                // double imgWidth = image.Source.Width;
                //ImageCanvas.Background = new SolidColorBrush(Colors.Black);

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
            ShowCircles();



            //dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            //dispatcherTimer.Tick += dispatcherTimer_Tick;
            //dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            //dispatcherTimer.Start();

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
        //private void dispatcherTimer_Tick(object sender, EventArgs e)
        //{

        //}

        private void ShowCircles()
        {

            double offset = 20;
            // Create a storyboard to contain the animations.
            Storyboard storyboard = new Storyboard();
            TimeSpan duration = new TimeSpan(0, 0, 3);

            // Create a DoubleAnimation to fade the not selected option control
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = 0.4;
            animation.To = 1.0;
            animation.Duration = new Duration(duration);
            // Configure the animation to target de property Opacity
            Storyboard.SetTargetName(animation, el.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Control.OpacityProperty));

            // Add the animation to the storyboard
            storyboard.Children.Add(animation);





            el.SetValue(Canvas.LeftProperty, offset);
            el.SetValue(Canvas.TopProperty, METState.Current.SCRL_window_H / 2);
           if (METState.Current.SCRL_State == METState.SCRL_States.Left ) METState.Current.SCRL_Flag = "Left";
           
            animation.Completed += (s, e) =>
            {

                if (METState.Current.SCRL_State == METState.SCRL_States.Left || METState.Current.SCRL_State == METState.SCRL_States.Left2)
                {
                    //your completed action here

                    el.SetValue(Canvas.LeftProperty, METState.Current.SCRL_window_W - offset - (double)el.GetValue(Canvas.WidthProperty));
                    el.SetValue(Canvas.TopProperty, METState.Current.SCRL_window_H / 2);

                    if (METState.Current.SCRL_State == METState.SCRL_States.Left) { METState.Current.SCRL_Flag = "Right"; METState.Current.SCRL_State = METState.SCRL_States.Right; }
                    else if (METState.Current.SCRL_State == METState.SCRL_States.Left2){ METState.Current.SCRL_Flag = "Right2"; METState.Current.SCRL_State = METState.SCRL_States.Right2; }
       
                    storyboard.Begin(this);
                }
                else if (METState.Current.SCRL_State == METState.SCRL_States.Right)
                {
                    METState.Current.SCRL_State = METState.SCRL_States.Rolling;
                  
                    // Example of rendertransform on canvas.
                    ImageCanvas.RenderTransform = _scroll;

                    METState.Current.SCRL_Flag = "";

                    //Calculating the duration
                    double dur = totalImageWidth / (Conditions.speed );



                    // Scroll.
                    var scroll = new Storyboard();
                    DoubleAnimation animation_scroll = new DoubleAnimation { Duration = TimeSpan.FromSeconds(dur), From = 0, To = -totalImageWidth };
                    Storyboard.SetTarget(animation_scroll, ImageCanvas);
                    Storyboard.SetTargetProperty(animation_scroll, new PropertyPath("RenderTransform.X"));
                    scroll.Children.Add(animation_scroll);
                    animation_scroll.Completed += (s_scroll, e_scroll) =>
                    {

                        METState.Current.SCRL_Flag = "Left2";
                        METState.Current.SCRL_State = METState.SCRL_States.Left2;

                        el.SetValue(Canvas.LeftProperty, offset);
                        el.SetValue(Canvas.TopProperty, METState.Current.SCRL_window_H / 2);

                        scroll.Stop();
                       // _scroll.X = 0;
                        storyboard.Begin(this);

                    };

                    METState.Current.SCRL_stopwatch.Reset();
                    METState.Current.SCRL_stopwatch.Start();

                    scroll.Begin();




                }
                else if (METState.Current.SCRL_State == METState.SCRL_States.Right2)
                {
                    CloseWindow();

                  
                }
            };

            // Begin the storyboard
            storyboard.Begin(this);

        }
       private void CloseWindow(){
       if (METState.Current.SCRL_DataExport_Eye != null)
                    {


                        METState.Current.SCRL_State = METState.SCRL_States.None;


                        METState.Current.SCRL_DataExport_Eye.CloseFile();
                        METState.Current.SCRL_DataExport_Eye = null;

                        METState.Current.SCRL_DataExport_ImageRoll.Close();
                        METState.Current.SCRL_DataExport_ImageRoll = null;

                    }
                    Close();
       }
        private void PrepareRecording()
        {
            string c = "c" + condition_width_speed + "seq" + SCRL.Conditions.image_sequence;

            String SuspiciousPath = Path.Combine(@"SCRL_images\result\" + c);


            if (!Directory.Exists(SuspiciousPath)) Directory.CreateDirectory(SuspiciousPath);



            if (METState.Current.SCRL_DataExport_Eye == null)// Record
            {


                METState.Current.SCRL_DataExport_Eye = new TextFile(SuspiciousPath + "/p" + participant + c);

                METState.Current.SCRL_DataExport_ImageRoll = new System.IO.StreamWriter(SuspiciousPath + "/p" + participant + c + ".csv");

                //// Write headdings of SCRL_DataExport_ImageRoll

                METState.Current.SCRL_DataExport_ImageRoll.Write(
                    "Speed," + SCRL.Conditions.speed
                   + "\n Image_scale," + SCRL.Conditions.image_scale
                   + "\n Border_scale," + SCRL.Conditions.border_scale
                   + "\n Window Width," + METState.Current.SCRL_window_W + "\n Window Height," + METState.Current.SCRL_window_H
                   + "\n" + "Target index," + string.Join(",", SCRL.Conditions.target_indices)
                   + "\n img_order," + SCRL.Conditions.image_sequence
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

        private BitmapImage[] CreateImageRoll_2(int p, int c)
        {


            Conditions.SetCondition(c);
            Conditions.SetImageSequence(Conditions.GetImageSequence(p, c));
      

            //setup images

            BitmapImage[] imgs = setupImages.setImages(Conditions.target_indices,
                  Conditions.images_count,
                  Conditions.targetImages_1,
                  Conditions.randomImages_1, "target images", "random images");





            return imgs;



        }

        private void ImageCanvas_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key ==  System.Windows.Input.Key. Escape)
            {
               CloseWindow();


            }
            else if (e.Key == System.Windows.Input.Key.Space)
            {
                METState.Current.SCRL_Flag = " -> Space Pressed";


            }
        }

        private void ImageCanvas_Loaded(object sender, RoutedEventArgs e)
        {
            this.PreviewKeyDown += ImageCanvas_PreviewKeyDown;
            this.Focusable = true;
            this.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Application.Current.MainWindow = this;

        }
    }
}
