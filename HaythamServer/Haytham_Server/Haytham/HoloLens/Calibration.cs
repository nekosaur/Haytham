using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge;
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
        private System.Drawing.Point[] calibrationPoints;

        /// <summary>
        /// Grid of n*m points
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        private void SetPoints(int n, int m)
        {
            this.calibrationPoints = new System.Drawing.Point[n * m];

            int offsetX = 100; //pixel offset from the borders of the screen
            int offsetY = 80; //pixel offset from the borders of the screen
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    calibrationPoints[count] = new System.Drawing.Point(((PresentationScreen.Width - 2 * offsetX) / (m - 1)) * j + offsetX, ((PresentationScreen.Height - 2 * offsetY) / (n - 1)) * i + offsetY);
                    calibrationPoints[count] = System.Drawing.Point.Add(calibrationPoints[count], new Size(PresentationScreen.Left, PresentationScreen.Top));

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

                    await Task.Delay(1000);

                    List<AForge.Point> points = new List<AForge.Point>();
                    for (int j = 0; j < 8; j++)
                    {
                        points.Add(new AForge.Point(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y));
                        await Task.Delay(250);
                    }

                    AForge.Point point = this.CalculateAverage(points);

                    this.SaveSample(calibrationPoints[i], point);

                    //await Task.Delay(1000);
                }

                METState.Current.EyeToDisplay_Mapping.Calibrate();

                for (int i = 0; i < calibrationPoints.Length; i += 2)
                {
                    METState.Current.METCoreObject.SendToForm("Sending verification point " + (i + 1), "tbHoloLensServer");
                    await client.Send(MessageType.ShowCalibrationPoint);
                    await client.Send(calibrationPoints[i].X);
                    await client.Send(calibrationPoints[i].Y);

                    await Task.Delay(2000);

                    client.SaveCalibrationData(calibrationPoints[i]);

                }

                // METState.Current.EyeToDisplay_Mapping.Calibrated = true;

                await client.Send(MessageType.FinishCalibration);
            });
        }

        public AForge.Point CalculateAverage(List<AForge.Point> points)
        {
            Dictionary<AForge.Point, Dictionary<AForge.Point, double>> edgeDistances = new Dictionary<AForge.Point, Dictionary<AForge.Point, double>>();
            Dictionary<AForge.Point, int> counts = new Dictionary<AForge.Point, int>();

            foreach (AForge.Point from in points)
            {
                Dictionary<AForge.Point, double> distances = new Dictionary<AForge.Point, double>();
                edgeDistances.Add(from, distances);

                foreach (AForge.Point to in points)
                {
                    distances.Add(to, EuclideanDistance(from, to));
                }

                distances.OrderByDescending(kvp => kvp.Value).Take(2).Select(kvp => kvp.Key).ToList().ForEach(p =>
                {
                    if (counts.ContainsKey(p))
                        counts[p] = counts[p] + 1;
                    else
                        counts.Add(p, 1);
                });
            }

            return points.Except(counts.OrderByDescending(kvp => kvp.Value).Take(2).Select(kvp => kvp.Key))
                .Aggregate(new AForge.Point(), (average, coordinate) =>
                {
                    average.X += coordinate.X / 6;
                    average.Y += coordinate.Y / 6;
                    return average;
                });
        }

        private double EuclideanDistance(AForge.Point a, AForge.Point b)
        {
            float dx = a.X - b.X;
            float dy = a.Y - b.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }

        /// <summary>
        /// Save coordinate sample for calibration
        /// </summary>
        /// <param name="sampleCoordinate"></param>
        public void SaveSample(System.Drawing.Point sampleCoordinate, AForge.Point eyeCoordinate)
        {
            if (task == TaskType.CalibrateDisplay)
            {
                METState.Current.EyeToDisplay_Mapping.Destination[0, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = sampleCoordinate.X;
                METState.Current.EyeToDisplay_Mapping.Destination[1, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = sampleCoordinate.Y;

                METState.Current.EyeToDisplay_Mapping.Source[0, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = eyeCoordinate == null ? METState.Current.eyeFeature.X : eyeCoordinate.X;
                METState.Current.EyeToDisplay_Mapping.Source[1, METState.Current.EyeToDisplay_Mapping.CalibrationTarget] = eyeCoordinate == null ? METState.Current.eyeFeature.Y : eyeCoordinate.Y;

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
