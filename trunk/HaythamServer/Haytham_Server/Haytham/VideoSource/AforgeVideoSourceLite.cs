using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haytham.VideoSource
{
	class AforgeVideoSourceLite : IVideoSource
	{
		public static void GetDevices(ref Dictionary<string, IVideoSource> deviceCache)
		{
			var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
			if (videoDevices != null && videoDevices.Count > 0)
			{
				foreach (FilterInfo device in videoDevices)
				{
					lock (deviceCache)
					{
						if (deviceCache.ContainsKey(device.Name))
							continue;
						//else .. all other code

						try
						{
							var video = new VideoCaptureDeviceLite(device.MonikerString);							

							// System.Diagnostics.Debug.WriteLine(device.MonikerString.ToString());
							var dev = new AforgeVideoSourceLite(device.Name, video);
							deviceCache.Add(device.Name, dev);
						}
						catch (Exception e)
						{
							System.Windows.Forms.MessageBox.Show(string.Join(Environment.NewLine, e.Message, "", e.Source, "", e.StackTrace));
						}
					}
				}
			}
		}
		public AforgeVideoSourceLite(string name_p, VideoCaptureDeviceLite dev)
		{
			this.name = name_p;			
			this.videoDevice = dev;
		}

		public string Name
		{
			get { return this.name; }
		}
		public IEnumerable<DeviceCapabilityInfo> Capabilities
		{
			get { return capList; }
		}
		public DeviceCapabilityInfo SelectedCap { get; set; }
		public bool HasSettings
		{
			get { return true; }
		}
		public bool IsRunning { get; set; }
		public void ShowSettings()
		{
			this.videoDevice.DisplayPropertyPage(IntPtr.Zero);
		}

		public event AForge.Video.NewFrameEventHandler NewFrame;

		public void Start()
		{
			this.videoDevice.NewFrame -= videoFile_NewFrame;
			this.videoDevice.NewFrame += videoFile_NewFrame;
			this.videoDevice.Start();
			this.IsRunning = true;
		}
		void videoFile_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
		{
			if (this.NewFrame != null)
				this.NewFrame(this, eventArgs);
		}

		public void Stop()
		{
			this.NewFrame = null;

			if (this.videoDevice != null)
				this.videoDevice.SignalToStop();
			this.IsRunning = false;
		}

		public override string ToString()
		{
			return this.Name;
		}

		private VideoCaptureDeviceLite videoDevice;		
		private string name;
		private List<DeviceCapabilityInfo> capList = new List<DeviceCapabilityInfo>() { new DeviceCapabilityInfo(null, "Default") };
	}
}
