
//<copyright file="DetectActiveScreen.cs" company="ITU">
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
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV.Structure;
using Emgu.CV;
namespace Haytham
{
    public class DetectActiveScreen
    {
        public bool Glyph_Is_On = false;
        public int NoRectangle_FrameCounter = 0;//0 means noRectangle found in the current frame
        public int ProcessImage_FrameCounter = 0;
        private GlyphImageProcessor imageProcessor = new GlyphImageProcessor();


        public void Detect(Image<Bgr, Byte> inputimg, Rectangle ROI_Rect)
        {
            bool rectFound = NoRectangle_FrameCounter == 0 ? true : false;

            if (METState.Current.server.ForcedActiveScreen != "")
            {
                METState.Current.server.activeScreen = METState.Current.server.ForcedActiveScreen;
                getActiveScreenResolusion();
            }
            else
            {


                if (NoRectangle_FrameCounter > 30)//25 frames is ok
                {

                    METState.Current.server.activeScreen = "";
                    if (Glyph_Is_On == true)
                    {
                        //signal
                        METState.Current.server.SendToClient("Glyph", "AllMonitors", false, true);
                        METState.Current.server.SendToClient("H", "AllMonitors", false, true);
                        Glyph_Is_On = false;
                    }
                }

                if (METState.Current.server.activeScreen == "" && rectFound)
                {

                    #region Only one screen (No need for visual marker)


                    if (METState.Current.server.CountTVClients() == 0 & METState.Current.server.CountMonitorClients() == 1)
                    {


                        foreach (KeyValuePair<string, Client> kvp in METState.Current.server.clients)
                        {
                            if (kvp.Value.ClientType == "Monitor") METState.Current.server.activeScreen = kvp.Value.ClientName;
                        }
                        getActiveScreenResolusion();
                    }

                    else if (METState.Current.server.CountTVClients() == 1 & METState.Current.server.CountMonitorClients() == 0)// not support more than one TV
                    {
                        foreach (KeyValuePair<string, Client> kvp in METState.Current.server.clients)
                        {
                            if (kvp.Value.ClientType == "TV") METState.Current.server.activeScreen = kvp.Value.ClientName;
                        }
                    }




                    #endregion Only one screen (No need for visual marker)


                    #region More than one screen (visual marker)

                    else if (Glyph_Is_On == false)
                    {
                        //signal show
                        METState.Current.server.SendToClient("Glyph", "AllMonitors", false, true);
                        METState.Current.server.SendToClient("S", "AllMonitors", false, true);
                        Glyph_Is_On = true;
                    }
                    else
                    {
                        //Marker is ready
                        DetectVisualMarker(inputimg, ROI_Rect);

                        ProcessImage_FrameCounter++;

                        if (METState.Current.server.activeScreen != "")//Marker Identified (Screen identified)
                        {
                            getActiveScreenResolusion();
                            ProcessImage_FrameCounter = 0;

                            //signal
                            METState.Current.server.SendToClient("Glyph", "AllMonitors", false, true);
                            METState.Current.server.SendToClient("H", "AllMonitors", false, true);
                            Glyph_Is_On = false;
                        }

                        else if (METState.Current.server.activeScreen == "" & ProcessImage_FrameCounter > 15)
                        {
                            if (METState.Current.server.CountTVClients() != 0)
                            {
                                METState.Current.server.activeScreen = "TV1";
                                // getActiveScreenResolusion();
                                ProcessImage_FrameCounter = 0;
                            }
                            //signal
                            METState.Current.server.SendToClient("Glyph", "AllMonitors", false, true);
                            METState.Current.server.SendToClient("H", "AllMonitors", false, true);
                            Glyph_Is_On = false;
                        }
                    }

                    #endregion More than one screen (visual marker)

                }
            }
            METState.Current.METCoreObject.SendToForm(METState.Current.server.activeScreen, "ActiveMonitor_Highlight");


        }
        public void DetectVisualMarker(Image<Bgr, Byte> inputimg, Rectangle ROI_Rect)
        {
            METState.Current.METCoreObject.SendToForm("1", "lblIdentification");


            //Marker detection

            Image<Bgr, Byte> CropedimgForGlyph = new Image<Bgr, byte>(inputimg.Bitmap);

            CvInvoke.cvSetImageROI(CropedimgForGlyph, ROI_Rect);
            METState.Current.server.activeScreen = imageProcessor.ProcessImage(CropedimgForGlyph.Bitmap);
            CvInvoke.cvResetImageROI(CropedimgForGlyph);//??

            METState.Current.METCoreObject.SendToForm("0", "lblIdentification");
        }

        public void getActiveScreenResolusion()
        {
            if (METState.Current.server.activeScreen != "")
            {
                METState.Current.monitor.Real_Monitor_W = METState.Current.server.clients[METState.Current.server.activeScreen].Width;
                METState.Current.monitor.Real_Monitor_H = METState.Current.server.clients[METState.Current.server.activeScreen].Height;
            }
        }



    }
}
