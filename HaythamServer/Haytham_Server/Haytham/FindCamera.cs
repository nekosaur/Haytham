
//<copyright file="FindCamera.cs" company="ITU">
//This file is part of Haytham 
//Copyright (C) 2013 Diako Mardanbegi
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using AForge.Video.DirectShow;
using AForge.Video;

namespace Haytham
{
   public class FindCamera
    {


        private ArrayList _DeviceList = new ArrayList();
        /// <summary>
        /// <para> DeviceList=|   Deviceinfo 0--|-----|__Name </para>
        /// <para>            |   Deviceinfo 1  |     |__MonikerString</para>
        /// <para>            |                 |     |__index</para>
        /// <para>            |                 |     |__DeviceCapabilityList=|  DeviceCapabilityInfo 0--|----|__FrameSize</para>
        /// <para>            |                 |                             |  DeviceCapabilityInfo 1  |    |__MaxFPS</para>
        /// <para>            |   Deviceinfo n  |                             |                          |</para>
        /// <para>                                                            |                          |</para>
        /// <para>                                                            |                          |</para>
        /// <para>           &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; |  DeviceCapabilityInfo n  |</para>
        /// </summary>
        ///
        public ArrayList DeviceList
        {
            get { return _DeviceList; }
        }
       

        public struct DeviceInfo
        {
            public ArrayList DeviceCapabilityList;
            public string Name;
            public string MonikerString;
            public int Index;
            Guid Category;

            public DeviceInfo(string name, string monikerString, int index, Guid category, ArrayList Capability)
            {
                Name = name;
                MonikerString = monikerString;
                Index = index;
                Category = category;
                DeviceCapabilityList = Capability;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public struct DeviceCapabilityInfo
        {
            public Size FrameSize;
            public int MaxFrameRate;

            public DeviceCapabilityInfo(Size frameSize, int maxFrameRate)
            {
                FrameSize = frameSize;
                MaxFrameRate = maxFrameRate;
            }
            public override string ToString()
            {
                return string.Format("{0}x{1}　{2}fps", FrameSize.Width, FrameSize.Height, MaxFrameRate);
            }
        }

        public void Search()
        {
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
           
            if (videoDevices != null && videoDevices.Count > 0)
            {
                
                    int idx = 0;
                    foreach (FilterInfo device in videoDevices)
                    {
                        System.Diagnostics.Debug.WriteLine(device.MonikerString.ToString());
                        System.Diagnostics.Debug.WriteLine(device.Name .ToString());

                try
                {
                        VideoCaptureDevice video = new VideoCaptureDevice(device.MonikerString);
                        System.Diagnostics.Debug.WriteLine(video.GetHashCode().ToString() );

                        ArrayList CapList = new ArrayList();
                        for (int i = 0; i < video.VideoCapabilities.Length; i++)
                        {
                            VideoCapabilities cap = video.VideoCapabilities[i];
                            DeviceCapabilityInfo capInfo = new DeviceCapabilityInfo(cap.FrameSize, cap.FrameRate);
                            

                            CapList.Add(capInfo);
                        }
                    
                       // System.Diagnostics.Debug.WriteLine(device.MonikerString.ToString());
                        _DeviceList.Add(new DeviceInfo(device.Name, device.MonikerString, idx, FilterCategory.VideoInputDevice, CapList));
                        idx++;
                }
                catch(Exception e)
                {}            
                    }






            }
        }
    }
}
