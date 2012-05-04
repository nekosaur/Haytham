using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;//for Dllimport
using System.Threading;


namespace Haytham_Client
{
    public partial class Form_monitor : Form
    {


        //**********Using event in user32 for sending button value****************//

        [DllImport("user32")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        private const byte VK_MENU = 0x12;
        private const byte VK_TAB = 0x09;
        private const int KEYEVENTF_EXTENDEDKEY = 0x01;
        private const int KEYEVENTF_KEYUP = 0x02;

        #region keys
        //Symbolic
        //constant name 	Value
        //(hexadecimal) 	Keyboard (or mouse) equivalent
        //VK_LBUTTON 	01 	Left mouse button
        //VK_RBUTTON 	02 	Right mouse button
        //VK_CANCEL 	03 	Control-break processing
        //VK_MBUTTON 	04 	Middle mouse button (three-button mouse)
        //VK_BACK 	08 	BACKSPACE key
        //VK_TAB 	09 	TAB key
        //VK_CLEAR 	0C 	CLEAR key
        //VK_RETURN 	0D 	ENTER key
        //VK_SHIFT 	10 	SHIFT key
        //VK_CONTROL 	11 	CTRL key
        //VK_MENU 	12 	ALT key
        //VK_PAUSE 	13 	PAUSE key
        //VK_CAPITAL 	14 	CAPS LOCK key
        //VK_ESCAPE 	1B 	ESC key
        //VK_SPACE 	20 	SPACEBAR
        //VK_PRIOR 	21 	PAGE UP key
        //VK_NEXT 	22 	PAGE DOWN key
        //VK_END 	23 	END key
        //VK_HOME 	24 	HOME key
        //VK_LEFT 	25 	LEFT ARROW key
        //VK_UP 	26 	UP ARROW key
        //VK_RIGHT 	27 	RIGHT ARROW key
        //VK_DOWN 	28 	DOWN ARROW key
        //VK_SELECT 	29 	SELECT key
        //VK_PRINT 	2A 	PRINT key
        //VK_EXECUTE 	2B 	EXECUTE key
        //VK_SNAPSHOT 	2C 	PRINT SCREEN key
        //VK_INSERT 	2D 	INS key
        //VK_DELETE 	2E 	DEL key
        //VK_HELP 	2F 	HELP key
        //    30 	0 key
        //    31 	1 key
        //    32 	2 key
        //    33 	3 key
        //    34 	4 key
        //    35 	5 key
        //    36 	6 key
        //    37 	7 key
        //    38 	8 key
        //    39 	9 key
        //    41 	A key
        //    42 	B key
        //    43 	C key
        //    44 	D key
        //    45 	E key
        //    46 	F key
        //    47 	G key
        //    48 	H key
        //    49 	I key
        //    4A 	J key
        //    4B 	K key
        //    4C 	L key
        //    4D 	M key
        //    4E 	N key
        //    4F 	O key
        //    50 	P key
        //    51 	Q key
        //    52 	R key
        //    53 	S key
        //    54 	T key
        //    55 	U key
        //    56 	V key
        //    57 	W key
        //    58 	X key
        //    59 	Y key
        //    5A 	Z key
        //VK_NUMPAD0 	60 	Numeric keypad 0 key
        //VK_NUMPAD1 	61 	Numeric keypad 1 key
        //VK_NUMPAD2 	62 	Numeric keypad 2 key
        //VK_NUMPAD3 	63 	Numeric keypad 3 key
        //VK_NUMPAD4 	64 	Numeric keypad 4 key
        //VK_NUMPAD5 	65 	Numeric keypad 5 key
        //VK_NUMPAD6 	66 	Numeric keypad 6 key
        //VK_NUMPAD7 	67 	Numeric keypad 7 key
        //VK_NUMPAD8 	68 	Numeric keypad 8 key
        //VK_NUMPAD9 	69 	Numeric keypad 9 key
        //VK_SEPARATOR 	6C 	Separator key
        //VK_SUBTRACT 	6D 	Subtract key
        //VK_DECIMAL 	6E 	Decimal key
        //VK_DIVIDE 	6F 	Divide key
        //VK_F1 	70 	F1 key
        //VK_F2 	71 	F2 key
        //VK_F3 	72 	F3 key
        //VK_F4 	73 	F4 key
        //VK_F5 	74 	F5 key
        //VK_F6 	75 	F6 key
        //VK_F7 	76 	F7 key
        //VK_F8 	77 	F8 key
        //VK_F9 	78 	F9 key
        //VK_F10 	79 	F10 key
        //VK_F11 	7A 	F11 key
        //VK_F12 	7B 	F12 key
        //VK_F13 	7C 	F13 key
        //VK_F14 	7D 	F14 key
        //VK_F15 	7E 	F15 key
        //VK_F16 	7F 	F16 key
        //VK_F17 	80H 	F17 key
        //VK_F18 	81H 	F18 key
        //VK_F19 	82H 	F19 key
        //VK_F20 	83H 	F20 key
        //VK_F21 	84H 	F21 key
        //VK_F22 	85H 	F22 key
        //VK_F23 	86H 	F23 key
        //VK_F24 	87H 	F24 key
        //VK_NUMLOCK 	90 	NUM LOCK key
        //VK_SCROLL 	91 	SCROLL LOCK key
        //VK_LSHIFT 	A0 	Left SHIFT key
        //VK_RSHIFT 	A1 	Right SHIFT key
        //VK_LCONTROL 	A2 	Left CONTROL key
        //VK_RCONTROL 	A3 	Right CONTROL key
        //VK_LMENU 	A4 	Left MENU key
        //VK_RMENU 	A5 	Right MENU key
        //VK_PLAY 	FA 	Play key
        //VK_ZOOM 	FB 	Zoom key
        #endregion keys

        //************************************************************************//
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        //************************************************************************//
        public class TextFile
        {
            StreamWriter SW;
            public string filenamewithoutextension;

            public TextFile(string filename)
            {
                CreateFile(filename);
            }

            private void CreateFile(string filename)
            {
                filenamewithoutextension = filename;
                SW = File.CreateText(filename + ".txt");


            }
            public void CloseFile()
            {
                SW.Close();

            }

            public void WriteLine(string text)
            {
                SW.WriteLine(text);

            }

        }
        private form1 frm1;
        public P1 frm_P1;


        public System.Windows.Forms.Timer timerExportData = new System.Windows.Forms.Timer();

        Form_Recognition frm_glyph;
        AnimatedCursor mycursor;
        private TextFile exportDataFile;



        //

        public Form_monitor(form1 frm)
        {

            frm1 = frm;
            InitializeComponent();

            Icon ico = new Icon(Properties.Resources.Untitled_2, 64, 64);
            this.Icon = ico;


            MoveCursor.ScreenTopLeft.X = Screen.FromHandle(this.Handle).Bounds.Left;
            MoveCursor.ScreenTopLeft.Y = Screen.FromHandle(this.Handle).Bounds.Top;
            MoveCursor.Screensize.Width = Screen.FromHandle(this.Handle).Bounds.Width;
            MoveCursor.Screensize.Height = Screen.FromHandle(this.Handle).Bounds.Height;




        }//end Form_monitor

        public void Form_monitor_Load(object sender, EventArgs e)
        {

            Height = 410;





            // MessageBox.Show(clientName);
            this.Text += "_" + ClientStatus.clientName;
            DisplayMessage("Connection successful\r\n", textBox1);

            DisplayMessage("Your name is " + ClientStatus.clientName + "\r\n", textBox1);

            // start a new thread for sending and receiving messages
            ClientStatus.inputoutputThread = new Thread(new ThreadStart(Run));
            ClientStatus.inputoutputThread.Start();


            Rectangle rect = new Rectangle(Screen.FromHandle(this.Handle).Bounds.Left, Screen.FromHandle(this.Handle).Bounds.Top, Screen.FromHandle(this.Handle).Bounds.Width, Screen.FromHandle(this.Handle).Bounds.Height);
            frm_glyph = new Form_Recognition(this, rect);




            frm_glyph.Show();
            frm_glyph.Hide();


            timerExportData.Tick += new EventHandler(timerExportData_Tick);


        }//end Form_monitor_Load

        private void Form_monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientStatus.clientName = "PauseReconnect";
            ClientStatus.inputoutputThread.Abort();
            ClientStatus.client.Close();

            frm1.Show();

        }//end Form_monitor_FormClosing
        public void Run()
        {

            try
            {
                // receive messages sent to client
                while (true)
                {
                    string msg = ClientStatus.reader.ReadString();

                    if (msg == "cursor" & (MoveCursor.enable == true ))
                    {

                        MoveCursor.gazePoint.X = int.Parse(ClientStatus.reader.ReadString());
                        // DisplayMessage("(" + cursorPos.X + ",", textBox1);

                        MoveCursor.gazePoint.Y = int.Parse(ClientStatus.reader.ReadString());
                        // DisplayMessage(cursorPos.Y + ")\r\n", textBox1);

                    }

                    else if (msg == "Blink")
                    {
                        int X = Cursor.Position.X;
                        int Y = Cursor.Position.Y;
                        mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

                    }

                    else if (msg == "Glyph")
                    {


                        string show = "";
                        show = ClientStatus.reader.ReadString();

                        if (show == "S")
                        {

                            //frm_glyph.Show();
                            frm_glyph.DisplayImage(true);
                            // DisplayMessage("Show Glyph\r\n", textBox1);



                        }
                        else if (show == "H")
                        {
                            try
                            {
                                frm_glyph.DisplayImage(false);
                                //  DisplayMessage("Hide Glyph\r\n", textBox1);
                            }
                            catch (Exception) { }

                        }
                    }




                }
            } // end try
            catch (IOException)
            {
                DisplayMessage("Connection failed\r\n", textBox1);

                Reconnect();
            } // end catch


        }


        private void Reconnect()
        {
            DisplayMessage("Waiting for connection...\r\n", textBox1);

            ClientStatus.Reconnect("Monitor");

            DisplayMessage("Connection successful\r\n", textBox1);
            Run();

        }


        // delegate that allows method DisplayMessage to be called
        // in the thread that creates and maintains the GUI
        private delegate void DisplayDelegate(string message, Control control);
        // method DisplayMessage sets displayTextBox's Text property
        // in a thread-safe manner
        public void DisplayMessage(string message, Control control)
        {
            try
            {
                // if modifying displayTextBox is not thread safe
                if (control.InvokeRequired)
                {
                    // use inherited method Invoke to execute DisplayMessage
                    // via a delegate
                    Invoke(new DisplayDelegate(DisplayMessage),
                    new object[] { message, control });
                } // end if
                else // OK to modify displayTextBox in current thread
                {
                    control.Text += message;

                    ((TextBox)control).SelectionStart = control.Text.Length;
                    ((TextBox)control).ScrollToCaret();
                    //textBox1.SelectionStart = textBox1.Text.Length;
                    //textBox1.ScrollToCaret();


                }
            }
            catch (Exception e) { }

        }// end method DisplayMessage

        private void button1_Click(object sender, EventArgs e)
        {

            frm_P1 = new P1(this);

            frm_P1.Left = Screen.FromHandle(this.Handle).Bounds.Left;
            frm_P1.Top = Screen.FromHandle(this.Handle).Bounds.Top;

            frm_P1.Show();


            ClientStatus.Gaze = true;

            MoveCursor.CursorLoop(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientStatus.writer.Write(txtMsgToSend.Text);
            txtMsgToSend.Text = "";
        }

        private void txtMsgToSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ClientStatus.writer.Write(txtMsgToSend.Text);
                txtMsgToSend.Text = "";

            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



            panel1.Enabled = !checkBox1.Checked;
            MoveCursor.CursorLoop(checkBox1.Checked);

            ClientStatus.Gaze = checkBox1.Checked;
            ClientStatus.Commands = checkBox1.Checked;
            ClientStatus.Blink = checkBox1.Checked;


            //
            if (checkBox1.Checked)
            {



                mycursor = new AnimatedCursor();
                mycursor.Show();
                Cursor.Hide();
            }
            else
            {


                mycursor.timerSpeed.Enabled = false;
                mycursor.Dispose();
                mycursor = null;
                Cursor.Show();

            }
        }

    

 

  
   


 



        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "TEXT File|*.txt|All File|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string dir = saveFileDialog.FileName;

                    exportDataFile = new TextFile(dir);
                    timerExportData.Interval = 8;//125Hz;
                    timerExportData.Enabled = true;

                }
            }
            else
            {
                timerExportData.Enabled = false;

                exportDataFile.CloseFile();

            }
        }

        void timerExportData_Tick(object sender, EventArgs e)
        {
            //change to OGAMA Format
            string DataLine = MoveCursor.gazePoint.X + "," + MoveCursor.gazePoint.Y + " " + Cursor.Position.X + "," + Cursor.Position.Y;
            if (exportDataFile != null) exportDataFile.WriteLine(DataLine);

        }











    }
}
