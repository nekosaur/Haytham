using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myGlass
{
    public  static class MessageType
    {
        
    //standard 12 byte int msgs
    //GLASS to HAYTHAM
    public const int toHAYTHAM_READY = 1000;
    public    const int toHAYTHAM_StreamGaze_HMGT_START = 1001;
    public   const int toHAYTHAM_StreamGaze_RGT_START = 1002;
    public   const int toHAYTHAM_StreamGaze_HMGT_STOP = 1003;
    public   const int toHAYTHAM_StreamGaze_RGT_STOP = 1004;

    public   const int toHAYTHAM_Calibrate_Display = 1005;
    public   const int toHAYTHAM_Calibrate_Display_Correct = 1006;

    public   const int toHAYTHAM_Calibrate_Scene = 1007;
    public   const int toHAYTHAM_Calibrate_Scene_Correct = 1008;

    public   const int toHAYTHAM_SnapshotComming = 1009;
    public   const int toHAYTHAM_SceneCalibration_Start = 1010;
    public   const int toHAYTHAM_HeadderComming=1011;
    public const int toHAYTHAM_Calibrate_Display_Finished = 1012;
    public const int toHAYTHAM_JsonComming = 1013;

    public const int toHAYTHAM_Calibrate_ReUse = 1016;
    public const  int toHAYTHAM_Experiment_display_Start=1017;
    public const int toHAYTHAM_Experiment_scene_Start = 1018;



    //HAYTHAM to GLASS
    public   const int toGLASS_test = 2001;
    public   const int toGLASS_GAZE_RGT = 2002;
    public   const int toGLASS_GAZE_HMGT = 2003;
    public   const int toGLASS_Calibrate_Display = 2004;
    public   const int toGLASS_Calibrate_Scene = 2005;
    public   const int toGLASS_ERROR_NOTCalibrated = 2006;
    public const int toGLASS_WHAT_IS_YOUR_IP = 2007;
    public const int toGLASS_DataReceived = 2008;
    public const int toGLASS_LetsCorrectOffset = 2009;

    public const int toGLASS_ERROR_MasterNOTFound = 2010;
    public const int toGLASS_Experiment_scene = 2011;
    public const int toGLASS_Experiment_Display = 2012;
 

    }
}
