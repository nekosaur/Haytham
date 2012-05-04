
// Glyph Recognition Studio
// http://www.aforgenet.com/projects/gratf/
//// Copyright © Andrew Kirillov, 2010
// andrew.kirillov@aforgenet.com
//
//Code has been changed by Diako Mardanbegi, 2012
//dima@itu.dk

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

//using AForge;
using AForge.Math.Geometry;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Vision.GlyphRecognition;


namespace Haytham
{
    class GlyphImageProcessor
    {
        // glyph recognizer to use for glyph recognition in video
        private GlyphRecognizer recognizer = new GlyphRecognizer( 5 );

        // quadrilateral transformation used to put image in place of glyph
        private BackwardQuadrilateralTransformation quadrilateralTransformation = new BackwardQuadrilateralTransformation( );

        // default pen and color to highlight glyphs
        private Pen defaultPen = new Pen( Color.Red, 3 );
        private Font defaultFont = new Font( FontFamily.GenericSerif, 15, FontStyle.Bold );
        public AForge. IntPoint center;
        public int angle;
        public int distance;
        public System.Drawing.Point pointer = new System.Drawing.Point();

        public GlyphImageProcessor()
        {
            GlyphVisualizationData visualizationData;
            byte[,] data;


            //Monitor 1

            data = new byte[5, 5];
            data[0, 0] = 0;
            data[0, 1] = 0;
            data[0, 2] = 0;
            data[0, 3] = 0;
            data[0, 4] = 0;

            data[1, 0] = 0;
            data[1, 1] = 1;
            data[1, 2] = 1;
            data[1, 3] = 0;
            data[1, 4] = 0;

            data[2, 0] = 0;
            data[2, 1] = 0;
            data[2, 2] = 1;
            data[2, 3] = 0;
            data[2, 4] = 0;

            data[3, 0] = 0;
            data[3, 1] = 0;
            data[3, 2] = 0;
            data[3, 3] = 1;
            data[3, 4] = 0;

            data[4, 0] = 0;
            data[4, 1] = 0;
            data[4, 2] = 0;
            data[4, 3] = 0;
            data[4, 4] = 0;


            Glyph S1 = new Glyph("Monitor1", data);
            visualizationData = new GlyphVisualizationData(Color.Red);
            S1.UserData = visualizationData;
   
            //Monitor 2

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 1;
      data[2, 3] = 0;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S2 = new Glyph("Monitor2", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S2.UserData = visualizationData;
    
            //Monitor 3

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 0;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 1;
      data[2, 2] = 1;
      data[2, 3] = 0;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S3 = new Glyph("Monitor3", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S3.UserData = visualizationData;
    
            //Monitor 4

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 1;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 1;
      data[2, 3] = 0;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S4 = new Glyph("Monitor4", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S4.UserData = visualizationData;
   
            //Monitor 5

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 1;
      data[2, 3] = 1;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S5 = new Glyph("Monitor5", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S5.UserData = visualizationData;
    
            //Monitor 6

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 1;
      data[2, 3] = 1;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 1;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S6 = new Glyph("Monitor6", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S6.UserData = visualizationData;
    
            //Monitor 7

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 1;
      data[2, 3] = 0;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S7 = new Glyph("Monitor7", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S7.UserData = visualizationData;
    
            //Monitor 8

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 1;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 0;
      data[2, 2] = 0;
      data[2, 3] = 1;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 1;
      data[3, 2] = 1;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S8 = new Glyph("Monitor8", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S8.UserData = visualizationData;
   
            //Monitor 9

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 0;
      data[1, 2] = 1;
      data[1, 3] = 0;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 1;
      data[2, 2] = 0;
      data[2, 3] = 1;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 0;
      data[3, 2] = 1;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S9 = new Glyph("Monitor9", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S9.UserData = visualizationData;
   
            //Monitor 10

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 1;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 1;
      data[2, 2] = 0;
      data[2, 3] = 0;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 1;
      data[3, 2] = 0;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph S10 = new Glyph("Monitor10", data);
      visualizationData = new GlyphVisualizationData(Color.Red);
      S10.UserData = visualizationData;

            //Roomba

      data = new byte[5, 5];
      data[0, 0] = 0;
      data[0, 1] = 0;
      data[0, 2] = 0;
      data[0, 3] = 0;
      data[0, 4] = 0;

      data[1, 0] = 0;
      data[1, 1] = 1;
      data[1, 2] = 0;
      data[1, 3] = 1;
      data[1, 4] = 0;

      data[2, 0] = 0;
      data[2, 1] = 1;
      data[2, 2] = 1;
      data[2, 3] = 1;
      data[2, 4] = 0;

      data[3, 0] = 0;
      data[3, 1] = 1;
      data[3, 2] = 1;
      data[3, 3] = 1;
      data[3, 4] = 0;

      data[4, 0] = 0;
      data[4, 1] = 0;
      data[4, 2] = 0;
      data[4, 3] = 0;
      data[4, 4] = 0;


      Glyph roomba = new Glyph("Roomba", data);
       visualizationData = new GlyphVisualizationData(Color.Yellow);
       roomba.UserData = visualizationData;
        
         


            
      GlyphDatabase gDB = new GlyphDatabase(5);
      gDB.Add(S1);
      gDB.Add(S2);
      gDB.Add(S3);
      gDB.Add(S4);
      gDB.Add(S5);
      gDB.Add(S6);
      gDB.Add(S7);
      gDB.Add(S8);
      gDB.Add(S9);
      gDB.Add(S10);
      gDB.Add(roomba);
      GlyphDatabase = gDB;

        }

        // Database of glyphs to recognize
        public GlyphDatabase GlyphDatabase
        {
            get { return recognizer.GlyphDatabase; }
            set
            {
                lock ( this )
                {
                    recognizer.GlyphDatabase = value;
                }
            }
        }

        // Glyphs' visualization type
        public VisualizationType VisualizationType
        {
            get { return visualizationType; }
            set
            {
                lock ( this )
                {
                    visualizationType = value;
                }
            }
        }
        private VisualizationType visualizationType = VisualizationType.Name;

        // Process image searching for glyphs and highlighting them
        public string ProcessImage( Bitmap bitmap )
        {
            string GlyphName = "";
            lock ( this )
            {
                // get list of recognized glyphs
                List<ExtractedGlyphData> glyphs = recognizer.FindGlyphs( bitmap );

                if ( glyphs.Count > 0 )
                {
                 
                    if ( ( visualizationType == VisualizationType.BorderOnly ) ||
                         ( visualizationType == VisualizationType.Name ) )
                    {
                        Graphics g = Graphics.FromImage( bitmap );

                        // highlight each found glyph
                        foreach ( ExtractedGlyphData glyphData in glyphs )
                        {
                           
                            if ( ( glyphData.RecognizedGlyph == null ) || ( glyphData.RecognizedGlyph.UserData == null ) )
                            {
                                // highlight with default pen
                                g.DrawPolygon( defaultPen, ToPointsArray( glyphData.Quadrilateral ) );
                            }
                            else
                            {
                                GlyphVisualizationData visualization =
                                    (GlyphVisualizationData) glyphData.RecognizedGlyph.UserData;

                                Pen pen = new Pen( visualization.Color, 3 );

                                // highlight border
                                g.DrawPolygon( pen, ToPointsArray( glyphData.Quadrilateral ) );

                                // show glyph's name
                                if ( visualizationType == VisualizationType.Name )
                                {
                                    // get glyph's center point
                                   AForge. IntPoint minXY, maxXY;
                                    PointsCloud.GetBoundingRectangle( glyphData.Quadrilateral, out minXY, out maxXY );
                                     center = ( minXY + maxXY ) / 2;

                                    // glyph's name size
                                    SizeF nameSize = g.MeasureString( glyphData.RecognizedGlyph.Name, defaultFont );

                                    // paint the name
                                    Brush brush = new SolidBrush( visualization.Color );

                                    g.DrawString( glyphData.RecognizedGlyph.Name, defaultFont, brush,
                                        new Point( center.X - (int) nameSize.Width / 2, center.Y - (int) nameSize.Height / 2 ) );
                                    GlyphName = glyphData.RecognizedGlyph.Name;

                                    if (GlyphName == "Roomba")
                                    {
                                        Point topC = new Point(0, 0);
                                        int i = 0, j = 1;
                                        topC.X = (glyphData.Quadrilateral[i].X + glyphData.Quadrilateral[j].X) / 2;
                                        topC.Y = (glyphData.Quadrilateral[i].Y + glyphData.Quadrilateral[j].Y) / 2;

                                        g.DrawLine(pen, pointer.X, pointer.Y, center.X, center.Y);
                                        g.DrawLine(pen, center.X, center.Y, topC.X, topC.Y);
                                        AForge.IntPoint a1 = new AForge.IntPoint(pointer.X, pointer.Y);
                                        // IntPoint a2 = new IntPoint(center.X, center.Y);
                                        AForge.IntPoint b1 = new AForge.IntPoint(center.X, center.Y);
                                        AForge.IntPoint a2 = new AForge.IntPoint(topC.X, topC.Y);
                                        distance = (int)(Math.Sqrt(Math.Pow(pointer.X - center.X, 2) + Math.Pow(pointer.Y - center.Y, 2)));
                                        angle = (int)(AForge.Math.Geometry.GeometryTools.GetAngleBetweenVectors(b1, a1, a2));

                                        int direc = 1;

                                        if ((a1.Y - b1.Y - ((b1.Y - a2.Y) / (b1.X - a2.X)) * (a1.X - b1.X)) < 0) direc = -1;

                                        if (a2.X < b1.X) direc *= -1;

                                        angle *= direc;
                                    }
                                    
                                    brush.Dispose( );
                                }

                                pen.Dispose( );
                            }
                        }
                    }
                    
                }
            }

            return GlyphName;
        }

        #region Helper methods
        // Convert list of AForge.NET framework's points to array of .NET's points
        private Point[] ToPointsArray(List<AForge.IntPoint> points)
        {
            int count = points.Count;
            Point[] pointsArray = new Point[count];

            for ( int i = 0; i < count; i++ )
            {
                pointsArray[i] = new Point( points[i].X, points[i].Y );
            }

            return pointsArray;
        }
        #endregion
    }
    struct GlyphVisualizationData
    {
        // Color to use for highlight and glyph name
        public Color Color;
        // Image to show in the quadrilateral of recognized glyph
        public string ImageName;

        public GlyphVisualizationData(Color color)
        {
            Color = color;
            ImageName = null;
        }
    }
    // Enumeration of visualization types
    enum VisualizationType
    {
        // Hightlight glyph with border only
        BorderOnly,
        // Hightlight glyph with border and put its name in the center
        Name,
        // Substitue glyph with its image
        Image
    }
}
