using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haytham.HoloLens.Tests
{
    class TestCalibration
    {
        public TestCalibration()
        {
            Calibration asd = new Calibration(null, 3, 3, new Rectangle(), Calibration.TaskType.CalibrateDisplay);
            List<AForge.Point> points = new List<AForge.Point>();
            points.Add(new AForge.Point(5, 5));
            points.Add(new AForge.Point(6, 5));
            points.Add(new AForge.Point(6, 6));
            points.Add(new AForge.Point(4, 6));
            points.Add(new AForge.Point(4, 5));
            points.Add(new AForge.Point(33333, 4333));
            points.Add(new AForge.Point(1231231236, 1231231237));
            points.Add(new AForge.Point(115999, 115999));
            AForge.Point avg = asd.CalculateAverage(points);
            Debug.WriteLine("SD");
        }
    }
}
