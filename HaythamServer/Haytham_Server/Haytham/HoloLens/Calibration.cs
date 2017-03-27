using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Haytham.Interfaces;

namespace Haytham.HoloLens
{
    class Calibration : ICalibration
    {
        public enum TaskType { CalibrateDisplay, EyeToEye };
        public Rectangle PresentationScreen { get; set; }

        private Client client;
        private TaskType task;
        private Point[] calibrationPoints;

        /// <summary>
        /// Grid of n*m points
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        private void SetPoints(int n, int m)
        {
            this.calibrationPoints = new Point[n * m];

            int offsetX = 100; //pixel offset from the borders of the screen
            int offsetY = 80; //pixel offset from the borders of the screen
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    calibrationPoints[count] = new Point(((PresentationScreen.Width - 2 * offsetX) / (m - 1)) * j + offsetX, ((PresentationScreen.Height - 2 * offsetY) / (n - 1)) * i + offsetY);
                    calibrationPoints[count] = Point.Add(calibrationPoints[count], new Size(PresentationScreen.Left, PresentationScreen.Top));

                    count++;
                }
            }
        }

        public Calibration(Client client, int n, int m, Rectangle rect, TaskType task)
        {
            this.client = client;
            this.task = task;
            this.PresentationScreen = rect;
            this.SetPoints(n, m);
        }

        /// <summary>
        /// Start calibration
        /// </summary>
        public void Start()
        {
            Task.Run(async () =>
            {
                for (int i = 0; i < calibrationPoints.Length; i++)
                {
                    METState.Current.METCoreObject.SendToForm("Sending calibration point " + (i + 1), "tbHoloLensServer");
                    await client.Send(MessageType.ShowCalibrationPoint);
                    await client.Send(calibrationPoints[i].X);
                    await client.Send(calibrationPoints[i].Y);

                    await Task.Delay(2000);

                    this.SaveSample(calibrationPoints[i]);

                    await Task.Delay(1000);
                }

                METState.Current.EyeToDisplay_Mapping.Calibrate();
                // METState.Current.EyeToDisplay_Mapping.Calibrated = true;

                await client.Send(MessageType.FinishCalibration);
            });
        }

        /// <summary>
        /// Save coordinate sample for calibration
        /// </summary>
        /// <param name="sampleCoordinate"></param>
        public void SaveSample(Point sampleCoordinate)
        {
            if (task == TaskType.CalibrateDisplay)
            {
                METState.Current.EyeToDisplay_Mapping.Destination[0, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = sampleCoordinate.X;
                METState.Current.EyeToDisplay_Mapping.Destination[1, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = sampleCoordinate.Y;

                METState.Current.EyeToDisplay_Mapping.Source[0, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = METState.Current.eyeFeature.X;
                METState.Current.EyeToDisplay_Mapping.Source[1, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = METState.Current.eyeFeature.Y;

                METState.Current.EyeToDisplay_Mapping.CalibrationTarget++;

                /*
                 * //.............................CAlibrating DisplayShown in Scene
                        Point[] DisplayInSceneImage = new Point[4];
                        DisplayInSceneImage[0] = new Point(510, 30);
                        DisplayInSceneImage[1] = new Point(870, 30);
                        DisplayInSceneImage[2] = new Point(510, 230);
                        DisplayInSceneImage[3] = new Point(870, 230);
                        METState.Current.GlassServer.client.Calibrate_DisplayshownInSceneMapping(DisplayInSceneImage);
                        */
            }
            /*
            else if (task == TaskType.EyeToEye)
            {
                METState.Current.EyeToEye_Mapping.Source[0, METState.Current.EyeToEye_Mapping.CalibrationTarget] = METState.Current.eyeFeature.X;
                METState.Current.EyeToEye_Mapping.Source[1, METState.Current.EyeToEye_Mapping.CalibrationTarget] = METState.Current.eyeFeature.Y;

                //CalibExp.EyeToDisplay_Mapping_4points.Destination[0, METState.Current.EyeToEye_Mapping.CalibrationTarget] = mycursor.coordinates.X;
                //CalibExp.EyeToDisplay_Mapping_4points.Destination[1, METState.Current.EyeToEye_Mapping.CalibrationTarget] = mycursor.coordinates.Y;
                //CalibExp.EyeToDisplay_Mapping_4points.Source[0, METState.Current.EyeToEye_Mapping.CalibrationTarget] = METState.Current.eyeFeature.X;
                //CalibExp.EyeToDisplay_Mapping_4points.Source[1, METState.Current.EyeToEye_Mapping.CalibrationTarget] = METState.Current.eyeFeature.Y;

                if (calibrationPoints.Count >= (METState.Current.EyeToEye_Mapping.CalibrationTarget + 2))
                {
                    myCursor.coordinates = calibrationPoints[METState.Current.EyeToEye_Mapping.CalibrationTarget + 2];
                    METState.Current.EyeToEye_Mapping.CalibrationTarget++;

                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, myCursor.coordinates);
                }
                else
                {
                    METState.Current.GlassServer.Send(myGlass.MessageType.toGLASS_Calibrate_Display, new Point(-2, -2));

                    METState.Current.EyeToEye_Mapping.Calibrate();
                    METState.Current.EyeToEye_Mapping.Calibrated = true;

                    // CalibExp.EyeToDisplay_Mapping_4points.Calibrate();
                    // CalibExp.EyeToDisplay_Mapping_4points.Calibrated = true;

                    finish();

                    timerSpeed.Enabled = false;
                }
            }*/
        }
    }
}
