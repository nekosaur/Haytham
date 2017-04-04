using Haytham.Forms;

namespace Haytham
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title10 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title11 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title12 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.rootContainer = new System.Windows.Forms.SplitContainer();
            this.leftTabs = new System.Windows.Forms.TabControl();
            this.tabPage_Camera = new System.Windows.Forms.TabPage();
            this.gbStartBoth = new System.Windows.Forms.GroupBox();
            this.startBoothVideos = new System.Windows.Forms.Button();
            this.gbSceneCameraDevice = new System.Windows.Forms.GroupBox();
            this.cbSceneVerticalFlip = new System.Windows.Forms.CheckBox();
            this.btnSettingsScene = new System.Windows.Forms.Button();
            this.btnStartScene = new System.Windows.Forms.Button();
            this.cmbDeviceCapabilityScene = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDeviceScene = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbEyeCameraDevice = new System.Windows.Forms.GroupBox();
            this.cbEyeVerticalFlip = new System.Windows.Forms.CheckBox();
            this.btnSettingsEye = new System.Windows.Forms.Button();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeviceCapabilityEye = new System.Windows.Forms.ComboBox();
            this.cmbDeviceEye = new System.Windows.Forms.ComboBox();
            this.tabPage_Glass = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTargetBMax = new System.Windows.Forms.NumericUpDown();
            this.nudTargetBMin = new System.Windows.Forms.NumericUpDown();
            this.nudTargetGMax = new System.Windows.Forms.NumericUpDown();
            this.nudTargetGMin = new System.Windows.Forms.NumericUpDown();
            this.nudTargetRMax = new System.Windows.Forms.NumericUpDown();
            this.nudTargetRMin = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtImageName = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCommandsToGlass = new System.Windows.Forms.ListBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.tabPage_Eye = new System.Windows.Forms.TabPage();
            this.gbGlintDetection = new System.Windows.Forms.GroupBox();
            this.cbGlintManual = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.rbGGaussian = new System.Windows.Forms.RadioButton();
            this.rbGMean = new System.Windows.Forms.RadioButton();
            this.cbGlintAuto = new System.Windows.Forms.RadioButton();
            this.cbShowGlint = new System.Windows.Forms.CheckBox();
            this.cbGlintDetection = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbPM = new System.Windows.Forms.RadioButton();
            this.pnlGlintDetection = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.rbPGaussian = new System.Windows.Forms.RadioButton();
            this.rbPMean = new System.Windows.Forms.RadioButton();
            this.cbPA = new System.Windows.Forms.RadioButton();
            this.cbRemoveGlint = new System.Windows.Forms.CheckBox();
            this.cbDilateErode = new System.Windows.Forms.CheckBox();
            this.cbShowPupil = new System.Windows.Forms.CheckBox();
            this.cbPupilDetection = new System.Windows.Forms.CheckBox();
            this.gbIrisDiameter = new System.Windows.Forms.GroupBox();
            this.cbShowIris = new System.Windows.Forms.CheckBox();
            this.lbIrisDiameter = new System.Windows.Forms.Label();
            this.tabPage_Scene = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSceneCameraCalibration = new System.Windows.Forms.Button();
            this.cbSceneUnDistortion = new System.Windows.Forms.CheckBox();
            this.cbShowGaze = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox21 = new System.Windows.Forms.GroupBox();
            this.cbShowEdges = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbShowScreen = new System.Windows.Forms.CheckBox();
            this.tabPage_Calibration = new System.Windows.Forms.TabPage();
            this.gbCalibrationGlass = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gbCalibrationRemote = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbCalibrationScene = new System.Windows.Forms.GroupBox();
            this.lbl_calibration = new System.Windows.Forms.Label();
            this.btnCalibration_Homography = new System.Windows.Forms.Button();
            this.btnCalibration_Polynomial = new System.Windows.Forms.Button();
            this.pnlCalibration = new System.Windows.Forms.Panel();
            this.rbGlint = new System.Windows.Forms.RadioButton();
            this.rbPupilGlint = new System.Windows.Forms.RadioButton();
            this.rdOnlyPupil = new System.Windows.Forms.RadioButton();
            this.cbGazeSmoothing = new System.Windows.Forms.CheckBox();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.gbDataCharts = new System.Windows.Forms.GroupBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbPlot = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbDataExport = new System.Windows.Forms.GroupBox();
            this.cbRecordSceneVideo = new System.Windows.Forms.CheckBox();
            this.cbRecordEyeVideo = new System.Windows.Forms.CheckBox();
            this.pbRecordProgress = new System.Windows.Forms.ProgressBar();
            this.btnRecord = new System.Windows.Forms.Button();
            this.tabPage_Clients = new System.Windows.Forms.TabPage();
            this.gbClientsSettings = new System.Windows.Forms.GroupBox();
            this.rbAutoActivation = new System.Windows.Forms.RadioButton();
            this.gbClientsMessages = new System.Windows.Forms.GroupBox();
            this.TextBoxServer = new System.Windows.Forms.TextBox();
            this.tabPage_Gesture = new System.Windows.Forms.TabPage();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.btn_Custom4 = new System.Windows.Forms.Button();
            this.prg_Custom4 = new System.Windows.Forms.ProgressBar();
            this.btn_Custom3 = new System.Windows.Forms.Button();
            this.prg_Custom3 = new System.Windows.Forms.ProgressBar();
            this.btn_Custom2 = new System.Windows.Forms.Button();
            this.prg_Custom2 = new System.Windows.Forms.ProgressBar();
            this.btn_Custom1 = new System.Windows.Forms.Button();
            this.prg_Custom1 = new System.Windows.Forms.ProgressBar();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.pbUpRight2 = new System.Windows.Forms.PictureBox();
            this.radioButton8D = new System.Windows.Forms.RadioButton();
            this.pbUp1 = new System.Windows.Forms.PictureBox();
            this.pbUpLeft2 = new System.Windows.Forms.PictureBox();
            this.pbUp2 = new System.Windows.Forms.PictureBox();
            this.radioButton4D = new System.Windows.Forms.RadioButton();
            this.pbUpRight1 = new System.Windows.Forms.PictureBox();
            this.pbRight1 = new System.Windows.Forms.PictureBox();
            this.pbUpLeft1 = new System.Windows.Forms.PictureBox();
            this.pbRight2 = new System.Windows.Forms.PictureBox();
            this.pbLeft2 = new System.Windows.Forms.PictureBox();
            this.pbDownRight1 = new System.Windows.Forms.PictureBox();
            this.pbLeft1 = new System.Windows.Forms.PictureBox();
            this.pbDownRight2 = new System.Windows.Forms.PictureBox();
            this.pbDownLeft2 = new System.Windows.Forms.PictureBox();
            this.pbDown1 = new System.Windows.Forms.PictureBox();
            this.pbDownLeft1 = new System.Windows.Forms.PictureBox();
            this.pbDown2 = new System.Windows.Forms.PictureBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pbTRight = new System.Windows.Forms.PictureBox();
            this.pbTLeft = new System.Windows.Forms.PictureBox();
            this.cbHeadRollGestures = new System.Windows.Forms.CheckBox();
            this.cbEditShowOpticalFlow = new System.Windows.Forms.CheckBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.btnDbBlink = new System.Windows.Forms.Button();
            this.btnBlink = new System.Windows.Forms.Button();
            this.tabPage_ExtData = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btn_CleanCache = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabPage_EyeGrip = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSpeedMindValue = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tbSpeedMind = new System.Windows.Forms.TrackBar();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.label_SCRL = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.nudSCRLSensitivity = new System.Windows.Forms.NumericUpDown();
            this.button14 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage_HoloLens = new System.Windows.Forms.TabPage();
            this.gbHoloLensExperiment = new System.Windows.Forms.GroupBox();
            this.lblHoloLensCurrentParticipant = new System.Windows.Forms.Label();
            this.btnHoloLensNewParticipant = new System.Windows.Forms.Button();
            this.cmbHoloLensChoices = new System.Windows.Forms.ComboBox();
            this.cmbHoloLensDistance = new System.Windows.Forms.ComboBox();
            this.cmbHoloLensAlignment = new System.Windows.Forms.ComboBox();
            this.lblHoloLensCalibration = new System.Windows.Forms.Label();
            this.btnHoloLensHideGaze = new System.Windows.Forms.Button();
            this.btnHoloLensShowGaze = new System.Windows.Forms.Button();
            this.lblHoloLensChoices = new System.Windows.Forms.Label();
            this.lblHoloLensAlignment = new System.Windows.Forms.Label();
            this.lblHoloLensDistance = new System.Windows.Forms.Label();
            this.btnHoloLensLoadExperiment = new System.Windows.Forms.Button();
            this.btnCalibrateHoloLensFar = new System.Windows.Forms.Button();
            this.btnCalibrateHoloLensMiddle = new System.Windows.Forms.Button();
            this.btnCalibrateHoloLensNear = new System.Windows.Forms.Button();
            this.gpHoloLensServer = new System.Windows.Forms.GroupBox();
            this.tbHoloLensServer = new System.Windows.Forms.TextBox();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gbEyeImage = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imEye = new System.Windows.Forms.PictureBox();
            this.gbSceneImage = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imSceneProcessed = new System.Windows.Forms.PictureBox();
            this.imScene = new System.Windows.Forms.PictureBox();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.chartTest = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.imEyeTest = new Emgu.CV.UI.ImageBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.lblIP = new System.Windows.Forms.TextBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.lblGlintCenter = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.lblPupilCenter = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.cmbSceneTimer = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cmbEyeTimer = new System.Windows.Forms.ComboBox();
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.btnHoloLensExperimentLoadSandbox = new System.Windows.Forms.Button();
            this.trackBarGABlockSize = new Haytham.Forms.TransparentTrackBar();
            this.trackBarThresholdGlint = new Haytham.Forms.TransparentTrackBar();
            this.trackBarGAConstant = new Haytham.Forms.TransparentTrackBar();
            this.trackBarPABlockSize = new Haytham.Forms.TransparentTrackBar();
            this.trackBarPAConstant = new Haytham.Forms.TransparentTrackBar();
            this.trackBarThresholdEye = new Haytham.Forms.TransparentTrackBar();
            this.tbIrisDiameter = new Haytham.Forms.TransparentTrackBar();
            this.tbMonitorBThreshold = new Haytham.Forms.TransparentTrackBar();
            this.tbMonitorGThreshold = new Haytham.Forms.TransparentTrackBar();
            this.tbMonitorMinSize = new Haytham.Forms.TransparentTrackBar();
            this.btnHoloLensExperimentShowScreen = new System.Windows.Forms.Button();
            this.btnHoloLensExperimentHideScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rootContainer)).BeginInit();
            this.rootContainer.Panel1.SuspendLayout();
            this.rootContainer.Panel2.SuspendLayout();
            this.rootContainer.SuspendLayout();
            this.leftTabs.SuspendLayout();
            this.tabPage_Camera.SuspendLayout();
            this.gbStartBoth.SuspendLayout();
            this.gbSceneCameraDevice.SuspendLayout();
            this.gbEyeCameraDevice.SuspendLayout();
            this.tabPage_Glass.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetBMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetRMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage_Eye.SuspendLayout();
            this.gbGlintDetection.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlGlintDetection.SuspendLayout();
            this.gbIrisDiameter.SuspendLayout();
            this.tabPage_Scene.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox21.SuspendLayout();
            this.tabPage_Calibration.SuspendLayout();
            this.gbCalibrationGlass.SuspendLayout();
            this.gbCalibrationRemote.SuspendLayout();
            this.gbCalibrationScene.SuspendLayout();
            this.pnlCalibration.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            this.gbDataCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gbDataExport.SuspendLayout();
            this.tabPage_Clients.SuspendLayout();
            this.gbClientsSettings.SuspendLayout();
            this.gbClientsMessages.SuspendLayout();
            this.tabPage_Gesture.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTLeft)).BeginInit();
            this.groupBox17.SuspendLayout();
            this.tabPage_ExtData.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage_EyeGrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedMind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSCRLSensitivity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage_HoloLens.SuspendLayout();
            this.gbHoloLensExperiment.SuspendLayout();
            this.gpHoloLensServer.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gbEyeImage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imEye)).BeginInit();
            this.gbSceneImage.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imSceneProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imScene)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imEyeTest)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGABlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdGlint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGAConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPABlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPAConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIrisDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorBThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorGThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorMinSize)).BeginInit();
            this.SuspendLayout();
            // 
            // rootContainer
            // 
            this.rootContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.rootContainer.Location = new System.Drawing.Point(0, 0);
            this.rootContainer.Margin = new System.Windows.Forms.Padding(2);
            this.rootContainer.Name = "rootContainer";
            // 
            // rootContainer.Panel1
            // 
            this.rootContainer.Panel1.Controls.Add(this.leftTabs);
            // 
            // rootContainer.Panel2
            // 
            this.rootContainer.Panel2.Controls.Add(this.gbMain);
            this.rootContainer.Panel2.Controls.Add(this.pnlTop);
            this.rootContainer.Size = new System.Drawing.Size(1133, 691);
            this.rootContainer.SplitterDistance = 345;
            this.rootContainer.SplitterWidth = 3;
            this.rootContainer.TabIndex = 43;
            // 
            // leftTabs
            // 
            this.leftTabs.Controls.Add(this.tabPage_Camera);
            this.leftTabs.Controls.Add(this.tabPage_Glass);
            this.leftTabs.Controls.Add(this.tabPage_Eye);
            this.leftTabs.Controls.Add(this.tabPage_Scene);
            this.leftTabs.Controls.Add(this.tabPage_Calibration);
            this.leftTabs.Controls.Add(this.tabPage_Data);
            this.leftTabs.Controls.Add(this.tabPage_Clients);
            this.leftTabs.Controls.Add(this.tabPage_Gesture);
            this.leftTabs.Controls.Add(this.tabPage_ExtData);
            this.leftTabs.Controls.Add(this.tabPage_EyeGrip);
            this.leftTabs.Controls.Add(this.tabPage_HoloLens);
            this.leftTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.leftTabs.Location = new System.Drawing.Point(0, 0);
            this.leftTabs.Margin = new System.Windows.Forms.Padding(2);
            this.leftTabs.Multiline = true;
            this.leftTabs.Name = "leftTabs";
            this.leftTabs.SelectedIndex = 0;
            this.leftTabs.Size = new System.Drawing.Size(345, 691);
            this.leftTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.leftTabs.TabIndex = 0;
            // 
            // tabPage_Camera
            // 
            this.tabPage_Camera.Controls.Add(this.gbStartBoth);
            this.tabPage_Camera.Controls.Add(this.gbSceneCameraDevice);
            this.tabPage_Camera.Controls.Add(this.gbEyeCameraDevice);
            this.tabPage_Camera.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Camera.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Camera.Name = "tabPage_Camera";
            this.tabPage_Camera.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Camera.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Camera.TabIndex = 0;
            this.tabPage_Camera.Text = "Camera";
            this.tabPage_Camera.UseVisualStyleBackColor = true;
            // 
            // gbStartBoth
            // 
            this.gbStartBoth.Controls.Add(this.startBoothVideos);
            this.gbStartBoth.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbStartBoth.Location = new System.Drawing.Point(2, 334);
            this.gbStartBoth.Margin = new System.Windows.Forms.Padding(2);
            this.gbStartBoth.Name = "gbStartBoth";
            this.gbStartBoth.Padding = new System.Windows.Forms.Padding(2);
            this.gbStartBoth.Size = new System.Drawing.Size(333, 69);
            this.gbStartBoth.TabIndex = 54;
            this.gbStartBoth.TabStop = false;
            // 
            // startBoothVideos
            // 
            this.startBoothVideos.Location = new System.Drawing.Point(49, 16);
            this.startBoothVideos.Margin = new System.Windows.Forms.Padding(2);
            this.startBoothVideos.Name = "startBoothVideos";
            this.startBoothVideos.Size = new System.Drawing.Size(115, 37);
            this.startBoothVideos.TabIndex = 55;
            this.startBoothVideos.Text = "Start Both";
            this.startBoothVideos.UseVisualStyleBackColor = true;
            this.startBoothVideos.Click += new System.EventHandler(this.button1_Click_5);
            // 
            // gbSceneCameraDevice
            // 
            this.gbSceneCameraDevice.Controls.Add(this.cbSceneVerticalFlip);
            this.gbSceneCameraDevice.Controls.Add(this.btnSettingsScene);
            this.gbSceneCameraDevice.Controls.Add(this.btnStartScene);
            this.gbSceneCameraDevice.Controls.Add(this.cmbDeviceCapabilityScene);
            this.gbSceneCameraDevice.Controls.Add(this.label6);
            this.gbSceneCameraDevice.Controls.Add(this.cmbDeviceScene);
            this.gbSceneCameraDevice.Controls.Add(this.label8);
            this.gbSceneCameraDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSceneCameraDevice.Location = new System.Drawing.Point(2, 168);
            this.gbSceneCameraDevice.Margin = new System.Windows.Forms.Padding(2);
            this.gbSceneCameraDevice.Name = "gbSceneCameraDevice";
            this.gbSceneCameraDevice.Padding = new System.Windows.Forms.Padding(2);
            this.gbSceneCameraDevice.Size = new System.Drawing.Size(333, 166);
            this.gbSceneCameraDevice.TabIndex = 52;
            this.gbSceneCameraDevice.TabStop = false;
            this.gbSceneCameraDevice.Text = "Scene Camera";
            // 
            // cbSceneVerticalFlip
            // 
            this.cbSceneVerticalFlip.AutoSize = true;
            this.cbSceneVerticalFlip.Location = new System.Drawing.Point(8, 136);
            this.cbSceneVerticalFlip.Margin = new System.Windows.Forms.Padding(2);
            this.cbSceneVerticalFlip.Name = "cbSceneVerticalFlip";
            this.cbSceneVerticalFlip.Size = new System.Drawing.Size(80, 17);
            this.cbSceneVerticalFlip.TabIndex = 57;
            this.cbSceneVerticalFlip.Text = "Flip Vertical";
            this.cbSceneVerticalFlip.UseVisualStyleBackColor = true;
            this.cbSceneVerticalFlip.CheckedChanged += new System.EventHandler(this.cb_scene_VFlip_CheckedChanged);
            // 
            // btnSettingsScene
            // 
            this.btnSettingsScene.Location = new System.Drawing.Point(8, 84);
            this.btnSettingsScene.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettingsScene.Name = "btnSettingsScene";
            this.btnSettingsScene.Size = new System.Drawing.Size(84, 37);
            this.btnSettingsScene.TabIndex = 10;
            this.btnSettingsScene.Text = "Settings";
            this.btnSettingsScene.UseVisualStyleBackColor = true;
            this.btnSettingsScene.Click += new System.EventHandler(this.btnSceneSetting_Click);
            // 
            // btnStartScene
            // 
            this.btnStartScene.Location = new System.Drawing.Point(97, 84);
            this.btnStartScene.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartScene.Name = "btnStartScene";
            this.btnStartScene.Size = new System.Drawing.Size(115, 37);
            this.btnStartScene.TabIndex = 9;
            this.btnStartScene.Text = "Start";
            this.btnStartScene.UseVisualStyleBackColor = true;
            this.btnStartScene.Click += new System.EventHandler(this.btnSceneStart_Click);
            // 
            // cmbDeviceCapabilityScene
            // 
            this.cmbDeviceCapabilityScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceCapabilityScene.FormattingEnabled = true;
            this.cmbDeviceCapabilityScene.Location = new System.Drawing.Point(59, 46);
            this.cmbDeviceCapabilityScene.Name = "cmbDeviceCapabilityScene";
            this.cmbDeviceCapabilityScene.Size = new System.Drawing.Size(265, 21);
            this.cmbDeviceCapabilityScene.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Resolution";
            // 
            // cmbDeviceScene
            // 
            this.cmbDeviceScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceScene.FormattingEnabled = true;
            this.cmbDeviceScene.Location = new System.Drawing.Point(49, 18);
            this.cmbDeviceScene.Name = "cmbDeviceScene";
            this.cmbDeviceScene.Size = new System.Drawing.Size(273, 21);
            this.cmbDeviceScene.TabIndex = 5;
            this.cmbDeviceScene.DropDown += new System.EventHandler(this.cmbDeviceScene_DropDown);
            this.cmbDeviceScene.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceScene_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Camera";
            // 
            // gbEyeCameraDevice
            // 
            this.gbEyeCameraDevice.Controls.Add(this.cbEyeVerticalFlip);
            this.gbEyeCameraDevice.Controls.Add(this.btnSettingsEye);
            this.gbEyeCameraDevice.Controls.Add(this.btnStartEye);
            this.gbEyeCameraDevice.Controls.Add(this.label5);
            this.gbEyeCameraDevice.Controls.Add(this.label1);
            this.gbEyeCameraDevice.Controls.Add(this.cmbDeviceCapabilityEye);
            this.gbEyeCameraDevice.Controls.Add(this.cmbDeviceEye);
            this.gbEyeCameraDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEyeCameraDevice.Location = new System.Drawing.Point(2, 2);
            this.gbEyeCameraDevice.Margin = new System.Windows.Forms.Padding(2);
            this.gbEyeCameraDevice.Name = "gbEyeCameraDevice";
            this.gbEyeCameraDevice.Padding = new System.Windows.Forms.Padding(2);
            this.gbEyeCameraDevice.Size = new System.Drawing.Size(333, 166);
            this.gbEyeCameraDevice.TabIndex = 51;
            this.gbEyeCameraDevice.TabStop = false;
            this.gbEyeCameraDevice.Text = "Eye Camera";
            // 
            // cbEyeVerticalFlip
            // 
            this.cbEyeVerticalFlip.AutoSize = true;
            this.cbEyeVerticalFlip.Location = new System.Drawing.Point(8, 133);
            this.cbEyeVerticalFlip.Margin = new System.Windows.Forms.Padding(2);
            this.cbEyeVerticalFlip.Name = "cbEyeVerticalFlip";
            this.cbEyeVerticalFlip.Size = new System.Drawing.Size(80, 17);
            this.cbEyeVerticalFlip.TabIndex = 57;
            this.cbEyeVerticalFlip.Text = "Flip Vertical";
            this.cbEyeVerticalFlip.UseVisualStyleBackColor = true;
            this.cbEyeVerticalFlip.CheckedChanged += new System.EventHandler(this.cb_eye_VFlip_CheckedChanged);
            // 
            // btnSettingsEye
            // 
            this.btnSettingsEye.Location = new System.Drawing.Point(8, 84);
            this.btnSettingsEye.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettingsEye.Name = "btnSettingsEye";
            this.btnSettingsEye.Size = new System.Drawing.Size(84, 37);
            this.btnSettingsEye.TabIndex = 10;
            this.btnSettingsEye.Text = "Settings";
            this.btnSettingsEye.UseVisualStyleBackColor = true;
            this.btnSettingsEye.Click += new System.EventHandler(this.btnEyeSettingClick);
            // 
            // btnStartEye
            // 
            this.btnStartEye.Location = new System.Drawing.Point(97, 84);
            this.btnStartEye.Margin = new System.Windows.Forms.Padding(2);
            this.btnStartEye.Name = "btnStartEye";
            this.btnStartEye.Size = new System.Drawing.Size(115, 37);
            this.btnStartEye.TabIndex = 9;
            this.btnStartEye.Text = "Start";
            this.btnStartEye.UseVisualStyleBackColor = true;
            this.btnStartEye.Click += new System.EventHandler(this.btnEyeStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Resolution";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera";
            // 
            // cmbDeviceCapabilityEye
            // 
            this.cmbDeviceCapabilityEye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceCapabilityEye.FormattingEnabled = true;
            this.cmbDeviceCapabilityEye.Location = new System.Drawing.Point(61, 50);
            this.cmbDeviceCapabilityEye.Name = "cmbDeviceCapabilityEye";
            this.cmbDeviceCapabilityEye.Size = new System.Drawing.Size(265, 21);
            this.cmbDeviceCapabilityEye.TabIndex = 8;
            // 
            // cmbDeviceEye
            // 
            this.cmbDeviceEye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceEye.FormattingEnabled = true;
            this.cmbDeviceEye.Location = new System.Drawing.Point(50, 24);
            this.cmbDeviceEye.Name = "cmbDeviceEye";
            this.cmbDeviceEye.Size = new System.Drawing.Size(273, 21);
            this.cmbDeviceEye.TabIndex = 6;
            this.cmbDeviceEye.DropDown += new System.EventHandler(this.cmbDeviceEye_DropDown);
            this.cmbDeviceEye.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceEye_SelectedIndexChanged);
            // 
            // tabPage_Glass
            // 
            this.tabPage_Glass.Controls.Add(this.groupBox1);
            this.tabPage_Glass.Controls.Add(this.button8);
            this.tabPage_Glass.Controls.Add(this.progressBar1);
            this.tabPage_Glass.Controls.Add(this.pictureBox2);
            this.tabPage_Glass.Controls.Add(this.label7);
            this.tabPage_Glass.Controls.Add(this.lbCommandsToGlass);
            this.tabPage_Glass.Controls.Add(this.tbOutput);
            this.tabPage_Glass.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Glass.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Glass.Name = "tabPage_Glass";
            this.tabPage_Glass.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Glass.TabIndex = 8;
            this.tabPage_Glass.Text = "Glass";
            this.tabPage_Glass.UseVisualStyleBackColor = true;
            this.tabPage_Glass.Click += new System.EventHandler(this.tabPage_Glass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTargetBMax);
            this.groupBox1.Controls.Add(this.nudTargetBMin);
            this.groupBox1.Controls.Add(this.nudTargetGMax);
            this.groupBox1.Controls.Add(this.nudTargetGMin);
            this.groupBox1.Controls.Add(this.nudTargetRMax);
            this.groupBox1.Controls.Add(this.nudTargetRMin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txtImageName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 169);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // nudTargetBMax
            // 
            this.nudTargetBMax.Location = new System.Drawing.Point(167, 138);
            this.nudTargetBMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetBMax.Name = "nudTargetBMax";
            this.nudTargetBMax.Size = new System.Drawing.Size(63, 20);
            this.nudTargetBMax.TabIndex = 85;
            this.nudTargetBMax.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.nudTargetBMax.ValueChanged += new System.EventHandler(this.target_B_max_ValueChanged);
            // 
            // nudTargetBMin
            // 
            this.nudTargetBMin.Location = new System.Drawing.Point(79, 137);
            this.nudTargetBMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetBMin.Name = "nudTargetBMin";
            this.nudTargetBMin.Size = new System.Drawing.Size(63, 20);
            this.nudTargetBMin.TabIndex = 84;
            this.nudTargetBMin.ValueChanged += new System.EventHandler(this.target_B_min_ValueChanged);
            // 
            // nudTargetGMax
            // 
            this.nudTargetGMax.Location = new System.Drawing.Point(167, 112);
            this.nudTargetGMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetGMax.Name = "nudTargetGMax";
            this.nudTargetGMax.Size = new System.Drawing.Size(63, 20);
            this.nudTargetGMax.TabIndex = 83;
            this.nudTargetGMax.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            this.nudTargetGMax.ValueChanged += new System.EventHandler(this.target_G_max_ValueChanged);
            // 
            // nudTargetGMin
            // 
            this.nudTargetGMin.Location = new System.Drawing.Point(79, 111);
            this.nudTargetGMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetGMin.Name = "nudTargetGMin";
            this.nudTargetGMin.Size = new System.Drawing.Size(63, 20);
            this.nudTargetGMin.TabIndex = 82;
            this.nudTargetGMin.ValueChanged += new System.EventHandler(this.target_G_min_ValueChanged);
            // 
            // nudTargetRMax
            // 
            this.nudTargetRMax.Location = new System.Drawing.Point(167, 83);
            this.nudTargetRMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetRMax.Name = "nudTargetRMax";
            this.nudTargetRMax.Size = new System.Drawing.Size(63, 20);
            this.nudTargetRMax.TabIndex = 81;
            this.nudTargetRMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetRMax.ValueChanged += new System.EventHandler(this.target_R_max_ValueChanged);
            // 
            // nudTargetRMin
            // 
            this.nudTargetRMin.Location = new System.Drawing.Point(79, 82);
            this.nudTargetRMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTargetRMin.Name = "nudTargetRMin";
            this.nudTargetRMin.Size = new System.Drawing.Size(63, 20);
            this.nudTargetRMin.TabIndex = 73;
            this.nudTargetRMin.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.nudTargetRMin.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 80;
            this.label14.Text = "B";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 77;
            this.label13.Text = "G";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "R";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 18);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 51);
            this.button7.TabIndex = 73;
            this.button7.Text = "detect target";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // txtImageName
            // 
            this.txtImageName.Location = new System.Drawing.Point(110, 34);
            this.txtImageName.Name = "txtImageName";
            this.txtImageName.Size = new System.Drawing.Size(120, 20);
            this.txtImageName.TabIndex = 74;
            this.txtImageName.TextChanged += new System.EventHandler(this.txtImageName_TextChanged);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 396);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(337, 60);
            this.button8.TabIndex = 73;
            this.button8.Text = "Show QRCode";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBar1.Location = new System.Drawing.Point(0, 386);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(337, 10);
            this.progressBar1.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 177);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 209);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.Picturebox2_Paint);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Double click on the msg you want to send";
            this.label7.Visible = false;
            // 
            // lbCommandsToGlass
            // 
            this.lbCommandsToGlass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCommandsToGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbCommandsToGlass.FormattingEnabled = true;
            this.lbCommandsToGlass.ItemHeight = 20;
            this.lbCommandsToGlass.Location = new System.Drawing.Point(0, 153);
            this.lbCommandsToGlass.Margin = new System.Windows.Forms.Padding(2);
            this.lbCommandsToGlass.Name = "lbCommandsToGlass";
            this.lbCommandsToGlass.Size = new System.Drawing.Size(337, 24);
            this.lbCommandsToGlass.TabIndex = 44;
            this.lbCommandsToGlass.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCommandsToGlass_MouseDoubleClick);
            // 
            // tbOutput
            // 
            this.tbOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbOutput.Location = new System.Drawing.Point(0, 0);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(337, 153);
            this.tbOutput.TabIndex = 39;
            // 
            // tabPage_Eye
            // 
            this.tabPage_Eye.Controls.Add(this.gbGlintDetection);
            this.tabPage_Eye.Controls.Add(this.groupBox6);
            this.tabPage_Eye.Controls.Add(this.gbIrisDiameter);
            this.tabPage_Eye.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Eye.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Eye.Name = "tabPage_Eye";
            this.tabPage_Eye.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Eye.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Eye.TabIndex = 1;
            this.tabPage_Eye.Text = "Eye";
            this.tabPage_Eye.UseVisualStyleBackColor = true;
            // 
            // gbGlintDetection
            // 
            this.gbGlintDetection.Controls.Add(this.cbGlintManual);
            this.gbGlintDetection.Controls.Add(this.panel4);
            this.gbGlintDetection.Controls.Add(this.cbGlintAuto);
            this.gbGlintDetection.Controls.Add(this.trackBarThresholdGlint);
            this.gbGlintDetection.Controls.Add(this.trackBarGAConstant);
            this.gbGlintDetection.Controls.Add(this.cbShowGlint);
            this.gbGlintDetection.Controls.Add(this.cbGlintDetection);
            this.gbGlintDetection.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGlintDetection.Location = new System.Drawing.Point(2, 230);
            this.gbGlintDetection.Margin = new System.Windows.Forms.Padding(2);
            this.gbGlintDetection.Name = "gbGlintDetection";
            this.gbGlintDetection.Padding = new System.Windows.Forms.Padding(2);
            this.gbGlintDetection.Size = new System.Drawing.Size(333, 120);
            this.gbGlintDetection.TabIndex = 60;
            this.gbGlintDetection.TabStop = false;
            this.gbGlintDetection.Text = "Glint Detection";
            // 
            // cbGlintManual
            // 
            this.cbGlintManual.AutoSize = true;
            this.cbGlintManual.Location = new System.Drawing.Point(18, 67);
            this.cbGlintManual.Margin = new System.Windows.Forms.Padding(2);
            this.cbGlintManual.Name = "cbGlintManual";
            this.cbGlintManual.Size = new System.Drawing.Size(60, 17);
            this.cbGlintManual.TabIndex = 59;
            this.cbGlintManual.Text = "Manual";
            this.cbGlintManual.UseVisualStyleBackColor = true;
            this.cbGlintManual.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.trackBarGABlockSize);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.rbGGaussian);
            this.panel4.Controls.Add(this.rbGMean);
            this.panel4.Location = new System.Drawing.Point(9, 141);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(202, 112);
            this.panel4.TabIndex = 69;
            this.panel4.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 64;
            this.label11.Text = "blockSize";
            // 
            // rbGGaussian
            // 
            this.rbGGaussian.AutoSize = true;
            this.rbGGaussian.Location = new System.Drawing.Point(112, 11);
            this.rbGGaussian.Margin = new System.Windows.Forms.Padding(2);
            this.rbGGaussian.Name = "rbGGaussian";
            this.rbGGaussian.Size = new System.Drawing.Size(69, 17);
            this.rbGGaussian.TabIndex = 61;
            this.rbGGaussian.Text = "Gaussian";
            this.rbGGaussian.UseVisualStyleBackColor = true;
            this.rbGGaussian.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_4);
            // 
            // rbGMean
            // 
            this.rbGMean.AutoSize = true;
            this.rbGMean.Checked = true;
            this.rbGMean.Location = new System.Drawing.Point(35, 11);
            this.rbGMean.Margin = new System.Windows.Forms.Padding(2);
            this.rbGMean.Name = "rbGMean";
            this.rbGMean.Size = new System.Drawing.Size(52, 17);
            this.rbGMean.TabIndex = 60;
            this.rbGMean.TabStop = true;
            this.rbGMean.Text = "Mean";
            this.rbGMean.UseVisualStyleBackColor = true;
            this.rbGMean.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_4);
            // 
            // cbGlintAuto
            // 
            this.cbGlintAuto.AutoSize = true;
            this.cbGlintAuto.Checked = true;
            this.cbGlintAuto.Location = new System.Drawing.Point(18, 42);
            this.cbGlintAuto.Margin = new System.Windows.Forms.Padding(2);
            this.cbGlintAuto.Name = "cbGlintAuto";
            this.cbGlintAuto.Size = new System.Drawing.Size(47, 17);
            this.cbGlintAuto.TabIndex = 58;
            this.cbGlintAuto.TabStop = true;
            this.cbGlintAuto.Text = "Auto";
            this.cbGlintAuto.UseVisualStyleBackColor = true;
            this.cbGlintAuto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
            // 
            // cbShowGlint
            // 
            this.cbShowGlint.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowGlint.BackColor = System.Drawing.Color.Yellow;
            this.cbShowGlint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowGlint.BackgroundImage")));
            this.cbShowGlint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowGlint.Checked = true;
            this.cbShowGlint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowGlint.FlatAppearance.BorderSize = 0;
            this.cbShowGlint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowGlint.Location = new System.Drawing.Point(195, 0);
            this.cbShowGlint.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowGlint.Name = "cbShowGlint";
            this.cbShowGlint.Size = new System.Drawing.Size(14, 18);
            this.cbShowGlint.TabIndex = 57;
            this.cbShowGlint.UseVisualStyleBackColor = false;
            this.cbShowGlint.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_8);
            // 
            // cbGlintDetection
            // 
            this.cbGlintDetection.Location = new System.Drawing.Point(83, 0);
            this.cbGlintDetection.Margin = new System.Windows.Forms.Padding(2);
            this.cbGlintDetection.Name = "cbGlintDetection";
            this.cbGlintDetection.Size = new System.Drawing.Size(106, 17);
            this.cbGlintDetection.TabIndex = 56;
            this.cbGlintDetection.UseVisualStyleBackColor = true;
            this.cbGlintDetection.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_7);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbPM);
            this.groupBox6.Controls.Add(this.pnlGlintDetection);
            this.groupBox6.Controls.Add(this.cbPA);
            this.groupBox6.Controls.Add(this.cbRemoveGlint);
            this.groupBox6.Controls.Add(this.cbDilateErode);
            this.groupBox6.Controls.Add(this.trackBarPAConstant);
            this.groupBox6.Controls.Add(this.trackBarThresholdEye);
            this.groupBox6.Controls.Add(this.cbShowPupil);
            this.groupBox6.Controls.Add(this.cbPupilDetection);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(2, 54);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(333, 176);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pupil Detection";
            // 
            // cbPM
            // 
            this.cbPM.AutoSize = true;
            this.cbPM.Location = new System.Drawing.Point(17, 69);
            this.cbPM.Margin = new System.Windows.Forms.Padding(2);
            this.cbPM.Name = "cbPM";
            this.cbPM.Size = new System.Drawing.Size(60, 17);
            this.cbPM.TabIndex = 59;
            this.cbPM.Text = "Manual";
            this.cbPM.UseVisualStyleBackColor = true;
            this.cbPM.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // pnlGlintDetection
            // 
            this.pnlGlintDetection.Controls.Add(this.trackBarPABlockSize);
            this.pnlGlintDetection.Controls.Add(this.label10);
            this.pnlGlintDetection.Controls.Add(this.rbPGaussian);
            this.pnlGlintDetection.Controls.Add(this.rbPMean);
            this.pnlGlintDetection.Location = new System.Drawing.Point(7, 190);
            this.pnlGlintDetection.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGlintDetection.Name = "pnlGlintDetection";
            this.pnlGlintDetection.Size = new System.Drawing.Size(202, 112);
            this.pnlGlintDetection.TabIndex = 67;
            this.pnlGlintDetection.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "blockSize";
            // 
            // rbPGaussian
            // 
            this.rbPGaussian.AutoSize = true;
            this.rbPGaussian.Location = new System.Drawing.Point(112, 11);
            this.rbPGaussian.Margin = new System.Windows.Forms.Padding(2);
            this.rbPGaussian.Name = "rbPGaussian";
            this.rbPGaussian.Size = new System.Drawing.Size(69, 17);
            this.rbPGaussian.TabIndex = 61;
            this.rbPGaussian.Text = "Gaussian";
            this.rbPGaussian.UseVisualStyleBackColor = true;
            this.rbPGaussian.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_3);
            // 
            // rbPMean
            // 
            this.rbPMean.AutoSize = true;
            this.rbPMean.Checked = true;
            this.rbPMean.Location = new System.Drawing.Point(35, 11);
            this.rbPMean.Margin = new System.Windows.Forms.Padding(2);
            this.rbPMean.Name = "rbPMean";
            this.rbPMean.Size = new System.Drawing.Size(52, 17);
            this.rbPMean.TabIndex = 60;
            this.rbPMean.TabStop = true;
            this.rbPMean.Text = "Mean";
            this.rbPMean.UseVisualStyleBackColor = true;
            this.rbPMean.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_3);
            // 
            // cbPA
            // 
            this.cbPA.AutoSize = true;
            this.cbPA.Checked = true;
            this.cbPA.Location = new System.Drawing.Point(18, 44);
            this.cbPA.Margin = new System.Windows.Forms.Padding(2);
            this.cbPA.Name = "cbPA";
            this.cbPA.Size = new System.Drawing.Size(47, 17);
            this.cbPA.TabIndex = 58;
            this.cbPA.TabStop = true;
            this.cbPA.Text = "Auto";
            this.cbPA.UseVisualStyleBackColor = true;
            this.cbPA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // cbRemoveGlint
            // 
            this.cbRemoveGlint.Location = new System.Drawing.Point(18, 131);
            this.cbRemoveGlint.Margin = new System.Windows.Forms.Padding(2);
            this.cbRemoveGlint.Name = "cbRemoveGlint";
            this.cbRemoveGlint.Size = new System.Drawing.Size(148, 17);
            this.cbRemoveGlint.TabIndex = 66;
            this.cbRemoveGlint.Text = "Remove Glint";
            this.cbRemoveGlint.UseVisualStyleBackColor = true;
            this.cbRemoveGlint.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged_1);
            // 
            // cbDilateErode
            // 
            this.cbDilateErode.Location = new System.Drawing.Point(18, 110);
            this.cbDilateErode.Margin = new System.Windows.Forms.Padding(2);
            this.cbDilateErode.Name = "cbDilateErode";
            this.cbDilateErode.Size = new System.Drawing.Size(148, 17);
            this.cbDilateErode.TabIndex = 65;
            this.cbDilateErode.Text = "Fill Gaps";
            this.cbDilateErode.UseVisualStyleBackColor = true;
            this.cbDilateErode.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_6);
            // 
            // cbShowPupil
            // 
            this.cbShowPupil.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowPupil.BackColor = System.Drawing.Color.Yellow;
            this.cbShowPupil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowPupil.BackgroundImage")));
            this.cbShowPupil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowPupil.Checked = true;
            this.cbShowPupil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPupil.FlatAppearance.BorderSize = 0;
            this.cbShowPupil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowPupil.Location = new System.Drawing.Point(195, -2);
            this.cbShowPupil.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowPupil.Name = "cbShowPupil";
            this.cbShowPupil.Size = new System.Drawing.Size(14, 18);
            this.cbShowPupil.TabIndex = 56;
            this.cbShowPupil.UseVisualStyleBackColor = false;
            this.cbShowPupil.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_4);
            // 
            // cbPupilDetection
            // 
            this.cbPupilDetection.Checked = true;
            this.cbPupilDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPupilDetection.Location = new System.Drawing.Point(83, -1);
            this.cbPupilDetection.Margin = new System.Windows.Forms.Padding(2);
            this.cbPupilDetection.Name = "cbPupilDetection";
            this.cbPupilDetection.Size = new System.Drawing.Size(106, 17);
            this.cbPupilDetection.TabIndex = 55;
            this.cbPupilDetection.UseVisualStyleBackColor = true;
            this.cbPupilDetection.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_3);
            // 
            // gbIrisDiameter
            // 
            this.gbIrisDiameter.Controls.Add(this.cbShowIris);
            this.gbIrisDiameter.Controls.Add(this.tbIrisDiameter);
            this.gbIrisDiameter.Controls.Add(this.lbIrisDiameter);
            this.gbIrisDiameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbIrisDiameter.Location = new System.Drawing.Point(2, 2);
            this.gbIrisDiameter.Margin = new System.Windows.Forms.Padding(2);
            this.gbIrisDiameter.Name = "gbIrisDiameter";
            this.gbIrisDiameter.Padding = new System.Windows.Forms.Padding(2);
            this.gbIrisDiameter.Size = new System.Drawing.Size(333, 52);
            this.gbIrisDiameter.TabIndex = 59;
            this.gbIrisDiameter.TabStop = false;
            // 
            // cbShowIris
            // 
            this.cbShowIris.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowIris.BackColor = System.Drawing.Color.Yellow;
            this.cbShowIris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowIris.BackgroundImage")));
            this.cbShowIris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowIris.Checked = true;
            this.cbShowIris.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowIris.FlatAppearance.BorderSize = 0;
            this.cbShowIris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowIris.Location = new System.Drawing.Point(226, 18);
            this.cbShowIris.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowIris.Name = "cbShowIris";
            this.cbShowIris.Size = new System.Drawing.Size(14, 18);
            this.cbShowIris.TabIndex = 3;
            this.cbShowIris.UseVisualStyleBackColor = false;
            this.cbShowIris.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_2);
            // 
            // lbIrisDiameter
            // 
            this.lbIrisDiameter.AutoSize = true;
            this.lbIrisDiameter.Location = new System.Drawing.Point(7, 21);
            this.lbIrisDiameter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIrisDiameter.Name = "lbIrisDiameter";
            this.lbIrisDiameter.Size = new System.Drawing.Size(65, 13);
            this.lbIrisDiameter.TabIndex = 1;
            this.lbIrisDiameter.Text = "Iris Diameter";
            // 
            // tabPage_Scene
            // 
            this.tabPage_Scene.Controls.Add(this.label17);
            this.tabPage_Scene.Controls.Add(this.groupBox8);
            this.tabPage_Scene.Controls.Add(this.cbShowGaze);
            this.tabPage_Scene.Controls.Add(this.groupBox7);
            this.tabPage_Scene.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Scene.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Scene.Name = "tabPage_Scene";
            this.tabPage_Scene.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Scene.TabIndex = 2;
            this.tabPage_Scene.Text = "Scene";
            this.tabPage_Scene.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 302);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Show gaze point in the image";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSceneCameraCalibration);
            this.groupBox8.Controls.Add(this.cbSceneUnDistortion);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 216);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(337, 76);
            this.groupBox8.TabIndex = 63;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Lens Distortion Correction";
            // 
            // btnSceneCameraCalibration
            // 
            this.btnSceneCameraCalibration.Location = new System.Drawing.Point(37, 26);
            this.btnSceneCameraCalibration.Margin = new System.Windows.Forms.Padding(2);
            this.btnSceneCameraCalibration.Name = "btnSceneCameraCalibration";
            this.btnSceneCameraCalibration.Size = new System.Drawing.Size(161, 35);
            this.btnSceneCameraCalibration.TabIndex = 59;
            this.btnSceneCameraCalibration.Text = "Calibrate for new Camera";
            this.btnSceneCameraCalibration.UseVisualStyleBackColor = true;
            this.btnSceneCameraCalibration.Click += new System.EventHandler(this.button1_Click_6);
            // 
            // cbSceneUnDistortion
            // 
            this.cbSceneUnDistortion.Location = new System.Drawing.Point(136, 0);
            this.cbSceneUnDistortion.Margin = new System.Windows.Forms.Padding(2);
            this.cbSceneUnDistortion.Name = "cbSceneUnDistortion";
            this.cbSceneUnDistortion.Size = new System.Drawing.Size(62, 13);
            this.cbSceneUnDistortion.TabIndex = 58;
            this.cbSceneUnDistortion.UseVisualStyleBackColor = true;
            this.cbSceneUnDistortion.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_11);
            // 
            // cbShowGaze
            // 
            this.cbShowGaze.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowGaze.BackColor = System.Drawing.Color.Yellow;
            this.cbShowGaze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowGaze.BackgroundImage")));
            this.cbShowGaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowGaze.Checked = true;
            this.cbShowGaze.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowGaze.FlatAppearance.BorderSize = 0;
            this.cbShowGaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowGaze.Location = new System.Drawing.Point(7, 299);
            this.cbShowGaze.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowGaze.Name = "cbShowGaze";
            this.cbShowGaze.Size = new System.Drawing.Size(14, 18);
            this.cbShowGaze.TabIndex = 67;
            this.cbShowGaze.UseVisualStyleBackColor = false;
            this.cbShowGaze.CheckedChanged += new System.EventHandler(this.cbShowGaze_CheckedChanged_2);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox21);
            this.groupBox7.Controls.Add(this.tbMonitorMinSize);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.cbShowScreen);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(337, 216);
            this.groupBox7.TabIndex = 62;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Screen Detection";
            // 
            // groupBox21
            // 
            this.groupBox21.Controls.Add(this.cbShowEdges);
            this.groupBox21.Controls.Add(this.tbMonitorBThreshold);
            this.groupBox21.Controls.Add(this.tbMonitorGThreshold);
            this.groupBox21.Location = new System.Drawing.Point(7, 100);
            this.groupBox21.Name = "groupBox21";
            this.groupBox21.Size = new System.Drawing.Size(221, 102);
            this.groupBox21.TabIndex = 3;
            this.groupBox21.TabStop = false;
            this.groupBox21.Text = "Edge detection sensitivity";
            // 
            // cbShowEdges
            // 
            this.cbShowEdges.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowEdges.BackColor = System.Drawing.Color.White;
            this.cbShowEdges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowEdges.BackgroundImage")));
            this.cbShowEdges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowEdges.FlatAppearance.BorderSize = 0;
            this.cbShowEdges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowEdges.Location = new System.Drawing.Point(195, -1);
            this.cbShowEdges.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowEdges.Name = "cbShowEdges";
            this.cbShowEdges.Size = new System.Drawing.Size(14, 18);
            this.cbShowEdges.TabIndex = 68;
            this.cbShowEdges.UseVisualStyleBackColor = false;
            this.cbShowEdges.CheckedChanged += new System.EventHandler(this.cbShowEdges_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 32);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(164, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Minimum display size in the image";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 45);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 63;
            // 
            // cbShowScreen
            // 
            this.cbShowScreen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowScreen.BackColor = System.Drawing.Color.Yellow;
            this.cbShowScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowScreen.BackgroundImage")));
            this.cbShowScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowScreen.Checked = true;
            this.cbShowScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowScreen.FlatAppearance.BorderSize = 0;
            this.cbShowScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowScreen.Location = new System.Drawing.Point(203, 0);
            this.cbShowScreen.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowScreen.Name = "cbShowScreen";
            this.cbShowScreen.Size = new System.Drawing.Size(14, 18);
            this.cbShowScreen.TabIndex = 58;
            this.cbShowScreen.UseVisualStyleBackColor = false;
            this.cbShowScreen.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_10);
            // 
            // tabPage_Calibration
            // 
            this.tabPage_Calibration.Controls.Add(this.gbCalibrationGlass);
            this.tabPage_Calibration.Controls.Add(this.gbCalibrationRemote);
            this.tabPage_Calibration.Controls.Add(this.gbCalibrationScene);
            this.tabPage_Calibration.Controls.Add(this.pnlCalibration);
            this.tabPage_Calibration.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Calibration.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Calibration.Name = "tabPage_Calibration";
            this.tabPage_Calibration.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Calibration.TabIndex = 3;
            this.tabPage_Calibration.Text = "Calibration";
            this.tabPage_Calibration.UseVisualStyleBackColor = true;
            // 
            // gbCalibrationGlass
            // 
            this.gbCalibrationGlass.Controls.Add(this.checkBox5);
            this.gbCalibrationGlass.Controls.Add(this.button9);
            this.gbCalibrationGlass.Controls.Add(this.button5);
            this.gbCalibrationGlass.Controls.Add(this.button6);
            this.gbCalibrationGlass.Controls.Add(this.label4);
            this.gbCalibrationGlass.Controls.Add(this.label3);
            this.gbCalibrationGlass.Controls.Add(this.button3);
            this.gbCalibrationGlass.Controls.Add(this.button4);
            this.gbCalibrationGlass.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCalibrationGlass.Location = new System.Drawing.Point(0, 320);
            this.gbCalibrationGlass.Name = "gbCalibrationGlass";
            this.gbCalibrationGlass.Size = new System.Drawing.Size(337, 272);
            this.gbCalibrationGlass.TabIndex = 62;
            this.gbCalibrationGlass.TabStop = false;
            this.gbCalibrationGlass.Text = "Gaze Estimation for the Glass ";
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(11, 153);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(163, 34);
            this.checkBox5.TabIndex = 72;
            this.checkBox5.Text = "Automatic target detection";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(173, 59);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 50);
            this.button9.TabIndex = 71;
            this.button9.Tag = "4";
            this.button9.Text = "correct offset";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(26, 199);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 50);
            this.button5.TabIndex = 70;
            this.button5.Tag = "4";
            this.button5.Text = "4 Points Homography";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 199);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 50);
            this.button6.TabIndex = 69;
            this.button6.Tag = "9";
            this.button6.Text = "9 Points Polynomial";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Scene Camera";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "HMD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 59);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 50);
            this.button3.TabIndex = 65;
            this.button3.Tag = "4";
            this.button3.Text = "4 Points Homography";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 59);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 50);
            this.button4.TabIndex = 64;
            this.button4.Tag = "9";
            this.button4.Text = "9 Points Polynomial";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button3_Click);
            // 
            // gbCalibrationRemote
            // 
            this.gbCalibrationRemote.Controls.Add(this.button1);
            this.gbCalibrationRemote.Controls.Add(this.button2);
            this.gbCalibrationRemote.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCalibrationRemote.Location = new System.Drawing.Point(0, 230);
            this.gbCalibrationRemote.Name = "gbCalibrationRemote";
            this.gbCalibrationRemote.Size = new System.Drawing.Size(337, 90);
            this.gbCalibrationRemote.TabIndex = 3;
            this.gbCalibrationRemote.TabStop = false;
            this.gbCalibrationRemote.Text = "Gaze Estimation in the remote display";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 50);
            this.button1.TabIndex = 65;
            this.button1.Text = "4 Points Homography";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 25);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 50);
            this.button2.TabIndex = 64;
            this.button2.Text = "9 Points Polynomial";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // gbCalibrationScene
            // 
            this.gbCalibrationScene.Controls.Add(this.lbl_calibration);
            this.gbCalibrationScene.Controls.Add(this.btnCalibration_Homography);
            this.gbCalibrationScene.Controls.Add(this.btnCalibration_Polynomial);
            this.gbCalibrationScene.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCalibrationScene.Location = new System.Drawing.Point(0, 144);
            this.gbCalibrationScene.Margin = new System.Windows.Forms.Padding(2);
            this.gbCalibrationScene.Name = "gbCalibrationScene";
            this.gbCalibrationScene.Padding = new System.Windows.Forms.Padding(2);
            this.gbCalibrationScene.Size = new System.Drawing.Size(337, 86);
            this.gbCalibrationScene.TabIndex = 61;
            this.gbCalibrationScene.TabStop = false;
            this.gbCalibrationScene.Text = "Gaze Estimation in the scene image";
            // 
            // lbl_calibration
            // 
            this.lbl_calibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_calibration.ForeColor = System.Drawing.Color.Red;
            this.lbl_calibration.Location = new System.Drawing.Point(3, 76);
            this.lbl_calibration.Name = "lbl_calibration";
            this.lbl_calibration.Size = new System.Drawing.Size(221, 84);
            this.lbl_calibration.TabIndex = 3;
            this.lbl_calibration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalibration_Homography
            // 
            this.btnCalibration_Homography.Location = new System.Drawing.Point(8, 24);
            this.btnCalibration_Homography.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalibration_Homography.Name = "btnCalibration_Homography";
            this.btnCalibration_Homography.Size = new System.Drawing.Size(83, 50);
            this.btnCalibration_Homography.TabIndex = 63;
            this.btnCalibration_Homography.Text = "4 Points Homography";
            this.btnCalibration_Homography.UseVisualStyleBackColor = true;
            this.btnCalibration_Homography.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCalibration_Polynomial
            // 
            this.btnCalibration_Polynomial.Location = new System.Drawing.Point(131, 24);
            this.btnCalibration_Polynomial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalibration_Polynomial.Name = "btnCalibration_Polynomial";
            this.btnCalibration_Polynomial.Size = new System.Drawing.Size(83, 50);
            this.btnCalibration_Polynomial.TabIndex = 62;
            this.btnCalibration_Polynomial.Text = "9 Points Polynomial";
            this.btnCalibration_Polynomial.UseVisualStyleBackColor = true;
            this.btnCalibration_Polynomial.Click += new System.EventHandler(this.button1_Click_7);
            // 
            // pnlCalibration
            // 
            this.pnlCalibration.Controls.Add(this.rbGlint);
            this.pnlCalibration.Controls.Add(this.rbPupilGlint);
            this.pnlCalibration.Controls.Add(this.rdOnlyPupil);
            this.pnlCalibration.Controls.Add(this.cbGazeSmoothing);
            this.pnlCalibration.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCalibration.Location = new System.Drawing.Point(0, 0);
            this.pnlCalibration.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCalibration.Name = "pnlCalibration";
            this.pnlCalibration.Size = new System.Drawing.Size(337, 144);
            this.pnlCalibration.TabIndex = 61;
            // 
            // rbGlint
            // 
            this.rbGlint.AutoSize = true;
            this.rbGlint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbGlint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbGlint.Location = new System.Drawing.Point(8, 47);
            this.rbGlint.Margin = new System.Windows.Forms.Padding(2);
            this.rbGlint.Name = "rbGlint";
            this.rbGlint.Size = new System.Drawing.Size(80, 17);
            this.rbGlint.TabIndex = 67;
            this.rbGlint.Text = "Glint Center";
            this.rbGlint.UseVisualStyleBackColor = true;
            this.rbGlint.CheckedChanged += new System.EventHandler(this.rbGlint_CheckedChanged);
            // 
            // rbPupilGlint
            // 
            this.rbPupilGlint.AutoSize = true;
            this.rbPupilGlint.Checked = true;
            this.rbPupilGlint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbPupilGlint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbPupilGlint.Location = new System.Drawing.Point(8, 26);
            this.rbPupilGlint.Margin = new System.Windows.Forms.Padding(2);
            this.rbPupilGlint.Name = "rbPupilGlint";
            this.rbPupilGlint.Size = new System.Drawing.Size(106, 17);
            this.rbPupilGlint.TabIndex = 59;
            this.rbPupilGlint.TabStop = true;
            this.rbPupilGlint.Text = "Pupil-Glint Vector";
            this.rbPupilGlint.UseVisualStyleBackColor = true;
            this.rbPupilGlint.CheckedChanged += new System.EventHandler(this.rbPupilGlint_CheckedChanged);
            // 
            // rdOnlyPupil
            // 
            this.rdOnlyPupil.AutoSize = true;
            this.rdOnlyPupil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdOnlyPupil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdOnlyPupil.Location = new System.Drawing.Point(7, 5);
            this.rdOnlyPupil.Margin = new System.Windows.Forms.Padding(2);
            this.rdOnlyPupil.Name = "rdOnlyPupil";
            this.rdOnlyPupil.Size = new System.Drawing.Size(82, 17);
            this.rdOnlyPupil.TabIndex = 58;
            this.rdOnlyPupil.Text = "Pupil Center";
            this.rdOnlyPupil.UseVisualStyleBackColor = true;
            this.rdOnlyPupil.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_5);
            // 
            // cbGazeSmoothing
            // 
            this.cbGazeSmoothing.Checked = true;
            this.cbGazeSmoothing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGazeSmoothing.Location = new System.Drawing.Point(7, 115);
            this.cbGazeSmoothing.Margin = new System.Windows.Forms.Padding(2);
            this.cbGazeSmoothing.Name = "cbGazeSmoothing";
            this.cbGazeSmoothing.Size = new System.Drawing.Size(148, 17);
            this.cbGazeSmoothing.TabIndex = 66;
            this.cbGazeSmoothing.Text = "Gaze Smoothing";
            this.cbGazeSmoothing.UseVisualStyleBackColor = true;
            this.cbGazeSmoothing.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_13);
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.Controls.Add(this.gbDataCharts);
            this.tabPage_Data.Controls.Add(this.gbDataExport);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Data.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Data.TabIndex = 4;
            this.tabPage_Data.Text = "Data";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // gbDataCharts
            // 
            this.gbDataCharts.Controls.Add(this.chart3);
            this.gbDataCharts.Controls.Add(this.cbPlot);
            this.gbDataCharts.Controls.Add(this.chart2);
            this.gbDataCharts.Controls.Add(this.chart1);
            this.gbDataCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDataCharts.Location = new System.Drawing.Point(0, 124);
            this.gbDataCharts.Margin = new System.Windows.Forms.Padding(2);
            this.gbDataCharts.Name = "gbDataCharts";
            this.gbDataCharts.Padding = new System.Windows.Forms.Padding(2);
            this.gbDataCharts.Size = new System.Drawing.Size(337, 466);
            this.gbDataCharts.TabIndex = 63;
            this.gbDataCharts.TabStop = false;
            this.gbDataCharts.Text = "Plot";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea9.AxisX.IsMarginVisible = false;
            chartArea9.AxisX.LabelStyle.Enabled = false;
            chartArea9.AxisX.MajorGrid.Enabled = false;
            chartArea9.AxisX.MajorTickMark.Enabled = false;
            chartArea9.AxisY.IsLabelAutoFit = false;
            chartArea9.AxisY.LabelStyle.Interval = 0D;
            chartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea9.BackColor = System.Drawing.Color.White;
            chartArea9.InnerPlotPosition.Auto = false;
            chartArea9.InnerPlotPosition.Height = 86.87582F;
            chartArea9.InnerPlotPosition.Width = 86.45924F;
            chartArea9.InnerPlotPosition.X = 13.54076F;
            chartArea9.InnerPlotPosition.Y = 6.56209F;
            chartArea9.Name = "ChartArea1";
            chartArea9.Position.Auto = false;
            chartArea9.Position.Height = 80.00502F;
            chartArea9.Position.Width = 94F;
            chartArea9.Position.X = 3F;
            chartArea9.Position.Y = 16.99498F;
            this.chart3.ChartAreas.Add(chartArea9);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart3.Location = new System.Drawing.Point(2, 294);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.EmptyPointStyle.BorderWidth = 0;
            series9.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series9.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series9.EmptyPointStyle.IsVisibleInLegend = false;
            series9.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series9.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series9.EmptyPointStyle.MarkerSize = 1;
            series9.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series9.Name = "PupilDiam";
            this.chart3.Series.Add(series9);
            this.chart3.Size = new System.Drawing.Size(333, 141);
            this.chart3.TabIndex = 47;
            this.chart3.Text = "chart3";
            title9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title9.Name = "PupilDiam";
            title9.Position.Auto = false;
            title9.Position.Height = 10.99498F;
            title9.Position.Width = 94F;
            title9.Position.X = 3F;
            title9.Position.Y = 3F;
            title9.Text = "Pupil Diameter";
            this.chart3.Titles.Add(title9);
            // 
            // cbPlot
            // 
            this.cbPlot.Location = new System.Drawing.Point(27, -1);
            this.cbPlot.Margin = new System.Windows.Forms.Padding(2);
            this.cbPlot.Name = "cbPlot";
            this.cbPlot.Size = new System.Drawing.Size(183, 17);
            this.cbPlot.TabIndex = 58;
            this.cbPlot.UseVisualStyleBackColor = true;
            this.cbPlot.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_14);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Transparent;
            chartArea10.AxisX.IsMarginVisible = false;
            chartArea10.AxisX.LabelStyle.Enabled = false;
            chartArea10.AxisX.MajorGrid.Enabled = false;
            chartArea10.AxisX.MajorTickMark.Enabled = false;
            chartArea10.AxisY.IsLabelAutoFit = false;
            chartArea10.AxisY.LabelStyle.Interval = 0D;
            chartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea10.BackColor = System.Drawing.Color.White;
            chartArea10.InnerPlotPosition.Auto = false;
            chartArea10.InnerPlotPosition.Height = 86.87582F;
            chartArea10.InnerPlotPosition.Width = 86.45924F;
            chartArea10.InnerPlotPosition.X = 13.54076F;
            chartArea10.InnerPlotPosition.Y = 6.56209F;
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 80.00502F;
            chartArea10.Position.Width = 94F;
            chartArea10.Position.X = 3F;
            chartArea10.Position.Y = 16.99498F;
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart2.Location = new System.Drawing.Point(2, 153);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.EmptyPointStyle.BorderWidth = 0;
            series10.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series10.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series10.EmptyPointStyle.IsVisibleInLegend = false;
            series10.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series10.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series10.EmptyPointStyle.MarkerSize = 1;
            series10.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series10.Name = "PupilY";
            this.chart2.Series.Add(series10);
            this.chart2.Size = new System.Drawing.Size(333, 141);
            this.chart2.TabIndex = 46;
            this.chart2.Text = "chart2";
            title10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title10.Name = "PupilY";
            title10.Position.Auto = false;
            title10.Position.Height = 10.99498F;
            title10.Position.Width = 94F;
            title10.Position.X = 3F;
            title10.Position.Y = 3F;
            title10.Text = "Pupil Y";
            this.chart2.Titles.Add(title10);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea11.AxisX.IsMarginVisible = false;
            chartArea11.AxisX.LabelStyle.Enabled = false;
            chartArea11.AxisX.MajorGrid.Enabled = false;
            chartArea11.AxisX.MajorTickMark.Enabled = false;
            chartArea11.AxisY.IsLabelAutoFit = false;
            chartArea11.AxisY.LabelStyle.Interval = 0D;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea11.BackColor = System.Drawing.Color.White;
            chartArea11.InnerPlotPosition.Auto = false;
            chartArea11.InnerPlotPosition.Height = 86.83621F;
            chartArea11.InnerPlotPosition.Width = 86.45924F;
            chartArea11.InnerPlotPosition.X = 13.54076F;
            chartArea11.InnerPlotPosition.Y = 6.5819F;
            chartArea11.Name = "ChartArea1";
            chartArea11.Position.Auto = false;
            chartArea11.Position.Height = 79.76426F;
            chartArea11.Position.Width = 94F;
            chartArea11.Position.X = 3F;
            chartArea11.Position.Y = 17.23574F;
            this.chart1.ChartAreas.Add(chartArea11);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart1.Location = new System.Drawing.Point(2, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.EmptyPointStyle.BorderWidth = 0;
            series11.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series11.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series11.EmptyPointStyle.IsVisibleInLegend = false;
            series11.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series11.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series11.EmptyPointStyle.MarkerSize = 1;
            series11.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series11.Name = "PupilX";
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(333, 138);
            this.chart1.TabIndex = 45;
            this.chart1.Text = "chart1";
            title11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title11.Name = "PupilX";
            title11.Position.Auto = false;
            title11.Position.Height = 11.23574F;
            title11.Position.Width = 94F;
            title11.Position.X = 3F;
            title11.Position.Y = 3F;
            title11.Text = "Pupil X";
            this.chart1.Titles.Add(title11);
            // 
            // gbDataExport
            // 
            this.gbDataExport.Controls.Add(this.cbRecordSceneVideo);
            this.gbDataExport.Controls.Add(this.cbRecordEyeVideo);
            this.gbDataExport.Controls.Add(this.pbRecordProgress);
            this.gbDataExport.Controls.Add(this.btnRecord);
            this.gbDataExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDataExport.Location = new System.Drawing.Point(0, 0);
            this.gbDataExport.Margin = new System.Windows.Forms.Padding(2);
            this.gbDataExport.Name = "gbDataExport";
            this.gbDataExport.Padding = new System.Windows.Forms.Padding(2);
            this.gbDataExport.Size = new System.Drawing.Size(337, 124);
            this.gbDataExport.TabIndex = 63;
            this.gbDataExport.TabStop = false;
            this.gbDataExport.Text = "Record Videos and EyeData";
            // 
            // cbRecordSceneVideo
            // 
            this.cbRecordSceneVideo.Location = new System.Drawing.Point(109, 91);
            this.cbRecordSceneVideo.Margin = new System.Windows.Forms.Padding(2);
            this.cbRecordSceneVideo.Name = "cbRecordSceneVideo";
            this.cbRecordSceneVideo.Size = new System.Drawing.Size(86, 23);
            this.cbRecordSceneVideo.TabIndex = 60;
            this.cbRecordSceneVideo.Text = "Scene video";
            this.cbRecordSceneVideo.UseVisualStyleBackColor = true;
            this.cbRecordSceneVideo.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbRecordEyeVideo
            // 
            this.cbRecordEyeVideo.Location = new System.Drawing.Point(36, 91);
            this.cbRecordEyeVideo.Margin = new System.Windows.Forms.Padding(2);
            this.cbRecordEyeVideo.Name = "cbRecordEyeVideo";
            this.cbRecordEyeVideo.Size = new System.Drawing.Size(86, 23);
            this.cbRecordEyeVideo.TabIndex = 59;
            this.cbRecordEyeVideo.Text = "Eye video";
            this.cbRecordEyeVideo.UseVisualStyleBackColor = true;
            this.cbRecordEyeVideo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pbRecordProgress
            // 
            this.pbRecordProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbRecordProgress.ForeColor = System.Drawing.Color.Red;
            this.pbRecordProgress.Location = new System.Drawing.Point(36, 74);
            this.pbRecordProgress.Margin = new System.Windows.Forms.Padding(2);
            this.pbRecordProgress.MarqueeAnimationSpeed = 10;
            this.pbRecordProgress.Name = "pbRecordProgress";
            this.pbRecordProgress.Size = new System.Drawing.Size(150, 10);
            this.pbRecordProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRecordProgress.TabIndex = 0;
            this.pbRecordProgress.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRecord.Location = new System.Drawing.Point(36, 21);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(150, 54);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "Export";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btn_Record_Click);
            // 
            // tabPage_Clients
            // 
            this.tabPage_Clients.Controls.Add(this.gbClientsSettings);
            this.tabPage_Clients.Controls.Add(this.gbClientsMessages);
            this.tabPage_Clients.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Clients.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Clients.Name = "tabPage_Clients";
            this.tabPage_Clients.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Clients.TabIndex = 5;
            this.tabPage_Clients.Text = "Clients";
            this.tabPage_Clients.UseVisualStyleBackColor = true;
            // 
            // gbClientsSettings
            // 
            this.gbClientsSettings.AutoSize = true;
            this.gbClientsSettings.Controls.Add(this.rbAutoActivation);
            this.gbClientsSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbClientsSettings.Location = new System.Drawing.Point(0, 230);
            this.gbClientsSettings.Margin = new System.Windows.Forms.Padding(2);
            this.gbClientsSettings.Name = "gbClientsSettings";
            this.gbClientsSettings.Padding = new System.Windows.Forms.Padding(2);
            this.gbClientsSettings.Size = new System.Drawing.Size(337, 53);
            this.gbClientsSettings.TabIndex = 64;
            this.gbClientsSettings.TabStop = false;
            this.gbClientsSettings.Text = "Clients";
            // 
            // rbAutoActivation
            // 
            this.rbAutoActivation.AutoSize = true;
            this.rbAutoActivation.Checked = true;
            this.rbAutoActivation.Location = new System.Drawing.Point(132, 18);
            this.rbAutoActivation.Name = "rbAutoActivation";
            this.rbAutoActivation.Size = new System.Drawing.Size(97, 17);
            this.rbAutoActivation.TabIndex = 0;
            this.rbAutoActivation.TabStop = true;
            this.rbAutoActivation.Text = "Auto Activation";
            this.rbAutoActivation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAutoActivation.UseVisualStyleBackColor = true;
            this.rbAutoActivation.CheckedChanged += new System.EventHandler(this.radioButtonAutoActivation_CheckedChanged);
            // 
            // gbClientsMessages
            // 
            this.gbClientsMessages.Controls.Add(this.TextBoxServer);
            this.gbClientsMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbClientsMessages.Location = new System.Drawing.Point(0, 0);
            this.gbClientsMessages.Margin = new System.Windows.Forms.Padding(2);
            this.gbClientsMessages.Name = "gbClientsMessages";
            this.gbClientsMessages.Padding = new System.Windows.Forms.Padding(2);
            this.gbClientsMessages.Size = new System.Drawing.Size(337, 230);
            this.gbClientsMessages.TabIndex = 63;
            this.gbClientsMessages.TabStop = false;
            this.gbClientsMessages.Text = "Messages ";
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxServer.Location = new System.Drawing.Point(2, 15);
            this.TextBoxServer.Multiline = true;
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.ReadOnly = true;
            this.TextBoxServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxServer.Size = new System.Drawing.Size(333, 213);
            this.TextBoxServer.TabIndex = 38;
            // 
            // tabPage_Gesture
            // 
            this.tabPage_Gesture.Controls.Add(this.groupBox19);
            this.tabPage_Gesture.Controls.Add(this.groupBox20);
            this.tabPage_Gesture.Controls.Add(this.groupBox16);
            this.tabPage_Gesture.Controls.Add(this.groupBox17);
            this.tabPage_Gesture.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Gesture.Name = "tabPage_Gesture";
            this.tabPage_Gesture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Gesture.Size = new System.Drawing.Size(337, 647);
            this.tabPage_Gesture.TabIndex = 6;
            this.tabPage_Gesture.Text = "Gestures";
            this.tabPage_Gesture.UseVisualStyleBackColor = true;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.btn_Custom4);
            this.groupBox19.Controls.Add(this.prg_Custom4);
            this.groupBox19.Controls.Add(this.btn_Custom3);
            this.groupBox19.Controls.Add(this.prg_Custom3);
            this.groupBox19.Controls.Add(this.btn_Custom2);
            this.groupBox19.Controls.Add(this.prg_Custom2);
            this.groupBox19.Controls.Add(this.btn_Custom1);
            this.groupBox19.Controls.Add(this.prg_Custom1);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox19.Location = new System.Drawing.Point(3, 432);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(331, 289);
            this.groupBox19.TabIndex = 3;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Custom gestures  (made only by head yaw and pitch)";
            // 
            // btn_Custom4
            // 
            this.btn_Custom4.BackColor = System.Drawing.Color.White;
            this.btn_Custom4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Custom4.Location = new System.Drawing.Point(73, 230);
            this.btn_Custom4.Name = "btn_Custom4";
            this.btn_Custom4.Size = new System.Drawing.Size(84, 37);
            this.btn_Custom4.TabIndex = 71;
            this.btn_Custom4.Tag = "Custom4";
            this.btn_Custom4.Text = "Custom 4";
            this.btn_Custom4.UseVisualStyleBackColor = false;
            this.btn_Custom4.Click += new System.EventHandler(this.btn_Custom4_Click);
            // 
            // prg_Custom4
            // 
            this.prg_Custom4.Location = new System.Drawing.Point(73, 266);
            this.prg_Custom4.Name = "prg_Custom4";
            this.prg_Custom4.Size = new System.Drawing.Size(84, 10);
            this.prg_Custom4.TabIndex = 70;
            // 
            // btn_Custom3
            // 
            this.btn_Custom3.BackColor = System.Drawing.Color.White;
            this.btn_Custom3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Custom3.Location = new System.Drawing.Point(73, 168);
            this.btn_Custom3.Name = "btn_Custom3";
            this.btn_Custom3.Size = new System.Drawing.Size(84, 37);
            this.btn_Custom3.TabIndex = 71;
            this.btn_Custom3.Tag = "Custom3";
            this.btn_Custom3.Text = "Custom 3";
            this.btn_Custom3.UseVisualStyleBackColor = false;
            this.btn_Custom3.Click += new System.EventHandler(this.btn_Custom3_Click);
            // 
            // prg_Custom3
            // 
            this.prg_Custom3.Location = new System.Drawing.Point(73, 204);
            this.prg_Custom3.Name = "prg_Custom3";
            this.prg_Custom3.Size = new System.Drawing.Size(84, 10);
            this.prg_Custom3.TabIndex = 70;
            // 
            // btn_Custom2
            // 
            this.btn_Custom2.BackColor = System.Drawing.Color.White;
            this.btn_Custom2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Custom2.Location = new System.Drawing.Point(73, 105);
            this.btn_Custom2.Name = "btn_Custom2";
            this.btn_Custom2.Size = new System.Drawing.Size(84, 37);
            this.btn_Custom2.TabIndex = 69;
            this.btn_Custom2.Tag = "Custom2";
            this.btn_Custom2.Text = "Custom 2";
            this.btn_Custom2.UseVisualStyleBackColor = false;
            this.btn_Custom2.Click += new System.EventHandler(this.btn_Custom2_Click);
            // 
            // prg_Custom2
            // 
            this.prg_Custom2.Location = new System.Drawing.Point(73, 141);
            this.prg_Custom2.Name = "prg_Custom2";
            this.prg_Custom2.Size = new System.Drawing.Size(84, 10);
            this.prg_Custom2.TabIndex = 68;
            // 
            // btn_Custom1
            // 
            this.btn_Custom1.BackColor = System.Drawing.Color.White;
            this.btn_Custom1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Custom1.Location = new System.Drawing.Point(72, 44);
            this.btn_Custom1.Name = "btn_Custom1";
            this.btn_Custom1.Size = new System.Drawing.Size(84, 37);
            this.btn_Custom1.TabIndex = 67;
            this.btn_Custom1.Tag = "Custom1";
            this.btn_Custom1.Text = "Custom 1";
            this.btn_Custom1.UseVisualStyleBackColor = false;
            this.btn_Custom1.Click += new System.EventHandler(this.btn_Custom1_Click);
            // 
            // prg_Custom1
            // 
            this.prg_Custom1.Location = new System.Drawing.Point(72, 80);
            this.prg_Custom1.Name = "prg_Custom1";
            this.prg_Custom1.Size = new System.Drawing.Size(84, 10);
            this.prg_Custom1.TabIndex = 67;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.pbUpRight2);
            this.groupBox20.Controls.Add(this.radioButton8D);
            this.groupBox20.Controls.Add(this.pbUp1);
            this.groupBox20.Controls.Add(this.pbUpLeft2);
            this.groupBox20.Controls.Add(this.pbUp2);
            this.groupBox20.Controls.Add(this.radioButton4D);
            this.groupBox20.Controls.Add(this.pbUpRight1);
            this.groupBox20.Controls.Add(this.pbRight1);
            this.groupBox20.Controls.Add(this.pbUpLeft1);
            this.groupBox20.Controls.Add(this.pbRight2);
            this.groupBox20.Controls.Add(this.pbLeft2);
            this.groupBox20.Controls.Add(this.pbDownRight1);
            this.groupBox20.Controls.Add(this.pbLeft1);
            this.groupBox20.Controls.Add(this.pbDownRight2);
            this.groupBox20.Controls.Add(this.pbDownLeft2);
            this.groupBox20.Controls.Add(this.pbDown1);
            this.groupBox20.Controls.Add(this.pbDownLeft1);
            this.groupBox20.Controls.Add(this.pbDown2);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox20.Location = new System.Drawing.Point(3, 143);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(331, 289);
            this.groupBox20.TabIndex = 3;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Head yaw and pitch";
            // 
            // pbUpRight2
            // 
            this.pbUpRight2.Image = global::Haytham.Properties.Resources.UR_UR;
            this.pbUpRight2.Location = new System.Drawing.Point(178, 19);
            this.pbUpRight2.Name = "pbUpRight2";
            this.pbUpRight2.Size = new System.Drawing.Size(40, 40);
            this.pbUpRight2.TabIndex = 32;
            this.pbUpRight2.TabStop = false;
            this.pbUpRight2.Visible = false;
            // 
            // radioButton8D
            // 
            this.radioButton8D.AutoSize = true;
            this.radioButton8D.Location = new System.Drawing.Point(115, 251);
            this.radioButton8D.Name = "radioButton8D";
            this.radioButton8D.Size = new System.Drawing.Size(81, 17);
            this.radioButton8D.TabIndex = 66;
            this.radioButton8D.Text = "8 Directions";
            this.radioButton8D.UseVisualStyleBackColor = true;
            this.radioButton8D.CheckedChanged += new System.EventHandler(this.radioButton8D_CheckedChanged);
            // 
            // pbUp1
            // 
            this.pbUp1.Image = global::Haytham.Properties.Resources.U_D;
            this.pbUp1.Location = new System.Drawing.Point(94, 63);
            this.pbUp1.Name = "pbUp1";
            this.pbUp1.Size = new System.Drawing.Size(40, 40);
            this.pbUp1.TabIndex = 29;
            this.pbUp1.TabStop = false;
            // 
            // pbUpLeft2
            // 
            this.pbUpLeft2.Image = global::Haytham.Properties.Resources.UL_UL;
            this.pbUpLeft2.Location = new System.Drawing.Point(9, 19);
            this.pbUpLeft2.Name = "pbUpLeft2";
            this.pbUpLeft2.Size = new System.Drawing.Size(40, 40);
            this.pbUpLeft2.TabIndex = 44;
            this.pbUpLeft2.TabStop = false;
            this.pbUpLeft2.Visible = false;
            // 
            // pbUp2
            // 
            this.pbUp2.Image = global::Haytham.Properties.Resources.U_U;
            this.pbUp2.Location = new System.Drawing.Point(94, 19);
            this.pbUp2.Name = "pbUp2";
            this.pbUp2.Size = new System.Drawing.Size(40, 40);
            this.pbUp2.TabIndex = 30;
            this.pbUp2.TabStop = false;
            // 
            // radioButton4D
            // 
            this.radioButton4D.AutoSize = true;
            this.radioButton4D.Checked = true;
            this.radioButton4D.Location = new System.Drawing.Point(29, 251);
            this.radioButton4D.Name = "radioButton4D";
            this.radioButton4D.Size = new System.Drawing.Size(81, 17);
            this.radioButton4D.TabIndex = 65;
            this.radioButton4D.TabStop = true;
            this.radioButton4D.Text = "4 Directions";
            this.radioButton4D.UseVisualStyleBackColor = true;
            this.radioButton4D.CheckedChanged += new System.EventHandler(this.radioButton4D_CheckedChanged_1);
            // 
            // pbUpRight1
            // 
            this.pbUpRight1.Image = global::Haytham.Properties.Resources.UR_DL;
            this.pbUpRight1.Location = new System.Drawing.Point(136, 63);
            this.pbUpRight1.Name = "pbUpRight1";
            this.pbUpRight1.Size = new System.Drawing.Size(40, 40);
            this.pbUpRight1.TabIndex = 31;
            this.pbUpRight1.TabStop = false;
            this.pbUpRight1.Visible = false;
            // 
            // pbRight1
            // 
            this.pbRight1.Image = global::Haytham.Properties.Resources.R_L;
            this.pbRight1.Location = new System.Drawing.Point(136, 108);
            this.pbRight1.Name = "pbRight1";
            this.pbRight1.Size = new System.Drawing.Size(40, 40);
            this.pbRight1.TabIndex = 33;
            this.pbRight1.TabStop = false;
            // 
            // pbUpLeft1
            // 
            this.pbUpLeft1.Image = global::Haytham.Properties.Resources.UL_DR;
            this.pbUpLeft1.Location = new System.Drawing.Point(52, 63);
            this.pbUpLeft1.Name = "pbUpLeft1";
            this.pbUpLeft1.Size = new System.Drawing.Size(40, 40);
            this.pbUpLeft1.TabIndex = 43;
            this.pbUpLeft1.TabStop = false;
            this.pbUpLeft1.Visible = false;
            // 
            // pbRight2
            // 
            this.pbRight2.Image = global::Haytham.Properties.Resources.R_R;
            this.pbRight2.Location = new System.Drawing.Point(178, 108);
            this.pbRight2.Name = "pbRight2";
            this.pbRight2.Size = new System.Drawing.Size(40, 40);
            this.pbRight2.TabIndex = 34;
            this.pbRight2.TabStop = false;
            // 
            // pbLeft2
            // 
            this.pbLeft2.Image = global::Haytham.Properties.Resources.L_L;
            this.pbLeft2.Location = new System.Drawing.Point(9, 108);
            this.pbLeft2.Name = "pbLeft2";
            this.pbLeft2.Size = new System.Drawing.Size(40, 40);
            this.pbLeft2.TabIndex = 42;
            this.pbLeft2.TabStop = false;
            // 
            // pbDownRight1
            // 
            this.pbDownRight1.Image = global::Haytham.Properties.Resources.DR_UL;
            this.pbDownRight1.Location = new System.Drawing.Point(136, 153);
            this.pbDownRight1.Name = "pbDownRight1";
            this.pbDownRight1.Size = new System.Drawing.Size(40, 40);
            this.pbDownRight1.TabIndex = 35;
            this.pbDownRight1.TabStop = false;
            this.pbDownRight1.Visible = false;
            // 
            // pbLeft1
            // 
            this.pbLeft1.Image = global::Haytham.Properties.Resources.L_R;
            this.pbLeft1.Location = new System.Drawing.Point(52, 108);
            this.pbLeft1.Name = "pbLeft1";
            this.pbLeft1.Size = new System.Drawing.Size(40, 40);
            this.pbLeft1.TabIndex = 41;
            this.pbLeft1.TabStop = false;
            // 
            // pbDownRight2
            // 
            this.pbDownRight2.Image = global::Haytham.Properties.Resources.DR_DR;
            this.pbDownRight2.Location = new System.Drawing.Point(178, 198);
            this.pbDownRight2.Name = "pbDownRight2";
            this.pbDownRight2.Size = new System.Drawing.Size(40, 40);
            this.pbDownRight2.TabIndex = 36;
            this.pbDownRight2.TabStop = false;
            this.pbDownRight2.Visible = false;
            // 
            // pbDownLeft2
            // 
            this.pbDownLeft2.Image = global::Haytham.Properties.Resources.DL_DL;
            this.pbDownLeft2.Location = new System.Drawing.Point(9, 198);
            this.pbDownLeft2.Name = "pbDownLeft2";
            this.pbDownLeft2.Size = new System.Drawing.Size(40, 40);
            this.pbDownLeft2.TabIndex = 40;
            this.pbDownLeft2.TabStop = false;
            this.pbDownLeft2.Visible = false;
            // 
            // pbDown1
            // 
            this.pbDown1.Image = global::Haytham.Properties.Resources.D_U;
            this.pbDown1.Location = new System.Drawing.Point(94, 153);
            this.pbDown1.Name = "pbDown1";
            this.pbDown1.Size = new System.Drawing.Size(40, 40);
            this.pbDown1.TabIndex = 37;
            this.pbDown1.TabStop = false;
            // 
            // pbDownLeft1
            // 
            this.pbDownLeft1.Image = global::Haytham.Properties.Resources.DL_UR;
            this.pbDownLeft1.Location = new System.Drawing.Point(52, 153);
            this.pbDownLeft1.Name = "pbDownLeft1";
            this.pbDownLeft1.Size = new System.Drawing.Size(40, 40);
            this.pbDownLeft1.TabIndex = 39;
            this.pbDownLeft1.TabStop = false;
            this.pbDownLeft1.Visible = false;
            // 
            // pbDown2
            // 
            this.pbDown2.Image = global::Haytham.Properties.Resources.D_D;
            this.pbDown2.Location = new System.Drawing.Point(94, 198);
            this.pbDown2.Name = "pbDown2";
            this.pbDown2.Size = new System.Drawing.Size(40, 40);
            this.pbDown2.TabIndex = 38;
            this.pbDown2.TabStop = false;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pbTRight);
            this.groupBox16.Controls.Add(this.pbTLeft);
            this.groupBox16.Controls.Add(this.cbHeadRollGestures);
            this.groupBox16.Controls.Add(this.cbEditShowOpticalFlow);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox16.Location = new System.Drawing.Point(3, 66);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(331, 77);
            this.groupBox16.TabIndex = 5;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Head Roll";
            // 
            // pbTRight
            // 
            this.pbTRight.Image = global::Haytham.Properties.Resources.TR;
            this.pbTRight.Location = new System.Drawing.Point(139, 24);
            this.pbTRight.Name = "pbTRight";
            this.pbTRight.Size = new System.Drawing.Size(40, 40);
            this.pbTRight.TabIndex = 88;
            this.pbTRight.TabStop = false;
            // 
            // pbTLeft
            // 
            this.pbTLeft.Image = global::Haytham.Properties.Resources.TL;
            this.pbTLeft.Location = new System.Drawing.Point(51, 24);
            this.pbTLeft.Name = "pbTLeft";
            this.pbTLeft.Size = new System.Drawing.Size(40, 40);
            this.pbTLeft.TabIndex = 87;
            this.pbTLeft.TabStop = false;
            // 
            // cbHeadRollGestures
            // 
            this.cbHeadRollGestures.Checked = true;
            this.cbHeadRollGestures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeadRollGestures.Location = new System.Drawing.Point(64, 0);
            this.cbHeadRollGestures.Margin = new System.Windows.Forms.Padding(2);
            this.cbHeadRollGestures.Name = "cbHeadRollGestures";
            this.cbHeadRollGestures.Size = new System.Drawing.Size(117, 19);
            this.cbHeadRollGestures.TabIndex = 85;
            this.cbHeadRollGestures.UseVisualStyleBackColor = true;
            this.cbHeadRollGestures.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_5);
            // 
            // cbEditShowOpticalFlow
            // 
            this.cbEditShowOpticalFlow.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEditShowOpticalFlow.BackColor = System.Drawing.Color.Transparent;
            this.cbEditShowOpticalFlow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEditShowOpticalFlow.BackgroundImage")));
            this.cbEditShowOpticalFlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbEditShowOpticalFlow.FlatAppearance.BorderSize = 0;
            this.cbEditShowOpticalFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEditShowOpticalFlow.Location = new System.Drawing.Point(185, 1);
            this.cbEditShowOpticalFlow.Margin = new System.Windows.Forms.Padding(2);
            this.cbEditShowOpticalFlow.Name = "cbEditShowOpticalFlow";
            this.cbEditShowOpticalFlow.Size = new System.Drawing.Size(14, 18);
            this.cbEditShowOpticalFlow.TabIndex = 82;
            this.cbEditShowOpticalFlow.UseVisualStyleBackColor = false;
            this.cbEditShowOpticalFlow.CheckedChanged += new System.EventHandler(this.checkEditShowOpticalFlow_CheckedChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.btnDbBlink);
            this.groupBox17.Controls.Add(this.btnBlink);
            this.groupBox17.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox17.Location = new System.Drawing.Point(3, 3);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(331, 63);
            this.groupBox17.TabIndex = 3;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Blink";
            // 
            // btnDbBlink
            // 
            this.btnDbBlink.BackColor = System.Drawing.Color.White;
            this.btnDbBlink.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDbBlink.Location = new System.Drawing.Point(115, 15);
            this.btnDbBlink.Name = "btnDbBlink";
            this.btnDbBlink.Size = new System.Drawing.Size(84, 37);
            this.btnDbBlink.TabIndex = 68;
            this.btnDbBlink.Tag = "DbBlink";
            this.btnDbBlink.Text = "DbBlink";
            this.btnDbBlink.UseVisualStyleBackColor = false;
            // 
            // btnBlink
            // 
            this.btnBlink.BackColor = System.Drawing.Color.White;
            this.btnBlink.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBlink.Location = new System.Drawing.Point(29, 15);
            this.btnBlink.Name = "btnBlink";
            this.btnBlink.Size = new System.Drawing.Size(84, 37);
            this.btnBlink.TabIndex = 68;
            this.btnBlink.Tag = "Blink";
            this.btnBlink.Text = "Blink";
            this.btnBlink.UseVisualStyleBackColor = false;
            // 
            // tabPage_ExtData
            // 
            this.tabPage_ExtData.Controls.Add(this.groupBox13);
            this.tabPage_ExtData.Location = new System.Drawing.Point(4, 40);
            this.tabPage_ExtData.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_ExtData.Name = "tabPage_ExtData";
            this.tabPage_ExtData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ExtData.Size = new System.Drawing.Size(337, 647);
            this.tabPage_ExtData.TabIndex = 7;
            this.tabPage_ExtData.Text = "ExtData";
            this.tabPage_ExtData.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btn_CleanCache);
            this.groupBox13.Controls.Add(this.label2);
            this.groupBox13.Controls.Add(this.numericUpDown1);
            this.groupBox13.Controls.Add(this.checkBox4);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(331, 69);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            // 
            // btn_CleanCache
            // 
            this.btn_CleanCache.Location = new System.Drawing.Point(12, 38);
            this.btn_CleanCache.Name = "btn_CleanCache";
            this.btn_CleanCache.Size = new System.Drawing.Size(75, 23);
            this.btn_CleanCache.TabIndex = 3;
            this.btn_CleanCache.Text = "clean cache";
            this.btn_CleanCache.UseVisualStyleBackColor = true;
            this.btn_CleanCache.Click += new System.EventHandler(this.btn_CleanCache_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font size:";
            this.label2.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(166, 41);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(12, 18);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(163, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Enable external data sources";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // tabPage_EyeGrip
            // 
            this.tabPage_EyeGrip.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_EyeGrip.Controls.Add(this.groupBox3);
            this.tabPage_EyeGrip.Controls.Add(this.groupBox2);
            this.tabPage_EyeGrip.Controls.Add(this.textBox1);
            this.tabPage_EyeGrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabPage_EyeGrip.Location = new System.Drawing.Point(4, 40);
            this.tabPage_EyeGrip.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_EyeGrip.Name = "tabPage_EyeGrip";
            this.tabPage_EyeGrip.Size = new System.Drawing.Size(337, 647);
            this.tabPage_EyeGrip.TabIndex = 9;
            this.tabPage_EyeGrip.Text = "EyeGrip";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbSpeedMindValue);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.tbSpeedMind);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.label_SCRL);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.nudSCRLSensitivity);
            this.groupBox3.Controls.Add(this.button14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 152);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(337, 426);
            this.groupBox3.TabIndex = 72;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qualitative Study";
            // 
            // lbSpeedMindValue
            // 
            this.lbSpeedMindValue.AutoSize = true;
            this.lbSpeedMindValue.Location = new System.Drawing.Point(151, 51);
            this.lbSpeedMindValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSpeedMindValue.Name = "lbSpeedMindValue";
            this.lbSpeedMindValue.Size = new System.Drawing.Size(54, 13);
            this.lbSpeedMindValue.TabIndex = 78;
            this.lbSpeedMindValue.Text = "Sensitivity";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 67);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(54, 13);
            this.label21.TabIndex = 77;
            this.label21.Text = "Sensitivity";
            // 
            // tbSpeedMind
            // 
            this.tbSpeedMind.Location = new System.Drawing.Point(111, 67);
            this.tbSpeedMind.Margin = new System.Windows.Forms.Padding(2);
            this.tbSpeedMind.Maximum = 2600;
            this.tbSpeedMind.Minimum = 1000;
            this.tbSpeedMind.Name = "tbSpeedMind";
            this.tbSpeedMind.Size = new System.Drawing.Size(127, 45);
            this.tbSpeedMind.SmallChange = 10;
            this.tbSpeedMind.TabIndex = 76;
            this.tbSpeedMind.TickFrequency = 10;
            this.tbSpeedMind.Value = 1800;
            this.tbSpeedMind.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 199);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 75;
            this.label20.Text = "Demos";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(148, 153);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 17);
            this.radioButton2.TabIndex = 74;
            this.radioButton2.Text = "Manual";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_6);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(77, 153);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 73;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EyeGrip";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_6);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 155);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 13);
            this.label19.TabIndex = 72;
            this.label19.Text = "Stop Mode";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 24);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Sensitivity";
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button13.Location = new System.Drawing.Point(89, 219);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(77, 94);
            this.button13.TabIndex = 67;
            this.button13.Text = "Menu demo";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label_SCRL
            // 
            this.label_SCRL.AutoSize = true;
            this.label_SCRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_SCRL.Location = new System.Drawing.Point(8, 393);
            this.label_SCRL.Name = "label_SCRL";
            this.label_SCRL.Size = new System.Drawing.Size(153, 17);
            this.label_SCRL.TabIndex = 66;
            this.label_SCRL.Text = "MindReading Result";
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button12.Location = new System.Drawing.Point(10, 219);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(74, 94);
            this.button12.TabIndex = 64;
            this.button12.Text = "Facebook demo";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // nudSCRLSensitivity
            // 
            this.nudSCRLSensitivity.Location = new System.Drawing.Point(77, 24);
            this.nudSCRLSensitivity.Margin = new System.Windows.Forms.Padding(2);
            this.nudSCRLSensitivity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSCRLSensitivity.Name = "nudSCRLSensitivity";
            this.nudSCRLSensitivity.Size = new System.Drawing.Size(40, 20);
            this.nudSCRLSensitivity.TabIndex = 70;
            this.nudSCRLSensitivity.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.nudSCRLSensitivity.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged_1);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button14.Location = new System.Drawing.Point(3, 339);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(160, 47);
            this.button14.TabIndex = 68;
            this.button14.Text = "Mind Reading";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(337, 132);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantitative Study";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button10.Location = new System.Drawing.Point(133, 29);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 37);
            this.button10.TabIndex = 61;
            this.button10.Text = "SCRL";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button11.Location = new System.Drawing.Point(41, 80);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(166, 32);
            this.button11.TabIndex = 63;
            this.button11.Text = "generate seq images";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "p1";
            // 
            // tabPage_HoloLens
            // 
            this.tabPage_HoloLens.Controls.Add(this.gbHoloLensExperiment);
            this.tabPage_HoloLens.Controls.Add(this.gpHoloLensServer);
            this.tabPage_HoloLens.Location = new System.Drawing.Point(4, 40);
            this.tabPage_HoloLens.Name = "tabPage_HoloLens";
            this.tabPage_HoloLens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HoloLens.Size = new System.Drawing.Size(337, 647);
            this.tabPage_HoloLens.TabIndex = 10;
            this.tabPage_HoloLens.Text = "HoloLens";
            this.tabPage_HoloLens.UseVisualStyleBackColor = true;
            // 
            // gbHoloLensExperiment
            // 
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensExperimentHideScreen);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensExperimentShowScreen);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensExperimentLoadSandbox);
            this.gbHoloLensExperiment.Controls.Add(this.lblHoloLensCurrentParticipant);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensNewParticipant);
            this.gbHoloLensExperiment.Controls.Add(this.cmbHoloLensChoices);
            this.gbHoloLensExperiment.Controls.Add(this.cmbHoloLensDistance);
            this.gbHoloLensExperiment.Controls.Add(this.cmbHoloLensAlignment);
            this.gbHoloLensExperiment.Controls.Add(this.lblHoloLensCalibration);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensHideGaze);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensShowGaze);
            this.gbHoloLensExperiment.Controls.Add(this.lblHoloLensChoices);
            this.gbHoloLensExperiment.Controls.Add(this.lblHoloLensAlignment);
            this.gbHoloLensExperiment.Controls.Add(this.lblHoloLensDistance);
            this.gbHoloLensExperiment.Controls.Add(this.btnHoloLensLoadExperiment);
            this.gbHoloLensExperiment.Controls.Add(this.btnCalibrateHoloLensFar);
            this.gbHoloLensExperiment.Controls.Add(this.btnCalibrateHoloLensMiddle);
            this.gbHoloLensExperiment.Controls.Add(this.btnCalibrateHoloLensNear);
            this.gbHoloLensExperiment.Location = new System.Drawing.Point(6, 215);
            this.gbHoloLensExperiment.Name = "gbHoloLensExperiment";
            this.gbHoloLensExperiment.Size = new System.Drawing.Size(323, 384);
            this.gbHoloLensExperiment.TabIndex = 1;
            this.gbHoloLensExperiment.TabStop = false;
            this.gbHoloLensExperiment.Text = "Experiment";
            // 
            // lblHoloLensCurrentParticipant
            // 
            this.lblHoloLensCurrentParticipant.AutoSize = true;
            this.lblHoloLensCurrentParticipant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHoloLensCurrentParticipant.Location = new System.Drawing.Point(6, 95);
            this.lblHoloLensCurrentParticipant.Name = "lblHoloLensCurrentParticipant";
            this.lblHoloLensCurrentParticipant.Size = new System.Drawing.Size(308, 26);
            this.lblHoloLensCurrentParticipant.TabIndex = 21;
            this.lblHoloLensCurrentParticipant.Text = "NO CURRENT PARTICIPANT";
            // 
            // btnHoloLensNewParticipant
            // 
            this.btnHoloLensNewParticipant.Location = new System.Drawing.Point(6, 65);
            this.btnHoloLensNewParticipant.Name = "btnHoloLensNewParticipant";
            this.btnHoloLensNewParticipant.Size = new System.Drawing.Size(310, 23);
            this.btnHoloLensNewParticipant.TabIndex = 20;
            this.btnHoloLensNewParticipant.Text = "New Participant";
            this.btnHoloLensNewParticipant.UseVisualStyleBackColor = true;
            this.btnHoloLensNewParticipant.Click += new System.EventHandler(this.btnHoloLensNewParticipant_Click);
            // 
            // cmbHoloLensChoices
            // 
            this.cmbHoloLensChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoloLensChoices.FormattingEnabled = true;
            this.cmbHoloLensChoices.Location = new System.Drawing.Point(218, 171);
            this.cmbHoloLensChoices.Name = "cmbHoloLensChoices";
            this.cmbHoloLensChoices.Size = new System.Drawing.Size(98, 21);
            this.cmbHoloLensChoices.TabIndex = 19;
            // 
            // cmbHoloLensDistance
            // 
            this.cmbHoloLensDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoloLensDistance.FormattingEnabled = true;
            this.cmbHoloLensDistance.Location = new System.Drawing.Point(116, 171);
            this.cmbHoloLensDistance.Name = "cmbHoloLensDistance";
            this.cmbHoloLensDistance.Size = new System.Drawing.Size(96, 21);
            this.cmbHoloLensDistance.TabIndex = 18;
            // 
            // cmbHoloLensAlignment
            // 
            this.cmbHoloLensAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoloLensAlignment.FormattingEnabled = true;
            this.cmbHoloLensAlignment.Location = new System.Drawing.Point(6, 171);
            this.cmbHoloLensAlignment.Name = "cmbHoloLensAlignment";
            this.cmbHoloLensAlignment.Size = new System.Drawing.Size(104, 21);
            this.cmbHoloLensAlignment.TabIndex = 17;
            // 
            // lblHoloLensCalibration
            // 
            this.lblHoloLensCalibration.AutoSize = true;
            this.lblHoloLensCalibration.Location = new System.Drawing.Point(6, 20);
            this.lblHoloLensCalibration.Name = "lblHoloLensCalibration";
            this.lblHoloLensCalibration.Size = new System.Drawing.Size(56, 13);
            this.lblHoloLensCalibration.TabIndex = 15;
            this.lblHoloLensCalibration.Text = "Calibration";
            // 
            // btnHoloLensHideGaze
            // 
            this.btnHoloLensHideGaze.Location = new System.Drawing.Point(163, 355);
            this.btnHoloLensHideGaze.Name = "btnHoloLensHideGaze";
            this.btnHoloLensHideGaze.Size = new System.Drawing.Size(154, 23);
            this.btnHoloLensHideGaze.TabIndex = 14;
            this.btnHoloLensHideGaze.Text = "Hide Gaze";
            this.btnHoloLensHideGaze.UseVisualStyleBackColor = true;
            this.btnHoloLensHideGaze.Click += new System.EventHandler(this.btnHoloLensHideGaze_Click);
            // 
            // btnHoloLensShowGaze
            // 
            this.btnHoloLensShowGaze.Location = new System.Drawing.Point(6, 355);
            this.btnHoloLensShowGaze.Name = "btnHoloLensShowGaze";
            this.btnHoloLensShowGaze.Size = new System.Drawing.Size(151, 23);
            this.btnHoloLensShowGaze.TabIndex = 13;
            this.btnHoloLensShowGaze.Text = "Show Gaze";
            this.btnHoloLensShowGaze.UseVisualStyleBackColor = true;
            this.btnHoloLensShowGaze.Click += new System.EventHandler(this.btnHoloLensShowGaze_Click);
            // 
            // lblHoloLensChoices
            // 
            this.lblHoloLensChoices.AutoSize = true;
            this.lblHoloLensChoices.Location = new System.Drawing.Point(215, 155);
            this.lblHoloLensChoices.Name = "lblHoloLensChoices";
            this.lblHoloLensChoices.Size = new System.Drawing.Size(45, 13);
            this.lblHoloLensChoices.TabIndex = 11;
            this.lblHoloLensChoices.Text = "Choices";
            // 
            // lblHoloLensAlignment
            // 
            this.lblHoloLensAlignment.AutoSize = true;
            this.lblHoloLensAlignment.Location = new System.Drawing.Point(4, 155);
            this.lblHoloLensAlignment.Name = "lblHoloLensAlignment";
            this.lblHoloLensAlignment.Size = new System.Drawing.Size(53, 13);
            this.lblHoloLensAlignment.TabIndex = 10;
            this.lblHoloLensAlignment.Text = "Alignment";
            // 
            // lblHoloLensDistance
            // 
            this.lblHoloLensDistance.AutoSize = true;
            this.lblHoloLensDistance.Location = new System.Drawing.Point(115, 155);
            this.lblHoloLensDistance.Name = "lblHoloLensDistance";
            this.lblHoloLensDistance.Size = new System.Drawing.Size(49, 13);
            this.lblHoloLensDistance.TabIndex = 9;
            this.lblHoloLensDistance.Text = "Distance";
            // 
            // btnHoloLensLoadExperiment
            // 
            this.btnHoloLensLoadExperiment.Location = new System.Drawing.Point(6, 198);
            this.btnHoloLensLoadExperiment.Name = "btnHoloLensLoadExperiment";
            this.btnHoloLensLoadExperiment.Size = new System.Drawing.Size(311, 23);
            this.btnHoloLensLoadExperiment.TabIndex = 7;
            this.btnHoloLensLoadExperiment.Text = "Load Experiment";
            this.btnHoloLensLoadExperiment.UseVisualStyleBackColor = true;
            this.btnHoloLensLoadExperiment.Click += new System.EventHandler(this.btnHoloLensLoadExperiment_Click);
            // 
            // btnCalibrateHoloLensFar
            // 
            this.btnCalibrateHoloLensFar.Location = new System.Drawing.Point(218, 36);
            this.btnCalibrateHoloLensFar.Name = "btnCalibrateHoloLensFar";
            this.btnCalibrateHoloLensFar.Size = new System.Drawing.Size(98, 23);
            this.btnCalibrateHoloLensFar.TabIndex = 2;
            this.btnCalibrateHoloLensFar.Text = "Calibrate Far";
            this.btnCalibrateHoloLensFar.UseVisualStyleBackColor = true;
            this.btnCalibrateHoloLensFar.Click += new System.EventHandler(this.btnCalibrateHoloLensFar_Click);
            // 
            // btnCalibrateHoloLensMiddle
            // 
            this.btnCalibrateHoloLensMiddle.Location = new System.Drawing.Point(108, 36);
            this.btnCalibrateHoloLensMiddle.Name = "btnCalibrateHoloLensMiddle";
            this.btnCalibrateHoloLensMiddle.Size = new System.Drawing.Size(104, 23);
            this.btnCalibrateHoloLensMiddle.TabIndex = 1;
            this.btnCalibrateHoloLensMiddle.Text = "Calibrate Middle";
            this.btnCalibrateHoloLensMiddle.UseVisualStyleBackColor = true;
            this.btnCalibrateHoloLensMiddle.Click += new System.EventHandler(this.btnCalibrateHoloLensMiddle_Click);
            // 
            // btnCalibrateHoloLensNear
            // 
            this.btnCalibrateHoloLensNear.Location = new System.Drawing.Point(6, 36);
            this.btnCalibrateHoloLensNear.Name = "btnCalibrateHoloLensNear";
            this.btnCalibrateHoloLensNear.Size = new System.Drawing.Size(96, 23);
            this.btnCalibrateHoloLensNear.TabIndex = 0;
            this.btnCalibrateHoloLensNear.Text = "Calibrate Near";
            this.btnCalibrateHoloLensNear.UseVisualStyleBackColor = true;
            this.btnCalibrateHoloLensNear.Click += new System.EventHandler(this.btnCalibrateHoloLensNear_Click);
            // 
            // gpHoloLensServer
            // 
            this.gpHoloLensServer.Controls.Add(this.tbHoloLensServer);
            this.gpHoloLensServer.Location = new System.Drawing.Point(6, 6);
            this.gpHoloLensServer.Name = "gpHoloLensServer";
            this.gpHoloLensServer.Size = new System.Drawing.Size(323, 203);
            this.gpHoloLensServer.TabIndex = 0;
            this.gpHoloLensServer.TabStop = false;
            this.gpHoloLensServer.Text = "Server";
            // 
            // tbHoloLensServer
            // 
            this.tbHoloLensServer.Location = new System.Drawing.Point(6, 14);
            this.tbHoloLensServer.Multiline = true;
            this.tbHoloLensServer.Name = "tbHoloLensServer";
            this.tbHoloLensServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbHoloLensServer.Size = new System.Drawing.Size(311, 183);
            this.tbHoloLensServer.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.AutoSize = true;
            this.gbMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbMain.BackColor = System.Drawing.SystemColors.Control;
            this.gbMain.Controls.Add(this.tableLayoutPanel1);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 24);
            this.gbMain.Margin = new System.Windows.Forms.Padding(2);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(2);
            this.gbMain.Size = new System.Drawing.Size(785, 667);
            this.gbMain.TabIndex = 1;
            this.gbMain.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox18, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.imEyeTest, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 650);
            this.tableLayoutPanel1.TabIndex = 75;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(-320, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gbEyeImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbSceneImage);
            this.splitContainer2.Size = new System.Drawing.Size(1097, 637);
            this.splitContainer2.SplitterDistance = 243;
            this.splitContainer2.TabIndex = 73;
            // 
            // gbEyeImage
            // 
            this.gbEyeImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbEyeImage.Controls.Add(this.panel1);
            this.gbEyeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEyeImage.Location = new System.Drawing.Point(0, 0);
            this.gbEyeImage.Margin = new System.Windows.Forms.Padding(2);
            this.gbEyeImage.Name = "gbEyeImage";
            this.gbEyeImage.Padding = new System.Windows.Forms.Padding(2);
            this.gbEyeImage.Size = new System.Drawing.Size(243, 637);
            this.gbEyeImage.TabIndex = 67;
            this.gbEyeImage.TabStop = false;
            this.gbEyeImage.Text = "Eye";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.imEye);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 620);
            this.panel1.TabIndex = 73;
            // 
            // imEye
            // 
            this.imEye.Dock = System.Windows.Forms.DockStyle.Top;
            this.imEye.Location = new System.Drawing.Point(0, 0);
            this.imEye.Name = "imEye";
            this.imEye.Size = new System.Drawing.Size(239, 550);
            this.imEye.TabIndex = 72;
            this.imEye.TabStop = false;
            this.imEye.Paint += new System.Windows.Forms.PaintEventHandler(this.imEye_Paint);
            // 
            // gbSceneImage
            // 
            this.gbSceneImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbSceneImage.Controls.Add(this.panel2);
            this.gbSceneImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSceneImage.Location = new System.Drawing.Point(0, 0);
            this.gbSceneImage.Margin = new System.Windows.Forms.Padding(2);
            this.gbSceneImage.Name = "gbSceneImage";
            this.gbSceneImage.Padding = new System.Windows.Forms.Padding(2);
            this.gbSceneImage.Size = new System.Drawing.Size(850, 637);
            this.gbSceneImage.TabIndex = 68;
            this.gbSceneImage.TabStop = false;
            this.gbSceneImage.Text = "Scene";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.imSceneProcessed);
            this.panel2.Controls.Add(this.imScene);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 620);
            this.panel2.TabIndex = 74;
            // 
            // imSceneProcessed
            // 
            this.imSceneProcessed.Dock = System.Windows.Forms.DockStyle.Left;
            this.imSceneProcessed.Location = new System.Drawing.Point(60, 0);
            this.imSceneProcessed.Name = "imSceneProcessed";
            this.imSceneProcessed.Size = new System.Drawing.Size(250, 620);
            this.imSceneProcessed.TabIndex = 75;
            this.imSceneProcessed.TabStop = false;
            this.imSceneProcessed.Paint += new System.Windows.Forms.PaintEventHandler(this.imSceneProcessed_Paint);
            // 
            // imScene
            // 
            this.imScene.Dock = System.Windows.Forms.DockStyle.Left;
            this.imScene.Location = new System.Drawing.Point(0, 0);
            this.imScene.Name = "imScene";
            this.imScene.Size = new System.Drawing.Size(60, 620);
            this.imScene.TabIndex = 73;
            this.imScene.TabStop = false;
            this.imScene.Paint += new System.Windows.Forms.PaintEventHandler(this.imScene_Paint);
            this.imScene.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imScene_MouseClick);
            this.imScene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imScene_MouseMove);
            // 
            // groupBox18
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox18, 3);
            this.groupBox18.Controls.Add(this.chartTest);
            this.groupBox18.Location = new System.Drawing.Point(3, 646);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(564, 1);
            this.groupBox18.TabIndex = 3;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "debug";
            this.groupBox18.Visible = false;
            // 
            // chartTest
            // 
            this.chartTest.BackColor = System.Drawing.Color.Transparent;
            chartArea12.AxisX.IsMarginVisible = false;
            chartArea12.AxisX.LabelStyle.Enabled = false;
            chartArea12.AxisX.MajorGrid.Enabled = false;
            chartArea12.AxisX.MajorTickMark.Enabled = false;
            chartArea12.AxisY.IsLabelAutoFit = false;
            chartArea12.AxisY.LabelStyle.Interval = 0D;
            chartArea12.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea12.BackColor = System.Drawing.Color.White;
            chartArea12.InnerPlotPosition.Auto = false;
            chartArea12.InnerPlotPosition.Height = 86.87582F;
            chartArea12.InnerPlotPosition.Width = 86.45924F;
            chartArea12.InnerPlotPosition.X = 13.54076F;
            chartArea12.InnerPlotPosition.Y = 6.56209F;
            chartArea12.Name = "ChartArea1";
            chartArea12.Position.Auto = false;
            chartArea12.Position.Height = 80.00502F;
            chartArea12.Position.Width = 94F;
            chartArea12.Position.X = 3F;
            chartArea12.Position.Y = 16.99498F;
            this.chartTest.ChartAreas.Add(chartArea12);
            this.chartTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartTest.Location = new System.Drawing.Point(3, 16);
            this.chartTest.Margin = new System.Windows.Forms.Padding(2);
            this.chartTest.Name = "chartTest";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.EmptyPointStyle.BorderWidth = 0;
            series12.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series12.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series12.EmptyPointStyle.IsVisibleInLegend = false;
            series12.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series12.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series12.EmptyPointStyle.MarkerSize = 1;
            series12.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series12.Name = "test";
            this.chartTest.Series.Add(series12);
            this.chartTest.Size = new System.Drawing.Size(549, 0);
            this.chartTest.TabIndex = 47;
            this.chartTest.Text = "chart3";
            title12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title12.Name = "test";
            title12.Position.Auto = false;
            title12.Position.Height = 10.99498F;
            title12.Position.Width = 94F;
            title12.Position.X = 3F;
            title12.Position.Y = 3F;
            title12.Text = "test";
            this.chartTest.Titles.Add(title12);
            // 
            // imEyeTest
            // 
            this.imEyeTest.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imEyeTest.Location = new System.Drawing.Point(3, 3);
            this.imEyeTest.Name = "imEyeTest";
            this.imEyeTest.Size = new System.Drawing.Size(1, 504);
            this.imEyeTest.TabIndex = 70;
            this.imEyeTest.TabStop = false;
            this.imEyeTest.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.splitter7);
            this.pnlTop.Controls.Add(this.lblIP);
            this.pnlTop.Controls.Add(this.splitter6);
            this.pnlTop.Controls.Add(this.lblGlintCenter);
            this.pnlTop.Controls.Add(this.splitter3);
            this.pnlTop.Controls.Add(this.lblPupilCenter);
            this.pnlTop.Controls.Add(this.splitter2);
            this.pnlTop.Controls.Add(this.cmbSceneTimer);
            this.pnlTop.Controls.Add(this.splitter1);
            this.pnlTop.Controls.Add(this.cmbEyeTimer);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(785, 24);
            this.pnlTop.TabIndex = 0;
            // 
            // splitter7
            // 
            this.splitter7.Location = new System.Drawing.Point(557, 0);
            this.splitter7.Margin = new System.Windows.Forms.Padding(2);
            this.splitter7.Name = "splitter7";
            this.splitter7.Size = new System.Drawing.Size(2, 24);
            this.splitter7.TabIndex = 73;
            this.splitter7.TabStop = false;
            // 
            // lblIP
            // 
            this.lblIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblIP.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIP.Location = new System.Drawing.Point(378, 0);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2);
            this.lblIP.Multiline = true;
            this.lblIP.Name = "lblIP";
            this.lblIP.ReadOnly = true;
            this.lblIP.Size = new System.Drawing.Size(179, 24);
            this.lblIP.TabIndex = 72;
            this.lblIP.Text = "Server IP: 000.000.000.000";
            this.lblIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitter6
            // 
            this.splitter6.Location = new System.Drawing.Point(376, 0);
            this.splitter6.Margin = new System.Windows.Forms.Padding(2);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(2, 24);
            this.splitter6.TabIndex = 71;
            this.splitter6.TabStop = false;
            // 
            // lblGlintCenter
            // 
            this.lblGlintCenter.AutoSize = true;
            this.lblGlintCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGlintCenter.Location = new System.Drawing.Point(314, 0);
            this.lblGlintCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGlintCenter.Name = "lblGlintCenter";
            this.lblGlintCenter.Size = new System.Drawing.Size(62, 13);
            this.lblGlintCenter.TabIndex = 66;
            this.lblGlintCenter.Text = "Glint Center";
            this.lblGlintCenter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(312, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(2, 24);
            this.splitter3.TabIndex = 65;
            this.splitter3.TabStop = false;
            // 
            // lblPupilCenter
            // 
            this.lblPupilCenter.AutoSize = true;
            this.lblPupilCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPupilCenter.Location = new System.Drawing.Point(248, 0);
            this.lblPupilCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPupilCenter.Name = "lblPupilCenter";
            this.lblPupilCenter.Size = new System.Drawing.Size(64, 13);
            this.lblPupilCenter.TabIndex = 64;
            this.lblPupilCenter.Text = "Pupil Center";
            this.lblPupilCenter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(246, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(2, 24);
            this.splitter2.TabIndex = 63;
            this.splitter2.TabStop = false;
            // 
            // cmbSceneTimer
            // 
            this.cmbSceneTimer.BackColor = System.Drawing.SystemColors.Control;
            this.cmbSceneTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSceneTimer.FormattingEnabled = true;
            this.cmbSceneTimer.Location = new System.Drawing.Point(124, 0);
            this.cmbSceneTimer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSceneTimer.Name = "cmbSceneTimer";
            this.cmbSceneTimer.Size = new System.Drawing.Size(122, 21);
            this.cmbSceneTimer.TabIndex = 62;
            this.cmbSceneTimer.SelectedIndexChanged += new System.EventHandler(this.comboBox_SceneTimer_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(122, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 24);
            this.splitter1.TabIndex = 61;
            this.splitter1.TabStop = false;
            // 
            // cmbEyeTimer
            // 
            this.cmbEyeTimer.BackColor = System.Drawing.SystemColors.Control;
            this.cmbEyeTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbEyeTimer.FormattingEnabled = true;
            this.cmbEyeTimer.Location = new System.Drawing.Point(0, 0);
            this.cmbEyeTimer.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEyeTimer.Name = "cmbEyeTimer";
            this.cmbEyeTimer.Size = new System.Drawing.Size(122, 21);
            this.cmbEyeTimer.TabIndex = 60;
            // 
            // timerReset
            // 
            this.timerReset.Interval = 500;
            this.timerReset.Tick += new System.EventHandler(this.timerReset_Tick);
            // 
            // btnHoloLensExperimentLoadSandbox
            // 
            this.btnHoloLensExperimentLoadSandbox.Location = new System.Drawing.Point(6, 286);
            this.btnHoloLensExperimentLoadSandbox.Name = "btnHoloLensExperimentLoadSandbox";
            this.btnHoloLensExperimentLoadSandbox.Size = new System.Drawing.Size(311, 23);
            this.btnHoloLensExperimentLoadSandbox.TabIndex = 22;
            this.btnHoloLensExperimentLoadSandbox.Text = "Load Sandbox";
            this.btnHoloLensExperimentLoadSandbox.UseVisualStyleBackColor = true;
            this.btnHoloLensExperimentLoadSandbox.Click += new System.EventHandler(this.btnHoloLensExperimentLoadSandbox_Click);
            // 
            // trackBarGABlockSize
            // 
            this.trackBarGABlockSize.AutoSize = false;
            this.trackBarGABlockSize.Location = new System.Drawing.Point(57, 32);
            this.trackBarGABlockSize.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGABlockSize.Maximum = 151;
            this.trackBarGABlockSize.Minimum = 33;
            this.trackBarGABlockSize.Name = "trackBarGABlockSize";
            this.trackBarGABlockSize.Size = new System.Drawing.Size(146, 24);
            this.trackBarGABlockSize.TabIndex = 65;
            this.trackBarGABlockSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGABlockSize.Value = 113;
            this.trackBarGABlockSize.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_4);
            // 
            // trackBarThresholdGlint
            // 
            this.trackBarThresholdGlint.AutoSize = false;
            this.trackBarThresholdGlint.Location = new System.Drawing.Point(76, 67);
            this.trackBarThresholdGlint.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarThresholdGlint.Maximum = 255;
            this.trackBarThresholdGlint.Minimum = 120;
            this.trackBarThresholdGlint.Name = "trackBarThresholdGlint";
            this.trackBarThresholdGlint.Size = new System.Drawing.Size(146, 24);
            this.trackBarThresholdGlint.TabIndex = 67;
            this.trackBarThresholdGlint.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThresholdGlint.Value = 200;
            this.trackBarThresholdGlint.ValueChanged += new System.EventHandler(this.transparentTrackBar2_ValueChanged);
            // 
            // trackBarGAConstant
            // 
            this.trackBarGAConstant.AutoSize = false;
            this.trackBarGAConstant.Location = new System.Drawing.Point(76, 42);
            this.trackBarGAConstant.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGAConstant.Maximum = 0;
            this.trackBarGAConstant.Minimum = -100;
            this.trackBarGAConstant.Name = "trackBarGAConstant";
            this.trackBarGAConstant.Size = new System.Drawing.Size(146, 24);
            this.trackBarGAConstant.TabIndex = 68;
            this.trackBarGAConstant.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGAConstant.Value = -80;
            this.trackBarGAConstant.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_3);
            // 
            // trackBarPABlockSize
            // 
            this.trackBarPABlockSize.AutoSize = false;
            this.trackBarPABlockSize.Location = new System.Drawing.Point(57, 32);
            this.trackBarPABlockSize.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarPABlockSize.Maximum = 151;
            this.trackBarPABlockSize.Minimum = 33;
            this.trackBarPABlockSize.Name = "trackBarPABlockSize";
            this.trackBarPABlockSize.Size = new System.Drawing.Size(146, 24);
            this.trackBarPABlockSize.TabIndex = 65;
            this.trackBarPABlockSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPABlockSize.Value = 113;
            this.trackBarPABlockSize.ValueChanged += new System.EventHandler(this.trackBarPABlockSize_ValueChanged);
            // 
            // trackBarPAConstant
            // 
            this.trackBarPAConstant.AutoSize = false;
            this.trackBarPAConstant.Location = new System.Drawing.Point(76, 43);
            this.trackBarPAConstant.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarPAConstant.Maximum = 50;
            this.trackBarPAConstant.Minimum = 5;
            this.trackBarPAConstant.Name = "trackBarPAConstant";
            this.trackBarPAConstant.Size = new System.Drawing.Size(146, 24);
            this.trackBarPAConstant.TabIndex = 64;
            this.trackBarPAConstant.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPAConstant.Value = 20;
            this.trackBarPAConstant.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_2);
            // 
            // trackBarThresholdEye
            // 
            this.trackBarThresholdEye.AutoSize = false;
            this.trackBarThresholdEye.Location = new System.Drawing.Point(76, 70);
            this.trackBarThresholdEye.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarThresholdEye.Maximum = 255;
            this.trackBarThresholdEye.Name = "trackBarThresholdEye";
            this.trackBarThresholdEye.Size = new System.Drawing.Size(146, 24);
            this.trackBarThresholdEye.TabIndex = 63;
            this.trackBarThresholdEye.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThresholdEye.Value = 70;
            this.trackBarThresholdEye.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_1);
            // 
            // tbIrisDiameter
            // 
            this.tbIrisDiameter.AutoSize = false;
            this.tbIrisDiameter.Location = new System.Drawing.Point(76, 17);
            this.tbIrisDiameter.Margin = new System.Windows.Forms.Padding(2);
            this.tbIrisDiameter.Maximum = 500;
            this.tbIrisDiameter.Minimum = 80;
            this.tbIrisDiameter.Name = "tbIrisDiameter";
            this.tbIrisDiameter.Size = new System.Drawing.Size(146, 27);
            this.tbIrisDiameter.TabIndex = 2;
            this.tbIrisDiameter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbIrisDiameter.Value = 200;
            this.tbIrisDiameter.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged);
            // 
            // tbMonitorBThreshold
            // 
            this.tbMonitorBThreshold.AutoSize = false;
            this.tbMonitorBThreshold.Location = new System.Drawing.Point(18, 32);
            this.tbMonitorBThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.tbMonitorBThreshold.Maximum = 360;
            this.tbMonitorBThreshold.Name = "tbMonitorBThreshold";
            this.tbMonitorBThreshold.Size = new System.Drawing.Size(185, 24);
            this.tbMonitorBThreshold.TabIndex = 65;
            this.tbMonitorBThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMonitorBThreshold.Value = 70;
            this.tbMonitorBThreshold.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_5);
            // 
            // tbMonitorGThreshold
            // 
            this.tbMonitorGThreshold.AutoSize = false;
            this.tbMonitorGThreshold.Location = new System.Drawing.Point(18, 60);
            this.tbMonitorGThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.tbMonitorGThreshold.Maximum = 360;
            this.tbMonitorGThreshold.Minimum = 5;
            this.tbMonitorGThreshold.Name = "tbMonitorGThreshold";
            this.tbMonitorGThreshold.Size = new System.Drawing.Size(185, 24);
            this.tbMonitorGThreshold.TabIndex = 66;
            this.tbMonitorGThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMonitorGThreshold.Value = 290;
            this.tbMonitorGThreshold.ValueChanged += new System.EventHandler(this.transparentTrackBar2_ValueChanged_1);
            // 
            // tbMonitorMinSize
            // 
            this.tbMonitorMinSize.AutoSize = false;
            this.tbMonitorMinSize.Location = new System.Drawing.Point(25, 47);
            this.tbMonitorMinSize.Margin = new System.Windows.Forms.Padding(2);
            this.tbMonitorMinSize.Maximum = 100;
            this.tbMonitorMinSize.Minimum = 5;
            this.tbMonitorMinSize.Name = "tbMonitorMinSize";
            this.tbMonitorMinSize.Size = new System.Drawing.Size(185, 24);
            this.tbMonitorMinSize.TabIndex = 67;
            this.tbMonitorMinSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbMonitorMinSize.Value = 30;
            this.tbMonitorMinSize.ValueChanged += new System.EventHandler(this.transparentTrackBar3_ValueChanged);
            this.tbMonitorMinSize.MouseEnter += new System.EventHandler(this.trackBarControl3_MouseEnter);
            this.tbMonitorMinSize.MouseLeave += new System.EventHandler(this.trackBarControl3_MouseLeave);
            // 
            // btnHoloLensExperimentShowScreen
            // 
            this.btnHoloLensExperimentShowScreen.Location = new System.Drawing.Point(6, 326);
            this.btnHoloLensExperimentShowScreen.Name = "btnHoloLensExperimentShowScreen";
            this.btnHoloLensExperimentShowScreen.Size = new System.Drawing.Size(151, 23);
            this.btnHoloLensExperimentShowScreen.TabIndex = 23;
            this.btnHoloLensExperimentShowScreen.Text = "Show Screen";
            this.btnHoloLensExperimentShowScreen.UseVisualStyleBackColor = true;
            this.btnHoloLensExperimentShowScreen.Click += new System.EventHandler(this.btnHoloLensExperimentShowScreen_Click);
            // 
            // btnHoloLensExperimentHideScreen
            // 
            this.btnHoloLensExperimentHideScreen.Location = new System.Drawing.Point(163, 326);
            this.btnHoloLensExperimentHideScreen.Name = "btnHoloLensExperimentHideScreen";
            this.btnHoloLensExperimentHideScreen.Size = new System.Drawing.Size(154, 23);
            this.btnHoloLensExperimentHideScreen.TabIndex = 24;
            this.btnHoloLensExperimentHideScreen.Text = "Hide Screen";
            this.btnHoloLensExperimentHideScreen.UseVisualStyleBackColor = true;
            this.btnHoloLensExperimentHideScreen.Click += new System.EventHandler(this.btnHoloLensExperimentHideScreen_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 691);
            this.Controls.Add(this.rootContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haytham_Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.rootContainer.Panel1.ResumeLayout(false);
            this.rootContainer.Panel2.ResumeLayout(false);
            this.rootContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootContainer)).EndInit();
            this.rootContainer.ResumeLayout(false);
            this.leftTabs.ResumeLayout(false);
            this.tabPage_Camera.ResumeLayout(false);
            this.gbStartBoth.ResumeLayout(false);
            this.gbSceneCameraDevice.ResumeLayout(false);
            this.gbSceneCameraDevice.PerformLayout();
            this.gbEyeCameraDevice.ResumeLayout(false);
            this.gbEyeCameraDevice.PerformLayout();
            this.tabPage_Glass.ResumeLayout(false);
            this.tabPage_Glass.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetBMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTargetRMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage_Eye.ResumeLayout(false);
            this.gbGlintDetection.ResumeLayout(false);
            this.gbGlintDetection.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlGlintDetection.ResumeLayout(false);
            this.pnlGlintDetection.PerformLayout();
            this.gbIrisDiameter.ResumeLayout(false);
            this.gbIrisDiameter.PerformLayout();
            this.tabPage_Scene.ResumeLayout(false);
            this.tabPage_Scene.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox21.ResumeLayout(false);
            this.tabPage_Calibration.ResumeLayout(false);
            this.gbCalibrationGlass.ResumeLayout(false);
            this.gbCalibrationGlass.PerformLayout();
            this.gbCalibrationRemote.ResumeLayout(false);
            this.gbCalibrationScene.ResumeLayout(false);
            this.pnlCalibration.ResumeLayout(false);
            this.pnlCalibration.PerformLayout();
            this.tabPage_Data.ResumeLayout(false);
            this.gbDataCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gbDataExport.ResumeLayout(false);
            this.tabPage_Clients.ResumeLayout(false);
            this.tabPage_Clients.PerformLayout();
            this.gbClientsSettings.ResumeLayout(false);
            this.gbClientsSettings.PerformLayout();
            this.gbClientsMessages.ResumeLayout(false);
            this.gbClientsMessages.PerformLayout();
            this.tabPage_Gesture.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUpLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownRight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDown2)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTLeft)).EndInit();
            this.groupBox17.ResumeLayout(false);
            this.tabPage_ExtData.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage_EyeGrip.ResumeLayout(false);
            this.tabPage_EyeGrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedMind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSCRLSensitivity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage_HoloLens.ResumeLayout(false);
            this.gbHoloLensExperiment.ResumeLayout(false);
            this.gbHoloLensExperiment.PerformLayout();
            this.gpHoloLensServer.ResumeLayout(false);
            this.gpHoloLensServer.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gbEyeImage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imEye)).EndInit();
            this.gbSceneImage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imSceneProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imScene)).EndInit();
            this.groupBox18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imEyeTest)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGABlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdGlint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGAConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPABlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPAConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbIrisDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorBThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorGThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonitorMinSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeviceCapabilityScene;
        private System.Windows.Forms.ComboBox cmbDeviceScene;
        private System.Windows.Forms.ComboBox cmbDeviceCapabilityEye;
        private System.Windows.Forms.ComboBox cmbDeviceEye;
        private System.Windows.Forms.TextBox TextBoxServer;
        private System.Windows.Forms.RadioButton rbAutoActivation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox gbEyeCameraDevice;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettingsEye;
        private System.Windows.Forms.GroupBox gbSceneCameraDevice;
        private System.Windows.Forms.Button btnSettingsScene;
        private System.Windows.Forms.Button btnStartScene;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Button startBoothVideos;
        private System.Windows.Forms.GroupBox gbStartBoth;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox gbGlintDetection;
        private System.Windows.Forms.GroupBox gbIrisDiameter;
        private System.Windows.Forms.Label lbIrisDiameter;
        private TransparentTrackBar tbIrisDiameter;
        private System.Windows.Forms.CheckBox cbShowIris;
        private System.Windows.Forms.CheckBox cbPupilDetection;
        private System.Windows.Forms.CheckBox cbShowPupil;
        private System.Windows.Forms.RadioButton cbPM;
        private System.Windows.Forms.RadioButton cbPA;
        private TransparentTrackBar trackBarThresholdEye;
        private TransparentTrackBar trackBarPAConstant;
        private System.Windows.Forms.CheckBox cbRemoveGlint;
        private System.Windows.Forms.CheckBox cbDilateErode;
        private System.Windows.Forms.CheckBox cbGlintDetection;
        private System.Windows.Forms.CheckBox cbShowGlint;
        private System.Windows.Forms.RadioButton cbGlintManual;
        private System.Windows.Forms.RadioButton cbGlintAuto;
        private TransparentTrackBar trackBarGAConstant;
        private TransparentTrackBar trackBarThresholdGlint;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel pnlGlintDetection;
        private System.Windows.Forms.RadioButton rbPGaussian;
        private System.Windows.Forms.RadioButton rbPMean;
        private TransparentTrackBar trackBarPABlockSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private TransparentTrackBar trackBarGABlockSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbGGaussian;
        private System.Windows.Forms.RadioButton rbGMean;
        private System.Windows.Forms.CheckBox cbShowScreen;
        private TransparentTrackBar tbMonitorMinSize;
        private TransparentTrackBar tbMonitorGThreshold;
        private TransparentTrackBar tbMonitorBThreshold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cbSceneUnDistortion;
        private System.Windows.Forms.Button btnSceneCameraCalibration;
        private System.Windows.Forms.GroupBox gbCalibrationScene;
        private System.Windows.Forms.Panel pnlCalibration;
        private System.Windows.Forms.RadioButton rbPupilGlint;
        private System.Windows.Forms.RadioButton rdOnlyPupil;
        private System.Windows.Forms.Button btnCalibration_Homography;
        private System.Windows.Forms.Button btnCalibration_Polynomial;
        private System.Windows.Forms.CheckBox cbGazeSmoothing;
        private System.Windows.Forms.GroupBox gbDataExport;
        private System.Windows.Forms.ProgressBar pbRecordProgress;
        private System.Windows.Forms.GroupBox gbDataCharts;
        private System.Windows.Forms.CheckBox cbPlot;
        private System.Windows.Forms.GroupBox gbClientsSettings;
        private System.Windows.Forms.GroupBox gbClientsMessages;
        private System.Windows.Forms.SplitContainer rootContainer;
        private System.Windows.Forms.TabControl leftTabs;
        private System.Windows.Forms.TabPage tabPage_Camera;
        private System.Windows.Forms.TabPage tabPage_Eye;
        private System.Windows.Forms.TabPage tabPage_Scene;
        private System.Windows.Forms.TabPage tabPage_Calibration;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.TabPage tabPage_Clients;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel pnlTop;

        private System.Windows.Forms.ComboBox cmbEyeTimer;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ComboBox cmbSceneTimer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.TextBox lblIP;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Label lblGlintCenter;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label lblPupilCenter;
        private System.Windows.Forms.GroupBox gbEyeImage;
        private Emgu.CV.UI.ImageBox imEyeTest;
        private System.Windows.Forms.GroupBox gbSceneImage;
        private System.Windows.Forms.CheckBox cbShowEdges;
        private System.Windows.Forms.CheckBox cbEyeVerticalFlip;
        private System.Windows.Forms.CheckBox cbSceneVerticalFlip;
        private System.Windows.Forms.GroupBox gbCalibrationRemote;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage_Gesture;
        private System.Windows.Forms.RadioButton radioButton4D;
        private System.Windows.Forms.RadioButton radioButton8D;
        private System.Windows.Forms.PictureBox pbUpLeft2;
        private System.Windows.Forms.PictureBox pbUpLeft1;
        private System.Windows.Forms.PictureBox pbLeft2;
        private System.Windows.Forms.PictureBox pbLeft1;
        private System.Windows.Forms.PictureBox pbDownLeft2;
        private System.Windows.Forms.PictureBox pbDownLeft1;
        private System.Windows.Forms.PictureBox pbDown2;
        private System.Windows.Forms.PictureBox pbDown1;
        private System.Windows.Forms.PictureBox pbDownRight2;
        private System.Windows.Forms.PictureBox pbDownRight1;
        private System.Windows.Forms.PictureBox pbRight2;
        private System.Windows.Forms.PictureBox pbRight1;
        private System.Windows.Forms.PictureBox pbUpRight2;
        private System.Windows.Forms.PictureBox pbUpRight1;
        private System.Windows.Forms.PictureBox pbUp2;
        private System.Windows.Forms.PictureBox pbUp1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox cbHeadRollGestures;
        private System.Windows.Forms.CheckBox cbEditShowOpticalFlow;
        private System.Windows.Forms.PictureBox pbTRight;
        private System.Windows.Forms.PictureBox pbTLeft;
        private System.Windows.Forms.Timer timerReset;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.ProgressBar prg_Custom1;
        private System.Windows.Forms.Button btn_Custom1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Button btn_Custom4;
        private System.Windows.Forms.ProgressBar prg_Custom4;
        private System.Windows.Forms.Button btn_Custom3;
        private System.Windows.Forms.ProgressBar prg_Custom3;
        private System.Windows.Forms.Button btn_Custom2;
        private System.Windows.Forms.ProgressBar prg_Custom2;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btnDbBlink;
        private System.Windows.Forms.Button btnBlink;
        private System.Windows.Forms.Label lbl_calibration;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbShowGaze;
        private System.Windows.Forms.GroupBox groupBox21;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTest;
        private System.Windows.Forms.CheckBox cbRecordSceneVideo;
        private System.Windows.Forms.CheckBox cbRecordEyeVideo;
        private System.Windows.Forms.PictureBox imEye;
        private System.Windows.Forms.PictureBox imScene;
		private System.Windows.Forms.TabPage tabPage_ExtData;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btn_CleanCache;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox imSceneProcessed;
        private System.Windows.Forms.RadioButton rbGlint;
        private System.Windows.Forms.GroupBox gbCalibrationGlass;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage_Glass;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbCommandsToGlass;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtImageName;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudTargetBMax;
        private System.Windows.Forms.NumericUpDown nudTargetBMin;
        private System.Windows.Forms.NumericUpDown nudTargetGMax;
        private System.Windows.Forms.NumericUpDown nudTargetGMin;
        private System.Windows.Forms.NumericUpDown nudTargetRMax;
        private System.Windows.Forms.NumericUpDown nudTargetRMin;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label_SCRL;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TabPage tabPage_EyeGrip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudSCRLSensitivity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TrackBar tbSpeedMind;
        private System.Windows.Forms.Label lbSpeedMindValue;
        private System.Windows.Forms.TabPage tabPage_HoloLens;
        private System.Windows.Forms.GroupBox gpHoloLensServer;
        private System.Windows.Forms.TextBox tbHoloLensServer;
        private System.Windows.Forms.GroupBox gbHoloLensExperiment;
        private System.Windows.Forms.Button btnCalibrateHoloLensNear;
        private System.Windows.Forms.Button btnCalibrateHoloLensFar;
        private System.Windows.Forms.Button btnCalibrateHoloLensMiddle;
        private System.Windows.Forms.Button btnHoloLensLoadExperiment;
        private System.Windows.Forms.Label lblHoloLensDistance;
        private System.Windows.Forms.Label lblHoloLensChoices;
        private System.Windows.Forms.Label lblHoloLensAlignment;
        private System.Windows.Forms.Button btnHoloLensHideGaze;
        private System.Windows.Forms.Button btnHoloLensShowGaze;
        private System.Windows.Forms.Label lblHoloLensCalibration;
        private System.Windows.Forms.ComboBox cmbHoloLensAlignment;
        private System.Windows.Forms.ComboBox cmbHoloLensChoices;
        private System.Windows.Forms.ComboBox cmbHoloLensDistance;
        private System.Windows.Forms.Button btnHoloLensNewParticipant;
        private System.Windows.Forms.Label lblHoloLensCurrentParticipant;
        private System.Windows.Forms.Button btnHoloLensExperimentLoadSandbox;
        private System.Windows.Forms.Button btnHoloLensExperimentHideScreen;
        private System.Windows.Forms.Button btnHoloLensExperimentShowScreen;
    }
}

