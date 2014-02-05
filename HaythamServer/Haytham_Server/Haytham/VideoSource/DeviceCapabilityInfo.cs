using AForge.Video.DirectShow;
using System.Drawing;

namespace Haytham.VideoSource
{
	
	public class DeviceCapabilityInfo
	{
		public Size FrameSize;
		public int MaxFrameRate;
		public VideoCapabilities origCap;
		string customStr;

		public DeviceCapabilityInfo(VideoCapabilities orig, string custom = null)
		{
			this.origCap = orig;
			if (orig != null)
			{
				FrameSize = orig.FrameSize;
				MaxFrameRate = orig.AverageFrameRate;
			}
			this.customStr = custom;
		}
		public override string ToString()
		{
			if (this.customStr != null)
				return this.customStr;
			return string.Format("{0}x{1}　{2}fps", FrameSize.Width, FrameSize.Height, MaxFrameRate);
		}
	}
}
