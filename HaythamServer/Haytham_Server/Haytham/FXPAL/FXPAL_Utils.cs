using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Haytham;
using myGlass;
using System.Drawing;
namespace Haytham.FXPAL
{
    public static class FXPAL_Utils
    {
        public  enum Mode : int { Finished = 0 };
        private static MemoryStream dataOutputStream = new MemoryStream();
        public static HyperImage mHyperImage;

        public static void SetupHyperImage(Image img)
        {
            mHyperImage = new HyperImage(img);

        }
       
        public static void UpdateUI()
        {

            Bitmap imgToShow =new Bitmap(mHyperImage.img);

            

            for (int i = 0; i < mHyperImage.locations.Count; i++)
            {
                if (mHyperImage.locations[i].X == 648 && mHyperImage.locations[i].Y == 486)
                { 
                //image annotation
                    MarkAnnotations(100, (Bitmap)imgToShow, imgToShow.Width - 100, imgToShow.Height - 100, System.Drawing.Color.Blue,1);
       
                }
                else
                {
                    //gaze annotation
                    MarkAnnotations(mHyperImage.CircleDiam, (Bitmap)imgToShow, mHyperImage.locations[i].X, mHyperImage.locations[i].Y, System.Drawing.Color.Yellow,0);
                }
            }


            METState.Current.METCoreObject.SendToForm(imgToShow, "imScene");
            METState.Current.METCoreObject.SendToForm("", "Update Glass Picturebox");


            if (mHyperImage.name != null && mHyperImage.name != "")
            {
                string folder = @"Jsons\";
                if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
                String SuspiciousPath = Path.Combine(folder, mHyperImage.name + ".jpg");
                imgToShow.Save(SuspiciousPath);
            }

        
        }
        public static String GetCursorString(int X, int Y)
        {
            String txt = "";
            try
            {


                for (int i = 0; i < mHyperImage.locations.Count; i++)
                {
                    double dist = Math.Sqrt((Math.Pow(X - mHyperImage.locations[i].X, 2)) + (Math.Pow(Y - mHyperImage.locations[i].Y, 2)));
                    if (dist < (mHyperImage.CircleDiam / 2))
                    {

                        return mHyperImage.texts[i];
                    }
                }
            }
            catch (Exception e) { txt = "";
            }
            return txt;

        }
        
       
        public static bool MarkAnnotations(double diam,Bitmap InputImage, int x, int y, Color color,int shape)
        {
            if (x > 0 & x < InputImage.Width & y > 0 & y < InputImage.Height)
            {
                Graphics gr2 = Graphics.FromImage(InputImage);

                // Create a new pen.
                Pen pen = new Pen(color);

                float size = (float)diam;
                // Set the pen's width.
                pen.Width = 3.0F;

                // Set the LineJoin property.
                pen.LineJoin = System.Drawing.Drawing2D.LineJoin.MiterClipped;

             if (shape==0)  gr2.DrawArc(pen, x - size / 2, y - size / 2, size, size, 0, 360);
             else if (shape == 1) gr2.DrawRectangle(pen,new Rectangle( new Point(x , y) , new Size((int)diam,(int)diam)));



                gr2.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
