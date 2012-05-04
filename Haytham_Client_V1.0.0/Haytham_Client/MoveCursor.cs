using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;

namespace Haytham_Client
{
    public static class MoveCursor
    {
        public static Point gazePoint;
        private static Point previousGazePoint;


        public static Point ScreenTopLeft;
        public static Size Screensize;





        private static Thread cursorThread; // Thread for moving the cursor
        private static bool _enable;
        public static bool enable// for checking if it's working or not
        {
            get
            {
                return _enable;
            }
        }
        public static void CursorLoop(bool setEnable)
        {
            _enable = setEnable;

            if (enable)
            {
                // start a new thread for moving the cursor

                cursorThread = new Thread(new ThreadStart(Move));
                cursorThread.Start();
                //Cursor.Hide();
            }
            else
            {
                cursorThread.Abort();
            }
        }

        private static void Move()
        {

            do
            {
                if (previousGazePoint != gazePoint)// don't move cursor if frm_Monitor.gazePoint is fixed (when server doesn't sent signal)
                {


                    System.Windows.Forms.Cursor.Position = Point.Add(gazePoint, new Size(ScreenTopLeft));
                    previousGazePoint = gazePoint;
                }

            } while (true);







        }







    }
}
