using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haytham.HoloLens
{
    static class MessageType
    {
        public const int StartCalibration = 1000;
        public const int ShowCalibrationPoint = 1001;
        public const int EyePositionData = 1002;
        public const int StartEyeDataTransfer = 1003;
        public const int StopEyeDataTransfer = 1004;
        public const int FinishCalibration = 1005;
        public const int LoadExperiment = 1006;
        public const int StartExperiment = 1007;
        public const int ToggleGaze = 1008;
        public const int StopExperiment = 1009;
        public const int FinishedExperiment = 1010;
        public const int SendTrialData = 1011;
        public const int LoadSandbox = 1012;
        public const int ToggleScreen = 1013;
        public const int AbortExperiment = 1014;
    }
}
