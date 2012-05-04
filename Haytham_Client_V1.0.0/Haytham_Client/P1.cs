using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Net;

namespace Haytham_Client
{
    public partial class P1 : Form
    {
        private Form_monitor frm_Monitor;


        public P1(Form_monitor frm)
        {
       
                InitializeComponent();

                Icon ico = new Icon(Properties.Resources.Untitled_2, 64, 64);
                this.Icon = ico;

                frm_Monitor = frm;
                frm_Monitor.Hide();
                this.WindowState = FormWindowState.Maximized;
                int W = Screen.FromHandle(frm_Monitor.Handle).Bounds.Width;
                int H = Screen.FromHandle(frm_Monitor.Handle).Bounds.Height;


                if (W > H)
                {


                    Uri myUri= new Uri(Application.StartupPath + "/Images/mouseyo.swf");
                    webBrowser1.Navigate(myUri);

                    
                }
                else
                {

                    Uri myUri = new Uri(Application.StartupPath + "/Images/mouseyo_V.swf");
                    webBrowser1.Navigate(myUri);
                }

                Cursor.Hide();




        }





        private void P1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EndTask();

        }


        private void EndTask()
        {

            frm_Monitor.Show();
            MoveCursor.CursorLoop (false);
            ClientStatus.Gaze = false;
            Cursor.Show();
        }



        private void webBrowser1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                EndTask();
                frm_Monitor.frm_P1 = null;
                this.Dispose();
                this.Close();


            }
        }







    }
}
