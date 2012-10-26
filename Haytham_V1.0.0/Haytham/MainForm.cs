
//<copyright file="MainForm.cs" company="ITU">
//This file is part of Haytham 
//Copyright (C) 2012 Diako Mardanbegi
// ------------------------------------------------------------------------
//This program is free software: you can redistribute it and/or modify
//it under the terms of the GNU General Public License as published by
//the Free Software Foundation, either version 3 of the License, or
//(at your option) any later version.

//This program is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//GNU General Public License for more details.

//You should have received a copy of the GNU General Public License
//along with this program.  If not, see <http://www.gnu.org/licenses/>.
// ------------------------------------------------------------------------
// </copyright>
// <author>Diako Mardanbegi</author>
// <email>dima@itu.dk</email>

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Windows.Forms.DataVisualization.Charting;
//using ;

namespace Haytham
{

    public partial class MainForm : Form
    {



        private Dictionary<string, System.Windows.Forms.Button> btnClients = new Dictionary<string, Button>();
        private Dictionary<string, System.Windows.Forms.Label> lblClients = new Dictionary<string, Label>();
        private Dictionary<string, System.Windows.Forms.TextBox> txtClients = new Dictionary<string, TextBox>();
        private Dictionary<string, System.Windows.Forms.RadioButton> radClients = new Dictionary<string, RadioButton>();

        private Dictionary<int, string> ClientsPos = new Dictionary<int, string>();

        [DllImport("winmm.dll")]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);

        [DllImport("winmm.dll")]
        public static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);



        public MainForm()
        {
            InitializeComponent();

            METState.Current.METCoreObject.SendToForm = new _SendToForm(UpdateControl);


            Icon ico = new Icon(Properties.Resources.Untitled_1, 64, 64);
            this.Icon = ico;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {


            groupBox13.Height = splitContainer1.Panel2.Height;
            splitContainer1.Panel2.AutoScroll = true;

            splitContainer1.Panel2.VerticalScroll.Visible = true;
            splitContainer1.Panel2.HorizontalScroll.Visible = true;
            splitContainer1.Panel1.HorizontalScroll.Minimum = 0;


            //..............
            groupBox_imgEye.AutoSize = true;
            groupBox_imgScene.AutoSize = true;



            groupBox14.Size = new Size(panel6.Width, splitContainer1.Panel2.Height - panel6.Height);
            groupBox14.AutoSize = true;

            METState.Current.screenMinSize = trackBarControl3.Value;
            METState.Current.syncCameras = checkEdit1.Checked;

            METState.Current.showScreen = cbShowScreen.Checked;
            METState.Current.showEdges = cbShowEdges.Checked;
            METState.Current.clientMouseSmoothing = cbMouseSmoothing.Checked;

            METState.Current.showIris = cbShowIris.Checked;
            METState.Current.showPupil = cbShowPupil.Checked;
            METState.Current.showGlint = cbShowGlint.Checked;

            METState.Current.sceneCameraUnDistortion = cbSceneUnDistortion.Checked;

            METState.Current.eye_VFlip = cb_eye_VFlip.Checked;
            METState.Current.scene_VFlip = cb_scene_VFlip.Checked;

            // Cursor.Show();


            METState.Current.GazeSmoother = cbGazeSmoothing.Checked;
            METState.Current.SceneDetection = checkBox1.Checked;

            if (rdOnlyPupil.Checked) METState.Current.calibration_eyeFeature = METState.Calibration_EyeFeature.Pupil;
            if (rbPupilGlint.Checked) METState.Current.calibration_eyeFeature = METState.Calibration_EyeFeature.PupilGlintVector;


            METState.Current.glintThreshold = trackBarThresholdGlint.Value;

            METState.Current.PupilThreshold = trackBarThresholdEye.Value;
            METState.Current.DilateErode = cbDilateErode.Checked;

            METState.Current.detectPupil = cbPupilDetection.Checked;
            METState.Current.detectGlint = cbGlintDetection.Checked;
            // cbRemoveGlint.Enabled = cbGlintDetection.Checked;
            METState.Current.RemoveGlint = cbRemoveGlint.Checked;// &cbRemoveGlint.Enabled;



            METState.Current.ShowGaze = cbShowGaze.Checked;
            METState.Current.ControlClientMouse = checkBox4.Checked;

            METState.Current.SceneBThreshold = trackBarB.Value;
            METState.Current.SceneGThreshold = trackBarG.Value;


            // METState.Current.monitor.server.ClientMoveCursor_1 = cbMoveCursor1.Checked;


            cmbDevice_Update(true, true);


            METState.Current.enablePlot = cbPlot.Checked;
            METState.Current.IrisDiameter = trackBarControl2.Value;

            METState.Current.monitor.Real_Monitor_W = 1440;//1920;// 1280;//;//Default
            METState.Current.monitor.Real_Monitor_H = 900;//1080;//2024;//;//Default


            //Adaptive Threshold
            //          pupil
            METState.Current.PAdaptive = cbPA.Checked;
            trackBarPAConstant.Enabled = cbPA.Checked;
            trackBarThresholdEye.Enabled = cbPM.Checked;

            METState.Current.PAdaptive_blockSize = trackBarPABlockSize.Value % 2 != 0 ? trackBarPABlockSize.Value : trackBarPABlockSize.Value + 1;
            METState.Current.PAdaptive_Constant = trackBarPAConstant.Value;
            METState.Current.PAdaptive_type = rbPMean.Checked ? Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C : Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;
            //          glint
            METState.Current.PAdaptive = cbGA.Checked;
            trackBarGAConstant.Enabled = cbGA.Checked;
            trackBarThresholdGlint.Enabled = cbGM.Checked;

            METState.Current.GAdaptive_blockSize = trackBarGABlockSize.Value % 2 != 0 ? trackBarGABlockSize.Value : trackBarGABlockSize.Value + 1;
            METState.Current.GAdaptive_Constant = trackBarGAConstant.Value - trackBarGAConstant.Maximum / 2;
            METState.Current.GAdaptive_type = rbGMean.Checked ? Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C : Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;
            //  METState.Current.PAdaptive_new = checkBox5.Checked;

            imEye.SizeMode = PictureBoxSizeMode.AutoSize;
            imScene.SizeMode = PictureBoxSizeMode.AutoSize;
            imSceneProcessed.SizeMode = PictureBoxSizeMode.AutoSize;
            imEyeTest.SizeMode = PictureBoxSizeMode.AutoSize;


        }
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch (Exception error)
            {
                // System.Windows.Forms.MessageBox.Show(error.ToString()); 
                // METState.Current.ErrorSound.Play();
            }
        }

        //.......................................................................Network Tab
        private void CreateClientControl(string clientName)
        {
            AddControls(clientName);

            ShowControls(clientName);
        }
        private void HighLight_Client(string clientName)
        {
            foreach (KeyValuePair<string, Label> kvp in lblClients)
            {
                if (kvp.Key == clientName)
                {
                    kvp.Value.BackColor = Color.Chartreuse;
                }
                else
                {
                    kvp.Value.BackColor = Color.Transparent;
                }
            }
            // if (lblClients.ContainsKey(clientName) == true)

        }
        private int GetPosForClient()
        {
            int n = 1;
            int i = 1;

            for (i = 1; i <= ClientsPos.Count(); i++)
            {
                if (ClientsPos.ContainsKey(i) != true)
                {

                    n = i;
                    break;
                }

            }

            if (ClientsPos.Count() + 1 == i & n == 1) n = i;


            return n;
        }
        // Function to create Control array
        // 'anyControl' is type of control, 'cNumber' is number of control
        private void AddControls(string clientName)
        {

            if (btnClients.ContainsKey(clientName) != true)
            {

                lblClients.Add(clientName, new Label());
                txtClients.Add(clientName, new TextBox());
                btnClients.Add(clientName, new Button());
                radClients.Add(clientName, new RadioButton());

                int tg;
                tg = GetPosForClient();
                ClientsPos.Add(tg, clientName);
                lblClients[clientName].Tag = tg;
                txtClients[clientName].Tag = tg;
                btnClients[clientName].Tag = tg;
                radClients[clientName].Tag = tg;

            }



        }
        private void RemoveControls(string clientName)
        {

            if (btnClients.ContainsKey(clientName))
            {
                panelClients.Controls.Remove(btnClients[clientName]);

                panelClients.Controls.Remove(lblClients[clientName]);

                panelClients.Controls.Remove(txtClients[clientName]);
                panelClients.Controls.Remove(radClients[clientName]);

                ClientsPos.Remove((int)(btnClients[clientName].Tag));
                lblClients.Remove(clientName);
                txtClients.Remove(clientName);
                btnClients.Remove(clientName);
                if (radClients[clientName].Checked)
                {
                    METState.Current.server.activeScreen = "";
                    METState.Current.server.ForcedActiveScreen = "";
                    radioButtonAutoActivation.Checked = true;
                };
                radClients.Remove(clientName);
            }
        }
        private void ShowControls(string clientName)
        {
            int xPos = 10;//distance from left and right eadge & between controls
            int yPos = 10;//vertical distance between controls

            int w = panelClients.Width;//220
            int h = 24;
            int top0 = radioButtonAutoActivation.Top + radioButtonAutoActivation.Height;//distance from top eadge


            //lbl
            lblClients[clientName].AutoSize = true;
            // lblClients[clientName].Width = w - radioButtonAutoActivation.Width;
            lblClients[clientName].Height = h;
            lblClients[clientName].TextAlign = ContentAlignment.MiddleLeft;
            lblClients[clientName].BorderStyle = System.Windows.Forms.BorderStyle.None;
            lblClients[clientName].Text = clientName;

            lblClients[clientName].Left = xPos;
            lblClients[clientName].Top = ((int)(lblClients[clientName].Tag) - 1) * 2 * h + yPos + top0;

            panelClients.Controls.Add(lblClients[clientName]);

            //rad
            radClients[clientName].AutoSize = true;
            // radClients[clientName].Width = w / 3;
            radClients[clientName].Height = h;
            radClients[clientName].Text = "Active";

            radClients[clientName].Left = radioButtonAutoActivation.Left;// xPos + 2 * w / 3;
            radClients[clientName].Top = lblClients[clientName].Top;

            panelClients.Controls.Add(radClients[clientName]);
            radClients[clientName].Visible = clientName.StartsWith("Monitor") | clientName.StartsWith("TV") ? true : false;
            radClients[clientName].CheckedChanged += new System.EventHandler(Click_radClients);

            //txt
            txtClients[clientName].Width = 3 * (w - 3 * xPos) / 5;
            txtClients[clientName].Height = h;
            txtClients[clientName].BackColor = System.Drawing.SystemColors.Info;
            txtClients[clientName].Text = "";

            txtClients[clientName].Left = xPos;
            txtClients[clientName].Top = radClients[clientName].Top + radClients[clientName].Height;

            panelClients.Controls.Add(txtClients[clientName]);
            txtClients[clientName].KeyDown += new System.Windows.Forms.KeyEventHandler(KeyDown_txtClients);//// the Event 

            //btn
            btnClients[clientName].Width = 2 * (w - 3 * xPos) / 5; ;
            btnClients[clientName].Height = h;
            btnClients[clientName].Text = "send";

            btnClients[clientName].Left = txtClients[clientName].Left + txtClients[clientName].Width + xPos;
            btnClients[clientName].Top = radClients[clientName].Top + radClients[clientName].Height;

            panelClients.Controls.Add(btnClients[clientName]);

            btnClients[clientName].Click += new System.EventHandler(Click_btnClients);//// the Event of click Button



        }
        public void Click_btnClients(Object sender, System.EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("send to " +  ((System.Windows.Forms.Button)sender).Tag.ToString());
            int tg = (int)(((System.Windows.Forms.Button)sender).Tag);
            string cName = ClientsPos[tg];
            SendTextToClient(cName);

        }
        public void Click_radClients(Object sender, System.EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("send to " +  ((System.Windows.Forms.Button)sender).Tag.ToString());
            int tg = (int)(((System.Windows.Forms.RadioButton)sender).Tag);
            string cName = ClientsPos[tg];
            //  if (radClients[cName].Checked) radClients[cName].Checked = false; ;

            METState.Current.server.ForcedActiveScreen = radClients[cName].Checked ? cName : "";
            METState.Current.server.activeScreen = METState.Current.server.ForcedActiveScreen;


        }
        public void KeyDown_txtClients(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                int tg = (int)(((System.Windows.Forms.TextBox)sender).Tag);

                string cName = ClientsPos[tg];
                SendTextToClient(cName);
            }


        }
        public void SendTextToClient(string cName)
        {

            METState.Current.server.SendToClient(txtClients[cName].Text, cName, true, true);
            METState.Current.METCoreObject.SendToForm("\r\n To " + cName + ": " + txtClients[cName].Text + "\r\n", "TextBoxServer");
            txtClients[cName].Text = "";

        }


        //.......................................................................


        private void cmbDevice_Update(bool eye, bool scene)
        {
            METState.Current.Devices = new FindCamera();
            METState.Current.Devices.Search();

            if (eye)
            {
                cmbDeviceEye.Items.Clear();

                cmbDeviceCapabilityEye.Items.Clear();

                foreach (FindCamera.DeviceInfo DevInf in METState.Current.Devices.DeviceList)
                {
                    cmbDeviceEye.Items.Add(DevInf);
                }
                cmbDeviceEye.Items.Add("Video file");

            }
            if (scene)
            {

                cmbDeviceScene.Items.Clear();
                cmbDeviceCapabilityScene.Items.Clear();

                foreach (FindCamera.DeviceInfo DevInf in METState.Current.Devices.DeviceList)
                {
                    cmbDeviceScene.Items.Add(DevInf);
                }
                cmbDeviceScene.Items.Add("Video file");


            }

            if (eye & scene)
            {
                switch (METState.Current.Devices.DeviceList.Count)
                {
                    case 0:
                        break;

                    case 1:
                        cmbDeviceEye.SelectedIndex = 0;
                        cmbDeviceScene.SelectedIndex = 0;
                        break;

                    case 2:
                        cmbDeviceEye.SelectedIndex = 0;
                        cmbDeviceScene.SelectedIndex = 1;
                        break;

                    default:
                        //IN 2TA Jabeja MItoonan beshan
                        cmbDeviceEye.SelectedIndex = 1;
                        cmbDeviceScene.SelectedIndex = 2;
                        break;
                }
            }
        }


        private void cmbDeviceEye_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSettingsEye.Enabled = false;
            if (cmbDeviceEye.SelectedItem.ToString() != "Video file")
            {
                //  btnSettingsEye.Enabled = true;
                if (cmbDeviceEye.SelectedItem != null)
                {

                    cmbDeviceCapabilityEye.Items.Clear();
                    //mishe pain nevesht har object
                    foreach (FindCamera.DeviceCapabilityInfo DevCapInf in ((FindCamera.DeviceInfo)METState.Current.Devices.DeviceList[cmbDeviceEye.SelectedIndex]).DeviceCapabilityList)
                    {
                        cmbDeviceCapabilityEye.Items.Add(DevCapInf);
                    }
                    cmbDeviceCapabilityEye.SelectedIndex = 0;
                }
            }
            else
            {
                btnSettingsEye.Enabled = false;
                cmbDeviceCapabilityEye.Items.Clear();
                cmbDeviceCapabilityEye.Text = "";
                METState.Current.EyeVideoFile = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // OpenFileDialog.Filter = "AVI File|*.avi|All File|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // create video source
                    METState.Current.EyeVideoFile = new AForge.Video.DirectShow.FileVideoSource(openFileDialog.FileName);
                }
            }
        }
        private void cmbDeviceScene_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSettingsScene.Enabled = false;
            if (cmbDeviceScene.SelectedItem.ToString() != "Video file")
            {
                //  btnSettingsScene.Enabled = true;
                if (cmbDeviceScene.SelectedItem != null)
                {

                    cmbDeviceCapabilityScene.Items.Clear();
                    //mishe pain nevesht har object
                    foreach (FindCamera.DeviceCapabilityInfo DevCapInf in ((FindCamera.DeviceInfo)METState.Current.Devices.DeviceList[cmbDeviceScene.SelectedIndex]).DeviceCapabilityList)
                    {
                        cmbDeviceCapabilityScene.Items.Add(DevCapInf);
                    }
                    cmbDeviceCapabilityScene.SelectedIndex = 0;
                }
            }
            else
            {
                btnSettingsScene.Enabled = false;
                cmbDeviceCapabilityScene.Items.Clear();
                cmbDeviceCapabilityScene.Text = "";
                METState.Current.SceneVideoFile = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                // OpenFileDialog.Filter = "AVI File|*.avi|All File|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // create video source
                    METState.Current.SceneVideoFile = new AForge.Video.DirectShow.FileVideoSource(openFileDialog.FileName);
                }
            }
        }

        private void imScene_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (METState.Current.EyeToScene_Mapping.Calibrated == false)//not to do one point calibration during the main calibration
                {
                    switch (METState.Current.EyeToScene_Mapping.CalibrationType)
                    {
                        case Calibration.calibration_type.calib_Polynomial:

                            METState.Current.GazeErrorX = 0;
                            METState.Current.GazeErrorY = 0;

                            if (METState.Current.EyeToScene_Mapping.CalibrationTarget < 9 & btnCalibration_Polynomial.Enabled == false)
                            {

                                METState.Current.EyeToScene_Mapping.ScenePoints.Add(new PointF(e.X, e.Y));
                                METState.Current.EyeToScene_Mapping.Destination[0, METState.Current.EyeToScene_Mapping.CalibrationTarget] = e.X;///METState.Current.Kw_SceneImg;
                                METState.Current.EyeToScene_Mapping.Destination[1, METState.Current.EyeToScene_Mapping.CalibrationTarget] = e.Y;///METState.Current.Kh_SceneImg;

                                METState.Current.EyeToScene_Mapping.Source[0, METState.Current.EyeToScene_Mapping.CalibrationTarget] = METState.Current.eyeFeature.X;
                                METState.Current.EyeToScene_Mapping.Source[1, METState.Current.EyeToScene_Mapping.CalibrationTarget] = METState.Current.eyeFeature.Y;


                                METState.Current.EyeToScene_Mapping.CalibrationTarget++;

                                if (METState.Current.EyeToScene_Mapping.CalibrationTarget == 9)
                                {

                                    METState.Current.EyeToScene_Mapping.CalibrationTarget = 0;
                                    METState.Current.EyeToScene_Mapping.Calibrate();
                                    

                                    METState.Current.EyeToScene_Mapping.Calibrated = true;
                                    btnCalibration_Polynomial.Enabled = true;
                                }
                            }
                            break;
                        case Calibration.calibration_type.calib_Homography:
                            if (METState.Current.EyeToScene_Mapping.CalibrationTarget < 4 & btnCalibration_Homography.Enabled == false)
                            {

                                METState.Current.EyeToScene_Mapping.ScenePoints.Add(new PointF(e.X, e.Y));
                                METState.Current.EyeToScene_Mapping.Destination[0, METState.Current.EyeToScene_Mapping.CalibrationTarget] = e.X;///METState.Current.Kw_SceneImg;
                                METState.Current.EyeToScene_Mapping.Destination[1, METState.Current.EyeToScene_Mapping.CalibrationTarget] = e.Y;///METState.Current.Kh_SceneImg;

                                METState.Current.EyeToScene_Mapping.Source[0, METState.Current.EyeToScene_Mapping.CalibrationTarget] = METState.Current.eyeFeature.X;
                                METState.Current.EyeToScene_Mapping.Source[1, METState.Current.EyeToScene_Mapping.CalibrationTarget] = METState.Current.eyeFeature.Y;


                                METState.Current.EyeToScene_Mapping.CalibrationTarget++;

                                if (METState.Current.EyeToScene_Mapping.CalibrationTarget == 4)
                                {

                                    METState.Current.EyeToScene_Mapping.CalibrationTarget = 0;
                                    METState.Current.EyeToScene_Mapping.Calibrate();
                                    

                                    METState.Current.EyeToScene_Mapping.Calibrated = true;
                                    btnCalibration_Homography.Enabled = true;
                                }
                            }
                            break;
                    }
                }
                else
                {
                    Point Gaze = METState.Current.EyeToScene_Mapping.Map(METState.Current.eyeFeature.X, METState.Current.eyeFeature.Y, e.X, e.Y);

                    METState.Current.GazeErrorX = Gaze.X;// / METState.Current.Kw_SceneImg);
                    METState.Current.GazeErrorY = Gaze.Y;// / METState.Current.Kh_SceneImg);

                }
            }
        }
        private void trackBarG_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.SceneGThreshold = trackBarG.Value;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            METState.Current.server.Close();

        }







        private void cbRemoveGlint_CheckedChanged(object sender, EventArgs e)
        {

            METState.Current.RemoveGlint = cbRemoveGlint.Checked;

        }




        private void radioButtonAutoActivation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAutoActivation.Checked) METState.Current.server.ForcedActiveScreen = "";
        }






        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.enablePlot = cbPlot.Checked;
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            METState.Current.METCoreObject.SaveCameraCalibrationData();

        }



        private void trackBarControl4_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_blockSize = trackBarPABlockSize.Value % 2 != 0 ? trackBarPABlockSize.Value : trackBarPABlockSize.Value + 1;

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;

        }


        private void rbGMean_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C;

        }

        private void rbGGaussian_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;

        }

        private void trackBarGABlockSize_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_blockSize = trackBarGABlockSize.Value % 2 != 0 ? trackBarGABlockSize.Value : trackBarGABlockSize.Value + 1;

        }



        private void cmbDeviceScene_DropDown(object sender, EventArgs e)
        {
            cmbDevice_Update(false, true);
        }

        private void cmbDeviceEye_DropDown(object sender, EventArgs e)
        {
            cmbDevice_Update(true, false);
        }




        private void cbGazeSmoothing_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.GazeSmoother = cbGazeSmoothing.Checked;

        }



        private void trackBarControl3_MouseEnter(object sender, EventArgs e)
        {
            METState.Current.showScreenSize = true;
        }

        private void trackBarControl3_MouseLeave(object sender, EventArgs e)
        {
            METState.Current.showScreenSize = false;

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnSettingsEye.Enabled = true;
                if (btnStartEye.Text == "Start")
                {
                    cmbDeviceEye.Enabled = false;
                    cmbDeviceCapabilityEye.Enabled = false;

                    if (cmbDeviceEye.SelectedItem.ToString() != "Video file")
                    {
                        btnStartEye.Text = "Stop";
                        simpleButton1.Enabled = false;
                        if (METState.Current.EyeVideoFile != null)
                        {
                            METState.Current.EyeVideoFile.SignalToStop();
                            METState.Current.EyeVideoFile = null;
                        }
                        METState.Current.EyeCamera = new AForge.Video.DirectShow.VideoCaptureDevice(((FindCamera.DeviceInfo)cmbDeviceEye.SelectedItem).MonikerString);
                        METState.Current.EyeCamera.DesiredFrameRate = ((FindCamera.DeviceCapabilityInfo)cmbDeviceCapabilityEye.SelectedItem).MaxFrameRate;
                        METState.Current.EyeCamera.DesiredFrameSize = ((FindCamera.DeviceCapabilityInfo)cmbDeviceCapabilityEye.SelectedItem).FrameSize;


                        METState.Current.EyeCamera.Start();


                        METState.Current.EyeCamera.NewFrame += new AForge.Video.NewFrameEventHandler(METState.Current.METCoreObject.EyeFrameCaptured);
                        METState.Current.METCoreObject.TrackerEventEye += new TrackerEventHandler(imEyeUpdate);
                        METState.Current.camera1Acquired = new AutoResetEvent(false);


                    }
                    else
                    {
                        #region videofile


                        if (METState.Current.EyeVideoFile != null)//&& METState.Current.EyeVideoFile.IsRunning
                        {

                            btnStartEye.Text = "Stop";
                            simpleButton1.Enabled = false;



                            METState.Current.EyeVideoFile.Start();

                            METState.Current.EyeVideoFile.NewFrame += new AForge.Video.NewFrameEventHandler(METState.Current.METCoreObject.EyeFrameCaptured);
                            METState.Current.METCoreObject.TrackerEventEye += new TrackerEventHandler(imEyeUpdate);
                            //timer1.Enabled = true;

                        }
                        #endregion video file
                    }
                }
                else
                {
                    cmbDeviceEye.Enabled = true;
                    cmbDeviceCapabilityEye.Enabled = true;

                    if (METState.Current.EyeIsRecording)
                    {
                        METState.Current.EyeIsRecording = false;
                        METState.Current.EyeVideoWriter.Dispose();
                        if (!METState.Current.SceneIsRecording)
                        {
                            btn_Record.Enabled = true;
                            btn_Record.Text = "Record Videos and EyeData";
                        }

                    }

                    if (METState.Current.EyeVideoFile != null)
                    {
                        METState.Current.EyeVideoFile.SignalToStop();
                        // METState.Current.EyeVideoFile = null;
                    }
                    else
                    {
                        METState.Current.EyeCamera.SignalToStop();
                        // METState.Current.EyeCamera.WaitForStop();
                        //   if (METState.Current.SceneCamera == null || METState.Current.SceneCamera.IsRunning != true) btnUpdateDevices.Enabled = true;
                        imEye.Image = null;
                        //   METState.Current.EyeImageForShow = null;

                    }
                    // METState.Current.camera1Acquired.Set();

                    btnStartEye.Text = "Start";
                    imEye.Size = new Size(0, 0);
                    if (btnStartScene.Text == "Start") simpleButton1.Enabled = true;


                }


            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.ToString());
                // METState.Current.ErrorSound.Play();
            }
        }


        private void button1_Click_3(object sender, EventArgs e)
        {
            METState.Current.EyeCamera.DisplayPropertyPage(IntPtr.Zero);

        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            METState.Current.SceneCamera.DisplayPropertyPage(IntPtr.Zero);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                btnSettingsScene.Enabled = true;
                if (btnStartScene.Text == "Start")
                {
                    cmbDeviceScene.Enabled = false;
                    cmbDeviceCapabilityScene.Enabled = false;

                    if (cmbDeviceScene.SelectedItem.ToString() != "Video file")
                    {
                        btnStartScene.Text = "Stop";
                        simpleButton1.Enabled = false;

                        if (METState.Current.SceneVideoFile != null)
                        {
                            METState.Current.SceneVideoFile.SignalToStop();
                            METState.Current.SceneVideoFile = null;
                        }
                        METState.Current.SceneCamera = new AForge.Video.DirectShow.VideoCaptureDevice(((FindCamera.DeviceInfo)cmbDeviceScene.SelectedItem).MonikerString);
                        METState.Current.SceneCamera.DesiredFrameRate = ((FindCamera.DeviceCapabilityInfo)cmbDeviceCapabilityScene.SelectedItem).MaxFrameRate;
                        METState.Current.SceneCamera.DesiredFrameSize = ((FindCamera.DeviceCapabilityInfo)cmbDeviceCapabilityScene.SelectedItem).FrameSize;


                        METState.Current.SceneCamera.Start();


                        METState.Current.SceneCamera.NewFrame += new AForge.Video.NewFrameEventHandler(METState.Current.METCoreObject.SceneFrameCaptured);
                        METState.Current.METCoreObject.TrackerEventScene += new TrackerEventHandler(imSceneUpdate);

                        //  btnUpdateDevices.Enabled = false;

                        if (METState.Current.METCoreObject.LoadCameraCalibrationData())
                        {
                            #region Find Intrinsic & Extrinsic Camera Parameters

                            try
                            {
                                for (int i = 0; i < METState.Current.cameraCalibrationSamples; i++)
                                    METState.Current.extrinsic_param[i] = new ExtrinsicCameraParameters();

                                CameraCalibration.CalibrateCamera(METState.Current.object_points, METState.Current.image_points, new Size(METState.Current.SceneCamera.DesiredFrameSize.Width, METState.Current.SceneCamera.DesiredFrameSize.Height), METState.Current.intrinsic_param, Emgu.CV.CvEnum.CALIB_TYPE.DEFAULT, out  METState.Current.extrinsic_param);
                                METState.Current.sceneCameraUnDistortion = true;
                                cbSceneUnDistortion.Checked = true;

                                METState.Current.sceneCameraCalibrating = false;

                            }

                            #endregion Find Intrinsic & Extrinsic Camera Parameters

                            catch (Exception er)
                            {
                                System.Windows.Forms.MessageBox.Show(er.Message.ToString());


                            }

                        }
                    }
                    else
                    {
                        #region videofile


                        if (METState.Current.SceneVideoFile != null)//&& METState.Current.SceneVideoFile.IsRunning
                        {

                            btnStartScene.Text = "Stop";
                            simpleButton1.Enabled = false;



                            METState.Current.SceneVideoFile.Start();

                            METState.Current.SceneVideoFile.NewFrame += new AForge.Video.NewFrameEventHandler(METState.Current.METCoreObject.SceneFrameCaptured);
                            METState.Current.METCoreObject.TrackerEventScene += new TrackerEventHandler(imSceneUpdate);
                            //timer1.Enabled = true;

                        }
                        #endregion video file
                    }
                }
                else
                {
                    cmbDeviceScene.Enabled = true;
                    cmbDeviceCapabilityScene.Enabled = true;

                    if (METState.Current.SceneIsRecording)
                    {
                        METState.Current.SceneIsRecording = false;
                        METState.Current.SceneVideoWriter.Dispose();
                        if (!METState.Current.SceneIsRecording)
                        {
                            btn_Record.Enabled = true;
                            btn_Record.Text = "Record Videos and SceneData";
                        }

                    }


                    if (METState.Current.SceneVideoFile != null)
                    {
                        METState.Current.SceneVideoFile.SignalToStop();
                    }
                    else
                    {


                        METState.Current.SceneCamera.SignalToStop();
                        //METState.Current.SceneCamera.WaitForStop();//We need to wait but this does not work!!!
                        // METState.Current.camera1Acquired.Set();
                        imScene.Image = null;
                    }


                    btnStartScene.Text = "Start";
                    imScene.Size = new Size(0, 0);
                    if (btnStartEye.Text == "Start") simpleButton1.Enabled = true;

                }

            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show(error.ToString());
                // METState.Current.ErrorSound.Play();
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            METState.Current.syncCameras = checkEdit1.Checked;

        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            if (btnStartEye.Text == "Start" & btnStartScene.Text == "Start")
            {
                button1_Click_1(sender, e);
                button2_Click(sender, e);
            }
        }

        private void transparentTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.IrisDiameter = trackBarControl2.Value;

        }

        private void checkBox2_CheckedChanged_2(object sender, EventArgs e)
        {
            cbShowIris.BackColor = cbShowIris.Checked ? Color.Yellow : Color.Transparent;
            METState.Current.showIris = cbShowIris.Checked;

        }

        private void checkBox2_CheckedChanged_3(object sender, EventArgs e)
        {
            METState.Current.detectPupil = cbPupilDetection.Checked;
            METState.Current.firstPupilDetection = cbPupilDetection.Checked;

        }

        private void checkBox2_CheckedChanged_4(object sender, EventArgs e)
        {
            cbShowPupil.BackColor = cbShowPupil.Checked ? Color.Yellow : Color.Transparent;

            METState.Current.showPupil = cbShowPupil.Checked;

        }



        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            METState.Current.PAdaptive = true;
            trackBarPAConstant.Enabled = cbPA.Checked;

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            METState.Current.PAdaptive = false;
            trackBarThresholdEye.Enabled = cbPM.Checked;

        }



        private void transparentTrackBar1_ValueChanged_1(object sender, EventArgs e)
        {
            METState.Current.PupilThreshold = trackBarThresholdEye.Value;

        }

        private void transparentTrackBar1_ValueChanged_2(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_Constant = trackBarPAConstant.Value;

        }



        private void checkBox2_CheckedChanged_6(object sender, EventArgs e)
        {
            METState.Current.DilateErode = cbDilateErode.Checked;

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            METState.Current.RemoveGlint = cbRemoveGlint.Checked;

        }

        private void checkBox2_CheckedChanged_7(object sender, EventArgs e)
        {
            METState.Current.detectGlint = cbGlintDetection.Checked;

        }

        private void checkBox2_CheckedChanged_8(object sender, EventArgs e)
        {
            cbShowGlint.BackColor = cbShowGlint.Checked ? Color.Yellow : Color.Transparent;

            METState.Current.showGlint = cbShowGlint.Checked;

        }

        private void radioButton2_CheckedChanged_2(object sender, EventArgs e)
        {
            METState.Current.GAdaptive = true;
            trackBarGAConstant.Enabled = cbGA.Checked;

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            METState.Current.GAdaptive = false;
            trackBarThresholdGlint.Enabled = cbGM.Checked;

        }

        private void transparentTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.glintThreshold = trackBarThresholdGlint.Value;

        }

        private void transparentTrackBar1_ValueChanged_3(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_Constant = trackBarGAConstant.Value - trackBarGAConstant.Maximum / 2;

        }

        private void checkBox2_CheckedChanged_9(object sender, EventArgs e)
        {
            METState.Current.SceneDetection = checkBox1.Checked;

        }

        private void radioButton2_CheckedChanged_3(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C;

        }

        private void radioButton1_CheckedChanged_3(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;

        }

        private void trackBarPABlockSize_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.PAdaptive_blockSize = trackBarPABlockSize.Value % 2 != 0 ? trackBarPABlockSize.Value : trackBarPABlockSize.Value + 1;

        }

        private void radioButton2_CheckedChanged_4(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_MEAN_C;

        }

        private void radioButton1_CheckedChanged_4(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_type = Emgu.CV.CvEnum.ADAPTIVE_THRESHOLD_TYPE.CV_ADAPTIVE_THRESH_GAUSSIAN_C;

        }

        private void transparentTrackBar1_ValueChanged_4(object sender, EventArgs e)
        {
            METState.Current.GAdaptive_blockSize = trackBarGABlockSize.Value % 2 != 0 ? trackBarGABlockSize.Value : trackBarGABlockSize.Value + 1;

        }



        private void checkBox2_CheckedChanged_10(object sender, EventArgs e)
        {
            cbShowScreen.BackColor = cbShowScreen.Checked ? Color.Yellow : Color.Transparent;

            METState.Current.showScreen = cbShowScreen.Checked;

        }

        private void transparentTrackBar1_ValueChanged_5(object sender, EventArgs e)
        {
            METState.Current.SceneBThreshold = trackBarB.Value;

        }

        private void transparentTrackBar2_ValueChanged_1(object sender, EventArgs e)
        {
            METState.Current.SceneGThreshold = trackBarG.Value;

        }

        private void transparentTrackBar3_ValueChanged(object sender, EventArgs e)
        {
            METState.Current.screenMinSize = trackBarControl3.Value;

        }

        private void checkBox2_CheckedChanged_11(object sender, EventArgs e)
        {
            METState.Current.sceneCameraUnDistortion = cbSceneUnDistortion.Checked;

        }

        private void button1_Click_6(object sender, EventArgs e)
        {


            #region camera calibration
            try
            {

                if (!METState.Current.sceneCameraCalibrating)
                {
                    //Set Variables
                    METState.Current.sceneCameraUnDistortion = false;
                    cbSceneUnDistortion.Checked = false;

                    METState.Current.sceneCameraCalibrating = true;
                    METState.Current.cameraCalibrationSamplesCount = 0;
                    METState.Current.object_points = new MCvPoint3D32f[METState.Current.cameraCalibrationSamples][];
                    METState.Current.image_points = new PointF[METState.Current.cameraCalibrationSamples][];
                    METState.Current.corners = new PointF[] { };
                    METState.Current.intrinsic_param = new IntrinsicCameraParameters();
                    METState.Current.extrinsic_param = new ExtrinsicCameraParameters[METState.Current.cameraCalibrationSamples];
                    btnSceneCameraCalibration.Text = string.Format("Grab ChessBoard {0}/{1}", 1, METState.Current.cameraCalibrationSamples);
                }
                else
                {
                    Image<Gray, Byte> GrayImg = METState.Current.SceneImageOrginal.Convert<Gray, Byte>();// EmgImgProcssing.BGRtoGray(e.image);

                    METState.Current.corners = Emgu.CV.CameraCalibration.FindChessboardCorners(GrayImg,
                           new Size(METState.Current.ChessBoard_W, METState.Current.ChessBoard_H),
                     Emgu.CV.CvEnum.CALIB_CB_TYPE.ADAPTIVE_THRESH | Emgu.CV.CvEnum.CALIB_CB_TYPE.DEFAULT);
                    //Emgu.CV.CvEnum.CALIB_CB_TYPE.ADAPTIVE_THRESH | Emgu.CV.CvEnum.CALIB_CB_TYPE.NORMALIZE_IMAGE | Emgu.CV.CvEnum.CALIB_CB_TYPE.FILTER_QUADS


                    Emgu.CV.CameraCalibration.DrawChessboardCorners(GrayImg, new Size(METState.Current.ChessBoard_W, METState.Current.ChessBoard_H), METState.Current.corners);

                    METState.Current.SceneImageProcessed = new Image<Bgr, byte>(GrayImg.Bitmap);

                    GrayImg.FindCornerSubPix(new PointF[][] { METState.Current.corners }, new Size(5, 5), new Size(-1, -1), new MCvTermCriteria(0.05));

                    if (METState.Current.corners.Length == METState.Current.ChessBoard_W * METState.Current.ChessBoard_H)
                    {
                        METState.Current.object_points[METState.Current.cameraCalibrationSamplesCount] = new MCvPoint3D32f[54];
                        for (int j = 0; j < METState.Current.ChessBoard_W * METState.Current.ChessBoard_H; j++)
                        {
                            METState.Current.image_points[METState.Current.cameraCalibrationSamplesCount] = METState.Current.corners;
                            //....Later
                            METState.Current.object_points[METState.Current.cameraCalibrationSamplesCount][j].x = j / METState.Current.ChessBoard_W;
                            METState.Current.object_points[METState.Current.cameraCalibrationSamplesCount][j].y = j % METState.Current.ChessBoard_W;
                            METState.Current.object_points[METState.Current.cameraCalibrationSamplesCount][j].z = 0.0f;
                        }
                        METState.Current.cameraCalibrationSamplesCount++;
                        btnSceneCameraCalibration.Text = string.Format("Grab ChessBoard {0}/{1}", METState.Current.cameraCalibrationSamplesCount, METState.Current.cameraCalibrationSamples);

                    }
                    if (METState.Current.cameraCalibrationSamplesCount == METState.Current.cameraCalibrationSamples)//Samples collected
                    {

                        // MessageBox.Show(METState.Current.cameraCalibrationSamplesCount.ToString() + " chessboard founded");

                        #region Find Intrinsic & Extrinsic Camera Parameters

                        for (int i = 0; i < METState.Current.cameraCalibrationSamples; i++)
                            METState.Current.extrinsic_param[i] = new ExtrinsicCameraParameters();

                        CameraCalibration.CalibrateCamera(METState.Current.object_points, METState.Current.image_points, new Size(GrayImg.Width, GrayImg.Height), METState.Current.intrinsic_param, Emgu.CV.CvEnum.CALIB_TYPE.DEFAULT, out  METState.Current.extrinsic_param);

                        #endregion Find Intrinsic & Extrinsic Camera Parameters

                        METState.Current.sceneCameraUnDistortion = true;
                        cbSceneUnDistortion.Checked = true;

                        METState.Current.sceneCameraCalibrating = false;
                        btnSceneCameraCalibration.Text = "Camera Calibration";
                        METState.Current.SceneImageProcessed = null;

                        METState.Current.METCoreObject.SaveCameraCalibrationData();

                    }
                }
            }
            catch (Exception er)
            {
                // System.Windows.Forms.MessageBox.Show(er.Message.ToString());
                System.Windows.Forms.MessageBox.Show("Corners not detected!");


            }
            #endregion camera calibration
        }



        private void radioButton2_CheckedChanged_5(object sender, EventArgs e)
        {
            if (rdOnlyPupil.Checked) METState.Current.calibration_eyeFeature = METState.Calibration_EyeFeature.Pupil;

        }

        private void radioButton1_CheckedChanged_5(object sender, EventArgs e)
        {
            if (rbPupilGlint.Checked) METState.Current.calibration_eyeFeature = METState.Calibration_EyeFeature.PupilGlintVector;

        }

        private void button1_Click_7(object sender, EventArgs e)
        {
            METState.Current.EyeToScene_Mapping.ScenePoints = new List<PointF>();
            METState.Current.GazeErrorX = 0;
            METState.Current.GazeErrorY = 0;

            METState.Current.EyeToScene_Mapping.CalibrationTarget = 0;
            METState.Current.EyeToScene_Mapping.Calibrated = false;// ta click rooye scene noghtegiri shavad na eslah
            METState.Current.EyeToScene_Mapping.CalibrationType = Calibration.calibration_type.calib_Polynomial;




            btnCalibration_Polynomial.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            METState.Current.EyeToScene_Mapping.ScenePoints = new List<PointF>();
            METState.Current.GazeErrorX = 0;
            METState.Current.GazeErrorY = 0;


            METState.Current.EyeToScene_Mapping.CalibrationTarget = 0;
            METState.Current.EyeToScene_Mapping.Calibrated = false;// ta click rooye scene noghtegiri shavad na eslah

            METState.Current.EyeToScene_Mapping.CalibrationType = Calibration.calibration_type.calib_Homography;
            btnCalibration_Homography.Enabled = false;
        }

        private void checkBox2_CheckedChanged_13(object sender, EventArgs e)
        {
            METState.Current.GazeSmoother = cbGazeSmoothing.Checked;

        }



        private void cbShowGaze_CheckedChanged_2(object sender, EventArgs e)
        {
            cbShowGaze.BackColor = cbShowGaze.Checked ? Color.Yellow : Color.Transparent;
            METState.Current.ShowGaze = cbShowGaze.Checked;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            #region Export
            if (METState.Current.SceneIsRecording == false & METState.Current.EyeIsRecording == false)// Record
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "AVI File|*.avi|All File|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    #region SetRecord

                    string dir = saveFileDialog.FileName;
                    int extesion_index = dir.IndexOf(".avi");
                    string newdir;
                    newdir = dir.Substring(0, extesion_index) + "_eye.avi";
                    bool codecOK = true;
                    try
                    {
                        if (METState.Current.SceneCamera != null && METState.Current.SceneCamera.IsRunning | METState.Current.SceneVideoFile != null)
                        {

                            int SceneW = METState.Current.SceneImageOrginal.Width;
                            int SceneH = METState.Current.SceneImageOrginal.Height;
                            METState.Current.SceneVideoWriter = new Emgu.CV.VideoWriter(dir, -1, 15, SceneW, SceneH, true);//15?? it dependes on fps of the videos 

                            METState.Current.SceneVideoWriterFrameNumber = 0;
                        }

                        if ((METState.Current.EyeCamera != null && METState.Current.EyeCamera.IsRunning) | METState.Current.EyeVideoFile != null)
                        {
                            int EyeW = METState.Current.EyeImageOrginal.Width;
                            int EyeH = METState.Current.EyeImageOrginal.Height;

                            METState.Current.EyeVideoWriter = new Emgu.CV.VideoWriter(newdir, -1, 15, EyeW, EyeH, true);
                            METState.Current.EyeVideoWriterFrameNumber = 0;
                        }
                    }
                    catch (Exception eee)//codec problem
                    {
                        System.Windows.Forms.MessageBox.Show("Codec Problem!");

                        codecOK = false;
                    }

                    if (codecOK)
                    {
                        // TextFile

                        string textdir = dir.Substring(0, extesion_index);
                        METState.Current.TextFileDataExport = new TextFile(textdir);
                        string GazeDataLine = "Pupil Center X , Pupil Center Y , Glint Center X , Glint Center Y , Pupil Diameter";
                        if (METState.Current.TextFileDataExport != null) METState.Current.TextFileDataExport.WriteLine(GazeDataLine);



                    #endregion SetRecord



                        #region RedFrame
                        Bgr color = new Bgr(System.Drawing.Color.Red);



                        if ((METState.Current.EyeCamera != null && METState.Current.EyeCamera.IsRunning) | METState.Current.EyeVideoFile != null)
                        {
                            Image<Bgr, Byte> EyeRED = new Image<Bgr, byte>(METState.Current.EyeImageOrginal.Width, METState.Current.EyeImageOrginal.Height, color);

                            METState.Current.EyeVideoWriter.WriteFrame<Bgr, Byte>(EyeRED);
                            METState.Current.EyeIsRecording = true;
                        }

                        if (METState.Current.SceneCamera != null && METState.Current.SceneCamera.IsRunning)
                        {
                            Image<Bgr, Byte> SceneRED = new Image<Bgr, byte>(METState.Current.SceneImageOrginal.Width, METState.Current.SceneImageOrginal.Height, color);
                            METState.Current.SceneVideoWriter.WriteFrame<Bgr, Byte>(SceneRED);
                            METState.Current.SceneIsRecording = true;

                        }
                        #endregion RedFrame

                        if (METState.Current.SceneIsRecording | METState.Current.EyeIsRecording)
                        {
                            lblExport.Text = "Recording. Click to Stop";// "Recording..." + "\r\n" + "Click to Stop";


                            btn_Record.Style = System.Windows.Forms.ProgressBarStyle.Marquee;


                        }
                    }
                }




            }
            else//Stop
            {
                Bgr color = new Bgr(System.Drawing.Color.Red);
                if (METState.Current.SceneIsRecording)
                {
                    METState.Current.SceneIsRecording = false;
                    Image<Bgr, Byte> SceneRED = new Image<Bgr, byte>(METState.Current.SceneImageOrginal.Width, METState.Current.SceneImageOrginal.Height, color);
                    METState.Current.SceneVideoWriter.WriteFrame<Bgr, Byte>(SceneRED);
                    METState.Current.SceneVideoWriter.Dispose();
                }
                if (METState.Current.EyeIsRecording)
                {
                    METState.Current.EyeIsRecording = false;
                    Image<Bgr, Byte> EyeRED = new Image<Bgr, byte>(METState.Current.EyeImageOrginal.Width, METState.Current.EyeImageOrginal.Height, color);
                    METState.Current.EyeVideoWriter.WriteFrame<Bgr, Byte>(EyeRED);
                    METState.Current.EyeVideoWriter.Dispose();
                }



                METState.Current.TextFileDataExport.CloseFile();
                METState.Current.TextFileDataExport = null;
                lblExport.Text = "Export";



                btn_Record.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                btn_Record.Value = 0;


            }
            #endregion Export
        }


        private void checkBox2_CheckedChanged_14(object sender, EventArgs e)
        {
            METState.Current.enablePlot = cbPlot.Checked;

        }

        private void checkBox2_CheckedChanged_15(object sender, EventArgs e)
        {
            METState.Current.ControlClientMouse = checkBox4.Checked;

        }

        private void checkBox2_CheckedChanged_16(object sender, EventArgs e)
        {
            METState.Current.clientMouseSmoothing = cbMouseSmoothing.Checked;

        }



        private void cbShowEdges_CheckedChanged(object sender, EventArgs e)
        {
            cbShowEdges.BackColor = cbShowEdges.Checked ? Color.Yellow : Color.Transparent;

            METState.Current.showEdges = cbShowEdges.Checked;
        }


        //.......................................................................Updating the Form.......................................................................

        public void UpdateControl(object message, string controlName)
        {
            string s = "";
            if (METState.Current.TimerEnable == true)
            {
                switch (controlName)
                {

                    case "textBoxTimerEye":
                        if (comboBox_EyeTimer.InvokeRequired)
                        {
                            Invoke(new _SendToForm(UpdateControl), new object[] { message, "textBoxTimerEye" });
                        }
                        else
                        {

                            comboBox_EyeTimer.Items.Clear();
                            foreach (KeyValuePair<string, object> kvp in METState.Current.ProcessTimeEyeBranch.TimerResults.Reverse())
                            {
                                if (kvp.Key == "Total")
                                {
                                    // comboBox_EyeTimer.Items.Add("Eye: " + kvp.Value.ToString() + " ms");// kvp.Key +
                                    // comboBox_EyeTimer.SelectedIndex = 0;
                                    comboBox_EyeTimer.Text = "Eye: " + kvp.Value.ToString() + " ms";
                                }
                                else
                                {
                                    comboBox_EyeTimer.Items.Add(kvp.Key + ": " + kvp.Value.ToString() + " ms");

                                }
                            }

                        }
                        break;
                    case "textBoxTimerScene":
                        if (comboBox_SceneTimer.InvokeRequired)
                        {
                            Invoke(new _SendToForm(UpdateControl), new object[] { message, "textBoxTimerScene" });
                        }
                        else
                        {
                            comboBox_SceneTimer.Items.Clear();

                            foreach (KeyValuePair<string, object> kvp in METState.Current.ProcessTimeSceneBranch.TimerResults.Reverse())
                            {
                                if (kvp.Key == "Total")
                                {
                                    //Undistortion was in another thread and was not in the total loop
                                    if (METState.Current.ProcessTimeSceneBranch.TimerResults.ContainsKey("UnDistortion"))
                                    {
                                        // comboBox_SceneTimer.Items.Add("Scene: " + ((double)kvp.Value + (double)METState.Current.ProcessTimeSceneBranch.TimerResults["UnDistortion"]).ToString() + " ms");// kvp.Key +
                                        // comboBox_SceneTimer.SelectedIndex = 0;
                                        comboBox_SceneTimer.Text = "Scene: " + ((double)kvp.Value + (double)METState.Current.ProcessTimeSceneBranch.TimerResults["UnDistortion"]).ToString() + " ms";
                                    }
                                    else
                                    {
                                        comboBox_SceneTimer.Items.Add("Scene: " + kvp.Value.ToString() + " ms");// kvp.Key +
                                        comboBox_SceneTimer.SelectedIndex = 0;
                                    }
                                }
                                else
                                {
                                    comboBox_SceneTimer.Items.Add(kvp.Key + ": " + kvp.Value.ToString() + " ms");
                                }
                            }
                        }
                        break;



                }
            }
            switch (controlName)
            {

                case "lblIP":
                    if (lblIP.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "lblIP" });
                    }
                    else
                    {
                        lblIP.Text = message.ToString();
                    }
                    break;
                case "lblPC":
                    if (lblPupilCenter.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "lblPC" });
                    }
                    else
                    {
                        lblPupilCenter.Text = message.ToString();
                    }
                    break;
                case "lblGC"://test
                    if (lblGlintCenter.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "lblGC" });
                    }
                    else
                    {
                        lblGlintCenter.Text = message.ToString();
                    }
                    break;

                case "UnDistortion":
                    if (cbSceneUnDistortion.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "UnDistortion" });
                    }
                    else
                    {
                        METState.Current.sceneCameraUnDistortion = (bool)message;
                        cbSceneUnDistortion.Checked = (bool)message;
                    }
                    break;

                case "PupilThreshold":
                    if (trackBarThresholdEye.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "PupilThreshold" });
                    }
                    else
                    {
                        trackBarThresholdEye.Value = (int)message;
                    }
                    break;

                case "Chart1":
                    if (chart1.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "Chart1" });
                    }
                    else
                    {
                        // chart1.Series[0].Points.AddY (message);
                        chart1.Series[0].Points.AddXY(DateTime.Now, message);

                        // Adjust Y & X axis scale
                        chart1.ResetAutoValues();

                        // Keep a constant number of points by removing them from the left
                        while (chart1.Series[0].Points.Count > METState.Current.numberOfPointsInChart)
                        {
                            // Remove data points on the left side
                            while (chart1.Series[0].Points.Count > METState.Current.numberOfPointsAfterRemoval)
                            {
                                chart1.Series[0].Points.RemoveAt(0);
                            }

                        }

                        // Invalidate chart
                        chart1.Invalidate();

                    }

                    break;
                case "Chart2":
                    if (chart2.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "Chart2" });
                    }
                    else
                    {
                        // chart1.Series[0].Points.AddY (message);
                        chart2.Series[0].Points.AddXY(DateTime.Now, message);

                        // Adjust Y & X axis scale
                        chart2.ResetAutoValues();

                        // Keep a constant number of points by removing them from the left
                        while (chart2.Series[0].Points.Count > METState.Current.numberOfPointsInChart)
                        {
                            // Remove data points on the left side
                            while (chart2.Series[0].Points.Count > METState.Current.numberOfPointsAfterRemoval)
                            {
                                chart2.Series[0].Points.RemoveAt(0);
                            }

                        }

                        // Invalidate chart
                        chart2.Invalidate();

                    }

                    break;
                case "Chart3":
                    if (chart3.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "Chart3" });
                    }
                    else
                    {
                       

                            // Set auto minimum and maximum values.
                            chart3.ChartAreas["ChartArea1"].AxisY.Minimum = (int)(METState.Current.MinPupilScale * METState.Current.IrisDiameter);
                            //  chart3.ChartAreas["ChartArea1"].AxisY.Maximum = (int)(METState.Current.MaxPupilScale * METState.Current.IrisDiameter);


                            // chart1.Series[0].Points.AddY (message);
                            chart3.Series[0].Points.AddXY(DateTime.Now, message);

                            // Adjust Y & X axis scale
                            chart3.ResetAutoValues();

                            // Keep a constant number of points by removing them from the left
                            while (chart3.Series[0].Points.Count > METState.Current.numberOfPointsInChart)
                            {
                                // Remove data points on the left side
                                while (chart3.Series[0].Points.Count > METState.Current.numberOfPointsAfterRemoval)
                                {
                                    chart3.Series[0].Points.RemoveAt(0);
                                }

                            }

                            // Invalidate chart
                            chart3.Invalidate();
                     
                    }

                    break;



                case "TextBoxServer":

                    if (TextBoxServer.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "TextBoxServer" });
                    }
                    else
                    {

                        TextBoxServer.Text += (string)message;
                        TextBoxServer.SelectionStart = TextBoxServer.Text.Length;
                        TextBoxServer.ScrollToCaret();

                    }


                    break;
                case "PanelClients_Add":

                    if (panelClients.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "PanelClients_Add" });
                    }
                    else
                    {


                        CreateClientControl((string)message);
                    }


                    break;
                case "PanelClients_Remove":

                    if (panelClients.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "PanelClients_Remove" });
                    }
                    else
                    {
                        RemoveControls((string)message);






                    }


                    break;
                case "ActiveMonitor_Highlight":

                    if (TextBoxServer.InvokeRequired)
                    {
                        Invoke(new _SendToForm(UpdateControl), new object[] { message, "ActiveMonitor_Highlight" });
                    }
                    else
                    {
                        HighLight_Client((string)message);






                    }


                    break;
                case "BlinkIndicator":
                    s = (string)message;
                    if (s.StartsWith("Blink") == true)
                    {
                        if (lblBlink.InvokeRequired)
                        {
                            Invoke(new _SendToForm(UpdateControl), new object[] { message, "BlinkIndicator" });
                        }
                        else
                        {
                            lblBlink.ForeColor = s.StartsWith("Blink0") ? Color.Silver : Color.Red;
                            lblBlink.BackColor = s.StartsWith("Blink0") ? Color.Transparent : Color.Green;
                            lblBlink.Font = s.StartsWith("Blink0") ? new Font(lblBlink.Font.Name, 8f, FontStyle.Bold) : new Font(lblBlink.Font.Name, 8f, FontStyle.Regular);

                        }
                    }
                    else if (s.StartsWith("DbBlink") == true)
                    {
                        if (lblDbBlink.InvokeRequired)
                        {
                            Invoke(new _SendToForm(UpdateControl), new object[] { message, "BlinkIndicator" });
                        }
                        else
                        {
                            lblDbBlink.ForeColor = s.StartsWith("DbBlink0") ? Color.Silver : Color.Red;
                            lblDbBlink.BackColor = s.StartsWith("DbBlink0") ? Color.Transparent : Color.Green;

                            lblDbBlink.Font = s.StartsWith("DbBlink0") ? new Font(lblDbBlink.Font.Name, 8f, FontStyle.Bold) : new Font(lblDbBlink.Font.Name, 8f, FontStyle.Regular);
                        }
                    }
                    break;

            }

        }


        public void imEyeUpdate(object sender, METEventArg eventArgs)
        {


            if (btnStartEye.Text == "Stop")//METState.Current.EyeCamera.IsRunning == true &&
            {
                imEye.Image = METState.Current.EyeImageForShow;
                // imEyeTest.Image = METState.Current.EyeImageTest;




            }
            else
            {
                imEye.Image = null;
            }


        }
        public void imSceneUpdate(object sender, METEventArg eventArgs)
        {



            if (btnStartScene.Text == "Stop")
            {
                imScene.Image = METState.Current.SceneImageForShow;
                imSceneProcessed.Image = METState.Current.SceneImageProcessed;

            }
            else
            {
                imScene.Image = null;
                imSceneProcessed.Image = null;
            }


        }

        private void cb_eye_VFlip_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.eye_VFlip = cb_eye_VFlip.Checked;

        }

        private void cb_scene_VFlip_CheckedChanged(object sender, EventArgs e)
        {
            METState.Current.scene_VFlip = cb_scene_VFlip.Checked;

        }



    }
}
