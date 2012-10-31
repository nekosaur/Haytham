namespace Haytham
{
   public  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Camera = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new System.Windows.Forms.Button();
            this.checkEdit1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_scene_VFlip = new System.Windows.Forms.CheckBox();
            this.btnSettingsScene = new System.Windows.Forms.Button();
            this.btnStartScene = new System.Windows.Forms.Button();
            this.cmbDeviceCapabilityScene = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDeviceScene = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_eye_VFlip = new System.Windows.Forms.CheckBox();
            this.btnSettingsEye = new System.Windows.Forms.Button();
            this.btnStartEye = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDeviceCapabilityEye = new System.Windows.Forms.ComboBox();
            this.cmbDeviceEye = new System.Windows.Forms.ComboBox();
            this.tabPage_Eye = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.trackBarGABlockSize = new Haytham.TransparentTrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.rbGGaussian = new System.Windows.Forms.RadioButton();
            this.rbGMean = new System.Windows.Forms.RadioButton();
            this.trackBarGAConstant = new Haytham.TransparentTrackBar();
            this.trackBarThresholdGlint = new Haytham.TransparentTrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbGM = new System.Windows.Forms.RadioButton();
            this.cbGA = new System.Windows.Forms.RadioButton();
            this.cbShowGlint = new System.Windows.Forms.CheckBox();
            this.cbGlintDetection = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBarPABlockSize = new Haytham.TransparentTrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.rbPGaussian = new System.Windows.Forms.RadioButton();
            this.rbPMean = new System.Windows.Forms.RadioButton();
            this.cbRemoveGlint = new System.Windows.Forms.CheckBox();
            this.cbDilateErode = new System.Windows.Forms.CheckBox();
            this.trackBarPAConstant = new Haytham.TransparentTrackBar();
            this.trackBarThresholdEye = new Haytham.TransparentTrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPM = new System.Windows.Forms.RadioButton();
            this.cbPA = new System.Windows.Forms.RadioButton();
            this.cbShowPupil = new System.Windows.Forms.CheckBox();
            this.cbPupilDetection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbShowIris = new System.Windows.Forms.CheckBox();
            this.trackBarControl2 = new Haytham.TransparentTrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage_Scene = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnSceneCameraCalibration = new System.Windows.Forms.Button();
            this.cbSceneUnDistortion = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbShowEdges = new System.Windows.Forms.CheckBox();
            this.trackBarControl3 = new Haytham.TransparentTrackBar();
            this.trackBarG = new Haytham.TransparentTrackBar();
            this.trackBarB = new Haytham.TransparentTrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbShowScreen = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage_Calibration = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbShowGaze = new System.Windows.Forms.CheckBox();
            this.btnCalibration_Homography = new System.Windows.Forms.Button();
            this.btnCalibration_Polynomial = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbPupilGlint = new System.Windows.Forms.RadioButton();
            this.rdOnlyPupil = new System.Windows.Forms.RadioButton();
            this.cbGazeSmoothing = new System.Windows.Forms.CheckBox();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbPlot = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Record = new System.Windows.Forms.ProgressBar();
            this.lblExport = new System.Windows.Forms.Label();
            this.tabPage_Network = new System.Windows.Forms.TabPage();
            this.panelClients = new System.Windows.Forms.GroupBox();
            this.radioButtonAutoActivation = new System.Windows.Forms.RadioButton();
            this.cbMouseSmoothing = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.TextBoxServer = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.imSceneProcessed = new Emgu.CV.UI.ImageBox();
            this.groupBox_imgScene = new System.Windows.Forms.GroupBox();
            this.imScene = new Emgu.CV.UI.ImageBox();
            this.imEyeTest = new Emgu.CV.UI.ImageBox();
            this.groupBox_imgEye = new System.Windows.Forms.GroupBox();
            this.imEye = new Emgu.CV.UI.ImageBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.splitter7 = new System.Windows.Forms.Splitter();
            this.lblIP = new System.Windows.Forms.TextBox();
            this.splitter6 = new System.Windows.Forms.Splitter();
            this.lblDbBlink = new System.Windows.Forms.Label();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.lblBlink = new System.Windows.Forms.Label();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.lblGlintCenter = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.lblPupilCenter = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.comboBox_SceneTimer = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBox_EyeTimer = new System.Windows.Forms.ComboBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Camera.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Eye.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGABlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGAConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdGlint)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPABlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPAConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdEye)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).BeginInit();
            this.tabPage_Scene.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.tabPage_Calibration.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage_Network.SuspendLayout();
            this.panelClients.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imSceneProcessed)).BeginInit();
            this.groupBox_imgScene.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imScene)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imEyeTest)).BeginInit();
            this.groupBox_imgEye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imEye)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox13);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox14);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Size = new System.Drawing.Size(1328, 686);
            this.splitContainer1.SplitterDistance = 242;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 43;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Camera);
            this.tabControl1.Controls.Add(this.tabPage_Eye);
            this.tabControl1.Controls.Add(this.tabPage_Scene);
            this.tabControl1.Controls.Add(this.tabPage_Calibration);
            this.tabControl1.Controls.Add(this.tabPage_Data);
            this.tabControl1.Controls.Add(this.tabPage_Network);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 686);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Camera
            // 
            this.tabPage_Camera.Controls.Add(this.groupBox3);
            this.tabPage_Camera.Controls.Add(this.groupBox2);
            this.tabPage_Camera.Controls.Add(this.groupBox1);
            this.tabPage_Camera.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Camera.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Camera.Name = "tabPage_Camera";
            this.tabPage_Camera.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Camera.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Camera.TabIndex = 0;
            this.tabPage_Camera.Text = "Camera";
            this.tabPage_Camera.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton1);
            this.groupBox3.Controls.Add(this.checkEdit1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 334);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(230, 69);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(99, 18);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(115, 37);
            this.simpleButton1.TabIndex = 55;
            this.simpleButton1.Text = "Start Both";
            this.simpleButton1.UseVisualStyleBackColor = true;
            this.simpleButton1.Click += new System.EventHandler(this.button1_Click_5);
            // 
            // checkEdit1
            // 
            this.checkEdit1.AutoSize = true;
            this.checkEdit1.Checked = true;
            this.checkEdit1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEdit1.Location = new System.Drawing.Point(8, 28);
            this.checkEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Size = new System.Drawing.Size(50, 17);
            this.checkEdit1.TabIndex = 54;
            this.checkEdit1.Text = "Sync";
            this.checkEdit1.UseVisualStyleBackColor = true;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_scene_VFlip);
            this.groupBox2.Controls.Add(this.btnSettingsScene);
            this.groupBox2.Controls.Add(this.btnStartScene);
            this.groupBox2.Controls.Add(this.cmbDeviceCapabilityScene);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbDeviceScene);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(230, 166);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scene Camera";
            // 
            // cb_scene_VFlip
            // 
            this.cb_scene_VFlip.AutoSize = true;
            this.cb_scene_VFlip.Location = new System.Drawing.Point(8, 136);
            this.cb_scene_VFlip.Margin = new System.Windows.Forms.Padding(2);
            this.cb_scene_VFlip.Name = "cb_scene_VFlip";
            this.cb_scene_VFlip.Size = new System.Drawing.Size(80, 17);
            this.cb_scene_VFlip.TabIndex = 57;
            this.cb_scene_VFlip.Text = "Flip Vertical";
            this.cb_scene_VFlip.UseVisualStyleBackColor = true;
            this.cb_scene_VFlip.CheckedChanged += new System.EventHandler(this.cb_scene_VFlip_CheckedChanged);
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
            this.btnSettingsScene.Click += new System.EventHandler(this.button1_Click_4);
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
            this.btnStartScene.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbDeviceCapabilityScene
            // 
            this.cmbDeviceCapabilityScene.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceCapabilityScene.FormattingEnabled = true;
            this.cmbDeviceCapabilityScene.Location = new System.Drawing.Point(59, 46);
            this.cmbDeviceCapabilityScene.Name = "cmbDeviceCapabilityScene";
            this.cmbDeviceCapabilityScene.Size = new System.Drawing.Size(162, 21);
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
            this.cmbDeviceScene.Size = new System.Drawing.Size(172, 21);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_eye_VFlip);
            this.groupBox1.Controls.Add(this.btnSettingsEye);
            this.groupBox1.Controls.Add(this.btnStartEye);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDeviceCapabilityEye);
            this.groupBox1.Controls.Add(this.cmbDeviceEye);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(230, 166);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eye Camera";
            // 
            // cb_eye_VFlip
            // 
            this.cb_eye_VFlip.AutoSize = true;
            this.cb_eye_VFlip.Location = new System.Drawing.Point(8, 133);
            this.cb_eye_VFlip.Margin = new System.Windows.Forms.Padding(2);
            this.cb_eye_VFlip.Name = "cb_eye_VFlip";
            this.cb_eye_VFlip.Size = new System.Drawing.Size(80, 17);
            this.cb_eye_VFlip.TabIndex = 57;
            this.cb_eye_VFlip.Text = "Flip Vertical";
            this.cb_eye_VFlip.UseVisualStyleBackColor = true;
            this.cb_eye_VFlip.CheckedChanged += new System.EventHandler(this.cb_eye_VFlip_CheckedChanged);
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
            this.btnSettingsEye.Click += new System.EventHandler(this.button1_Click_3);
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
            this.btnStartEye.Click += new System.EventHandler(this.button1_Click_1);
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
            this.cmbDeviceCapabilityEye.Size = new System.Drawing.Size(162, 21);
            this.cmbDeviceCapabilityEye.TabIndex = 8;
            // 
            // cmbDeviceEye
            // 
            this.cmbDeviceEye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeviceEye.FormattingEnabled = true;
            this.cmbDeviceEye.Location = new System.Drawing.Point(50, 24);
            this.cmbDeviceEye.Name = "cmbDeviceEye";
            this.cmbDeviceEye.Size = new System.Drawing.Size(172, 21);
            this.cmbDeviceEye.TabIndex = 6;
            this.cmbDeviceEye.DropDown += new System.EventHandler(this.cmbDeviceEye_DropDown);
            this.cmbDeviceEye.SelectedIndexChanged += new System.EventHandler(this.cmbDeviceEye_SelectedIndexChanged);
            // 
            // tabPage_Eye
            // 
            this.tabPage_Eye.Controls.Add(this.groupBox5);
            this.tabPage_Eye.Controls.Add(this.groupBox6);
            this.tabPage_Eye.Controls.Add(this.groupBox4);
            this.tabPage_Eye.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Eye.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Eye.Name = "tabPage_Eye";
            this.tabPage_Eye.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_Eye.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Eye.TabIndex = 1;
            this.tabPage_Eye.Text = "Eye";
            this.tabPage_Eye.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.panel4);
            this.groupBox5.Controls.Add(this.trackBarGAConstant);
            this.groupBox5.Controls.Add(this.trackBarThresholdGlint);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.panel2);
            this.groupBox5.Controls.Add(this.cbShowGlint);
            this.groupBox5.Controls.Add(this.cbGlintDetection);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(2, 248);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(230, 120);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Glint";
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
            // trackBarGAConstant
            // 
            this.trackBarGAConstant.AutoSize = false;
            this.trackBarGAConstant.Location = new System.Drawing.Point(63, 90);
            this.trackBarGAConstant.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarGAConstant.Maximum = 0;
            this.trackBarGAConstant.Minimum = -100;
            this.trackBarGAConstant.Name = "trackBarGAConstant";
            this.trackBarGAConstant.Size = new System.Drawing.Size(146, 24);
            this.trackBarGAConstant.TabIndex = 68;
            this.trackBarGAConstant.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGAConstant.Value = -100;
            this.trackBarGAConstant.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_3);
            // 
            // trackBarThresholdGlint
            // 
            this.trackBarThresholdGlint.AutoSize = false;
            this.trackBarThresholdGlint.Location = new System.Drawing.Point(62, 64);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Sensitivity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Threshold";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbGM);
            this.panel2.Controls.Add(this.cbGA);
            this.panel2.Location = new System.Drawing.Point(14, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 28);
            this.panel2.TabIndex = 61;
            // 
            // cbGM
            // 
            this.cbGM.AutoSize = true;
            this.cbGM.Location = new System.Drawing.Point(105, 6);
            this.cbGM.Margin = new System.Windows.Forms.Padding(2);
            this.cbGM.Name = "cbGM";
            this.cbGM.Size = new System.Drawing.Size(60, 17);
            this.cbGM.TabIndex = 59;
            this.cbGM.Text = "Manual";
            this.cbGM.UseVisualStyleBackColor = true;
            this.cbGM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_2);
            // 
            // cbGA
            // 
            this.cbGA.AutoSize = true;
            this.cbGA.Checked = true;
            this.cbGA.Location = new System.Drawing.Point(28, 6);
            this.cbGA.Margin = new System.Windows.Forms.Padding(2);
            this.cbGA.Name = "cbGA";
            this.cbGA.Size = new System.Drawing.Size(47, 17);
            this.cbGA.TabIndex = 58;
            this.cbGA.TabStop = true;
            this.cbGA.Text = "Auto";
            this.cbGA.UseVisualStyleBackColor = true;
            this.cbGA.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_2);
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
            this.cbGlintDetection.Checked = true;
            this.cbGlintDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGlintDetection.Location = new System.Drawing.Point(31, -1);
            this.cbGlintDetection.Margin = new System.Windows.Forms.Padding(2);
            this.cbGlintDetection.Name = "cbGlintDetection";
            this.cbGlintDetection.Size = new System.Drawing.Size(148, 17);
            this.cbGlintDetection.TabIndex = 56;
            this.cbGlintDetection.UseVisualStyleBackColor = true;
            this.cbGlintDetection.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_7);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.panel3);
            this.groupBox6.Controls.Add(this.cbRemoveGlint);
            this.groupBox6.Controls.Add(this.cbDilateErode);
            this.groupBox6.Controls.Add(this.trackBarPAConstant);
            this.groupBox6.Controls.Add(this.trackBarThresholdEye);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.panel1);
            this.groupBox6.Controls.Add(this.cbShowPupil);
            this.groupBox6.Controls.Add(this.cbPupilDetection);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(2, 72);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(230, 176);
            this.groupBox6.TabIndex = 60;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pupil";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBarPABlockSize);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rbPGaussian);
            this.panel3.Controls.Add(this.rbPMean);
            this.panel3.Location = new System.Drawing.Point(7, 190);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 112);
            this.panel3.TabIndex = 67;
            this.panel3.Visible = false;
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
            // cbRemoveGlint
            // 
            this.cbRemoveGlint.Location = new System.Drawing.Point(8, 150);
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
            this.cbDilateErode.Location = new System.Drawing.Point(8, 128);
            this.cbDilateErode.Margin = new System.Windows.Forms.Padding(2);
            this.cbDilateErode.Name = "cbDilateErode";
            this.cbDilateErode.Size = new System.Drawing.Size(148, 17);
            this.cbDilateErode.TabIndex = 65;
            this.cbDilateErode.Text = "Fill Gaps";
            this.cbDilateErode.UseVisualStyleBackColor = true;
            this.cbDilateErode.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_6);
            // 
            // trackBarPAConstant
            // 
            this.trackBarPAConstant.AutoSize = false;
            this.trackBarPAConstant.Location = new System.Drawing.Point(62, 90);
            this.trackBarPAConstant.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarPAConstant.Maximum = 50;
            this.trackBarPAConstant.Minimum = 5;
            this.trackBarPAConstant.Name = "trackBarPAConstant";
            this.trackBarPAConstant.Size = new System.Drawing.Size(146, 24);
            this.trackBarPAConstant.TabIndex = 64;
            this.trackBarPAConstant.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarPAConstant.Value = 15;
            this.trackBarPAConstant.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_2);
            // 
            // trackBarThresholdEye
            // 
            this.trackBarThresholdEye.AutoSize = false;
            this.trackBarThresholdEye.Location = new System.Drawing.Point(62, 64);
            this.trackBarThresholdEye.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarThresholdEye.Maximum = 255;
            this.trackBarThresholdEye.Name = "trackBarThresholdEye";
            this.trackBarThresholdEye.Size = new System.Drawing.Size(146, 24);
            this.trackBarThresholdEye.TabIndex = 63;
            this.trackBarThresholdEye.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarThresholdEye.Value = 70;
            this.trackBarThresholdEye.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Sensitivity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Threshold";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPM);
            this.panel1.Controls.Add(this.cbPA);
            this.panel1.Location = new System.Drawing.Point(14, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 28);
            this.panel1.TabIndex = 60;
            // 
            // cbPM
            // 
            this.cbPM.AutoSize = true;
            this.cbPM.Location = new System.Drawing.Point(105, 6);
            this.cbPM.Margin = new System.Windows.Forms.Padding(2);
            this.cbPM.Name = "cbPM";
            this.cbPM.Size = new System.Drawing.Size(60, 17);
            this.cbPM.TabIndex = 59;
            this.cbPM.Text = "Manual";
            this.cbPM.UseVisualStyleBackColor = true;
            this.cbPM.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // cbPA
            // 
            this.cbPA.AutoSize = true;
            this.cbPA.Checked = true;
            this.cbPA.Location = new System.Drawing.Point(28, 6);
            this.cbPA.Margin = new System.Windows.Forms.Padding(2);
            this.cbPA.Name = "cbPA";
            this.cbPA.Size = new System.Drawing.Size(47, 17);
            this.cbPA.TabIndex = 58;
            this.cbPA.TabStop = true;
            this.cbPA.Text = "Auto";
            this.cbPA.UseVisualStyleBackColor = true;
            this.cbPA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
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
            this.cbPupilDetection.Location = new System.Drawing.Point(32, -1);
            this.cbPupilDetection.Margin = new System.Windows.Forms.Padding(2);
            this.cbPupilDetection.Name = "cbPupilDetection";
            this.cbPupilDetection.Size = new System.Drawing.Size(148, 17);
            this.cbPupilDetection.TabIndex = 55;
            this.cbPupilDetection.UseVisualStyleBackColor = true;
            this.cbPupilDetection.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_3);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbShowIris);
            this.groupBox4.Controls.Add(this.trackBarControl2);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(230, 70);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
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
            this.cbShowIris.Location = new System.Drawing.Point(194, 24);
            this.cbShowIris.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowIris.Name = "cbShowIris";
            this.cbShowIris.Size = new System.Drawing.Size(14, 18);
            this.cbShowIris.TabIndex = 3;
            this.cbShowIris.UseVisualStyleBackColor = false;
            this.cbShowIris.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_2);
            // 
            // trackBarControl2
            // 
            this.trackBarControl2.AutoSize = false;
            this.trackBarControl2.Location = new System.Drawing.Point(51, 23);
            this.trackBarControl2.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarControl2.Maximum = 500;
            this.trackBarControl2.Minimum = 80;
            this.trackBarControl2.Name = "trackBarControl2";
            this.trackBarControl2.Size = new System.Drawing.Size(146, 27);
            this.trackBarControl2.TabIndex = 2;
            this.trackBarControl2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl2.Value = 220;
            this.trackBarControl2.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "IrisSize";
            // 
            // tabPage_Scene
            // 
            this.tabPage_Scene.Controls.Add(this.groupBox8);
            this.tabPage_Scene.Controls.Add(this.groupBox7);
            this.tabPage_Scene.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Scene.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Scene.Name = "tabPage_Scene";
            this.tabPage_Scene.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Scene.TabIndex = 2;
            this.tabPage_Scene.Text = "Scene";
            this.tabPage_Scene.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnSceneCameraCalibration);
            this.groupBox8.Controls.Add(this.cbSceneUnDistortion);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(0, 136);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox8.Size = new System.Drawing.Size(234, 76);
            this.groupBox8.TabIndex = 63;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Camera Calibration";
            // 
            // btnSceneCameraCalibration
            // 
            this.btnSceneCameraCalibration.Location = new System.Drawing.Point(110, 21);
            this.btnSceneCameraCalibration.Margin = new System.Windows.Forms.Padding(2);
            this.btnSceneCameraCalibration.Name = "btnSceneCameraCalibration";
            this.btnSceneCameraCalibration.Size = new System.Drawing.Size(100, 35);
            this.btnSceneCameraCalibration.TabIndex = 59;
            this.btnSceneCameraCalibration.Text = "Calibrate the Camera";
            this.btnSceneCameraCalibration.UseVisualStyleBackColor = true;
            this.btnSceneCameraCalibration.Click += new System.EventHandler(this.button1_Click_6);
            // 
            // cbSceneUnDistortion
            // 
            this.cbSceneUnDistortion.Location = new System.Drawing.Point(13, 31);
            this.cbSceneUnDistortion.Margin = new System.Windows.Forms.Padding(2);
            this.cbSceneUnDistortion.Name = "cbSceneUnDistortion";
            this.cbSceneUnDistortion.Size = new System.Drawing.Size(80, 17);
            this.cbSceneUnDistortion.TabIndex = 58;
            this.cbSceneUnDistortion.Text = "Undistortion ";
            this.cbSceneUnDistortion.UseVisualStyleBackColor = true;
            this.cbSceneUnDistortion.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_11);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbShowEdges);
            this.groupBox7.Controls.Add(this.trackBarControl3);
            this.groupBox7.Controls.Add(this.trackBarG);
            this.groupBox7.Controls.Add(this.trackBarB);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.cbShowScreen);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(234, 136);
            this.groupBox7.TabIndex = 62;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Screen Detection";
            // 
            // cbShowEdges
            // 
            this.cbShowEdges.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbShowEdges.BackColor = System.Drawing.Color.White;
            this.cbShowEdges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbShowEdges.BackgroundImage")));
            this.cbShowEdges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbShowEdges.FlatAppearance.BorderSize = 0;
            this.cbShowEdges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowEdges.Location = new System.Drawing.Point(184, 0);
            this.cbShowEdges.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowEdges.Name = "cbShowEdges";
            this.cbShowEdges.Size = new System.Drawing.Size(14, 18);
            this.cbShowEdges.TabIndex = 68;
            this.cbShowEdges.UseVisualStyleBackColor = false;
            this.cbShowEdges.CheckedChanged += new System.EventHandler(this.cbShowEdges_CheckedChanged);
            // 
            // trackBarControl3
            // 
            this.trackBarControl3.AutoSize = false;
            this.trackBarControl3.Location = new System.Drawing.Point(65, 87);
            this.trackBarControl3.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarControl3.Maximum = 100;
            this.trackBarControl3.Minimum = 5;
            this.trackBarControl3.Name = "trackBarControl3";
            this.trackBarControl3.Size = new System.Drawing.Size(146, 24);
            this.trackBarControl3.TabIndex = 67;
            this.trackBarControl3.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarControl3.Value = 30;
            this.trackBarControl3.ValueChanged += new System.EventHandler(this.transparentTrackBar3_ValueChanged);
            this.trackBarControl3.MouseEnter += new System.EventHandler(this.trackBarControl3_MouseEnter);
            this.trackBarControl3.MouseLeave += new System.EventHandler(this.trackBarControl3_MouseLeave);
            // 
            // trackBarG
            // 
            this.trackBarG.AutoSize = false;
            this.trackBarG.Location = new System.Drawing.Point(65, 58);
            this.trackBarG.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarG.Maximum = 360;
            this.trackBarG.Minimum = 5;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(146, 24);
            this.trackBarG.TabIndex = 66;
            this.trackBarG.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarG.Value = 290;
            this.trackBarG.ValueChanged += new System.EventHandler(this.transparentTrackBar2_ValueChanged_1);
            // 
            // trackBarB
            // 
            this.trackBarB.AutoSize = false;
            this.trackBarB.Location = new System.Drawing.Point(65, 30);
            this.trackBarB.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarB.Maximum = 360;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(146, 24);
            this.trackBarB.TabIndex = 65;
            this.trackBarB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarB.Value = 70;
            this.trackBarB.ValueChanged += new System.EventHandler(this.transparentTrackBar1_ValueChanged_5);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 91);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Min Size";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 60);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Thresh2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Thresh1";
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
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(90, -1);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_9);
            // 
            // tabPage_Calibration
            // 
            this.tabPage_Calibration.Controls.Add(this.groupBox15);
            this.tabPage_Calibration.Controls.Add(this.groupBox9);
            this.tabPage_Calibration.Controls.Add(this.panel5);
            this.tabPage_Calibration.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Calibration.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Calibration.Name = "tabPage_Calibration";
            this.tabPage_Calibration.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Calibration.TabIndex = 3;
            this.tabPage_Calibration.Text = "Calibration";
            this.tabPage_Calibration.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.checkBox3);
            this.groupBox15.Controls.Add(this.button1);
            this.groupBox15.Controls.Add(this.button2);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(0, 199);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(234, 127);
            this.groupBox15.TabIndex = 3;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Gaze Estimation in the remote display";
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(7, 95);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(148, 17);
            this.checkBox3.TabIndex = 68;
            this.checkBox3.Text = "Control Cursor";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
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
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.cbShowGaze);
            this.groupBox9.Controls.Add(this.btnCalibration_Homography);
            this.groupBox9.Controls.Add(this.btnCalibration_Polynomial);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox9.Location = new System.Drawing.Point(0, 52);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(234, 147);
            this.groupBox9.TabIndex = 61;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gaze Estimation in the scene image";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 115);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 68;
            this.label17.Text = "Show Gaze Point";
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
            this.cbShowGaze.Location = new System.Drawing.Point(5, 111);
            this.cbShowGaze.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowGaze.Name = "cbShowGaze";
            this.cbShowGaze.Size = new System.Drawing.Size(14, 18);
            this.cbShowGaze.TabIndex = 67;
            this.cbShowGaze.UseVisualStyleBackColor = false;
            this.cbShowGaze.CheckedChanged += new System.EventHandler(this.cbShowGaze_CheckedChanged_2);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.rbPupilGlint);
            this.panel5.Controls.Add(this.rdOnlyPupil);
            this.panel5.Controls.Add(this.cbGazeSmoothing);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 52);
            this.panel5.TabIndex = 61;
            // 
            // rbPupilGlint
            // 
            this.rbPupilGlint.AutoSize = true;
            this.rbPupilGlint.Checked = true;
            this.rbPupilGlint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbPupilGlint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbPupilGlint.Location = new System.Drawing.Point(93, 5);
            this.rbPupilGlint.Margin = new System.Windows.Forms.Padding(2);
            this.rbPupilGlint.Name = "rbPupilGlint";
            this.rbPupilGlint.Size = new System.Drawing.Size(106, 17);
            this.rbPupilGlint.TabIndex = 59;
            this.rbPupilGlint.TabStop = true;
            this.rbPupilGlint.Text = "Pupil-Glint Vector";
            this.rbPupilGlint.UseVisualStyleBackColor = true;
            this.rbPupilGlint.Visible = false;
            this.rbPupilGlint.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_5);
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
            this.rdOnlyPupil.Visible = false;
            this.rdOnlyPupil.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_5);
            // 
            // cbGazeSmoothing
            // 
            this.cbGazeSmoothing.Checked = true;
            this.cbGazeSmoothing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGazeSmoothing.Location = new System.Drawing.Point(8, 26);
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
            this.tabPage_Data.Controls.Add(this.groupBox11);
            this.tabPage_Data.Controls.Add(this.groupBox10);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Data.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Data.TabIndex = 4;
            this.tabPage_Data.Text = "Data";
            this.tabPage_Data.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chart3);
            this.groupBox11.Controls.Add(this.cbPlot);
            this.groupBox11.Controls.Add(this.chart2);
            this.groupBox11.Controls.Add(this.chart1);
            this.groupBox11.Location = new System.Drawing.Point(4, 119);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox11.Size = new System.Drawing.Size(224, 442);
            this.groupBox11.TabIndex = 63;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Plot";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 86.87582F;
            chartArea1.InnerPlotPosition.Width = 86.45924F;
            chartArea1.InnerPlotPosition.X = 13.54076F;
            chartArea1.InnerPlotPosition.Y = 6.56209F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80.00502F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 16.99498F;
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart3.Location = new System.Drawing.Point(2, 294);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.EmptyPointStyle.BorderWidth = 0;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series1.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series1.EmptyPointStyle.IsVisibleInLegend = false;
            series1.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series1.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series1.EmptyPointStyle.MarkerSize = 1;
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series1.Name = "PupilDiam";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(220, 141);
            this.chart3.TabIndex = 47;
            this.chart3.Text = "chart3";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "PupilDiam";
            title1.Position.Auto = false;
            title1.Position.Height = 10.99498F;
            title1.Position.Width = 94F;
            title1.Position.X = 3F;
            title1.Position.Y = 3F;
            title1.Text = "Pupil Diameter";
            this.chart3.Titles.Add(title1);
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
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Interval = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 86.87582F;
            chartArea2.InnerPlotPosition.Width = 86.45924F;
            chartArea2.InnerPlotPosition.X = 13.54076F;
            chartArea2.InnerPlotPosition.Y = 6.56209F;
            chartArea2.Name = "ChartArea1";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80.00502F;
            chartArea2.Position.Width = 94F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 16.99498F;
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart2.Location = new System.Drawing.Point(2, 153);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.EmptyPointStyle.BorderWidth = 0;
            series2.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series2.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series2.EmptyPointStyle.IsVisibleInLegend = false;
            series2.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series2.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series2.EmptyPointStyle.MarkerSize = 1;
            series2.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series2.Name = "PupilY";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(220, 141);
            this.chart2.TabIndex = 46;
            this.chart2.Text = "chart2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "PupilY";
            title2.Position.Auto = false;
            title2.Position.Height = 10.99498F;
            title2.Position.Width = 94F;
            title2.Position.X = 3F;
            title2.Position.Y = 3F;
            title2.Text = "Pupil Y";
            this.chart2.Titles.Add(title2);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Interval = 0D;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 86.83621F;
            chartArea3.InnerPlotPosition.Width = 86.45924F;
            chartArea3.InnerPlotPosition.X = 13.54076F;
            chartArea3.InnerPlotPosition.Y = 6.5819F;
            chartArea3.Name = "ChartArea1";
            chartArea3.Position.Auto = false;
            chartArea3.Position.Height = 79.76426F;
            chartArea3.Position.Width = 94F;
            chartArea3.Position.X = 3F;
            chartArea3.Position.Y = 17.23574F;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            this.chart1.Location = new System.Drawing.Point(2, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.EmptyPointStyle.BorderWidth = 0;
            series3.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series3.EmptyPointStyle.CustomProperties = "LabelStyle=Top";
            series3.EmptyPointStyle.IsVisibleInLegend = false;
            series3.EmptyPointStyle.MarkerColor = System.Drawing.Color.Red;
            series3.EmptyPointStyle.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            series3.EmptyPointStyle.MarkerSize = 1;
            series3.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Cross;
            series3.Name = "PupilX";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(220, 138);
            this.chart1.TabIndex = 45;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "PupilX";
            title3.Position.Auto = false;
            title3.Position.Height = 11.23574F;
            title3.Position.Width = 94F;
            title3.Position.X = 3F;
            title3.Position.Y = 3F;
            title3.Text = "Pupil X";
            this.chart1.Titles.Add(title3);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panel7);
            this.groupBox10.Location = new System.Drawing.Point(4, 5);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(224, 102);
            this.groupBox10.TabIndex = 63;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Record Videos and EyeData";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Record);
            this.panel7.Controls.Add(this.lblExport);
            this.panel7.Location = new System.Drawing.Point(26, 22);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 66);
            this.panel7.TabIndex = 67;
            // 
            // btn_Record
            // 
            this.btn_Record.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Record.ForeColor = System.Drawing.Color.Red;
            this.btn_Record.Location = new System.Drawing.Point(43, 22);
            this.btn_Record.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Record.MarqueeAnimationSpeed = 10;
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(86, 43);
            this.btn_Record.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.btn_Record.TabIndex = 0;
            this.btn_Record.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblExport
            // 
            this.lblExport.BackColor = System.Drawing.Color.Transparent;
            this.lblExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExport.Enabled = false;
            this.lblExport.Location = new System.Drawing.Point(0, 0);
            this.lblExport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(172, 18);
            this.lblExport.TabIndex = 66;
            this.lblExport.Text = "Export";
            this.lblExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tabPage_Network
            // 
            this.tabPage_Network.Controls.Add(this.panelClients);
            this.tabPage_Network.Controls.Add(this.groupBox12);
            this.tabPage_Network.Location = new System.Drawing.Point(4, 40);
            this.tabPage_Network.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_Network.Name = "tabPage_Network";
            this.tabPage_Network.Size = new System.Drawing.Size(234, 642);
            this.tabPage_Network.TabIndex = 5;
            this.tabPage_Network.Text = "Network";
            this.tabPage_Network.UseVisualStyleBackColor = true;
            // 
            // panelClients
            // 
            this.panelClients.AutoSize = true;
            this.panelClients.Controls.Add(this.radioButtonAutoActivation);
            this.panelClients.Controls.Add(this.cbMouseSmoothing);
            this.panelClients.Controls.Add(this.checkBox4);
            this.panelClients.Location = new System.Drawing.Point(2, 240);
            this.panelClients.Margin = new System.Windows.Forms.Padding(2);
            this.panelClients.Name = "panelClients";
            this.panelClients.Padding = new System.Windows.Forms.Padding(2);
            this.panelClients.Size = new System.Drawing.Size(223, 85);
            this.panelClients.TabIndex = 64;
            this.panelClients.TabStop = false;
            this.panelClients.Text = "Clients";
            // 
            // radioButtonAutoActivation
            // 
            this.radioButtonAutoActivation.AutoSize = true;
            this.radioButtonAutoActivation.Checked = true;
            this.radioButtonAutoActivation.Location = new System.Drawing.Point(120, 50);
            this.radioButtonAutoActivation.Name = "radioButtonAutoActivation";
            this.radioButtonAutoActivation.Size = new System.Drawing.Size(97, 17);
            this.radioButtonAutoActivation.TabIndex = 0;
            this.radioButtonAutoActivation.TabStop = true;
            this.radioButtonAutoActivation.Text = "Auto Activation";
            this.radioButtonAutoActivation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonAutoActivation.UseVisualStyleBackColor = true;
            this.radioButtonAutoActivation.CheckedChanged += new System.EventHandler(this.radioButtonAutoActivation_CheckedChanged);
            // 
            // cbMouseSmoothing
            // 
            this.cbMouseSmoothing.Location = new System.Drawing.Point(106, 27);
            this.cbMouseSmoothing.Margin = new System.Windows.Forms.Padding(2);
            this.cbMouseSmoothing.Name = "cbMouseSmoothing";
            this.cbMouseSmoothing.Size = new System.Drawing.Size(111, 17);
            this.cbMouseSmoothing.TabIndex = 60;
            this.cbMouseSmoothing.Text = "Mouse Smoothing";
            this.cbMouseSmoothing.UseVisualStyleBackColor = true;
            this.cbMouseSmoothing.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_16);
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(4, 27);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 59;
            this.checkBox4.Text = "Control Client Mouse";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_15);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.TextBoxServer);
            this.groupBox12.Location = new System.Drawing.Point(2, 5);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox12.Size = new System.Drawing.Size(225, 230);
            this.groupBox12.TabIndex = 63;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Messages ";
            // 
            // TextBoxServer
            // 
            this.TextBoxServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxServer.Location = new System.Drawing.Point(2, 15);
            this.TextBoxServer.Multiline = true;
            this.TextBoxServer.Name = "TextBoxServer";
            this.TextBoxServer.ReadOnly = true;
            this.TextBoxServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxServer.Size = new System.Drawing.Size(221, 213);
            this.TextBoxServer.TabIndex = 38;
            // 
            // groupBox13
            // 
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(284, 24);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox13.Size = new System.Drawing.Size(799, 250);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            // 
            // groupBox14
            // 
            this.groupBox14.AutoSize = true;
            this.groupBox14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox14.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox14.Controls.Add(this.imSceneProcessed);
            this.groupBox14.Controls.Add(this.groupBox_imgScene);
            this.groupBox14.Controls.Add(this.imEyeTest);
            this.groupBox14.Controls.Add(this.groupBox_imgEye);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox14.Location = new System.Drawing.Point(0, 24);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox14.Size = new System.Drawing.Size(284, 662);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            // 
            // imSceneProcessed
            // 
            this.imSceneProcessed.Dock = System.Windows.Forms.DockStyle.Left;
            this.imSceneProcessed.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imSceneProcessed.Location = new System.Drawing.Point(204, 15);
            this.imSceneProcessed.Name = "imSceneProcessed";
            this.imSceneProcessed.Size = new System.Drawing.Size(78, 645);
            this.imSceneProcessed.TabIndex = 69;
            this.imSceneProcessed.TabStop = false;
            // 
            // groupBox_imgScene
            // 
            this.groupBox_imgScene.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_imgScene.Controls.Add(this.imScene);
            this.groupBox_imgScene.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_imgScene.Location = new System.Drawing.Point(135, 15);
            this.groupBox_imgScene.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_imgScene.Name = "groupBox_imgScene";
            this.groupBox_imgScene.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_imgScene.Size = new System.Drawing.Size(69, 645);
            this.groupBox_imgScene.TabIndex = 68;
            this.groupBox_imgScene.TabStop = false;
            this.groupBox_imgScene.Text = "Scene";
            // 
            // imScene
            // 
            this.imScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imScene.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imScene.Location = new System.Drawing.Point(2, 15);
            this.imScene.Name = "imScene";
            this.imScene.Size = new System.Drawing.Size(65, 628);
            this.imScene.TabIndex = 63;
            this.imScene.TabStop = false;
            this.imScene.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imScene_MouseClick);
            // 
            // imEyeTest
            // 
            this.imEyeTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.imEyeTest.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imEyeTest.Location = new System.Drawing.Point(76, 15);
            this.imEyeTest.Name = "imEyeTest";
            this.imEyeTest.Size = new System.Drawing.Size(59, 645);
            this.imEyeTest.TabIndex = 70;
            this.imEyeTest.TabStop = false;
            this.imEyeTest.Visible = false;
            // 
            // groupBox_imgEye
            // 
            this.groupBox_imgEye.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_imgEye.Controls.Add(this.imEye);
            this.groupBox_imgEye.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox_imgEye.Location = new System.Drawing.Point(2, 15);
            this.groupBox_imgEye.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_imgEye.Name = "groupBox_imgEye";
            this.groupBox_imgEye.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_imgEye.Size = new System.Drawing.Size(74, 645);
            this.groupBox_imgEye.TabIndex = 67;
            this.groupBox_imgEye.TabStop = false;
            this.groupBox_imgEye.Text = "Eye";
            // 
            // imEye
            // 
            this.imEye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imEye.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imEye.Location = new System.Drawing.Point(2, 15);
            this.imEye.Name = "imEye";
            this.imEye.Size = new System.Drawing.Size(70, 628);
            this.imEye.TabIndex = 2;
            this.imEye.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.splitter7);
            this.panel6.Controls.Add(this.lblIP);
            this.panel6.Controls.Add(this.splitter6);
            this.panel6.Controls.Add(this.lblDbBlink);
            this.panel6.Controls.Add(this.splitter5);
            this.panel6.Controls.Add(this.lblBlink);
            this.panel6.Controls.Add(this.splitter4);
            this.panel6.Controls.Add(this.lblGlintCenter);
            this.panel6.Controls.Add(this.splitter3);
            this.panel6.Controls.Add(this.lblPupilCenter);
            this.panel6.Controls.Add(this.splitter2);
            this.panel6.Controls.Add(this.comboBox_SceneTimer);
            this.panel6.Controls.Add(this.splitter1);
            this.panel6.Controls.Add(this.comboBox_EyeTimer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1083, 24);
            this.panel6.TabIndex = 0;
            // 
            // splitter7
            // 
            this.splitter7.Location = new System.Drawing.Point(748, 0);
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
            this.lblIP.Location = new System.Drawing.Point(620, 0);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2);
            this.lblIP.Multiline = true;
            this.lblIP.Name = "lblIP";
            this.lblIP.ReadOnly = true;
            this.lblIP.Size = new System.Drawing.Size(128, 24);
            this.lblIP.TabIndex = 72;
            this.lblIP.Text = "Server IP: 000.000.000.000";
            this.lblIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitter6
            // 
            this.splitter6.Location = new System.Drawing.Point(618, 0);
            this.splitter6.Margin = new System.Windows.Forms.Padding(2);
            this.splitter6.Name = "splitter6";
            this.splitter6.Size = new System.Drawing.Size(2, 24);
            this.splitter6.TabIndex = 71;
            this.splitter6.TabStop = false;
            // 
            // lblDbBlink
            // 
            this.lblDbBlink.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDbBlink.Location = new System.Drawing.Point(527, 0);
            this.lblDbBlink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDbBlink.Name = "lblDbBlink";
            this.lblDbBlink.Size = new System.Drawing.Size(91, 24);
            this.lblDbBlink.TabIndex = 70;
            this.lblDbBlink.Text = "DoubleBlink";
            this.lblDbBlink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(525, 0);
            this.splitter5.Margin = new System.Windows.Forms.Padding(2);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(2, 24);
            this.splitter5.TabIndex = 69;
            this.splitter5.TabStop = false;
            // 
            // lblBlink
            // 
            this.lblBlink.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBlink.Location = new System.Drawing.Point(434, 0);
            this.lblBlink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlink.Name = "lblBlink";
            this.lblBlink.Size = new System.Drawing.Size(91, 24);
            this.lblBlink.TabIndex = 68;
            this.lblBlink.Text = "Blink";
            this.lblBlink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(432, 0);
            this.splitter4.Margin = new System.Windows.Forms.Padding(2);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(2, 24);
            this.splitter4.TabIndex = 67;
            this.splitter4.TabStop = false;
            // 
            // lblGlintCenter
            // 
            this.lblGlintCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblGlintCenter.Location = new System.Drawing.Point(341, 0);
            this.lblGlintCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGlintCenter.Name = "lblGlintCenter";
            this.lblGlintCenter.Size = new System.Drawing.Size(91, 24);
            this.lblGlintCenter.TabIndex = 66;
            this.lblGlintCenter.Text = "Glint Center";
            this.lblGlintCenter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(339, 0);
            this.splitter3.Margin = new System.Windows.Forms.Padding(2);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(2, 24);
            this.splitter3.TabIndex = 65;
            this.splitter3.TabStop = false;
            // 
            // lblPupilCenter
            // 
            this.lblPupilCenter.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPupilCenter.Location = new System.Drawing.Point(248, 0);
            this.lblPupilCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPupilCenter.Name = "lblPupilCenter";
            this.lblPupilCenter.Size = new System.Drawing.Size(91, 24);
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
            // comboBox_SceneTimer
            // 
            this.comboBox_SceneTimer.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SceneTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_SceneTimer.FormattingEnabled = true;
            this.comboBox_SceneTimer.Location = new System.Drawing.Point(124, 0);
            this.comboBox_SceneTimer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_SceneTimer.Name = "comboBox_SceneTimer";
            this.comboBox_SceneTimer.Size = new System.Drawing.Size(122, 21);
            this.comboBox_SceneTimer.TabIndex = 62;
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
            // comboBox_EyeTimer
            // 
            this.comboBox_EyeTimer.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_EyeTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_EyeTimer.FormattingEnabled = true;
            this.comboBox_EyeTimer.Location = new System.Drawing.Point(0, 0);
            this.comboBox_EyeTimer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_EyeTimer.Name = "comboBox_EyeTimer";
            this.comboBox_EyeTimer.Size = new System.Drawing.Size(122, 21);
            this.comboBox_EyeTimer.TabIndex = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 686);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Haytham_Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Camera.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Eye.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGABlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGAConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdGlint)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPABlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPAConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThresholdEye)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl2)).EndInit();
            this.tabPage_Scene.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.tabPage_Calibration.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage_Data.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabPage_Network.ResumeLayout(false);
            this.tabPage_Network.PerformLayout();
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imSceneProcessed)).EndInit();
            this.groupBox_imgScene.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imScene)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imEyeTest)).EndInit();
            this.groupBox_imgEye.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imEye)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
      
        private System.Windows.Forms.ComboBox cmbDeviceCapabilityScene;
        private System.Windows.Forms.ComboBox cmbDeviceScene;
        private System.Windows.Forms.ComboBox cmbDeviceCapabilityEye;
        private System.Windows.Forms.ComboBox cmbDeviceEye;
        private System.Windows.Forms.TextBox TextBoxServer;
        private System.Windows.Forms.RadioButton radioButtonAutoActivation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Emgu.CV.UI.ImageBox imEye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStartEye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettingsEye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSettingsScene;
        private System.Windows.Forms.Button btnStartScene;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkEdit1;
        private System.Windows.Forms.Button simpleButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private TransparentTrackBar trackBarControl2;
        private System.Windows.Forms.CheckBox cbShowIris;
        private System.Windows.Forms.CheckBox cbPupilDetection;
        private System.Windows.Forms.CheckBox cbShowPupil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton cbPM;
        private System.Windows.Forms.RadioButton cbPA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private TransparentTrackBar trackBarThresholdEye;
        private TransparentTrackBar trackBarPAConstant;
        private System.Windows.Forms.CheckBox cbRemoveGlint;
        private System.Windows.Forms.CheckBox cbDilateErode;
        private System.Windows.Forms.CheckBox cbGlintDetection;
        private System.Windows.Forms.CheckBox cbShowGlint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton cbGM;
        private System.Windows.Forms.RadioButton cbGA;
        private TransparentTrackBar trackBarGAConstant;
        private TransparentTrackBar trackBarThresholdGlint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
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
        private TransparentTrackBar trackBarControl3;
        private TransparentTrackBar trackBarG;
        private TransparentTrackBar trackBarB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cbSceneUnDistortion;
        private System.Windows.Forms.Button btnSceneCameraCalibration;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbPupilGlint;
        private System.Windows.Forms.RadioButton rdOnlyPupil;
        private System.Windows.Forms.Button btnCalibration_Homography;
        private System.Windows.Forms.Button btnCalibration_Polynomial;
        private System.Windows.Forms.CheckBox cbGazeSmoothing;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbShowGaze;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ProgressBar btn_Record;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox cbPlot;
        private System.Windows.Forms.GroupBox panelClients;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox cbMouseSmoothing;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Camera;
        private System.Windows.Forms.TabPage tabPage_Eye;
        private System.Windows.Forms.TabPage tabPage_Scene;
        private System.Windows.Forms.TabPage tabPage_Calibration;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.TabPage tabPage_Network;
        private System.Windows.Forms.GroupBox groupBox14;    
       private System.Windows.Forms.Panel panel6;

        private System.Windows.Forms.ComboBox comboBox_EyeTimer;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ComboBox comboBox_SceneTimer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter7;
        private System.Windows.Forms.TextBox lblIP;
        private System.Windows.Forms.Splitter splitter6;
        private System.Windows.Forms.Label lblDbBlink;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Label lblBlink;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Label lblGlintCenter;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label lblPupilCenter;
        private Emgu.CV.UI.ImageBox imScene;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.GroupBox groupBox_imgEye;
        private Emgu.CV.UI.ImageBox imEyeTest;
        private Emgu.CV.UI.ImageBox imSceneProcessed;
        private System.Windows.Forms.GroupBox groupBox_imgScene;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.CheckBox cbShowEdges;
        private System.Windows.Forms.CheckBox cb_eye_VFlip;
        private System.Windows.Forms.CheckBox cb_scene_VFlip;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

