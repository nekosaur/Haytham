using System.Collections.Generic;

namespace Haytham.VideoSource
{
	public interface IVideoSource
	{
		string Name { get; }
		IEnumerable<DeviceCapabilityInfo> Capabilities { get; }
		DeviceCapabilityInfo SelectedCap { get; set; }
		bool HasSettings { get; }
		bool IsRunning { get; }

		void ShowSettings();
		void Start();
		void Stop();

		event AForge.Video.NewFrameEventHandler NewFrame;
	}
}
