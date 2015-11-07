using GMap.NET.MapProviders;
namespace MultiWiiWinGUI
{
    partial class mainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageFlightDeck = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bBind = new System.Windows.Forms.Button();
            this.b_cal_acc = new System.Windows.Forms.Button();
            this.cb_monitor_rate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_pause = new System.Windows.Forms.Button();
            this.b_cal_mag = new System.Windows.Forms.Button();
            this.l_cycletime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label47 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.labelRSSI = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.labelNoise = new System.Windows.Forms.Label();
            this.labelSentPackets = new System.Windows.Forms.Label();
            this.l_i2cerrors = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReceivedPackets = new System.Windows.Forms.Label();
            this.l_vbatt = new System.Windows.Forms.Label();
            this.labelCRCErrors = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_powersum = new System.Windows.Forms.Label();
            this.tabPageMisson = new System.Windows.Forms.TabPage();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuAddLand = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddJump = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPOI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuSetHead = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuDeleteWP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.createCircleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkAltitudeChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fetchMapTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.cbShowFlightPath = new System.Windows.Forms.CheckBox();
            this.cbShowPos = new System.Windows.Forms.CheckBox();
            this.cbShowWP = new System.Windows.Forms.CheckBox();
            this.cbShowMission = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbMapProviders = new System.Windows.Forms.ComboBox();
            this.b_Clear_Route = new System.Windows.Forms.Button();
            this.spcontMapMain = new System.Windows.Forms.SplitContainer();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.btnMapZoopDown = new System.Windows.Forms.Button();
            this.btnMapZoomUp = new System.Windows.Forms.Button();
            this.lNavError = new System.Windows.Forms.Label();
            this.LMousePos = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.lNavState = new System.Windows.Forms.Label();
            this.lGpsMode = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.cbSendGTCAlt = new System.Windows.Forms.CheckBox();
            this.txtGTCAlt = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.bClickToGo = new System.Windows.Forms.Button();
            this.l_GPS_numsat = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.l_GPS_alt = new System.Windows.Forms.Label();
            this.lGPS_lon = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lGPS_lat = new System.Windows.Forms.Label();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.missionDataGrid = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Par1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Par3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LATCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LONCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTCOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label75 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lDistLastWP = new System.Windows.Forms.Label();
            this.btnLoadMission = new System.Windows.Forms.Button();
            this.btnSaveMission = new System.Windows.Forms.Button();
            this.btnDownLoadMission = new System.Windows.Forms.Button();
            this.btnUploadMission = new System.Windows.Forms.Button();
            this.txtDefAlt = new System.Windows.Forms.TextBox();
            this.lDistance = new System.Windows.Forms.Label();
            this.lDefAlt = new System.Windows.Forms.Label();
            this.tabPagePID = new System.Windows.Forms.TabPage();
            this.naviGroup = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.nLandSpeed = new System.Windows.Forms.NumericUpDown();
            this.label71 = new System.Windows.Forms.Label();
            this.nFence = new System.Windows.Forms.NumericUpDown();
            this.label88 = new System.Windows.Forms.Label();
            this.nBanking = new System.Windows.Forms.NumericUpDown();
            this.label87 = new System.Windows.Forms.Label();
            this.nCrosstrack = new System.Windows.Forms.NumericUpDown();
            this.label86 = new System.Windows.Forms.Label();
            this.nRTHAlt = new System.Windows.Forms.NumericUpDown();
            this.label85 = new System.Windows.Forms.Label();
            this.nMinSpeed = new System.Windows.Forms.NumericUpDown();
            this.nWPRadius = new System.Windows.Forms.NumericUpDown();
            this.label84 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.nMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.nSafeWPDist = new System.Windows.Forms.NumericUpDown();
            this.label83 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.nMaxAlt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nTEXPO = new System.Windows.Forms.NumericUpDown();
            this.nTMID = new System.Windows.Forms.NumericUpDown();
            this.trackBar_T_EXPO = new System.Windows.Forms.TrackBar();
            this.trackBar_T_MID = new System.Windows.Forms.TrackBar();
            this.trackbar_RC_Rate = new System.Windows.Forms.TrackBar();
            this.label65 = new System.Windows.Forms.Label();
            this.trackbar_RC_Expo = new System.Windows.Forms.TrackBar();
            this.nRCRate = new System.Windows.Forms.NumericUpDown();
            this.nRCExpo = new System.Windows.Forms.NumericUpDown();
            this.label66 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label_sok = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.nRATE_tpid = new System.Windows.Forms.NumericUpDown();
            this.nRATE_yaw = new System.Windows.Forms.NumericUpDown();
            this.nRATE_rp = new System.Windows.Forms.NumericUpDown();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.lVBatConf = new System.Windows.Forms.Label();
            this.labelvbat = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label58 = new System.Windows.Forms.Label();
            this.lMaxThr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.nFSThr = new System.Windows.Forms.NumericUpDown();
            this.label59 = new System.Windows.Forms.Label();
            this.nMinThr = new System.Windows.Forms.NumericUpDown();
            this.lMinCommand = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label62 = new System.Windows.Forms.Label();
            this.lLife = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.lArms = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label68 = new System.Windows.Forms.Label();
            this.nVBatCritical = new System.Windows.Forms.NumericUpDown();
            this.nPAlarm = new System.Windows.Forms.NumericUpDown();
            this.nVBatWarn2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nVBatWarn1 = new System.Windows.Forms.NumericUpDown();
            this.label63 = new System.Windows.Forms.Label();
            this.nVBatScale = new System.Windows.Forms.NumericUpDown();
            this.label64 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbMagSign = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.nMagDeg = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.nMagMin = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nSrvRate4 = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.nSrvMax8 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMax7 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMax6 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID1 = new System.Windows.Forms.Label();
            this.nSrvMax5 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID2 = new System.Windows.Forms.Label();
            this.nSrvMax4 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID3 = new System.Windows.Forms.Label();
            this.nSrvMax3 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID4 = new System.Windows.Forms.Label();
            this.nSrvMax2 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID5 = new System.Windows.Forms.Label();
            this.nSrvMax1 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID6 = new System.Windows.Forms.Label();
            this.nSrvMid8 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID7 = new System.Windows.Forms.Label();
            this.nSrvMid7 = new System.Windows.Forms.NumericUpDown();
            this.lSrvID8 = new System.Windows.Forms.Label();
            this.nSrvMid6 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName1 = new System.Windows.Forms.Label();
            this.nSrvMid5 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName3 = new System.Windows.Forms.Label();
            this.nSrvMid4 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName2 = new System.Windows.Forms.Label();
            this.nSrvMid3 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName4 = new System.Windows.Forms.Label();
            this.nSrvMid2 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName5 = new System.Windows.Forms.Label();
            this.nSrvMid1 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName6 = new System.Windows.Forms.Label();
            this.nSrvMin8 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName7 = new System.Windows.Forms.Label();
            this.nSrvMin7 = new System.Windows.Forms.NumericUpDown();
            this.lSrvName8 = new System.Windows.Forms.Label();
            this.nSrvMin6 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate1 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin5 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate2 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin4 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate3 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin3 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate5 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin2 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate6 = new System.Windows.Forms.NumericUpDown();
            this.nSrvMin1 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate7 = new System.Windows.Forms.NumericUpDown();
            this.nSrvRate8 = new System.Windows.Forms.NumericUpDown();
            this.tabPageRC = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabSensorGraph = new System.Windows.Forms.TabPage();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.zgMonitor = new ZedGraph.ZedGraphControl();
            this.label28 = new System.Windows.Forms.Label();
            this.cb_dbg1 = new System.Windows.Forms.CheckBox();
            this.l_dbg1 = new System.Windows.Forms.Label();
            this.cb_dbg2 = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.l_dbg2 = new System.Windows.Forms.Label();
            this.cb_dbg3 = new System.Windows.Forms.CheckBox();
            this.l_dbg4 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.l_dbg3 = new System.Windows.Forms.Label();
            this.cb_dbg4 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_ACC = new System.Windows.Forms.Button();
            this.b_check_all_ACC = new System.Windows.Forms.Button();
            this.l_acc_z = new System.Windows.Forms.Label();
            this.l_acc_pitch = new System.Windows.Forms.Label();
            this.l_acc_roll = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_acc_z = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_acc_pitch = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_acc_roll = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_GYRO = new System.Windows.Forms.Button();
            this.b_check_all_GYRO = new System.Windows.Forms.Button();
            this.l_gyro_yaw = new System.Windows.Forms.Label();
            this.l_gyro_pitch = new System.Windows.Forms.Label();
            this.l_gyro_roll = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cb_gyro_yaw = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cb_gyro_pitch = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cb_gyro_roll = new System.Windows.Forms.CheckBox();
            this.cb_alt = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_uncheck_all_MAG = new System.Windows.Forms.Button();
            this.b_check_all_MAG = new System.Windows.Forms.Button();
            this.l_mag_yaw = new System.Windows.Forms.Label();
            this.l_mag_pitch = new System.Windows.Forms.Label();
            this.l_mag_roll = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cb_mag_yaw = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cb_mag_pitch = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cb_mag_roll = new System.Windows.Forms.CheckBox();
            this.l_alt = new System.Windows.Forms.Label();
            this.cb_head = new System.Windows.Forms.CheckBox();
            this.l_head = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPageVideo = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.dropdown_devices = new System.Windows.Forms.ComboBox();
            this.b_video_connect = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.b_Record = new System.Windows.Forms.Button();
            this.cb_codec = new System.Windows.Forms.ComboBox();
            this.nFrameRate = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nBitRate = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.l_capture_file = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label42 = new System.Windows.Forms.Label();
            this.comboSpeakInterval = new System.Windows.Forms.ComboBox();
            this.cbSpeakDist = new System.Windows.Forms.CheckBox();
            this.cbSpeakAlt = new System.Windows.Forms.CheckBox();
            this.cbSpeakBattery = new System.Windows.Forms.CheckBox();
            this.cbGUISpeechEnabled = new System.Windows.Forms.CheckBox();
            this.cbCellcount = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.l_i2cdatasupress = new System.Windows.Forms.Label();
            this.b_check_update = new System.Windows.Forms.Button();
            this.b_select_settings_folder = new System.Windows.Forms.Button();
            this.l_Settings_folder = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cb_Log10 = new System.Windows.Forms.CheckBox();
            this.cb_Log9 = new System.Windows.Forms.CheckBox();
            this.cb_Log8 = new System.Windows.Forms.CheckBox();
            this.cb_Log7 = new System.Windows.Forms.CheckBox();
            this.cb_Log6 = new System.Windows.Forms.CheckBox();
            this.cb_Log5 = new System.Windows.Forms.CheckBox();
            this.cb_Log4 = new System.Windows.Forms.CheckBox();
            this.cb_Log3 = new System.Windows.Forms.CheckBox();
            this.cb_Log2 = new System.Windows.Forms.CheckBox();
            this.cb_Log1 = new System.Windows.Forms.CheckBox();
            this.b_save_gui_settings = new System.Windows.Forms.Button();
            this.cb_Logging_enabled = new System.Windows.Forms.CheckBox();
            this.b_select_capture_folder = new System.Windows.Forms.Button();
            this.l_Capture_folder = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.b_select_log_folder = new System.Windows.Forms.Button();
            this.l_LogFolder = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPageCLI = new System.Windows.Forms.TabPage();
            this.gbTerminal = new System.Windows.Forms.GroupBox();
            this.cmdCLISend = new System.Windows.Forms.Button();
            this.txtCLICommand = new System.Windows.Forms.TextBox();
            this.txtCLIResult = new System.Windows.Forms.TextBox();
            this.timer_realtime = new System.Windows.Forms.Timer(this.components);
            this.bkgWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_serial_port = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cb_serial_speed = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.timer_announce = new System.Windows.Forms.Timer(this.components);
            this.battery_indicator1 = new MultiWiiGUIControls.battery_indicator();
            this.vertical_speed_indicator1 = new MultiWiiGUIControls.vertical_speed_indicator();
            this.altitude_meter1 = new MultiWiiGUIControls.altitude_meter();
            this.attitudeIndicatorInstrumentControl1 = new MultiWiiGUIControls.artifical_horizon();
            this.gpsIndicator = new MultiWiiGUIControls.GpsIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new MultiWiiGUIControls.heading_indicator();
            this.rc_input_control1 = new MultiWiiGUIControls.rc_input_control();
            this.motorsIndicator1 = new MultiWiiGUIControls.MWGUIMotors();
            this.indACC = new MultiWiiGUIControls.indicator_lamp();
            this.indGPS = new MultiWiiGUIControls.indicator_lamp();
            this.indOPTIC = new MultiWiiGUIControls.indicator_lamp();
            this.indBARO = new MultiWiiGUIControls.indicator_lamp();
            this.indMAG = new MultiWiiGUIControls.indicator_lamp();
            this.indSONAR = new MultiWiiGUIControls.indicator_lamp();
            this.barNoise = new MultiWiiGUIControls.ColorProgressBar();
            this.barRSSI = new MultiWiiGUIControls.ColorProgressBar();
            this.battery_indicator2 = new MultiWiiGUIControls.battery_indicator();
            this.barRSSIMission = new MultiWiiGUIControls.ColorProgressBar();
            this.cbAutoPan = new MultiWiiGUIControls.CheckBoxEx();
            this.cbShowGauges = new MultiWiiGUIControls.CheckBoxEx();
            this.altitude_meter2 = new MultiWiiGUIControls.altitude_meter();
            this.vertical_speed_indicator2 = new MultiWiiGUIControls.vertical_speed_indicator();
            this.gpsIndicator2 = new MultiWiiGUIControls.GpsIndicatorInstrumentControl();
            this.cbNavBaroTakeover = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavDisableSticks = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavGPS_filtering = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavGPS_Lead = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavResetHome = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavHeadingControl = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavTailFirst = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavRTHHead = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavWaitRTHAlt = new MultiWiiGUIControls.CheckBoxEx();
            this.cbNavSlowNav = new MultiWiiGUIControls.CheckBoxEx();
            this.throttle_expo_control1 = new MultiWiiGUIControls.throttle_expo_control();
            this.rc_expo_control1 = new MultiWiiGUIControls.rc_expo_control();
            this.cbSrvRev1 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev2 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev3 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev4 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev5 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev6 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev7 = new MultiWiiGUIControls.CheckBoxEx();
            this.cbSrvRev8 = new MultiWiiGUIControls.CheckBoxEx();
            this.rci_Control_settings = new MultiWiiGUIControls.rc_input_control();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tsMenuAddWP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPosholdTimed = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddPosholdUnlim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAddRTH = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UP = new System.Windows.Forms.DataGridViewImageColumn();
            this.Down = new System.Windows.Forms.DataGridViewImageColumn();
            this.DEL = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_connect = new System.Windows.Forms.ToolStripButton();
            this.b_read_settings = new System.Windows.Forms.ToolStripButton();
            this.b_write_settings = new System.Windows.Forms.ToolStripButton();
            this.b_reset = new System.Windows.Forms.ToolStripButton();
            this.b_load_from_file = new System.Windows.Forms.ToolStripButton();
            this.b_write_to_file = new System.Windows.Forms.ToolStripButton();
            this.b_log = new System.Windows.Forms.ToolStripButton();
            this.b_start_KML_log = new System.Windows.Forms.ToolStripButton();
            this.b_log_browser = new System.Windows.Forms.ToolStripButton();
            this.b_about = new System.Windows.Forms.ToolStripButton();
            this.bDebugWindws = new System.Windows.Forms.ToolStripButton();
            this.tabMain.SuspendLayout();
            this.tabPageFlightDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPageMisson.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcontMapMain)).BeginInit();
            this.spcontMapMain.Panel1.SuspendLayout();
            this.spcontMapMain.Panel2.SuspendLayout();
            this.spcontMapMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missionDataGrid)).BeginInit();
            this.tabPagePID.SuspendLayout();
            this.naviGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLandSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrosstrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRTHAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWPRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSafeWPDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTEXPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_EXPO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_MID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Rate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Expo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCExpo)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_tpid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_rp)).BeginInit();
            this.tabPageConf.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFSThr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinThr)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatScale)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMagDeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMagMin)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate8)).BeginInit();
            this.tabPageRC.SuspendLayout();
            this.tabSensorGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFrameRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBitRate)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPageCLI.SuspendLayout();
            this.gbTerminal.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Controls.Add(this.tabPageFlightDeck);
            this.tabMain.Controls.Add(this.tabPageMisson);
            this.tabMain.Controls.Add(this.tabPagePID);
            this.tabMain.Controls.Add(this.tabPageConf);
            this.tabMain.Controls.Add(this.tabPageRC);
            this.tabMain.Controls.Add(this.tabSensorGraph);
            this.tabMain.Controls.Add(this.tabPageVideo);
            this.tabMain.Controls.Add(this.tabPageSettings);
            this.tabMain.Controls.Add(this.tabPageCLI);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabPageFlightDeck
            // 
            resources.ApplyResources(this.tabPageFlightDeck, "tabPageFlightDeck");
            this.tabPageFlightDeck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageFlightDeck.Controls.Add(this.splitContainer1);
            this.tabPageFlightDeck.ForeColor = System.Drawing.Color.White;
            this.tabPageFlightDeck.Name = "tabPageFlightDeck";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.bBind);
            this.splitContainer1.Panel1.Controls.Add(this.b_cal_acc);
            this.splitContainer1.Panel1.Controls.Add(this.cb_monitor_rate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.b_pause);
            this.splitContainer1.Panel1.Controls.Add(this.b_cal_mag);
            this.splitContainer1.Panel1.Controls.Add(this.l_cycletime);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // bBind
            // 
            resources.ApplyResources(this.bBind, "bBind");
            this.bBind.ForeColor = System.Drawing.Color.Black;
            this.bBind.Name = "bBind";
            this.bBind.UseVisualStyleBackColor = true;
            this.bBind.Click += new System.EventHandler(this.bBind_Click);
            // 
            // b_cal_acc
            // 
            resources.ApplyResources(this.b_cal_acc, "b_cal_acc");
            this.b_cal_acc.ForeColor = System.Drawing.Color.Black;
            this.b_cal_acc.Name = "b_cal_acc";
            this.b_cal_acc.UseVisualStyleBackColor = true;
            this.b_cal_acc.Click += new System.EventHandler(this.b_cal_acc_Click);
            // 
            // cb_monitor_rate
            // 
            resources.ApplyResources(this.cb_monitor_rate, "cb_monitor_rate");
            this.cb_monitor_rate.BackColor = System.Drawing.Color.DimGray;
            this.cb_monitor_rate.ForeColor = System.Drawing.Color.White;
            this.cb_monitor_rate.FormattingEnabled = true;
            this.cb_monitor_rate.Name = "cb_monitor_rate";
            this.cb_monitor_rate.SelectedIndexChanged += new System.EventHandler(this.cb_monitor_rate_SelectedIndexChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // b_pause
            // 
            resources.ApplyResources(this.b_pause, "b_pause");
            this.b_pause.ForeColor = System.Drawing.Color.Black;
            this.b_pause.Name = "b_pause";
            this.b_pause.UseVisualStyleBackColor = true;
            this.b_pause.Click += new System.EventHandler(this.b_pause_Click);
            // 
            // b_cal_mag
            // 
            resources.ApplyResources(this.b_cal_mag, "b_cal_mag");
            this.b_cal_mag.ForeColor = System.Drawing.Color.Black;
            this.b_cal_mag.Name = "b_cal_mag";
            this.b_cal_mag.UseVisualStyleBackColor = true;
            this.b_cal_mag.Click += new System.EventHandler(this.b_cal_mag_Click);
            // 
            // l_cycletime
            // 
            resources.ApplyResources(this.l_cycletime, "l_cycletime");
            this.l_cycletime.Name = "l_cycletime";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.label81);
            this.splitContainer2.Panel2.Controls.Add(this.label80);
            this.splitContainer2.Panel2.Controls.Add(this.label79);
            this.splitContainer2.Panel2.Controls.Add(this.barNoise);
            this.splitContainer2.Panel2.Controls.Add(this.barRSSI);
            this.splitContainer2.Panel2.Controls.Add(this.labelRSSI);
            this.splitContainer2.Panel2.Controls.Add(this.label69);
            this.splitContainer2.Panel2.Controls.Add(this.labelNoise);
            this.splitContainer2.Panel2.Controls.Add(this.labelSentPackets);
            this.splitContainer2.Panel2.Controls.Add(this.l_i2cerrors);
            this.splitContainer2.Panel2.Controls.Add(this.label44);
            this.splitContainer2.Panel2.Controls.Add(this.label21);
            this.splitContainer2.Panel2.Controls.Add(this.label43);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.labelReceivedPackets);
            this.splitContainer2.Panel2.Controls.Add(this.l_vbatt);
            this.splitContainer2.Panel2.Controls.Add(this.labelCRCErrors);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.l_powersum);
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            resources.ApplyResources(this.splitContainer3.Panel1, "splitContainer3.Panel1");
            this.splitContainer3.Panel1.Controls.Add(this.battery_indicator1);
            this.splitContainer3.Panel1.Controls.Add(this.vertical_speed_indicator1);
            this.splitContainer3.Panel1.Controls.Add(this.altitude_meter1);
            this.splitContainer3.Panel1.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.splitContainer3.Panel1.Controls.Add(this.gpsIndicator);
            this.splitContainer3.Panel1.Controls.Add(this.headingIndicatorInstrumentControl1);
            // 
            // splitContainer3.Panel2
            // 
            resources.ApplyResources(this.splitContainer3.Panel2, "splitContainer3.Panel2");
            this.splitContainer3.Panel2.Controls.Add(this.label47);
            this.splitContainer3.Panel2.Controls.Add(this.rc_input_control1);
            this.splitContainer3.Panel2.Controls.Add(this.motorsIndicator1);
            this.splitContainer3.Panel2.Controls.Add(this.indACC);
            this.splitContainer3.Panel2.Controls.Add(this.indGPS);
            this.splitContainer3.Panel2.Controls.Add(this.indOPTIC);
            this.splitContainer3.Panel2.Controls.Add(this.indBARO);
            this.splitContainer3.Panel2.Controls.Add(this.indMAG);
            this.splitContainer3.Panel2.Controls.Add(this.indSONAR);
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label81
            // 
            resources.ApplyResources(this.label81, "label81");
            this.label81.Name = "label81";
            // 
            // label80
            // 
            resources.ApplyResources(this.label80, "label80");
            this.label80.Name = "label80";
            // 
            // label79
            // 
            resources.ApplyResources(this.label79, "label79");
            this.label79.Name = "label79";
            // 
            // labelRSSI
            // 
            resources.ApplyResources(this.labelRSSI, "labelRSSI");
            this.labelRSSI.Name = "labelRSSI";
            // 
            // label69
            // 
            resources.ApplyResources(this.label69, "label69");
            this.label69.Name = "label69";
            // 
            // labelNoise
            // 
            resources.ApplyResources(this.labelNoise, "labelNoise");
            this.labelNoise.Name = "labelNoise";
            // 
            // labelSentPackets
            // 
            resources.ApplyResources(this.labelSentPackets, "labelSentPackets");
            this.labelSentPackets.Name = "labelSentPackets";
            // 
            // l_i2cerrors
            // 
            resources.ApplyResources(this.l_i2cerrors, "l_i2cerrors");
            this.l_i2cerrors.Name = "l_i2cerrors";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // labelReceivedPackets
            // 
            resources.ApplyResources(this.labelReceivedPackets, "labelReceivedPackets");
            this.labelReceivedPackets.Name = "labelReceivedPackets";
            // 
            // l_vbatt
            // 
            resources.ApplyResources(this.l_vbatt, "l_vbatt");
            this.l_vbatt.Name = "l_vbatt";
            // 
            // labelCRCErrors
            // 
            resources.ApplyResources(this.labelCRCErrors, "labelCRCErrors");
            this.labelCRCErrors.Name = "labelCRCErrors";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // l_powersum
            // 
            resources.ApplyResources(this.l_powersum, "l_powersum");
            this.l_powersum.Name = "l_powersum";
            // 
            // tabPageMisson
            // 
            resources.ApplyResources(this.tabPageMisson, "tabPageMisson");
            this.tabPageMisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageMisson.ContextMenuStrip = this.contextMenuStripMap;
            this.tabPageMisson.Controls.Add(this.splitContainer7);
            this.tabPageMisson.Name = "tabPageMisson";
            // 
            // contextMenuStripMap
            // 
            resources.ApplyResources(this.contextMenuStripMap, "contextMenuStripMap");
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuAddWP,
            this.tsMenuAddPosholdTimed,
            this.tsMenuAddPosholdUnlim,
            this.tsMenuAddRTH,
            this.tsMenuAddLand,
            this.tsMenuAddJump,
            this.tsMenuAddPOI,
            this.tsMenuSetHead,
            this.tsMenuDeleteWP,
            this.toolStripSeparator5,
            this.clearMissionToolStripMenuItem,
            this.createCircleToolStripMenuItem,
            this.bulkAltitudeChangeToolStripMenuItem,
            this.toolStripSeparator6,
            this.fetchMapTilesToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMap_Opening);
            // 
            // tsMenuAddLand
            // 
            resources.ApplyResources(this.tsMenuAddLand, "tsMenuAddLand");
            this.tsMenuAddLand.Name = "tsMenuAddLand";
            this.tsMenuAddLand.Click += new System.EventHandler(this.tsMenuAddLand_Click);
            // 
            // tsMenuAddJump
            // 
            resources.ApplyResources(this.tsMenuAddJump, "tsMenuAddJump");
            this.tsMenuAddJump.Name = "tsMenuAddJump";
            this.tsMenuAddJump.Click += new System.EventHandler(this.tsMenuAddJump_Click);
            // 
            // tsMenuAddPOI
            // 
            resources.ApplyResources(this.tsMenuAddPOI, "tsMenuAddPOI");
            this.tsMenuAddPOI.Name = "tsMenuAddPOI";
            this.tsMenuAddPOI.Click += new System.EventHandler(this.tsMenuAddPOI_Click);
            // 
            // tsMenuSetHead
            // 
            resources.ApplyResources(this.tsMenuSetHead, "tsMenuSetHead");
            this.tsMenuSetHead.Name = "tsMenuSetHead";
            this.tsMenuSetHead.Click += new System.EventHandler(this.tsMenuSetHead_Click);
            // 
            // tsMenuDeleteWP
            // 
            resources.ApplyResources(this.tsMenuDeleteWP, "tsMenuDeleteWP");
            this.tsMenuDeleteWP.Name = "tsMenuDeleteWP";
            this.tsMenuDeleteWP.Click += new System.EventHandler(this.tsMenuDeleteWP_Click);
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // createCircleToolStripMenuItem
            // 
            resources.ApplyResources(this.createCircleToolStripMenuItem, "createCircleToolStripMenuItem");
            this.createCircleToolStripMenuItem.Name = "createCircleToolStripMenuItem";
            this.createCircleToolStripMenuItem.Click += new System.EventHandler(this.createCircleToolStripMenuItem_Click);
            // 
            // bulkAltitudeChangeToolStripMenuItem
            // 
            resources.ApplyResources(this.bulkAltitudeChangeToolStripMenuItem, "bulkAltitudeChangeToolStripMenuItem");
            this.bulkAltitudeChangeToolStripMenuItem.Name = "bulkAltitudeChangeToolStripMenuItem";
            this.bulkAltitudeChangeToolStripMenuItem.Click += new System.EventHandler(this.bulkAltitudeChangeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // fetchMapTilesToolStripMenuItem
            // 
            resources.ApplyResources(this.fetchMapTilesToolStripMenuItem, "fetchMapTilesToolStripMenuItem");
            this.fetchMapTilesToolStripMenuItem.Name = "fetchMapTilesToolStripMenuItem";
            this.fetchMapTilesToolStripMenuItem.Click += new System.EventHandler(this.fetchMapTilesToolStripMenuItem_Click);
            // 
            // splitContainer7
            // 
            resources.ApplyResources(this.splitContainer7, "splitContainer7");
            this.splitContainer7.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            resources.ApplyResources(this.splitContainer7.Panel1, "splitContainer7.Panel1");
            this.splitContainer7.Panel1.Controls.Add(this.cbShowFlightPath);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowPos);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowWP);
            this.splitContainer7.Panel1.Controls.Add(this.cbShowMission);
            this.splitContainer7.Panel1.Controls.Add(this.label23);
            this.splitContainer7.Panel1.Controls.Add(this.cbMapProviders);
            this.splitContainer7.Panel1.Controls.Add(this.b_Clear_Route);
            // 
            // splitContainer7.Panel2
            // 
            resources.ApplyResources(this.splitContainer7.Panel2, "splitContainer7.Panel2");
            this.splitContainer7.Panel2.Controls.Add(this.spcontMapMain);
            // 
            // cbShowFlightPath
            // 
            resources.ApplyResources(this.cbShowFlightPath, "cbShowFlightPath");
            this.cbShowFlightPath.Checked = true;
            this.cbShowFlightPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowFlightPath.ForeColor = System.Drawing.Color.White;
            this.cbShowFlightPath.Name = "cbShowFlightPath";
            this.cbShowFlightPath.UseVisualStyleBackColor = true;
            this.cbShowFlightPath.CheckedChanged += new System.EventHandler(this.cbShowFlightPath_CheckedChanged);
            // 
            // cbShowPos
            // 
            resources.ApplyResources(this.cbShowPos, "cbShowPos");
            this.cbShowPos.Checked = true;
            this.cbShowPos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowPos.ForeColor = System.Drawing.Color.White;
            this.cbShowPos.Name = "cbShowPos";
            this.cbShowPos.UseVisualStyleBackColor = true;
            this.cbShowPos.CheckedChanged += new System.EventHandler(this.cbShowPos_CheckedChanged);
            // 
            // cbShowWP
            // 
            resources.ApplyResources(this.cbShowWP, "cbShowWP");
            this.cbShowWP.Checked = true;
            this.cbShowWP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowWP.ForeColor = System.Drawing.Color.White;
            this.cbShowWP.Name = "cbShowWP";
            this.cbShowWP.UseVisualStyleBackColor = true;
            this.cbShowWP.CheckedChanged += new System.EventHandler(this.cbShowWP_CheckedChanged);
            // 
            // cbShowMission
            // 
            resources.ApplyResources(this.cbShowMission, "cbShowMission");
            this.cbShowMission.Checked = true;
            this.cbShowMission.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowMission.ForeColor = System.Drawing.Color.White;
            this.cbShowMission.Name = "cbShowMission";
            this.cbShowMission.UseVisualStyleBackColor = true;
            this.cbShowMission.CheckedChanged += new System.EventHandler(this.cbShowMission_CheckedChanged);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Name = "label23";
            // 
            // cbMapProviders
            // 
            resources.ApplyResources(this.cbMapProviders, "cbMapProviders");
            this.cbMapProviders.FormattingEnabled = true;
            this.cbMapProviders.Name = "cbMapProviders";
           
            // 
            // b_Clear_Route
            // 
            resources.ApplyResources(this.b_Clear_Route, "b_Clear_Route");
            this.b_Clear_Route.Name = "b_Clear_Route";
            this.b_Clear_Route.UseVisualStyleBackColor = true;
            this.b_Clear_Route.Click += new System.EventHandler(this.b_Clear_Route_Click);
            // 
            // spcontMapMain
            // 
            resources.ApplyResources(this.spcontMapMain, "spcontMapMain");
            this.spcontMapMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcontMapMain.Name = "spcontMapMain";
            // 
            // spcontMapMain.Panel1
            // 
            resources.ApplyResources(this.spcontMapMain.Panel1, "spcontMapMain.Panel1");
            this.spcontMapMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spcontMapMain.Panel1.Controls.Add(this.splitContainer9);
            // 
            // spcontMapMain.Panel2
            // 
            resources.ApplyResources(this.spcontMapMain.Panel2, "spcontMapMain.Panel2");
            this.spcontMapMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spcontMapMain.Panel2.Controls.Add(this.splitContainer8);
            this.spcontMapMain.Panel2.Leave += new System.EventHandler(this.txtDefAlt_TextChanged);
            // 
            // splitContainer9
            // 
            resources.ApplyResources(this.splitContainer9, "splitContainer9");
            this.splitContainer9.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer9.Name = "splitContainer9";
            // 
            // splitContainer9.Panel1
            // 
            resources.ApplyResources(this.splitContainer9.Panel1, "splitContainer9.Panel1");
            this.splitContainer9.Panel1.Controls.Add(this.btnMapZoopDown);
            this.splitContainer9.Panel1.Controls.Add(this.btnMapZoomUp);
            this.splitContainer9.Panel1.Controls.Add(this.battery_indicator2);
            this.splitContainer9.Panel1.Controls.Add(this.barRSSIMission);
            this.splitContainer9.Panel1.Controls.Add(this.lNavError);
            this.splitContainer9.Panel1.Controls.Add(this.cbAutoPan);
            this.splitContainer9.Panel1.Controls.Add(this.cbShowGauges);
            this.splitContainer9.Panel1.Controls.Add(this.altitude_meter2);
            this.splitContainer9.Panel1.Controls.Add(this.vertical_speed_indicator2);
            this.splitContainer9.Panel1.Controls.Add(this.gpsIndicator2);
            this.splitContainer9.Panel1.Controls.Add(this.LMousePos);
            this.splitContainer9.Panel1.Controls.Add(this.label45);
            this.splitContainer9.Panel1.Controls.Add(this.MainMap);
            // 
            // splitContainer9.Panel2
            // 
            resources.ApplyResources(this.splitContainer9.Panel2, "splitContainer9.Panel2");
            this.splitContainer9.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer9.Panel2.Controls.Add(this.lNavState);
            this.splitContainer9.Panel2.Controls.Add(this.lGpsMode);
            this.splitContainer9.Panel2.Controls.Add(this.l11);
            this.splitContainer9.Panel2.Controls.Add(this.label72);
            this.splitContainer9.Panel2.Controls.Add(this.cbSendGTCAlt);
            this.splitContainer9.Panel2.Controls.Add(this.txtGTCAlt);
            this.splitContainer9.Panel2.Controls.Add(this.label46);
            this.splitContainer9.Panel2.Controls.Add(this.bClickToGo);
            this.splitContainer9.Panel2.Controls.Add(this.l_GPS_numsat);
            this.splitContainer9.Panel2.Controls.Add(this.label25);
            this.splitContainer9.Panel2.Controls.Add(this.label39);
            this.splitContainer9.Panel2.Controls.Add(this.label32);
            this.splitContainer9.Panel2.Controls.Add(this.l_GPS_alt);
            this.splitContainer9.Panel2.Controls.Add(this.lGPS_lon);
            this.splitContainer9.Panel2.Controls.Add(this.label34);
            this.splitContainer9.Panel2.Controls.Add(this.lGPS_lat);
            // 
            // btnMapZoopDown
            // 
            resources.ApplyResources(this.btnMapZoopDown, "btnMapZoopDown");
            this.btnMapZoopDown.Name = "btnMapZoopDown";
            this.btnMapZoopDown.UseVisualStyleBackColor = true;
            this.btnMapZoopDown.Click += new System.EventHandler(this.btnMapZoopDown_Click);
            // 
            // btnMapZoomUp
            // 
            resources.ApplyResources(this.btnMapZoomUp, "btnMapZoomUp");
            this.btnMapZoomUp.Name = "btnMapZoomUp";
            this.btnMapZoomUp.UseVisualStyleBackColor = true;
            this.btnMapZoomUp.Click += new System.EventHandler(this.btnMapZoomUp_Click);
            // 
            // lNavError
            // 
            resources.ApplyResources(this.lNavError, "lNavError");
            this.lNavError.ForeColor = System.Drawing.Color.Red;
            this.lNavError.Name = "lNavError";
            // 
            // LMousePos
            // 
            resources.ApplyResources(this.LMousePos, "LMousePos");
            this.LMousePos.ForeColor = System.Drawing.Color.White;
            this.LMousePos.Name = "LMousePos";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Name = "label45";
            // 
            // MainMap
            // 
            resources.ApplyResources(this.MainMap, "MainMap");
            this.MainMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.MidnightBlue;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 20;
            this.MainMap.MinZoom = 5;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Zoom = 10D;
            // 
            // lNavState
            // 
            resources.ApplyResources(this.lNavState, "lNavState");
            this.lNavState.ForeColor = System.Drawing.Color.White;
            this.lNavState.Name = "lNavState";
            // 
            // lGpsMode
            // 
            resources.ApplyResources(this.lGpsMode, "lGpsMode");
            this.lGpsMode.ForeColor = System.Drawing.Color.White;
            this.lGpsMode.Name = "lGpsMode";
            // 
            // l11
            // 
            resources.ApplyResources(this.l11, "l11");
            this.l11.ForeColor = System.Drawing.Color.White;
            this.l11.Name = "l11";
            // 
            // label72
            // 
            resources.ApplyResources(this.label72, "label72");
            this.label72.ForeColor = System.Drawing.Color.White;
            this.label72.Name = "label72";
            // 
            // cbSendGTCAlt
            // 
            resources.ApplyResources(this.cbSendGTCAlt, "cbSendGTCAlt");
            this.cbSendGTCAlt.Checked = true;
            this.cbSendGTCAlt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSendGTCAlt.ForeColor = System.Drawing.Color.White;
            this.cbSendGTCAlt.Name = "cbSendGTCAlt";
            this.cbSendGTCAlt.UseVisualStyleBackColor = true;
            this.cbSendGTCAlt.CheckedChanged += new System.EventHandler(this.cbSendGTCAlt_CheckedChanged);
            // 
            // txtGTCAlt
            // 
            resources.ApplyResources(this.txtGTCAlt, "txtGTCAlt");
            this.txtGTCAlt.BackColor = System.Drawing.Color.White;
            this.txtGTCAlt.ForeColor = System.Drawing.Color.Black;
            this.txtGTCAlt.Name = "txtGTCAlt";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Name = "label46";
            // 
            // bClickToGo
            // 
            resources.ApplyResources(this.bClickToGo, "bClickToGo");
            this.bClickToGo.Name = "bClickToGo";
            this.bClickToGo.UseVisualStyleBackColor = true;
            this.bClickToGo.Click += new System.EventHandler(this.bClickToGo_Click);
            // 
            // l_GPS_numsat
            // 
            resources.ApplyResources(this.l_GPS_numsat, "l_GPS_numsat");
            this.l_GPS_numsat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_GPS_numsat.Name = "l_GPS_numsat";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Name = "label25";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label39.Name = "label39";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Name = "label32";
            // 
            // l_GPS_alt
            // 
            resources.ApplyResources(this.l_GPS_alt, "l_GPS_alt");
            this.l_GPS_alt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_GPS_alt.Name = "l_GPS_alt";
            // 
            // lGPS_lon
            // 
            resources.ApplyResources(this.lGPS_lon, "lGPS_lon");
            this.lGPS_lon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lGPS_lon.Name = "lGPS_lon";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label34.Name = "label34";
            // 
            // lGPS_lat
            // 
            resources.ApplyResources(this.lGPS_lat, "lGPS_lat");
            this.lGPS_lat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lGPS_lat.Name = "lGPS_lat";
            // 
            // splitContainer8
            // 
            resources.ApplyResources(this.splitContainer8, "splitContainer8");
            this.splitContainer8.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            resources.ApplyResources(this.splitContainer8.Panel1, "splitContainer8.Panel1");
            this.splitContainer8.Panel1.Controls.Add(this.missionDataGrid);
            // 
            // splitContainer8.Panel2
            // 
            resources.ApplyResources(this.splitContainer8.Panel2, "splitContainer8.Panel2");
            this.splitContainer8.Panel2.Controls.Add(this.label75);
            this.splitContainer8.Panel2.Controls.Add(this.label74);
            this.splitContainer8.Panel2.Controls.Add(this.label73);
            this.splitContainer8.Panel2.Controls.Add(this.lDistLastWP);
            this.splitContainer8.Panel2.Controls.Add(this.btnLoadMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnSaveMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnDownLoadMission);
            this.splitContainer8.Panel2.Controls.Add(this.btnUploadMission);
            this.splitContainer8.Panel2.Controls.Add(this.txtDefAlt);
            this.splitContainer8.Panel2.Controls.Add(this.lDistance);
            this.splitContainer8.Panel2.Controls.Add(this.lDefAlt);
            // 
            // missionDataGrid
            // 
            resources.ApplyResources(this.missionDataGrid, "missionDataGrid");
            this.missionDataGrid.AllowUserToAddRows = false;
            this.missionDataGrid.AllowUserToDeleteRows = false;
            this.missionDataGrid.AllowUserToResizeRows = false;
            this.missionDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.missionDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.missionDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.missionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.missionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.missionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Action,
            this.Par1,
            this.Par2,
            this.Par3,
            this.LATCOL,
            this.LONCOL,
            this.ALTCOL,
            this.UP,
            this.Down,
            this.DEL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.missionDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.missionDataGrid.EnableHeadersVisualStyles = false;
            this.missionDataGrid.Name = "missionDataGrid";
            this.missionDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.missionDataGrid.RowHeadersVisible = false;
            this.missionDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellContentClick);
            this.missionDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellEndEdit);
            this.missionDataGrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellEnter);
            this.missionDataGrid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_CellValidated);
            this.missionDataGrid.CurrentCellDirtyStateChanged += new System.EventHandler(this.missionDataGrid_CurrentCellDirtyStateChanged);
            this.missionDataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.missionDataGrid_RowEnter);
            this.missionDataGrid.SelectionChanged += new System.EventHandler(this.missionDataGrid_SelectionChanged);
            // 
            // No
            // 
            resources.ApplyResources(this.No, "No");
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Action
            // 
            resources.ApplyResources(this.Action, "Action");
            this.Action.Items.AddRange(new object[] {
            "WAYPOINT",
            "POSHOLD_UNLIM",
            "POSHOLD_TIME",
            "RTH",
            "LAND",
            "JUMP",
            "SET_POI",
            "SET_HEAD"});
            this.Action.Name = "Action";
            // 
            // Par1
            // 
            resources.ApplyResources(this.Par1, "Par1");
            this.Par1.Name = "Par1";
            // 
            // Par2
            // 
            resources.ApplyResources(this.Par2, "Par2");
            this.Par2.Name = "Par2";
            // 
            // Par3
            // 
            resources.ApplyResources(this.Par3, "Par3");
            this.Par3.Name = "Par3";
            // 
            // LATCOL
            // 
            resources.ApplyResources(this.LATCOL, "LATCOL");
            this.LATCOL.Name = "LATCOL";
            this.LATCOL.ReadOnly = true;
            // 
            // LONCOL
            // 
            resources.ApplyResources(this.LONCOL, "LONCOL");
            this.LONCOL.Name = "LONCOL";
            this.LONCOL.ReadOnly = true;
            // 
            // ALTCOL
            // 
            resources.ApplyResources(this.ALTCOL, "ALTCOL");
            this.ALTCOL.Name = "ALTCOL";
            // 
            // label75
            // 
            resources.ApplyResources(this.label75, "label75");
            this.label75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label75.Name = "label75";
            // 
            // label74
            // 
            resources.ApplyResources(this.label74, "label74");
            this.label74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label74.Name = "label74";
            // 
            // label73
            // 
            resources.ApplyResources(this.label73, "label73");
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label73.Name = "label73";
            // 
            // lDistLastWP
            // 
            resources.ApplyResources(this.lDistLastWP, "lDistLastWP");
            this.lDistLastWP.ForeColor = System.Drawing.Color.White;
            this.lDistLastWP.Name = "lDistLastWP";
            // 
            // btnLoadMission
            // 
            resources.ApplyResources(this.btnLoadMission, "btnLoadMission");
            this.btnLoadMission.Name = "btnLoadMission";
            this.btnLoadMission.UseVisualStyleBackColor = true;
            this.btnLoadMission.Click += new System.EventHandler(this.btnLoadMission_Click);
            // 
            // btnSaveMission
            // 
            resources.ApplyResources(this.btnSaveMission, "btnSaveMission");
            this.btnSaveMission.Name = "btnSaveMission";
            this.btnSaveMission.UseVisualStyleBackColor = true;
            this.btnSaveMission.Click += new System.EventHandler(this.btnSaveMission_Click);
            // 
            // btnDownLoadMission
            // 
            resources.ApplyResources(this.btnDownLoadMission, "btnDownLoadMission");
            this.btnDownLoadMission.Name = "btnDownLoadMission";
            this.btnDownLoadMission.UseVisualStyleBackColor = true;
            this.btnDownLoadMission.Click += new System.EventHandler(this.btnDownLoadMission_Click);
            // 
            // btnUploadMission
            // 
            resources.ApplyResources(this.btnUploadMission, "btnUploadMission");
            this.btnUploadMission.Name = "btnUploadMission";
            this.btnUploadMission.UseVisualStyleBackColor = true;
            this.btnUploadMission.Click += new System.EventHandler(this.btnUploadMission_Click);
            // 
            // txtDefAlt
            // 
            resources.ApplyResources(this.txtDefAlt, "txtDefAlt");
            this.txtDefAlt.BackColor = System.Drawing.Color.White;
            this.txtDefAlt.ForeColor = System.Drawing.Color.Black;
            this.txtDefAlt.Name = "txtDefAlt";
            this.txtDefAlt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDefAlt_KeyDown);
            this.txtDefAlt.Leave += new System.EventHandler(this.txtDefAlt_TextChanged);
            // 
            // lDistance
            // 
            resources.ApplyResources(this.lDistance, "lDistance");
            this.lDistance.ForeColor = System.Drawing.Color.White;
            this.lDistance.Name = "lDistance";
            // 
            // lDefAlt
            // 
            resources.ApplyResources(this.lDefAlt, "lDefAlt");
            this.lDefAlt.ForeColor = System.Drawing.Color.White;
            this.lDefAlt.Name = "lDefAlt";
            // 
            // tabPagePID
            // 
            resources.ApplyResources(this.tabPagePID, "tabPagePID");
            this.tabPagePID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPagePID.Controls.Add(this.naviGroup);
            this.tabPagePID.Controls.Add(this.label2);
            this.tabPagePID.Controls.Add(this.label1);
            this.tabPagePID.Controls.Add(this.nTEXPO);
            this.tabPagePID.Controls.Add(this.nTMID);
            this.tabPagePID.Controls.Add(this.trackBar_T_EXPO);
            this.tabPagePID.Controls.Add(this.trackBar_T_MID);
            this.tabPagePID.Controls.Add(this.trackbar_RC_Rate);
            this.tabPagePID.Controls.Add(this.label65);
            this.tabPagePID.Controls.Add(this.trackbar_RC_Expo);
            this.tabPagePID.Controls.Add(this.nRCRate);
            this.tabPagePID.Controls.Add(this.nRCExpo);
            this.tabPagePID.Controls.Add(this.label66);
            this.tabPagePID.Controls.Add(this.groupBox12);
            this.tabPagePID.Controls.Add(this.throttle_expo_control1);
            this.tabPagePID.Controls.Add(this.rc_expo_control1);
            this.tabPagePID.Name = "tabPagePID";
            // 
            // naviGroup
            // 
            resources.ApplyResources(this.naviGroup, "naviGroup");
            this.naviGroup.Controls.Add(this.label41);
            this.naviGroup.Controls.Add(this.nLandSpeed);
            this.naviGroup.Controls.Add(this.label71);
            this.naviGroup.Controls.Add(this.nFence);
            this.naviGroup.Controls.Add(this.cbNavBaroTakeover);
            this.naviGroup.Controls.Add(this.cbNavDisableSticks);
            this.naviGroup.Controls.Add(this.cbNavGPS_filtering);
            this.naviGroup.Controls.Add(this.label88);
            this.naviGroup.Controls.Add(this.cbNavGPS_Lead);
            this.naviGroup.Controls.Add(this.nBanking);
            this.naviGroup.Controls.Add(this.cbNavResetHome);
            this.naviGroup.Controls.Add(this.label87);
            this.naviGroup.Controls.Add(this.cbNavHeadingControl);
            this.naviGroup.Controls.Add(this.nCrosstrack);
            this.naviGroup.Controls.Add(this.cbNavTailFirst);
            this.naviGroup.Controls.Add(this.label86);
            this.naviGroup.Controls.Add(this.cbNavRTHHead);
            this.naviGroup.Controls.Add(this.nRTHAlt);
            this.naviGroup.Controls.Add(this.cbNavWaitRTHAlt);
            this.naviGroup.Controls.Add(this.label85);
            this.naviGroup.Controls.Add(this.cbNavSlowNav);
            this.naviGroup.Controls.Add(this.nMinSpeed);
            this.naviGroup.Controls.Add(this.nWPRadius);
            this.naviGroup.Controls.Add(this.label84);
            this.naviGroup.Controls.Add(this.label76);
            this.naviGroup.Controls.Add(this.nMaxSpeed);
            this.naviGroup.Controls.Add(this.nSafeWPDist);
            this.naviGroup.Controls.Add(this.label83);
            this.naviGroup.Controls.Add(this.label82);
            this.naviGroup.Controls.Add(this.nMaxAlt);
            this.naviGroup.ForeColor = System.Drawing.Color.White;
            this.naviGroup.Name = "naviGroup";
            this.naviGroup.TabStop = false;
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label41.Name = "label41";
            // 
            // nLandSpeed
            // 
            resources.ApplyResources(this.nLandSpeed, "nLandSpeed");
            this.nLandSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nLandSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nLandSpeed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nLandSpeed.Name = "nLandSpeed";
            this.nLandSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label71
            // 
            resources.ApplyResources(this.label71, "label71");
            this.label71.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label71.Name = "label71";
            // 
            // nFence
            // 
            resources.ApplyResources(this.nFence, "nFence");
            this.nFence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nFence.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nFence.Name = "nFence";
            this.nFence.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label88
            // 
            resources.ApplyResources(this.label88, "label88");
            this.label88.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label88.Name = "label88";
            // 
            // nBanking
            // 
            resources.ApplyResources(this.nBanking, "nBanking");
            this.nBanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nBanking.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nBanking.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nBanking.Name = "nBanking";
            this.nBanking.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label87.Name = "label87";
            // 
            // nCrosstrack
            // 
            resources.ApplyResources(this.nCrosstrack, "nCrosstrack");
            this.nCrosstrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nCrosstrack.DecimalPlaces = 2;
            this.nCrosstrack.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nCrosstrack.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nCrosstrack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nCrosstrack.Name = "nCrosstrack";
            this.nCrosstrack.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label86.Name = "label86";
            // 
            // nRTHAlt
            // 
            resources.ApplyResources(this.nRTHAlt, "nRTHAlt");
            this.nRTHAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRTHAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nRTHAlt.Name = "nRTHAlt";
            this.nRTHAlt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label85
            // 
            resources.ApplyResources(this.label85, "label85");
            this.label85.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label85.Name = "label85";
            // 
            // nMinSpeed
            // 
            resources.ApplyResources(this.nMinSpeed, "nMinSpeed");
            this.nMinSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMinSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMinSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMinSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nMinSpeed.Name = "nMinSpeed";
            this.nMinSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nWPRadius
            // 
            resources.ApplyResources(this.nWPRadius, "nWPRadius");
            this.nWPRadius.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nWPRadius.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nWPRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nWPRadius.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nWPRadius.Name = "nWPRadius";
            this.nWPRadius.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label84
            // 
            resources.ApplyResources(this.label84, "label84");
            this.label84.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label84.Name = "label84";
            // 
            // label76
            // 
            resources.ApplyResources(this.label76, "label76");
            this.label76.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label76.Name = "label76";
            // 
            // nMaxSpeed
            // 
            resources.ApplyResources(this.nMaxSpeed, "nMaxSpeed");
            this.nMaxSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMaxSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nMaxSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nMaxSpeed.Name = "nMaxSpeed";
            this.nMaxSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nSafeWPDist
            // 
            resources.ApplyResources(this.nSafeWPDist, "nSafeWPDist");
            this.nSafeWPDist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nSafeWPDist.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nSafeWPDist.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nSafeWPDist.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nSafeWPDist.Name = "nSafeWPDist";
            this.nSafeWPDist.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label83
            // 
            resources.ApplyResources(this.label83, "label83");
            this.label83.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label83.Name = "label83";
            // 
            // label82
            // 
            resources.ApplyResources(this.label82, "label82");
            this.label82.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label82.Name = "label82";
            // 
            // nMaxAlt
            // 
            resources.ApplyResources(this.nMaxAlt, "nMaxAlt");
            this.nMaxAlt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMaxAlt.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nMaxAlt.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nMaxAlt.Name = "nMaxAlt";
            this.nMaxAlt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // nTEXPO
            // 
            resources.ApplyResources(this.nTEXPO, "nTEXPO");
            this.nTEXPO.BackColor = System.Drawing.Color.LightGray;
            this.nTEXPO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nTEXPO.DecimalPlaces = 2;
            this.nTEXPO.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nTEXPO.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTEXPO.Name = "nTEXPO";
            this.nTEXPO.ValueChanged += new System.EventHandler(this.nTEXPO_ValueChanged);
            // 
            // nTMID
            // 
            resources.ApplyResources(this.nTMID, "nTMID");
            this.nTMID.BackColor = System.Drawing.Color.LightGray;
            this.nTMID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nTMID.DecimalPlaces = 2;
            this.nTMID.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nTMID.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nTMID.Name = "nTMID";
            this.nTMID.ValueChanged += new System.EventHandler(this.nTMID_ValueChanged);
            // 
            // trackBar_T_EXPO
            // 
            resources.ApplyResources(this.trackBar_T_EXPO, "trackBar_T_EXPO");
            this.trackBar_T_EXPO.LargeChange = 1;
            this.trackBar_T_EXPO.Maximum = 100;
            this.trackBar_T_EXPO.Name = "trackBar_T_EXPO";
            this.trackBar_T_EXPO.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_T_EXPO.Value = 100;
            this.trackBar_T_EXPO.Scroll += new System.EventHandler(this.trackBar_T_EXPO_Scroll);
            // 
            // trackBar_T_MID
            // 
            resources.ApplyResources(this.trackBar_T_MID, "trackBar_T_MID");
            this.trackBar_T_MID.Maximum = 100;
            this.trackBar_T_MID.Name = "trackBar_T_MID";
            this.trackBar_T_MID.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_T_MID.Value = 80;
            this.trackBar_T_MID.Scroll += new System.EventHandler(this.trackBar_T_MID_Scroll);
            // 
            // trackbar_RC_Rate
            // 
            resources.ApplyResources(this.trackbar_RC_Rate, "trackbar_RC_Rate");
            this.trackbar_RC_Rate.LargeChange = 1;
            this.trackbar_RC_Rate.Maximum = 250;
            this.trackbar_RC_Rate.Name = "trackbar_RC_Rate";
            this.trackbar_RC_Rate.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_RC_Rate.Value = 100;
            this.trackbar_RC_Rate.Scroll += new System.EventHandler(this.trackbar_RC_Rate_Scroll);
            // 
            // label65
            // 
            resources.ApplyResources(this.label65, "label65");
            this.label65.ForeColor = System.Drawing.Color.Gainsboro;
            this.label65.Name = "label65";
            // 
            // trackbar_RC_Expo
            // 
            resources.ApplyResources(this.trackbar_RC_Expo, "trackbar_RC_Expo");
            this.trackbar_RC_Expo.Maximum = 100;
            this.trackbar_RC_Expo.Name = "trackbar_RC_Expo";
            this.trackbar_RC_Expo.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_RC_Expo.Value = 80;
            this.trackbar_RC_Expo.Scroll += new System.EventHandler(this.trackbar_RC_Expo_Scroll);
            // 
            // nRCRate
            // 
            resources.ApplyResources(this.nRCRate, "nRCRate");
            this.nRCRate.BackColor = System.Drawing.Color.LightGray;
            this.nRCRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRCRate.DecimalPlaces = 2;
            this.nRCRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRCRate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nRCRate.Name = "nRCRate";
            this.nRCRate.ValueChanged += new System.EventHandler(this.nRCRate_ValueChanged);
            // 
            // nRCExpo
            // 
            resources.ApplyResources(this.nRCExpo, "nRCExpo");
            this.nRCExpo.BackColor = System.Drawing.Color.LightGray;
            this.nRCExpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRCExpo.DecimalPlaces = 2;
            this.nRCExpo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRCExpo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRCExpo.Name = "nRCExpo";
            this.nRCExpo.ValueChanged += new System.EventHandler(this.nRCExpo_ValueChanged);
            // 
            // label66
            // 
            resources.ApplyResources(this.label66, "label66");
            this.label66.ForeColor = System.Drawing.Color.Gainsboro;
            this.label66.Name = "label66";
            // 
            // groupBox12
            // 
            resources.ApplyResources(this.groupBox12, "groupBox12");
            this.groupBox12.Controls.Add(this.label50);
            this.groupBox12.Controls.Add(this.label_sok);
            this.groupBox12.Controls.Add(this.label60);
            this.groupBox12.Controls.Add(this.nRATE_tpid);
            this.groupBox12.Controls.Add(this.nRATE_yaw);
            this.groupBox12.Controls.Add(this.nRATE_rp);
            this.groupBox12.ForeColor = System.Drawing.Color.White;
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.TabStop = false;
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Name = "label50";
            // 
            // label_sok
            // 
            resources.ApplyResources(this.label_sok, "label_sok");
            this.label_sok.ForeColor = System.Drawing.Color.White;
            this.label_sok.Name = "label_sok";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Name = "label60";
            // 
            // nRATE_tpid
            // 
            resources.ApplyResources(this.nRATE_tpid, "nRATE_tpid");
            this.nRATE_tpid.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_tpid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_tpid.DecimalPlaces = 2;
            this.nRATE_tpid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_tpid.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_tpid.Name = "nRATE_tpid";
            this.nRATE_tpid.ValueChanged += new System.EventHandler(this.nRATE_tpid_ValueChanged);
            // 
            // nRATE_yaw
            // 
            resources.ApplyResources(this.nRATE_yaw, "nRATE_yaw");
            this.nRATE_yaw.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_yaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_yaw.DecimalPlaces = 2;
            this.nRATE_yaw.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_yaw.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_yaw.Name = "nRATE_yaw";
            this.nRATE_yaw.ValueChanged += new System.EventHandler(this.nRATE_yaw_ValueChanged);
            // 
            // nRATE_rp
            // 
            resources.ApplyResources(this.nRATE_rp, "nRATE_rp");
            this.nRATE_rp.BackColor = System.Drawing.Color.LightGray;
            this.nRATE_rp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nRATE_rp.DecimalPlaces = 2;
            this.nRATE_rp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nRATE_rp.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nRATE_rp.Name = "nRATE_rp";
            this.nRATE_rp.ValueChanged += new System.EventHandler(this.nRATE_rp_ValueChanged);
            // 
            // tabPageConf
            // 
            resources.ApplyResources(this.tabPageConf, "tabPageConf");
            this.tabPageConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageConf.Controls.Add(this.lVBatConf);
            this.tabPageConf.Controls.Add(this.labelvbat);
            this.tabPageConf.Controls.Add(this.groupBox8);
            this.tabPageConf.Controls.Add(this.groupBox7);
            this.tabPageConf.Controls.Add(this.groupBox6);
            this.tabPageConf.Controls.Add(this.groupBox5);
            this.tabPageConf.Controls.Add(this.groupBox4);
            this.tabPageConf.Name = "tabPageConf";
            // 
            // lVBatConf
            // 
            resources.ApplyResources(this.lVBatConf, "lVBatConf");
            this.lVBatConf.ForeColor = System.Drawing.Color.White;
            this.lVBatConf.Name = "lVBatConf";
            // 
            // labelvbat
            // 
            resources.ApplyResources(this.labelvbat, "labelvbat");
            this.labelvbat.ForeColor = System.Drawing.Color.White;
            this.labelvbat.Name = "labelvbat";
            // 
            // groupBox8
            // 
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Controls.Add(this.label58);
            this.groupBox8.Controls.Add(this.lMaxThr);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label57);
            this.groupBox8.Controls.Add(this.nFSThr);
            this.groupBox8.Controls.Add(this.label59);
            this.groupBox8.Controls.Add(this.nMinThr);
            this.groupBox8.Controls.Add(this.lMinCommand);
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Name = "label58";
            // 
            // lMaxThr
            // 
            resources.ApplyResources(this.lMaxThr, "lMaxThr");
            this.lMaxThr.ForeColor = System.Drawing.Color.White;
            this.lMaxThr.Name = "lMaxThr";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Name = "label9";
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.ForeColor = System.Drawing.Color.White;
            this.label57.Name = "label57";
            // 
            // nFSThr
            // 
            resources.ApplyResources(this.nFSThr, "nFSThr");
            this.nFSThr.BackColor = System.Drawing.Color.LightGray;
            this.nFSThr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nFSThr.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nFSThr.Name = "nFSThr";
            this.nFSThr.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.ForeColor = System.Drawing.Color.White;
            this.label59.Name = "label59";
            // 
            // nMinThr
            // 
            resources.ApplyResources(this.nMinThr, "nMinThr");
            this.nMinThr.BackColor = System.Drawing.Color.LightGray;
            this.nMinThr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nMinThr.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nMinThr.Name = "nMinThr";
            this.nMinThr.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // lMinCommand
            // 
            resources.ApplyResources(this.lMinCommand, "lMinCommand");
            this.lMinCommand.ForeColor = System.Drawing.Color.White;
            this.lMinCommand.Name = "lMinCommand";
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.label62);
            this.groupBox7.Controls.Add(this.lLife);
            this.groupBox7.Controls.Add(this.label61);
            this.groupBox7.Controls.Add(this.lArms);
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // label62
            // 
            resources.ApplyResources(this.label62, "label62");
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Name = "label62";
            // 
            // lLife
            // 
            resources.ApplyResources(this.lLife, "lLife");
            this.lLife.ForeColor = System.Drawing.Color.White;
            this.lLife.Name = "lLife";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.ForeColor = System.Drawing.Color.White;
            this.label61.Name = "label61";
            // 
            // lArms
            // 
            resources.ApplyResources(this.lArms, "lArms");
            this.lArms.ForeColor = System.Drawing.Color.White;
            this.lArms.Name = "lArms";
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.label68);
            this.groupBox6.Controls.Add(this.nVBatCritical);
            this.groupBox6.Controls.Add(this.nPAlarm);
            this.groupBox6.Controls.Add(this.nVBatWarn2);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.nVBatWarn1);
            this.groupBox6.Controls.Add(this.label63);
            this.groupBox6.Controls.Add(this.nVBatScale);
            this.groupBox6.Controls.Add(this.label64);
            this.groupBox6.Controls.Add(this.label67);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // label68
            // 
            resources.ApplyResources(this.label68, "label68");
            this.label68.ForeColor = System.Drawing.Color.White;
            this.label68.Name = "label68";
            // 
            // nVBatCritical
            // 
            resources.ApplyResources(this.nVBatCritical, "nVBatCritical");
            this.nVBatCritical.BackColor = System.Drawing.Color.LightGray;
            this.nVBatCritical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatCritical.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nVBatCritical.Name = "nVBatCritical";
            // 
            // nPAlarm
            // 
            resources.ApplyResources(this.nPAlarm, "nPAlarm");
            this.nPAlarm.BackColor = System.Drawing.Color.LightGray;
            this.nPAlarm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nPAlarm.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nPAlarm.Name = "nPAlarm";
            // 
            // nVBatWarn2
            // 
            resources.ApplyResources(this.nVBatWarn2, "nVBatWarn2");
            this.nVBatWarn2.BackColor = System.Drawing.Color.LightGray;
            this.nVBatWarn2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatWarn2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatWarn2.Name = "nVBatWarn2";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Name = "label8";
            // 
            // nVBatWarn1
            // 
            resources.ApplyResources(this.nVBatWarn1, "nVBatWarn1");
            this.nVBatWarn1.BackColor = System.Drawing.Color.LightGray;
            this.nVBatWarn1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatWarn1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatWarn1.Name = "nVBatWarn1";
            // 
            // label63
            // 
            resources.ApplyResources(this.label63, "label63");
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Name = "label63";
            // 
            // nVBatScale
            // 
            resources.ApplyResources(this.nVBatScale, "nVBatScale");
            this.nVBatScale.BackColor = System.Drawing.Color.LightGray;
            this.nVBatScale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nVBatScale.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nVBatScale.Name = "nVBatScale";
            // 
            // label64
            // 
            resources.ApplyResources(this.label64, "label64");
            this.label64.ForeColor = System.Drawing.Color.White;
            this.label64.Name = "label64";
            // 
            // label67
            // 
            resources.ApplyResources(this.label67, "label67");
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Name = "label67";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.cbMagSign);
            this.groupBox5.Controls.Add(this.linkLabel1);
            this.groupBox5.Controls.Add(this.nMagDeg);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label48);
            this.groupBox5.Controls.Add(this.nMagMin);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // cbMagSign
            // 
            resources.ApplyResources(this.cbMagSign, "cbMagSign");
            this.cbMagSign.FormattingEnabled = true;
            this.cbMagSign.Items.AddRange(new object[] {
            resources.GetString("cbMagSign.Items"),
            resources.GetString("cbMagSign.Items1")});
            this.cbMagSign.Name = "cbMagSign";
            this.cbMagSign.SelectedIndexChanged += new System.EventHandler(this.cbMagSign_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // nMagDeg
            // 
            resources.ApplyResources(this.nMagDeg, "nMagDeg");
            this.nMagDeg.Name = "nMagDeg";
            this.nMagDeg.ValueChanged += new System.EventHandler(this.nMagDeg_ValueChanged);
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.ForeColor = System.Drawing.Color.Coral;
            this.label49.Name = "label49";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Name = "label10";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Name = "label48";
            // 
            // nMagMin
            // 
            resources.ApplyResources(this.nMagMin, "nMagMin");
            this.nMagMin.Name = "nMagMin";
            this.nMagMin.ValueChanged += new System.EventHandler(this.nMagMin_ValueChanged);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.nSrvRate4);
            this.groupBox4.Controls.Add(this.label56);
            this.groupBox4.Controls.Add(this.cbSrvRev1);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.cbSrvRev2);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.cbSrvRev3);
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.cbSrvRev4);
            this.groupBox4.Controls.Add(this.label52);
            this.groupBox4.Controls.Add(this.cbSrvRev5);
            this.groupBox4.Controls.Add(this.label51);
            this.groupBox4.Controls.Add(this.cbSrvRev6);
            this.groupBox4.Controls.Add(this.nSrvMax8);
            this.groupBox4.Controls.Add(this.cbSrvRev7);
            this.groupBox4.Controls.Add(this.nSrvMax7);
            this.groupBox4.Controls.Add(this.cbSrvRev8);
            this.groupBox4.Controls.Add(this.nSrvMax6);
            this.groupBox4.Controls.Add(this.lSrvID1);
            this.groupBox4.Controls.Add(this.nSrvMax5);
            this.groupBox4.Controls.Add(this.lSrvID2);
            this.groupBox4.Controls.Add(this.nSrvMax4);
            this.groupBox4.Controls.Add(this.lSrvID3);
            this.groupBox4.Controls.Add(this.nSrvMax3);
            this.groupBox4.Controls.Add(this.lSrvID4);
            this.groupBox4.Controls.Add(this.nSrvMax2);
            this.groupBox4.Controls.Add(this.lSrvID5);
            this.groupBox4.Controls.Add(this.nSrvMax1);
            this.groupBox4.Controls.Add(this.lSrvID6);
            this.groupBox4.Controls.Add(this.nSrvMid8);
            this.groupBox4.Controls.Add(this.lSrvID7);
            this.groupBox4.Controls.Add(this.nSrvMid7);
            this.groupBox4.Controls.Add(this.lSrvID8);
            this.groupBox4.Controls.Add(this.nSrvMid6);
            this.groupBox4.Controls.Add(this.lSrvName1);
            this.groupBox4.Controls.Add(this.nSrvMid5);
            this.groupBox4.Controls.Add(this.lSrvName3);
            this.groupBox4.Controls.Add(this.nSrvMid4);
            this.groupBox4.Controls.Add(this.lSrvName2);
            this.groupBox4.Controls.Add(this.nSrvMid3);
            this.groupBox4.Controls.Add(this.lSrvName4);
            this.groupBox4.Controls.Add(this.nSrvMid2);
            this.groupBox4.Controls.Add(this.lSrvName5);
            this.groupBox4.Controls.Add(this.nSrvMid1);
            this.groupBox4.Controls.Add(this.lSrvName6);
            this.groupBox4.Controls.Add(this.nSrvMin8);
            this.groupBox4.Controls.Add(this.lSrvName7);
            this.groupBox4.Controls.Add(this.nSrvMin7);
            this.groupBox4.Controls.Add(this.lSrvName8);
            this.groupBox4.Controls.Add(this.nSrvMin6);
            this.groupBox4.Controls.Add(this.nSrvRate1);
            this.groupBox4.Controls.Add(this.nSrvMin5);
            this.groupBox4.Controls.Add(this.nSrvRate2);
            this.groupBox4.Controls.Add(this.nSrvMin4);
            this.groupBox4.Controls.Add(this.nSrvRate3);
            this.groupBox4.Controls.Add(this.nSrvMin3);
            this.groupBox4.Controls.Add(this.nSrvRate5);
            this.groupBox4.Controls.Add(this.nSrvMin2);
            this.groupBox4.Controls.Add(this.nSrvRate6);
            this.groupBox4.Controls.Add(this.nSrvMin1);
            this.groupBox4.Controls.Add(this.nSrvRate7);
            this.groupBox4.Controls.Add(this.nSrvRate8);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // nSrvRate4
            // 
            resources.ApplyResources(this.nSrvRate4, "nSrvRate4");
            this.nSrvRate4.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate4.Name = "nSrvRate4";
            this.nSrvRate4.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.ForeColor = System.Drawing.Color.White;
            this.label56.Name = "label56";
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Name = "label55";
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Name = "label54";
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Name = "label53";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Name = "label52";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Name = "label51";
            // 
            // nSrvMax8
            // 
            resources.ApplyResources(this.nSrvMax8, "nSrvMax8");
            this.nSrvMax8.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax8.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax8.Name = "nSrvMax8";
            this.nSrvMax8.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nSrvMax7
            // 
            resources.ApplyResources(this.nSrvMax7, "nSrvMax7");
            this.nSrvMax7.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax7.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax7.Name = "nSrvMax7";
            this.nSrvMax7.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // nSrvMax6
            // 
            resources.ApplyResources(this.nSrvMax6, "nSrvMax6");
            this.nSrvMax6.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax6.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax6.Name = "nSrvMax6";
            this.nSrvMax6.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID1
            // 
            resources.ApplyResources(this.lSrvID1, "lSrvID1");
            this.lSrvID1.ForeColor = System.Drawing.Color.White;
            this.lSrvID1.Name = "lSrvID1";
            // 
            // nSrvMax5
            // 
            resources.ApplyResources(this.nSrvMax5, "nSrvMax5");
            this.nSrvMax5.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax5.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax5.Name = "nSrvMax5";
            this.nSrvMax5.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID2
            // 
            resources.ApplyResources(this.lSrvID2, "lSrvID2");
            this.lSrvID2.ForeColor = System.Drawing.Color.White;
            this.lSrvID2.Name = "lSrvID2";
            // 
            // nSrvMax4
            // 
            resources.ApplyResources(this.nSrvMax4, "nSrvMax4");
            this.nSrvMax4.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax4.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax4.Name = "nSrvMax4";
            this.nSrvMax4.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID3
            // 
            resources.ApplyResources(this.lSrvID3, "lSrvID3");
            this.lSrvID3.ForeColor = System.Drawing.Color.White;
            this.lSrvID3.Name = "lSrvID3";
            // 
            // nSrvMax3
            // 
            resources.ApplyResources(this.nSrvMax3, "nSrvMax3");
            this.nSrvMax3.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax3.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax3.Name = "nSrvMax3";
            this.nSrvMax3.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID4
            // 
            resources.ApplyResources(this.lSrvID4, "lSrvID4");
            this.lSrvID4.ForeColor = System.Drawing.Color.White;
            this.lSrvID4.Name = "lSrvID4";
            // 
            // nSrvMax2
            // 
            resources.ApplyResources(this.nSrvMax2, "nSrvMax2");
            this.nSrvMax2.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax2.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax2.Name = "nSrvMax2";
            this.nSrvMax2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID5
            // 
            resources.ApplyResources(this.lSrvID5, "lSrvID5");
            this.lSrvID5.ForeColor = System.Drawing.Color.White;
            this.lSrvID5.Name = "lSrvID5";
            // 
            // nSrvMax1
            // 
            resources.ApplyResources(this.nSrvMax1, "nSrvMax1");
            this.nSrvMax1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMax1.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMax1.Name = "nSrvMax1";
            this.nSrvMax1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lSrvID6
            // 
            resources.ApplyResources(this.lSrvID6, "lSrvID6");
            this.lSrvID6.ForeColor = System.Drawing.Color.White;
            this.lSrvID6.Name = "lSrvID6";
            // 
            // nSrvMid8
            // 
            resources.ApplyResources(this.nSrvMid8, "nSrvMid8");
            this.nSrvMid8.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid8.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid8.Name = "nSrvMid8";
            this.nSrvMid8.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvID7
            // 
            resources.ApplyResources(this.lSrvID7, "lSrvID7");
            this.lSrvID7.ForeColor = System.Drawing.Color.White;
            this.lSrvID7.Name = "lSrvID7";
            // 
            // nSrvMid7
            // 
            resources.ApplyResources(this.nSrvMid7, "nSrvMid7");
            this.nSrvMid7.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid7.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid7.Name = "nSrvMid7";
            this.nSrvMid7.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvID8
            // 
            resources.ApplyResources(this.lSrvID8, "lSrvID8");
            this.lSrvID8.ForeColor = System.Drawing.Color.White;
            this.lSrvID8.Name = "lSrvID8";
            // 
            // nSrvMid6
            // 
            resources.ApplyResources(this.nSrvMid6, "nSrvMid6");
            this.nSrvMid6.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid6.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid6.Name = "nSrvMid6";
            this.nSrvMid6.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName1
            // 
            resources.ApplyResources(this.lSrvName1, "lSrvName1");
            this.lSrvName1.ForeColor = System.Drawing.Color.White;
            this.lSrvName1.Name = "lSrvName1";
            // 
            // nSrvMid5
            // 
            resources.ApplyResources(this.nSrvMid5, "nSrvMid5");
            this.nSrvMid5.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid5.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid5.Name = "nSrvMid5";
            this.nSrvMid5.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName3
            // 
            resources.ApplyResources(this.lSrvName3, "lSrvName3");
            this.lSrvName3.ForeColor = System.Drawing.Color.White;
            this.lSrvName3.Name = "lSrvName3";
            // 
            // nSrvMid4
            // 
            resources.ApplyResources(this.nSrvMid4, "nSrvMid4");
            this.nSrvMid4.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid4.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid4.Name = "nSrvMid4";
            this.nSrvMid4.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName2
            // 
            resources.ApplyResources(this.lSrvName2, "lSrvName2");
            this.lSrvName2.ForeColor = System.Drawing.Color.White;
            this.lSrvName2.Name = "lSrvName2";
            // 
            // nSrvMid3
            // 
            resources.ApplyResources(this.nSrvMid3, "nSrvMid3");
            this.nSrvMid3.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid3.Name = "nSrvMid3";
            this.nSrvMid3.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName4
            // 
            resources.ApplyResources(this.lSrvName4, "lSrvName4");
            this.lSrvName4.ForeColor = System.Drawing.Color.White;
            this.lSrvName4.Name = "lSrvName4";
            // 
            // nSrvMid2
            // 
            resources.ApplyResources(this.nSrvMid2, "nSrvMid2");
            this.nSrvMid2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid2.Name = "nSrvMid2";
            this.nSrvMid2.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // lSrvName5
            // 
            resources.ApplyResources(this.lSrvName5, "lSrvName5");
            this.lSrvName5.ForeColor = System.Drawing.Color.White;
            this.lSrvName5.Name = "lSrvName5";
            // 
            // nSrvMid1
            // 
            resources.ApplyResources(this.nSrvMid1, "nSrvMid1");
            this.nSrvMid1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nSrvMid1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nSrvMid1.Name = "nSrvMid1";
            this.nSrvMid1.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.nSrvMid1.ValueChanged += new System.EventHandler(this.nSrvMid1_ValueChanged);
            // 
            // lSrvName6
            // 
            resources.ApplyResources(this.lSrvName6, "lSrvName6");
            this.lSrvName6.ForeColor = System.Drawing.Color.White;
            this.lSrvName6.Name = "lSrvName6";
            // 
            // nSrvMin8
            // 
            resources.ApplyResources(this.nSrvMin8, "nSrvMin8");
            this.nSrvMin8.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin8.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin8.Name = "nSrvMin8";
            this.nSrvMin8.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lSrvName7
            // 
            resources.ApplyResources(this.lSrvName7, "lSrvName7");
            this.lSrvName7.ForeColor = System.Drawing.Color.White;
            this.lSrvName7.Name = "lSrvName7";
            // 
            // nSrvMin7
            // 
            resources.ApplyResources(this.nSrvMin7, "nSrvMin7");
            this.nSrvMin7.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin7.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin7.Name = "nSrvMin7";
            this.nSrvMin7.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lSrvName8
            // 
            resources.ApplyResources(this.lSrvName8, "lSrvName8");
            this.lSrvName8.ForeColor = System.Drawing.Color.White;
            this.lSrvName8.Name = "lSrvName8";
            // 
            // nSrvMin6
            // 
            resources.ApplyResources(this.nSrvMin6, "nSrvMin6");
            this.nSrvMin6.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin6.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin6.Name = "nSrvMin6";
            this.nSrvMin6.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate1
            // 
            resources.ApplyResources(this.nSrvRate1, "nSrvRate1");
            this.nSrvRate1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate1.Name = "nSrvRate1";
            this.nSrvRate1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin5
            // 
            resources.ApplyResources(this.nSrvMin5, "nSrvMin5");
            this.nSrvMin5.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin5.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin5.Name = "nSrvMin5";
            this.nSrvMin5.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate2
            // 
            resources.ApplyResources(this.nSrvRate2, "nSrvRate2");
            this.nSrvRate2.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate2.Name = "nSrvRate2";
            this.nSrvRate2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin4
            // 
            resources.ApplyResources(this.nSrvMin4, "nSrvMin4");
            this.nSrvMin4.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin4.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin4.Name = "nSrvMin4";
            this.nSrvMin4.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate3
            // 
            resources.ApplyResources(this.nSrvRate3, "nSrvRate3");
            this.nSrvRate3.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate3.Name = "nSrvRate3";
            this.nSrvRate3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin3
            // 
            resources.ApplyResources(this.nSrvMin3, "nSrvMin3");
            this.nSrvMin3.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin3.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin3.Name = "nSrvMin3";
            this.nSrvMin3.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate5
            // 
            resources.ApplyResources(this.nSrvRate5, "nSrvRate5");
            this.nSrvRate5.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate5.Name = "nSrvRate5";
            this.nSrvRate5.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin2
            // 
            resources.ApplyResources(this.nSrvMin2, "nSrvMin2");
            this.nSrvMin2.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin2.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin2.Name = "nSrvMin2";
            this.nSrvMin2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate6
            // 
            resources.ApplyResources(this.nSrvRate6, "nSrvRate6");
            this.nSrvRate6.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate6.Name = "nSrvRate6";
            this.nSrvRate6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvMin1
            // 
            resources.ApplyResources(this.nSrvMin1, "nSrvMin1");
            this.nSrvMin1.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nSrvMin1.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nSrvMin1.Name = "nSrvMin1";
            this.nSrvMin1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nSrvRate7
            // 
            resources.ApplyResources(this.nSrvRate7, "nSrvRate7");
            this.nSrvRate7.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate7.Name = "nSrvRate7";
            this.nSrvRate7.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nSrvRate8
            // 
            resources.ApplyResources(this.nSrvRate8, "nSrvRate8");
            this.nSrvRate8.Cursor = System.Windows.Forms.Cursors.Default;
            this.nSrvRate8.Name = "nSrvRate8";
            this.nSrvRate8.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tabPageRC
            // 
            resources.ApplyResources(this.tabPageRC, "tabPageRC");
            this.tabPageRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageRC.Controls.Add(this.label5);
            this.tabPageRC.Controls.Add(this.label4);
            this.tabPageRC.Controls.Add(this.rci_Control_settings);
            this.tabPageRC.Controls.Add(this.pictureBox1);
            this.tabPageRC.Name = "tabPageRC";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // tabSensorGraph
            // 
            resources.ApplyResources(this.tabSensorGraph, "tabSensorGraph");
            this.tabSensorGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabSensorGraph.Controls.Add(this.splitContainer10);
            this.tabSensorGraph.Name = "tabSensorGraph";
            // 
            // splitContainer10
            // 
            resources.ApplyResources(this.splitContainer10, "splitContainer10");
            this.splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            resources.ApplyResources(this.splitContainer10.Panel1, "splitContainer10.Panel1");
            // 
            // splitContainer10.Panel2
            // 
            resources.ApplyResources(this.splitContainer10.Panel2, "splitContainer10.Panel2");
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            // 
            // splitContainer11
            // 
            resources.ApplyResources(this.splitContainer11, "splitContainer11");
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            resources.ApplyResources(this.splitContainer11.Panel1, "splitContainer11.Panel1");
            this.splitContainer11.Panel1.Controls.Add(this.splitContainer12);
            // 
            // splitContainer11.Panel2
            // 
            resources.ApplyResources(this.splitContainer11.Panel2, "splitContainer11.Panel2");
            this.splitContainer11.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer11.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer11.Panel2.Controls.Add(this.cb_alt);
            this.splitContainer11.Panel2.Controls.Add(this.label22);
            this.splitContainer11.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer11.Panel2.Controls.Add(this.l_alt);
            this.splitContainer11.Panel2.Controls.Add(this.cb_head);
            this.splitContainer11.Panel2.Controls.Add(this.l_head);
            this.splitContainer11.Panel2.Controls.Add(this.label26);
            // 
            // splitContainer12
            // 
            resources.ApplyResources(this.splitContainer12, "splitContainer12");
            this.splitContainer12.Name = "splitContainer12";
            // 
            // splitContainer12.Panel1
            // 
            resources.ApplyResources(this.splitContainer12.Panel1, "splitContainer12.Panel1");
            this.splitContainer12.Panel1.Controls.Add(this.zgMonitor);
            // 
            // splitContainer12.Panel2
            // 
            resources.ApplyResources(this.splitContainer12.Panel2, "splitContainer12.Panel2");
            this.splitContainer12.Panel2.Controls.Add(this.label28);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg1);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg1);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg2);
            this.splitContainer12.Panel2.Controls.Add(this.label33);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg2);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg3);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg4);
            this.splitContainer12.Panel2.Controls.Add(this.label38);
            this.splitContainer12.Panel2.Controls.Add(this.label40);
            this.splitContainer12.Panel2.Controls.Add(this.l_dbg3);
            this.splitContainer12.Panel2.Controls.Add(this.cb_dbg4);
            // 
            // zgMonitor
            // 
            resources.ApplyResources(this.zgMonitor, "zgMonitor");
            this.zgMonitor.IsZoomOnMouseCenter = true;
            this.zgMonitor.Name = "zgMonitor";
            this.zgMonitor.ScrollGrace = 0D;
            this.zgMonitor.ScrollMaxX = 0D;
            this.zgMonitor.ScrollMaxY = 0D;
            this.zgMonitor.ScrollMaxY2 = 0D;
            this.zgMonitor.ScrollMinX = 0D;
            this.zgMonitor.ScrollMinY = 0D;
            this.zgMonitor.ScrollMinY2 = 0D;
            this.zgMonitor.UseExtendedPrintDialog = true;
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Name = "label28";
            // 
            // cb_dbg1
            // 
            resources.ApplyResources(this.cb_dbg1, "cb_dbg1");
            this.cb_dbg1.Name = "cb_dbg1";
            this.cb_dbg1.UseVisualStyleBackColor = true;
            // 
            // l_dbg1
            // 
            resources.ApplyResources(this.l_dbg1, "l_dbg1");
            this.l_dbg1.ForeColor = System.Drawing.Color.White;
            this.l_dbg1.Name = "l_dbg1";
            // 
            // cb_dbg2
            // 
            resources.ApplyResources(this.cb_dbg2, "cb_dbg2");
            this.cb_dbg2.Name = "cb_dbg2";
            this.cb_dbg2.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label33.ForeColor = System.Drawing.Color.Black;
            this.label33.Name = "label33";
            // 
            // l_dbg2
            // 
            resources.ApplyResources(this.l_dbg2, "l_dbg2");
            this.l_dbg2.ForeColor = System.Drawing.Color.White;
            this.l_dbg2.Name = "l_dbg2";
            // 
            // cb_dbg3
            // 
            resources.ApplyResources(this.cb_dbg3, "cb_dbg3");
            this.cb_dbg3.Name = "cb_dbg3";
            this.cb_dbg3.UseVisualStyleBackColor = true;
            // 
            // l_dbg4
            // 
            resources.ApplyResources(this.l_dbg4, "l_dbg4");
            this.l_dbg4.ForeColor = System.Drawing.Color.White;
            this.l_dbg4.Name = "l_dbg4";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Name = "label38";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Name = "label40";
            // 
            // l_dbg3
            // 
            resources.ApplyResources(this.l_dbg3, "l_dbg3");
            this.l_dbg3.ForeColor = System.Drawing.Color.White;
            this.l_dbg3.Name = "l_dbg3";
            // 
            // cb_dbg4
            // 
            resources.ApplyResources(this.cb_dbg4, "cb_dbg4");
            this.cb_dbg4.Name = "cb_dbg4";
            this.cb_dbg4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.b_uncheck_all_ACC);
            this.groupBox1.Controls.Add(this.b_check_all_ACC);
            this.groupBox1.Controls.Add(this.l_acc_z);
            this.groupBox1.Controls.Add(this.l_acc_pitch);
            this.groupBox1.Controls.Add(this.l_acc_roll);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cb_acc_z);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cb_acc_pitch);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cb_acc_roll);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // b_uncheck_all_ACC
            // 
            resources.ApplyResources(this.b_uncheck_all_ACC, "b_uncheck_all_ACC");
            this.b_uncheck_all_ACC.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_ACC.Name = "b_uncheck_all_ACC";
            this.b_uncheck_all_ACC.UseVisualStyleBackColor = true;
            this.b_uncheck_all_ACC.Click += new System.EventHandler(this.b_uncheck_all_ACC_Click);
            // 
            // b_check_all_ACC
            // 
            resources.ApplyResources(this.b_check_all_ACC, "b_check_all_ACC");
            this.b_check_all_ACC.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_ACC.Name = "b_check_all_ACC";
            this.b_check_all_ACC.UseVisualStyleBackColor = true;
            this.b_check_all_ACC.Click += new System.EventHandler(this.b_check_all_ACC_Click);
            // 
            // l_acc_z
            // 
            resources.ApplyResources(this.l_acc_z, "l_acc_z");
            this.l_acc_z.Name = "l_acc_z";
            // 
            // l_acc_pitch
            // 
            resources.ApplyResources(this.l_acc_pitch, "l_acc_pitch");
            this.l_acc_pitch.Name = "l_acc_pitch";
            // 
            // l_acc_roll
            // 
            resources.ApplyResources(this.l_acc_roll, "l_acc_roll");
            this.l_acc_roll.Name = "l_acc_roll";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Blue;
            this.label18.Name = "label18";
            // 
            // cb_acc_z
            // 
            resources.ApplyResources(this.cb_acc_z, "cb_acc_z");
            this.cb_acc_z.Checked = true;
            this.cb_acc_z.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_z.Name = "cb_acc_z";
            this.cb_acc_z.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Green;
            this.label16.Name = "label16";
            // 
            // cb_acc_pitch
            // 
            resources.ApplyResources(this.cb_acc_pitch, "cb_acc_pitch");
            this.cb_acc_pitch.Checked = true;
            this.cb_acc_pitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_pitch.Name = "cb_acc_pitch";
            this.cb_acc_pitch.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Name = "label14";
            // 
            // cb_acc_roll
            // 
            resources.ApplyResources(this.cb_acc_roll, "cb_acc_roll");
            this.cb_acc_roll.Checked = true;
            this.cb_acc_roll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_acc_roll.Name = "cb_acc_roll";
            this.cb_acc_roll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.b_uncheck_all_GYRO);
            this.groupBox2.Controls.Add(this.b_check_all_GYRO);
            this.groupBox2.Controls.Add(this.l_gyro_yaw);
            this.groupBox2.Controls.Add(this.l_gyro_pitch);
            this.groupBox2.Controls.Add(this.l_gyro_roll);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.cb_gyro_yaw);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.cb_gyro_pitch);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.cb_gyro_roll);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // b_uncheck_all_GYRO
            // 
            resources.ApplyResources(this.b_uncheck_all_GYRO, "b_uncheck_all_GYRO");
            this.b_uncheck_all_GYRO.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_GYRO.Name = "b_uncheck_all_GYRO";
            this.b_uncheck_all_GYRO.UseVisualStyleBackColor = true;
            this.b_uncheck_all_GYRO.Click += new System.EventHandler(this.b_uncheck_all_GYRO_Click);
            // 
            // b_check_all_GYRO
            // 
            resources.ApplyResources(this.b_check_all_GYRO, "b_check_all_GYRO");
            this.b_check_all_GYRO.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_GYRO.Name = "b_check_all_GYRO";
            this.b_check_all_GYRO.UseVisualStyleBackColor = true;
            this.b_check_all_GYRO.Click += new System.EventHandler(this.b_check_all_GYRO_Click);
            // 
            // l_gyro_yaw
            // 
            resources.ApplyResources(this.l_gyro_yaw, "l_gyro_yaw");
            this.l_gyro_yaw.Name = "l_gyro_yaw";
            // 
            // l_gyro_pitch
            // 
            resources.ApplyResources(this.l_gyro_pitch, "l_gyro_pitch");
            this.l_gyro_pitch.Name = "l_gyro_pitch";
            // 
            // l_gyro_roll
            // 
            resources.ApplyResources(this.l_gyro_roll, "l_gyro_roll");
            this.l_gyro_roll.Name = "l_gyro_roll";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.BackColor = System.Drawing.Color.Magenta;
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Name = "label29";
            // 
            // cb_gyro_yaw
            // 
            resources.ApplyResources(this.cb_gyro_yaw, "cb_gyro_yaw");
            this.cb_gyro_yaw.Checked = true;
            this.cb_gyro_yaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_yaw.Name = "cb_gyro_yaw";
            this.cb_gyro_yaw.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.BackColor = System.Drawing.Color.Cyan;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Name = "label30";
            // 
            // cb_gyro_pitch
            // 
            resources.ApplyResources(this.cb_gyro_pitch, "cb_gyro_pitch");
            this.cb_gyro_pitch.Checked = true;
            this.cb_gyro_pitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_pitch.Name = "cb_gyro_pitch";
            this.cb_gyro_pitch.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.BackColor = System.Drawing.Color.Khaki;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Name = "label31";
            // 
            // cb_gyro_roll
            // 
            resources.ApplyResources(this.cb_gyro_roll, "cb_gyro_roll");
            this.cb_gyro_roll.Checked = true;
            this.cb_gyro_roll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_gyro_roll.Name = "cb_gyro_roll";
            this.cb_gyro_roll.UseVisualStyleBackColor = true;
            // 
            // cb_alt
            // 
            resources.ApplyResources(this.cb_alt, "cb_alt");
            this.cb_alt.Name = "cb_alt";
            this.cb_alt.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Name = "label22";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.b_uncheck_all_MAG);
            this.groupBox3.Controls.Add(this.b_check_all_MAG);
            this.groupBox3.Controls.Add(this.l_mag_yaw);
            this.groupBox3.Controls.Add(this.l_mag_pitch);
            this.groupBox3.Controls.Add(this.l_mag_roll);
            this.groupBox3.Controls.Add(this.label35);
            this.groupBox3.Controls.Add(this.cb_mag_yaw);
            this.groupBox3.Controls.Add(this.label36);
            this.groupBox3.Controls.Add(this.cb_mag_pitch);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.cb_mag_roll);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // b_uncheck_all_MAG
            // 
            resources.ApplyResources(this.b_uncheck_all_MAG, "b_uncheck_all_MAG");
            this.b_uncheck_all_MAG.ForeColor = System.Drawing.Color.Black;
            this.b_uncheck_all_MAG.Name = "b_uncheck_all_MAG";
            this.b_uncheck_all_MAG.UseVisualStyleBackColor = true;
            this.b_uncheck_all_MAG.Click += new System.EventHandler(this.b_uncheck_all_MAG_Click);
            // 
            // b_check_all_MAG
            // 
            resources.ApplyResources(this.b_check_all_MAG, "b_check_all_MAG");
            this.b_check_all_MAG.ForeColor = System.Drawing.Color.Black;
            this.b_check_all_MAG.Name = "b_check_all_MAG";
            this.b_check_all_MAG.UseVisualStyleBackColor = true;
            this.b_check_all_MAG.Click += new System.EventHandler(this.b_check_all_MAG_Click);
            // 
            // l_mag_yaw
            // 
            resources.ApplyResources(this.l_mag_yaw, "l_mag_yaw");
            this.l_mag_yaw.Name = "l_mag_yaw";
            // 
            // l_mag_pitch
            // 
            resources.ApplyResources(this.l_mag_pitch, "l_mag_pitch");
            this.l_mag_pitch.Name = "l_mag_pitch";
            // 
            // l_mag_roll
            // 
            resources.ApplyResources(this.l_mag_roll, "l_mag_roll");
            this.l_mag_roll.Name = "l_mag_roll";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label35.Name = "label35";
            // 
            // cb_mag_yaw
            // 
            resources.ApplyResources(this.cb_mag_yaw, "cb_mag_yaw");
            this.cb_mag_yaw.Name = "cb_mag_yaw";
            this.cb_mag_yaw.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.BackColor = System.Drawing.Color.MediumPurple;
            this.label36.Name = "label36";
            // 
            // cb_mag_pitch
            // 
            resources.ApplyResources(this.cb_mag_pitch, "cb_mag_pitch");
            this.cb_mag_pitch.Name = "cb_mag_pitch";
            this.cb_mag_pitch.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.BackColor = System.Drawing.Color.CadetBlue;
            this.label37.Name = "label37";
            // 
            // cb_mag_roll
            // 
            resources.ApplyResources(this.cb_mag_roll, "cb_mag_roll");
            this.cb_mag_roll.Name = "cb_mag_roll";
            this.cb_mag_roll.UseVisualStyleBackColor = true;
            // 
            // l_alt
            // 
            resources.ApplyResources(this.l_alt, "l_alt");
            this.l_alt.ForeColor = System.Drawing.Color.White;
            this.l_alt.Name = "l_alt";
            // 
            // cb_head
            // 
            resources.ApplyResources(this.cb_head, "cb_head");
            this.cb_head.Name = "cb_head";
            this.cb_head.UseVisualStyleBackColor = true;
            // 
            // l_head
            // 
            resources.ApplyResources(this.l_head, "l_head");
            this.l_head.ForeColor = System.Drawing.Color.White;
            this.l_head.Name = "l_head";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.BackColor = System.Drawing.Color.Orange;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Name = "label26";
            // 
            // tabPageVideo
            // 
            resources.ApplyResources(this.tabPageVideo, "tabPageVideo");
            this.tabPageVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageVideo.Controls.Add(this.splitContainer6);
            this.tabPageVideo.Controls.Add(this.l_capture_file);
            this.tabPageVideo.Name = "tabPageVideo";
            // 
            // splitContainer6
            // 
            resources.ApplyResources(this.splitContainer6, "splitContainer6");
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer6.Name = "splitContainer6";
            // 
            // splitContainer6.Panel1
            // 
            resources.ApplyResources(this.splitContainer6.Panel1, "splitContainer6.Panel1");
            this.splitContainer6.Panel1.Controls.Add(this.videoSourcePlayer);
            // 
            // splitContainer6.Panel2
            // 
            resources.ApplyResources(this.splitContainer6.Panel2, "splitContainer6.Panel2");
            this.splitContainer6.Panel2.Controls.Add(this.dropdown_devices);
            this.splitContainer6.Panel2.Controls.Add(this.b_video_connect);
            this.splitContainer6.Panel2.Controls.Add(this.label19);
            this.splitContainer6.Panel2.Controls.Add(this.b_Record);
            this.splitContainer6.Panel2.Controls.Add(this.cb_codec);
            this.splitContainer6.Panel2.Controls.Add(this.nFrameRate);
            this.splitContainer6.Panel2.Controls.Add(this.label17);
            this.splitContainer6.Panel2.Controls.Add(this.label12);
            this.splitContainer6.Panel2.Controls.Add(this.label15);
            this.splitContainer6.Panel2.Controls.Add(this.nBitRate);
            this.splitContainer6.Panel2.Controls.Add(this.label13);
            // 
            // videoSourcePlayer
            // 
            resources.ApplyResources(this.videoSourcePlayer, "videoSourcePlayer");
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.SizeChanged += new System.EventHandler(this.videoSourcePlayer_SizeChanged);
            // 
            // dropdown_devices
            // 
            resources.ApplyResources(this.dropdown_devices, "dropdown_devices");
            this.dropdown_devices.BackColor = System.Drawing.Color.Gray;
            this.dropdown_devices.FormattingEnabled = true;
            this.dropdown_devices.Name = "dropdown_devices";
            // 
            // b_video_connect
            // 
            resources.ApplyResources(this.b_video_connect, "b_video_connect");
            this.b_video_connect.Name = "b_video_connect";
            this.b_video_connect.UseVisualStyleBackColor = true;
            this.b_video_connect.Click += new System.EventHandler(this.b_video_connect_Click);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Name = "label19";
            // 
            // b_Record
            // 
            resources.ApplyResources(this.b_Record, "b_Record");
            this.b_Record.Name = "b_Record";
            this.b_Record.UseVisualStyleBackColor = true;
            this.b_Record.Click += new System.EventHandler(this.b_Record_Click);
            // 
            // cb_codec
            // 
            resources.ApplyResources(this.cb_codec, "cb_codec");
            this.cb_codec.FormattingEnabled = true;
            this.cb_codec.Items.AddRange(new object[] {
            resources.GetString("cb_codec.Items"),
            resources.GetString("cb_codec.Items1"),
            resources.GetString("cb_codec.Items2"),
            resources.GetString("cb_codec.Items3"),
            resources.GetString("cb_codec.Items4"),
            resources.GetString("cb_codec.Items5"),
            resources.GetString("cb_codec.Items6"),
            resources.GetString("cb_codec.Items7"),
            resources.GetString("cb_codec.Items8")});
            this.cb_codec.Name = "cb_codec";
            // 
            // nFrameRate
            // 
            resources.ApplyResources(this.nFrameRate, "nFrameRate");
            this.nFrameRate.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nFrameRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nFrameRate.Name = "nFrameRate";
            this.nFrameRate.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Name = "label17";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Name = "label12";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Name = "label15";
            // 
            // nBitRate
            // 
            resources.ApplyResources(this.nBitRate, "nBitRate");
            this.nBitRate.DecimalPlaces = 1;
            this.nBitRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nBitRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nBitRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nBitRate.Name = "nBitRate";
            this.nBitRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // l_capture_file
            // 
            resources.ApplyResources(this.l_capture_file, "l_capture_file");
            this.l_capture_file.ForeColor = System.Drawing.Color.Gainsboro;
            this.l_capture_file.Name = "l_capture_file";
            // 
            // tabPageSettings
            // 
            resources.ApplyResources(this.tabPageSettings, "tabPageSettings");
            this.tabPageSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageSettings.Controls.Add(this.groupBox9);
            this.tabPageSettings.Controls.Add(this.cbCellcount);
            this.tabPageSettings.Controls.Add(this.label70);
            this.tabPageSettings.Controls.Add(this.l_i2cdatasupress);
            this.tabPageSettings.Controls.Add(this.b_check_update);
            this.tabPageSettings.Controls.Add(this.b_select_settings_folder);
            this.tabPageSettings.Controls.Add(this.l_Settings_folder);
            this.tabPageSettings.Controls.Add(this.label27);
            this.tabPageSettings.Controls.Add(this.groupBox11);
            this.tabPageSettings.Controls.Add(this.b_save_gui_settings);
            this.tabPageSettings.Controls.Add(this.cb_Logging_enabled);
            this.tabPageSettings.Controls.Add(this.b_select_capture_folder);
            this.tabPageSettings.Controls.Add(this.l_Capture_folder);
            this.tabPageSettings.Controls.Add(this.label24);
            this.tabPageSettings.Controls.Add(this.b_select_log_folder);
            this.tabPageSettings.Controls.Add(this.l_LogFolder);
            this.tabPageSettings.Controls.Add(this.label20);
            this.tabPageSettings.ForeColor = System.Drawing.Color.White;
            this.tabPageSettings.Name = "tabPageSettings";
            // 
            // groupBox9
            // 
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Controls.Add(this.label42);
            this.groupBox9.Controls.Add(this.comboSpeakInterval);
            this.groupBox9.Controls.Add(this.cbSpeakDist);
            this.groupBox9.Controls.Add(this.cbSpeakAlt);
            this.groupBox9.Controls.Add(this.cbSpeakBattery);
            this.groupBox9.Controls.Add(this.cbGUISpeechEnabled);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // comboSpeakInterval
            // 
            resources.ApplyResources(this.comboSpeakInterval, "comboSpeakInterval");
            this.comboSpeakInterval.FormattingEnabled = true;
            this.comboSpeakInterval.Items.AddRange(new object[] {
            resources.GetString("comboSpeakInterval.Items"),
            resources.GetString("comboSpeakInterval.Items1"),
            resources.GetString("comboSpeakInterval.Items2"),
            resources.GetString("comboSpeakInterval.Items3"),
            resources.GetString("comboSpeakInterval.Items4")});
            this.comboSpeakInterval.Name = "comboSpeakInterval";
            this.comboSpeakInterval.SelectedIndexChanged += new System.EventHandler(this.comboSpeakInterval_SelectedIndexChanged);
            // 
            // cbSpeakDist
            // 
            resources.ApplyResources(this.cbSpeakDist, "cbSpeakDist");
            this.cbSpeakDist.Name = "cbSpeakDist";
            this.cbSpeakDist.UseVisualStyleBackColor = true;
            this.cbSpeakDist.CheckedChanged += new System.EventHandler(this.cbSpeakDist_CheckedChanged);
            // 
            // cbSpeakAlt
            // 
            resources.ApplyResources(this.cbSpeakAlt, "cbSpeakAlt");
            this.cbSpeakAlt.Name = "cbSpeakAlt";
            this.cbSpeakAlt.UseVisualStyleBackColor = true;
            this.cbSpeakAlt.CheckedChanged += new System.EventHandler(this.cbSpeakAlt_CheckedChanged);
            // 
            // cbSpeakBattery
            // 
            resources.ApplyResources(this.cbSpeakBattery, "cbSpeakBattery");
            this.cbSpeakBattery.Name = "cbSpeakBattery";
            this.cbSpeakBattery.UseVisualStyleBackColor = true;
            this.cbSpeakBattery.CheckedChanged += new System.EventHandler(this.cbSpeakBattery_CheckedChanged);
            // 
            // cbGUISpeechEnabled
            // 
            resources.ApplyResources(this.cbGUISpeechEnabled, "cbGUISpeechEnabled");
            this.cbGUISpeechEnabled.Name = "cbGUISpeechEnabled";
            this.cbGUISpeechEnabled.UseVisualStyleBackColor = true;
            this.cbGUISpeechEnabled.Click += new System.EventHandler(this.cbGUISpeechEnabled_CheckedChanged);
            // 
            // cbCellcount
            // 
            resources.ApplyResources(this.cbCellcount, "cbCellcount");
            this.cbCellcount.FormattingEnabled = true;
            this.cbCellcount.Items.AddRange(new object[] {
            resources.GetString("cbCellcount.Items"),
            resources.GetString("cbCellcount.Items1"),
            resources.GetString("cbCellcount.Items2"),
            resources.GetString("cbCellcount.Items3"),
            resources.GetString("cbCellcount.Items4"),
            resources.GetString("cbCellcount.Items5"),
            resources.GetString("cbCellcount.Items6"),
            resources.GetString("cbCellcount.Items7"),
            resources.GetString("cbCellcount.Items8"),
            resources.GetString("cbCellcount.Items9")});
            this.cbCellcount.Name = "cbCellcount";
            this.cbCellcount.SelectedIndexChanged += new System.EventHandler(this.cbCellcount_SelectedIndexChanged);
            // 
            // label70
            // 
            resources.ApplyResources(this.label70, "label70");
            this.label70.Name = "label70";
            // 
            // l_i2cdatasupress
            // 
            resources.ApplyResources(this.l_i2cdatasupress, "l_i2cdatasupress");
            this.l_i2cdatasupress.Name = "l_i2cdatasupress";
            // 
            // b_check_update
            // 
            resources.ApplyResources(this.b_check_update, "b_check_update");
            this.b_check_update.ForeColor = System.Drawing.Color.Black;
            this.b_check_update.Name = "b_check_update";
            this.b_check_update.UseVisualStyleBackColor = true;
            this.b_check_update.Click += new System.EventHandler(this.b_check_update_Click);
            // 
            // b_select_settings_folder
            // 
            resources.ApplyResources(this.b_select_settings_folder, "b_select_settings_folder");
            this.b_select_settings_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_settings_folder.Name = "b_select_settings_folder";
            this.b_select_settings_folder.UseVisualStyleBackColor = true;
            this.b_select_settings_folder.Click += new System.EventHandler(this.b_select_settings_folder_Click);
            // 
            // l_Settings_folder
            // 
            resources.ApplyResources(this.l_Settings_folder, "l_Settings_folder");
            this.l_Settings_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Settings_folder.Name = "l_Settings_folder";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // groupBox11
            // 
            resources.ApplyResources(this.groupBox11, "groupBox11");
            this.groupBox11.Controls.Add(this.cb_Log10);
            this.groupBox11.Controls.Add(this.cb_Log9);
            this.groupBox11.Controls.Add(this.cb_Log8);
            this.groupBox11.Controls.Add(this.cb_Log7);
            this.groupBox11.Controls.Add(this.cb_Log6);
            this.groupBox11.Controls.Add(this.cb_Log5);
            this.groupBox11.Controls.Add(this.cb_Log4);
            this.groupBox11.Controls.Add(this.cb_Log3);
            this.groupBox11.Controls.Add(this.cb_Log2);
            this.groupBox11.Controls.Add(this.cb_Log1);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.TabStop = false;
            // 
            // cb_Log10
            // 
            resources.ApplyResources(this.cb_Log10, "cb_Log10");
            this.cb_Log10.Name = "cb_Log10";
            this.cb_Log10.UseVisualStyleBackColor = true;
            this.cb_Log10.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log9
            // 
            resources.ApplyResources(this.cb_Log9, "cb_Log9");
            this.cb_Log9.Name = "cb_Log9";
            this.cb_Log9.UseVisualStyleBackColor = true;
            this.cb_Log9.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log8
            // 
            resources.ApplyResources(this.cb_Log8, "cb_Log8");
            this.cb_Log8.Name = "cb_Log8";
            this.cb_Log8.UseVisualStyleBackColor = true;
            this.cb_Log8.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log7
            // 
            resources.ApplyResources(this.cb_Log7, "cb_Log7");
            this.cb_Log7.Name = "cb_Log7";
            this.cb_Log7.UseVisualStyleBackColor = true;
            this.cb_Log7.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log6
            // 
            resources.ApplyResources(this.cb_Log6, "cb_Log6");
            this.cb_Log6.Name = "cb_Log6";
            this.cb_Log6.UseVisualStyleBackColor = true;
            this.cb_Log6.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log5
            // 
            resources.ApplyResources(this.cb_Log5, "cb_Log5");
            this.cb_Log5.Name = "cb_Log5";
            this.cb_Log5.UseVisualStyleBackColor = true;
            this.cb_Log5.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log4
            // 
            resources.ApplyResources(this.cb_Log4, "cb_Log4");
            this.cb_Log4.Name = "cb_Log4";
            this.cb_Log4.UseVisualStyleBackColor = true;
            this.cb_Log4.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log3
            // 
            resources.ApplyResources(this.cb_Log3, "cb_Log3");
            this.cb_Log3.Name = "cb_Log3";
            this.cb_Log3.UseVisualStyleBackColor = true;
            this.cb_Log3.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log2
            // 
            resources.ApplyResources(this.cb_Log2, "cb_Log2");
            this.cb_Log2.Name = "cb_Log2";
            this.cb_Log2.UseVisualStyleBackColor = true;
            this.cb_Log2.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // cb_Log1
            // 
            resources.ApplyResources(this.cb_Log1, "cb_Log1");
            this.cb_Log1.Name = "cb_Log1";
            this.cb_Log1.UseVisualStyleBackColor = true;
            this.cb_Log1.Click += new System.EventHandler(this.log_option_Clicked);
            // 
            // b_save_gui_settings
            // 
            resources.ApplyResources(this.b_save_gui_settings, "b_save_gui_settings");
            this.b_save_gui_settings.BackColor = System.Drawing.Color.Transparent;
            this.b_save_gui_settings.ForeColor = System.Drawing.Color.Black;
            this.b_save_gui_settings.Name = "b_save_gui_settings";
            this.b_save_gui_settings.UseVisualStyleBackColor = false;
            this.b_save_gui_settings.Click += new System.EventHandler(this.b_save_gui_settings_Click);
            // 
            // cb_Logging_enabled
            // 
            resources.ApplyResources(this.cb_Logging_enabled, "cb_Logging_enabled");
            this.cb_Logging_enabled.Name = "cb_Logging_enabled";
            this.cb_Logging_enabled.UseVisualStyleBackColor = true;
            this.cb_Logging_enabled.Click += new System.EventHandler(this.cb_Logging_enabled_Click);
            // 
            // b_select_capture_folder
            // 
            resources.ApplyResources(this.b_select_capture_folder, "b_select_capture_folder");
            this.b_select_capture_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_capture_folder.Name = "b_select_capture_folder";
            this.b_select_capture_folder.UseVisualStyleBackColor = true;
            this.b_select_capture_folder.Click += new System.EventHandler(this.b_select_capture_folder_Click);
            // 
            // l_Capture_folder
            // 
            resources.ApplyResources(this.l_Capture_folder, "l_Capture_folder");
            this.l_Capture_folder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_Capture_folder.Name = "l_Capture_folder";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // b_select_log_folder
            // 
            resources.ApplyResources(this.b_select_log_folder, "b_select_log_folder");
            this.b_select_log_folder.ForeColor = System.Drawing.Color.Black;
            this.b_select_log_folder.Name = "b_select_log_folder";
            this.b_select_log_folder.UseVisualStyleBackColor = true;
            this.b_select_log_folder.Click += new System.EventHandler(this.b_select_log_folder_Click);
            // 
            // l_LogFolder
            // 
            resources.ApplyResources(this.l_LogFolder, "l_LogFolder");
            this.l_LogFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.l_LogFolder.Name = "l_LogFolder";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // tabPageCLI
            // 
            resources.ApplyResources(this.tabPageCLI, "tabPageCLI");
            this.tabPageCLI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageCLI.Controls.Add(this.gbTerminal);
            this.tabPageCLI.Name = "tabPageCLI";
            // 
            // gbTerminal
            // 
            resources.ApplyResources(this.gbTerminal, "gbTerminal");
            this.gbTerminal.Controls.Add(this.cmdCLISend);
            this.gbTerminal.Controls.Add(this.txtCLICommand);
            this.gbTerminal.Controls.Add(this.txtCLIResult);
            this.gbTerminal.Name = "gbTerminal";
            this.gbTerminal.TabStop = false;
            // 
            // cmdCLISend
            // 
            resources.ApplyResources(this.cmdCLISend, "cmdCLISend");
            this.cmdCLISend.Name = "cmdCLISend";
            this.cmdCLISend.UseVisualStyleBackColor = true;
            this.cmdCLISend.Click += new System.EventHandler(this.cmdCLISend_Click);
            // 
            // txtCLICommand
            // 
            resources.ApplyResources(this.txtCLICommand, "txtCLICommand");
            this.txtCLICommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCLICommand.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCLICommand.Name = "txtCLICommand";
            // 
            // txtCLIResult
            // 
            resources.ApplyResources(this.txtCLIResult, "txtCLIResult");
            this.txtCLIResult.AllowDrop = true;
            this.txtCLIResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCLIResult.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCLIResult.Name = "txtCLIResult";
            // 
            // timer_realtime
            // 
            this.timer_realtime.Tick += new System.EventHandler(this.timer_realtime_Tick);
            // 
            // bkgWorker
            // 
            this.bkgWorker.WorkerSupportsCancellation = true;
            this.bkgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorker_DoWork);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_serial_port,
            this.toolStripLabel2,
            this.cb_serial_speed,
            this.b_connect,
            this.toolStripSeparator1,
            this.b_read_settings,
            this.b_write_settings,
            this.b_reset,
            this.toolStripSeparator2,
            this.b_load_from_file,
            this.b_write_to_file,
            this.toolStripSeparator3,
            this.b_log,
            this.b_start_KML_log,
            this.b_log_browser,
            this.toolStripSeparator4,
            this.b_about,
            this.bDebugWindws});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // cb_serial_port
            // 
            resources.ApplyResources(this.cb_serial_port, "cb_serial_port");
            this.cb_serial_port.Name = "cb_serial_port";
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // cb_serial_speed
            // 
            resources.ApplyResources(this.cb_serial_speed, "cb_serial_speed");
            this.cb_serial_speed.Name = "cb_serial_speed";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // timer_announce
            // 
            this.timer_announce.Enabled = true;
            this.timer_announce.Interval = 30000;
            this.timer_announce.Tick += new System.EventHandler(this.timer_announce_Tick);
            // 
            // battery_indicator1
            // 
            resources.ApplyResources(this.battery_indicator1, "battery_indicator1");
            this.battery_indicator1.Name = "battery_indicator1";
            // 
            // vertical_speed_indicator1
            // 
            resources.ApplyResources(this.vertical_speed_indicator1, "vertical_speed_indicator1");
            this.vertical_speed_indicator1.Name = "vertical_speed_indicator1";
            // 
            // altitude_meter1
            // 
            resources.ApplyResources(this.altitude_meter1, "altitude_meter1");
            this.altitude_meter1.Name = "altitude_meter1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            resources.ApplyResources(this.attitudeIndicatorInstrumentControl1, "attitudeIndicatorInstrumentControl1");
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Click += new System.EventHandler(this.attitudeIndicatorInstrumentControl1_Click);
            // 
            // gpsIndicator
            // 
            resources.ApplyResources(this.gpsIndicator, "gpsIndicator");
            this.gpsIndicator.Name = "gpsIndicator";
            // 
            // headingIndicatorInstrumentControl1
            // 
            resources.ApplyResources(this.headingIndicatorInstrumentControl1, "headingIndicatorInstrumentControl1");
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            // 
            // rc_input_control1
            // 
            resources.ApplyResources(this.rc_input_control1, "rc_input_control1");
            this.rc_input_control1.Name = "rc_input_control1";
            // 
            // motorsIndicator1
            // 
            resources.ApplyResources(this.motorsIndicator1, "motorsIndicator1");
            this.motorsIndicator1.Name = "motorsIndicator1";
            // 
            // indACC
            // 
            resources.ApplyResources(this.indACC, "indACC");
            this.indACC.Name = "indACC";
            // 
            // indGPS
            // 
            resources.ApplyResources(this.indGPS, "indGPS");
            this.indGPS.Name = "indGPS";
            // 
            // indOPTIC
            // 
            resources.ApplyResources(this.indOPTIC, "indOPTIC");
            this.indOPTIC.Name = "indOPTIC";
            // 
            // indBARO
            // 
            resources.ApplyResources(this.indBARO, "indBARO");
            this.indBARO.Name = "indBARO";
            // 
            // indMAG
            // 
            resources.ApplyResources(this.indMAG, "indMAG");
            this.indMAG.Name = "indMAG";
            // 
            // indSONAR
            // 
            resources.ApplyResources(this.indSONAR, "indSONAR");
            this.indSONAR.Name = "indSONAR";
            // 
            // barNoise
            // 
            resources.ApplyResources(this.barNoise, "barNoise");
            this.barNoise.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barNoise.BkgColor = System.Drawing.Color.Transparent;
            this.barNoise.BorderColor = System.Drawing.Color.Black;
            this.barNoise.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barNoise.Maximum = 255;
            this.barNoise.Minimum = 0;
            this.barNoise.Name = "barNoise";
            this.barNoise.Step = 1;
            this.barNoise.Value = 0;
            // 
            // barRSSI
            // 
            resources.ApplyResources(this.barRSSI, "barRSSI");
            this.barRSSI.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barRSSI.BkgColor = System.Drawing.Color.Transparent;
            this.barRSSI.BorderColor = System.Drawing.Color.Black;
            this.barRSSI.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barRSSI.Maximum = 255;
            this.barRSSI.Minimum = 0;
            this.barRSSI.Name = "barRSSI";
            this.barRSSI.Step = 1;
            this.barRSSI.Value = 0;
            // 
            // battery_indicator2
            // 
            resources.ApplyResources(this.battery_indicator2, "battery_indicator2");
            this.battery_indicator2.Name = "battery_indicator2";
            // 
            // barRSSIMission
            // 
            resources.ApplyResources(this.barRSSIMission, "barRSSIMission");
            this.barRSSIMission.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.barRSSIMission.BkgColor = System.Drawing.Color.Transparent;
            this.barRSSIMission.BorderColor = System.Drawing.Color.Black;
            this.barRSSIMission.FillStyle = MultiWiiGUIControls.ColorProgressBar.FillStyles.Solid;
            this.barRSSIMission.Maximum = 255;
            this.barRSSIMission.Minimum = 0;
            this.barRSSIMission.Name = "barRSSIMission";
            this.barRSSIMission.Step = 1;
            this.barRSSIMission.Value = 0;
            // 
            // cbAutoPan
            // 
            resources.ApplyResources(this.cbAutoPan, "cbAutoPan");
            this.cbAutoPan.aux = 0;
            this.cbAutoPan.BackColor = System.Drawing.Color.Transparent;
            this.cbAutoPan.Checked = true;
            this.cbAutoPan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoPan.ForeColor = System.Drawing.Color.White;
            this.cbAutoPan.IsHighlighted = false;
            this.cbAutoPan.item = 0;
            this.cbAutoPan.Name = "cbAutoPan";
            this.cbAutoPan.rclevel = 0;
            this.cbAutoPan.UseVisualStyleBackColor = false;
            // 
            // cbShowGauges
            // 
            resources.ApplyResources(this.cbShowGauges, "cbShowGauges");
            this.cbShowGauges.aux = 0;
            this.cbShowGauges.BackColor = System.Drawing.Color.Transparent;
            this.cbShowGauges.ForeColor = System.Drawing.Color.White;
            this.cbShowGauges.IsHighlighted = false;
            this.cbShowGauges.item = 0;
            this.cbShowGauges.Name = "cbShowGauges";
            this.cbShowGauges.rclevel = 0;
            this.cbShowGauges.UseVisualStyleBackColor = false;
            this.cbShowGauges.CheckedChanged += new System.EventHandler(this.cbShowGauges_CheckedChanged);
            // 
            // altitude_meter2
            // 
            resources.ApplyResources(this.altitude_meter2, "altitude_meter2");
            this.altitude_meter2.Name = "altitude_meter2";
            // 
            // vertical_speed_indicator2
            // 
            resources.ApplyResources(this.vertical_speed_indicator2, "vertical_speed_indicator2");
            this.vertical_speed_indicator2.Name = "vertical_speed_indicator2";
            // 
            // gpsIndicator2
            // 
            resources.ApplyResources(this.gpsIndicator2, "gpsIndicator2");
            this.gpsIndicator2.Name = "gpsIndicator2";
            // 
            // cbNavBaroTakeover
            // 
            resources.ApplyResources(this.cbNavBaroTakeover, "cbNavBaroTakeover");
            this.cbNavBaroTakeover.aux = 0;
            this.cbNavBaroTakeover.ForeColor = System.Drawing.Color.White;
            this.cbNavBaroTakeover.IsHighlighted = false;
            this.cbNavBaroTakeover.item = 0;
            this.cbNavBaroTakeover.Name = "cbNavBaroTakeover";
            this.cbNavBaroTakeover.rclevel = 0;
            this.cbNavBaroTakeover.UseVisualStyleBackColor = true;
            // 
            // cbNavDisableSticks
            // 
            resources.ApplyResources(this.cbNavDisableSticks, "cbNavDisableSticks");
            this.cbNavDisableSticks.aux = 0;
            this.cbNavDisableSticks.ForeColor = System.Drawing.Color.White;
            this.cbNavDisableSticks.IsHighlighted = false;
            this.cbNavDisableSticks.item = 0;
            this.cbNavDisableSticks.Name = "cbNavDisableSticks";
            this.cbNavDisableSticks.rclevel = 0;
            this.cbNavDisableSticks.UseVisualStyleBackColor = true;
            // 
            // cbNavGPS_filtering
            // 
            resources.ApplyResources(this.cbNavGPS_filtering, "cbNavGPS_filtering");
            this.cbNavGPS_filtering.aux = 0;
            this.cbNavGPS_filtering.ForeColor = System.Drawing.Color.White;
            this.cbNavGPS_filtering.IsHighlighted = false;
            this.cbNavGPS_filtering.item = 0;
            this.cbNavGPS_filtering.Name = "cbNavGPS_filtering";
            this.cbNavGPS_filtering.rclevel = 0;
            this.cbNavGPS_filtering.UseVisualStyleBackColor = true;
            // 
            // cbNavGPS_Lead
            // 
            resources.ApplyResources(this.cbNavGPS_Lead, "cbNavGPS_Lead");
            this.cbNavGPS_Lead.aux = 0;
            this.cbNavGPS_Lead.ForeColor = System.Drawing.Color.White;
            this.cbNavGPS_Lead.IsHighlighted = false;
            this.cbNavGPS_Lead.item = 0;
            this.cbNavGPS_Lead.Name = "cbNavGPS_Lead";
            this.cbNavGPS_Lead.rclevel = 0;
            this.cbNavGPS_Lead.UseVisualStyleBackColor = true;
            // 
            // cbNavResetHome
            // 
            resources.ApplyResources(this.cbNavResetHome, "cbNavResetHome");
            this.cbNavResetHome.aux = 0;
            this.cbNavResetHome.ForeColor = System.Drawing.Color.White;
            this.cbNavResetHome.IsHighlighted = false;
            this.cbNavResetHome.item = 0;
            this.cbNavResetHome.Name = "cbNavResetHome";
            this.cbNavResetHome.rclevel = 0;
            this.cbNavResetHome.UseVisualStyleBackColor = true;
            // 
            // cbNavHeadingControl
            // 
            resources.ApplyResources(this.cbNavHeadingControl, "cbNavHeadingControl");
            this.cbNavHeadingControl.aux = 0;
            this.cbNavHeadingControl.ForeColor = System.Drawing.Color.White;
            this.cbNavHeadingControl.IsHighlighted = false;
            this.cbNavHeadingControl.item = 0;
            this.cbNavHeadingControl.Name = "cbNavHeadingControl";
            this.cbNavHeadingControl.rclevel = 0;
            this.cbNavHeadingControl.UseVisualStyleBackColor = true;
            // 
            // cbNavTailFirst
            // 
            resources.ApplyResources(this.cbNavTailFirst, "cbNavTailFirst");
            this.cbNavTailFirst.aux = 0;
            this.cbNavTailFirst.ForeColor = System.Drawing.Color.White;
            this.cbNavTailFirst.IsHighlighted = false;
            this.cbNavTailFirst.item = 0;
            this.cbNavTailFirst.Name = "cbNavTailFirst";
            this.cbNavTailFirst.rclevel = 0;
            this.cbNavTailFirst.UseVisualStyleBackColor = true;
            // 
            // cbNavRTHHead
            // 
            resources.ApplyResources(this.cbNavRTHHead, "cbNavRTHHead");
            this.cbNavRTHHead.aux = 0;
            this.cbNavRTHHead.ForeColor = System.Drawing.Color.White;
            this.cbNavRTHHead.IsHighlighted = false;
            this.cbNavRTHHead.item = 0;
            this.cbNavRTHHead.Name = "cbNavRTHHead";
            this.cbNavRTHHead.rclevel = 0;
            this.cbNavRTHHead.UseVisualStyleBackColor = true;
            this.cbNavRTHHead.CheckedChanged += new System.EventHandler(this.checkBoxEx5_CheckedChanged);
            // 
            // cbNavWaitRTHAlt
            // 
            resources.ApplyResources(this.cbNavWaitRTHAlt, "cbNavWaitRTHAlt");
            this.cbNavWaitRTHAlt.aux = 0;
            this.cbNavWaitRTHAlt.ForeColor = System.Drawing.Color.White;
            this.cbNavWaitRTHAlt.IsHighlighted = false;
            this.cbNavWaitRTHAlt.item = 0;
            this.cbNavWaitRTHAlt.Name = "cbNavWaitRTHAlt";
            this.cbNavWaitRTHAlt.rclevel = 0;
            this.cbNavWaitRTHAlt.UseVisualStyleBackColor = true;
            // 
            // cbNavSlowNav
            // 
            resources.ApplyResources(this.cbNavSlowNav, "cbNavSlowNav");
            this.cbNavSlowNav.aux = 0;
            this.cbNavSlowNav.ForeColor = System.Drawing.Color.White;
            this.cbNavSlowNav.IsHighlighted = false;
            this.cbNavSlowNav.item = 0;
            this.cbNavSlowNav.Name = "cbNavSlowNav";
            this.cbNavSlowNav.rclevel = 0;
            this.cbNavSlowNav.UseVisualStyleBackColor = true;
            // 
            // throttle_expo_control1
            // 
            resources.ApplyResources(this.throttle_expo_control1, "throttle_expo_control1");
            this.throttle_expo_control1.Name = "throttle_expo_control1";
            // 
            // rc_expo_control1
            // 
            resources.ApplyResources(this.rc_expo_control1, "rc_expo_control1");
            this.rc_expo_control1.Name = "rc_expo_control1";
            // 
            // cbSrvRev1
            // 
            resources.ApplyResources(this.cbSrvRev1, "cbSrvRev1");
            this.cbSrvRev1.aux = 0;
            this.cbSrvRev1.IsHighlighted = false;
            this.cbSrvRev1.item = 0;
            this.cbSrvRev1.Name = "cbSrvRev1";
            this.cbSrvRev1.rclevel = 0;
            this.cbSrvRev1.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev2
            // 
            resources.ApplyResources(this.cbSrvRev2, "cbSrvRev2");
            this.cbSrvRev2.aux = 0;
            this.cbSrvRev2.IsHighlighted = false;
            this.cbSrvRev2.item = 0;
            this.cbSrvRev2.Name = "cbSrvRev2";
            this.cbSrvRev2.rclevel = 0;
            this.cbSrvRev2.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev3
            // 
            resources.ApplyResources(this.cbSrvRev3, "cbSrvRev3");
            this.cbSrvRev3.aux = 0;
            this.cbSrvRev3.IsHighlighted = false;
            this.cbSrvRev3.item = 0;
            this.cbSrvRev3.Name = "cbSrvRev3";
            this.cbSrvRev3.rclevel = 0;
            this.cbSrvRev3.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev4
            // 
            resources.ApplyResources(this.cbSrvRev4, "cbSrvRev4");
            this.cbSrvRev4.aux = 0;
            this.cbSrvRev4.IsHighlighted = false;
            this.cbSrvRev4.item = 0;
            this.cbSrvRev4.Name = "cbSrvRev4";
            this.cbSrvRev4.rclevel = 0;
            this.cbSrvRev4.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev5
            // 
            resources.ApplyResources(this.cbSrvRev5, "cbSrvRev5");
            this.cbSrvRev5.aux = 0;
            this.cbSrvRev5.IsHighlighted = false;
            this.cbSrvRev5.item = 0;
            this.cbSrvRev5.Name = "cbSrvRev5";
            this.cbSrvRev5.rclevel = 0;
            this.cbSrvRev5.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev6
            // 
            resources.ApplyResources(this.cbSrvRev6, "cbSrvRev6");
            this.cbSrvRev6.aux = 0;
            this.cbSrvRev6.IsHighlighted = false;
            this.cbSrvRev6.item = 0;
            this.cbSrvRev6.Name = "cbSrvRev6";
            this.cbSrvRev6.rclevel = 0;
            this.cbSrvRev6.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev7
            // 
            resources.ApplyResources(this.cbSrvRev7, "cbSrvRev7");
            this.cbSrvRev7.aux = 0;
            this.cbSrvRev7.IsHighlighted = false;
            this.cbSrvRev7.item = 0;
            this.cbSrvRev7.Name = "cbSrvRev7";
            this.cbSrvRev7.rclevel = 0;
            this.cbSrvRev7.UseVisualStyleBackColor = true;
            // 
            // cbSrvRev8
            // 
            resources.ApplyResources(this.cbSrvRev8, "cbSrvRev8");
            this.cbSrvRev8.aux = 0;
            this.cbSrvRev8.IsHighlighted = false;
            this.cbSrvRev8.item = 0;
            this.cbSrvRev8.Name = "cbSrvRev8";
            this.cbSrvRev8.rclevel = 0;
            this.cbSrvRev8.UseVisualStyleBackColor = true;
            // 
            // rci_Control_settings
            // 
            resources.ApplyResources(this.rci_Control_settings, "rci_Control_settings");
            this.rci_Control_settings.Name = "rci_Control_settings";
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::MultiWiiWinGUI.Properties.Resources.up_btn;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::MultiWiiWinGUI.Properties.Resources.down_btn;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            resources.ApplyResources(this.dataGridViewImageColumn3, "dataGridViewImageColumn3");
            this.dataGridViewImageColumn3.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // tsMenuAddWP
            // 
            resources.ApplyResources(this.tsMenuAddWP, "tsMenuAddWP");
            this.tsMenuAddWP.Image = global::MultiWiiWinGUI.Properties.Resources.wpicon;
            this.tsMenuAddWP.Name = "tsMenuAddWP";
            this.tsMenuAddWP.Click += new System.EventHandler(this.tsMenuAddWP_Click);
            // 
            // tsMenuAddPosholdTimed
            // 
            resources.ApplyResources(this.tsMenuAddPosholdTimed, "tsMenuAddPosholdTimed");
            this.tsMenuAddPosholdTimed.Image = global::MultiWiiWinGUI.Properties.Resources.phicon;
            this.tsMenuAddPosholdTimed.Name = "tsMenuAddPosholdTimed";
            this.tsMenuAddPosholdTimed.Click += new System.EventHandler(this.tsMenuAddPosholdTimed_Click);
            // 
            // tsMenuAddPosholdUnlim
            // 
            resources.ApplyResources(this.tsMenuAddPosholdUnlim, "tsMenuAddPosholdUnlim");
            this.tsMenuAddPosholdUnlim.Image = global::MultiWiiWinGUI.Properties.Resources.poshold_unlim;
            this.tsMenuAddPosholdUnlim.Name = "tsMenuAddPosholdUnlim";
            this.tsMenuAddPosholdUnlim.Click += new System.EventHandler(this.tsMenuAddPosholdUnlim_Click);
            // 
            // tsMenuAddRTH
            // 
            resources.ApplyResources(this.tsMenuAddRTH, "tsMenuAddRTH");
            this.tsMenuAddRTH.Image = global::MultiWiiWinGUI.Properties.Resources.bluehome;
            this.tsMenuAddRTH.Name = "tsMenuAddRTH";
            this.tsMenuAddRTH.Click += new System.EventHandler(this.tsMenuAddRTH_Click);
            // 
            // clearMissionToolStripMenuItem
            // 
            resources.ApplyResources(this.clearMissionToolStripMenuItem, "clearMissionToolStripMenuItem");
            this.clearMissionToolStripMenuItem.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.clearMissionToolStripMenuItem.Name = "clearMissionToolStripMenuItem";
            this.clearMissionToolStripMenuItem.Click += new System.EventHandler(this.clearMissionToolStripMenuItem_Click);
            // 
            // UP
            // 
            resources.ApplyResources(this.UP, "UP");
            this.UP.Image = global::MultiWiiWinGUI.Properties.Resources.up_btn;
            this.UP.Name = "UP";
            // 
            // Down
            // 
            resources.ApplyResources(this.Down, "Down");
            this.Down.Image = global::MultiWiiWinGUI.Properties.Resources.down_btn;
            this.Down.Name = "Down";
            // 
            // DEL
            // 
            resources.ApplyResources(this.DEL, "DEL");
            this.DEL.Image = global::MultiWiiWinGUI.Properties.Resources.del_btn;
            this.DEL.Name = "DEL";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::MultiWiiWinGUI.Properties.Resources.checkbox_legend;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // b_connect
            // 
            resources.ApplyResources(this.b_connect, "b_connect");
            this.b_connect.Image = global::MultiWiiWinGUI.Properties.Resources.connect;
            this.b_connect.Name = "b_connect";
            this.b_connect.Click += new System.EventHandler(this.b_connect_Click);
            // 
            // b_read_settings
            // 
            resources.ApplyResources(this.b_read_settings, "b_read_settings");
            this.b_read_settings.Image = global::MultiWiiWinGUI.Properties.Resources.read_settings;
            this.b_read_settings.Name = "b_read_settings";
            this.b_read_settings.Click += new System.EventHandler(this.b_read_settings_Click);
            // 
            // b_write_settings
            // 
            resources.ApplyResources(this.b_write_settings, "b_write_settings");
            this.b_write_settings.Image = global::MultiWiiWinGUI.Properties.Resources.write_settings;
            this.b_write_settings.Name = "b_write_settings";
            this.b_write_settings.Click += new System.EventHandler(this.b_write_settings_Click);
            // 
            // b_reset
            // 
            resources.ApplyResources(this.b_reset, "b_reset");
            this.b_reset.Image = global::MultiWiiWinGUI.Properties.Resources.reset;
            this.b_reset.Name = "b_reset";
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // b_load_from_file
            // 
            resources.ApplyResources(this.b_load_from_file, "b_load_from_file");
            this.b_load_from_file.Image = global::MultiWiiWinGUI.Properties.Resources.load_from_file;
            this.b_load_from_file.Name = "b_load_from_file";
            this.b_load_from_file.Click += new System.EventHandler(this.b_load_from_file_Click);
            // 
            // b_write_to_file
            // 
            resources.ApplyResources(this.b_write_to_file, "b_write_to_file");
            this.b_write_to_file.Image = global::MultiWiiWinGUI.Properties.Resources.write_to_file;
            this.b_write_to_file.Name = "b_write_to_file";
            this.b_write_to_file.Click += new System.EventHandler(this.b_write_to_file_Click);
            // 
            // b_log
            // 
            resources.ApplyResources(this.b_log, "b_log");
            this.b_log.Image = global::MultiWiiWinGUI.Properties.Resources.start_log;
            this.b_log.Name = "b_log";
            this.b_log.Click += new System.EventHandler(this.b_log_Click);
            // 
            // b_start_KML_log
            // 
            resources.ApplyResources(this.b_start_KML_log, "b_start_KML_log");
            this.b_start_KML_log.BackColor = System.Drawing.Color.Transparent;
            this.b_start_KML_log.Image = global::MultiWiiWinGUI.Properties.Resources.earth_3;
            this.b_start_KML_log.Name = "b_start_KML_log";
            this.b_start_KML_log.Click += new System.EventHandler(this.b_start_KML_log_Click);
            // 
            // b_log_browser
            // 
            resources.ApplyResources(this.b_log_browser, "b_log_browser");
            this.b_log_browser.Image = global::MultiWiiWinGUI.Properties.Resources.logbrowser;
            this.b_log_browser.Name = "b_log_browser";
            this.b_log_browser.Click += new System.EventHandler(this.b_log_browser_Click);
            // 
            // b_about
            // 
            resources.ApplyResources(this.b_about, "b_about");
            this.b_about.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.b_about.Image = global::MultiWiiWinGUI.Properties.Resources.about;
            this.b_about.Name = "b_about";
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // bDebugWindws
            // 
            resources.ApplyResources(this.bDebugWindws, "bDebugWindws");
            this.bDebugWindws.Name = "bDebugWindws";
            this.bDebugWindws.Click += new System.EventHandler(this.bDebugWindws_Click);
            // 
            // mainGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mainGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainGUI_FormClosing);
            this.Load += new System.EventHandler(this.mainGUI_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPageFlightDeck.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPageMisson.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.spcontMapMain.Panel1.ResumeLayout(false);
            this.spcontMapMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcontMapMain)).EndInit();
            this.spcontMapMain.ResumeLayout(false);
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel1.PerformLayout();
            this.splitContainer9.Panel2.ResumeLayout(false);
            this.splitContainer9.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            this.splitContainer8.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.missionDataGrid)).EndInit();
            this.tabPagePID.ResumeLayout(false);
            this.tabPagePID.PerformLayout();
            this.naviGroup.ResumeLayout(false);
            this.naviGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLandSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCrosstrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRTHAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWPRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSafeWPDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMaxAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTEXPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_EXPO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_T_MID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Rate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_RC_Expo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRCExpo)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_tpid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRATE_rp)).EndInit();
            this.tabPageConf.ResumeLayout(false);
            this.tabPageConf.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nFSThr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMinThr)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatWarn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVBatScale)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMagDeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMagMin)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMax1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvMin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSrvRate8)).EndInit();
            this.tabPageRC.ResumeLayout(false);
            this.tabPageRC.PerformLayout();
            this.tabSensorGraph.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            this.splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel1.PerformLayout();
            this.splitContainer12.Panel2.ResumeLayout(false);
            this.splitContainer12.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageVideo.ResumeLayout(false);
            this.tabPageVideo.PerformLayout();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nFrameRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nBitRate)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPageCLI.ResumeLayout(false);
            this.gbTerminal.ResumeLayout(false);
            this.gbTerminal.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageRC;
        private System.Windows.Forms.TabPage tabPagePID;
        private System.Windows.Forms.TabPage tabPageFlightDeck;
        private System.Windows.Forms.Timer timer_realtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_monitor_rate;
        private MultiWiiGUIControls.artifical_horizon attitudeIndicatorInstrumentControl1;
        private MultiWiiGUIControls.heading_indicator headingIndicatorInstrumentControl1;
        private MultiWiiGUIControls.GpsIndicatorInstrumentControl gpsIndicator;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label_sok;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.NumericUpDown nRATE_tpid;
        private System.Windows.Forms.NumericUpDown nRATE_yaw;
        private System.Windows.Forms.NumericUpDown nRATE_rp;
        private MultiWiiGUIControls.MWGUIMotors motorsIndicator1;
        private System.Windows.Forms.TabPage tabPageVideo;
        private MultiWiiGUIControls.rc_input_control rc_input_control1;
        private System.Windows.Forms.Button b_pause;
        private MultiWiiGUIControls.rc_input_control rci_Control_settings;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TrackBar trackbar_RC_Rate;
        private System.Windows.Forms.TrackBar trackbar_RC_Expo;
        private MultiWiiGUIControls.rc_expo_control rc_expo_control1;
        private System.ComponentModel.BackgroundWorker bkgWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nRCExpo;
        private System.Windows.Forms.NumericUpDown nRCRate;
        private System.Windows.Forms.Button b_cal_acc;
        private System.Windows.Forms.Button b_cal_mag;
        private MultiWiiGUIControls.indicator_lamp indGPS;
        private MultiWiiGUIControls.indicator_lamp indSONAR;
        private MultiWiiGUIControls.indicator_lamp indMAG;
        private MultiWiiGUIControls.indicator_lamp indBARO;
        private MultiWiiGUIControls.indicator_lamp indACC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label l_cycletime;
        private System.Windows.Forms.Label l_vbatt;
        private System.Windows.Forms.Label l_powersum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_video_connect;
        private System.Windows.Forms.ComboBox dropdown_devices;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.Button b_Record;
        private System.Windows.Forms.ComboBox cb_codec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nBitRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nFrameRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Button b_select_log_folder;
        private System.Windows.Forms.Label l_LogFolder;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button b_select_capture_folder;
        private System.Windows.Forms.Label l_Capture_folder;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button b_save_gui_settings;
        private System.Windows.Forms.CheckBox cb_Logging_enabled;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label l_capture_file;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox cb_Log10;
        private System.Windows.Forms.CheckBox cb_Log9;
        private System.Windows.Forms.CheckBox cb_Log8;
        private System.Windows.Forms.CheckBox cb_Log7;
        private System.Windows.Forms.CheckBox cb_Log6;
        private System.Windows.Forms.CheckBox cb_Log5;
        private System.Windows.Forms.CheckBox cb_Log4;
        private System.Windows.Forms.CheckBox cb_Log3;
        private System.Windows.Forms.CheckBox cb_Log2;
        private System.Windows.Forms.CheckBox cb_Log1;
        private System.Windows.Forms.Label l_i2cerrors;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button b_select_settings_folder;
        private System.Windows.Forms.Label l_Settings_folder;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button b_check_update;
        private System.Windows.Forms.Label l_i2cdatasupress;
        private System.Windows.Forms.TrackBar trackBar_T_EXPO;
        private System.Windows.Forms.TrackBar trackBar_T_MID;
        private MultiWiiGUIControls.throttle_expo_control throttle_expo_control1;
        private System.Windows.Forms.NumericUpDown nTEXPO;
        private System.Windows.Forms.NumericUpDown nTMID;
        private System.Windows.Forms.TabPage tabPageMisson;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_serial_port;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cb_serial_speed;
        private System.Windows.Forms.ToolStripButton b_connect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton b_read_settings;
        private System.Windows.Forms.ToolStripButton b_write_settings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton b_load_from_file;
        private System.Windows.Forms.ToolStripButton b_write_to_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton b_log;
        private System.Windows.Forms.ToolStripButton b_log_browser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton b_about;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MultiWiiGUIControls.indicator_lamp indOPTIC;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lGPS_lat;
        private System.Windows.Forms.Label lGPS_lon;
        private System.Windows.Forms.ToolStripButton b_start_KML_log;
        private System.Windows.Forms.Label l_GPS_numsat;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label l_GPS_alt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button b_Clear_Route;
        private System.Windows.Forms.Label labelCRCErrors;
        private System.Windows.Forms.Label labelReceivedPackets;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer spcontMapMain;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbMapProviders;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.Label LMousePos;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ToolStripButton b_reset;
        private System.Windows.Forms.TabPage tabPageCLI;
        private System.Windows.Forms.GroupBox gbTerminal;
        private System.Windows.Forms.Button cmdCLISend;
        private System.Windows.Forms.TextBox txtCLICommand;
        private System.Windows.Forms.TextBox txtCLIResult;
        private System.Windows.Forms.DataGridView missionDataGrid;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Label lDistance;
        private System.Windows.Forms.CheckBox cbShowMission;
        private System.Windows.Forms.CheckBox cbShowWP;
        private System.Windows.Forms.CheckBox cbShowFlightPath;
        private System.Windows.Forms.CheckBox cbShowPos;
        private System.Windows.Forms.Button bClickToGo;
        private System.Windows.Forms.Label lDefAlt;
        private System.Windows.Forms.TextBox txtDefAlt;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button btnLoadMission;
        private System.Windows.Forms.Button btnSaveMission;
        private System.Windows.Forms.Button btnDownLoadMission;
        private System.Windows.Forms.Button btnUploadMission;
        private System.Windows.Forms.TextBox txtGTCAlt;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label lDistLastWP;
        private System.Windows.Forms.CheckBox cbSendGTCAlt;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ToolStripButton bDebugWindws;
        private System.Windows.Forms.TabPage tabPageConf;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown nMagMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nMagDeg;
        private System.Windows.Forms.ComboBox cbMagSign;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown nSrvRate4;
        private System.Windows.Forms.Label label56;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev1;
        private System.Windows.Forms.Label label55;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev2;
        private System.Windows.Forms.Label label54;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev3;
        private System.Windows.Forms.Label label53;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev4;
        private System.Windows.Forms.Label label52;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev5;
        private System.Windows.Forms.Label label51;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev6;
        private System.Windows.Forms.NumericUpDown nSrvMax8;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev7;
        private System.Windows.Forms.NumericUpDown nSrvMax7;
        private MultiWiiGUIControls.CheckBoxEx cbSrvRev8;
        private System.Windows.Forms.NumericUpDown nSrvMax6;
        private System.Windows.Forms.Label lSrvID1;
        private System.Windows.Forms.NumericUpDown nSrvMax5;
        private System.Windows.Forms.Label lSrvID2;
        private System.Windows.Forms.NumericUpDown nSrvMax4;
        private System.Windows.Forms.Label lSrvID3;
        private System.Windows.Forms.NumericUpDown nSrvMax3;
        private System.Windows.Forms.Label lSrvID4;
        private System.Windows.Forms.NumericUpDown nSrvMax2;
        private System.Windows.Forms.Label lSrvID5;
        private System.Windows.Forms.NumericUpDown nSrvMax1;
        private System.Windows.Forms.Label lSrvID6;
        private System.Windows.Forms.NumericUpDown nSrvMid8;
        private System.Windows.Forms.Label lSrvID7;
        private System.Windows.Forms.NumericUpDown nSrvMid7;
        private System.Windows.Forms.Label lSrvID8;
        private System.Windows.Forms.NumericUpDown nSrvMid6;
        private System.Windows.Forms.Label lSrvName1;
        private System.Windows.Forms.NumericUpDown nSrvMid5;
        private System.Windows.Forms.Label lSrvName3;
        private System.Windows.Forms.NumericUpDown nSrvMid4;
        private System.Windows.Forms.Label lSrvName2;
        private System.Windows.Forms.NumericUpDown nSrvMid3;
        private System.Windows.Forms.Label lSrvName4;
        private System.Windows.Forms.NumericUpDown nSrvMid2;
        private System.Windows.Forms.Label lSrvName5;
        private System.Windows.Forms.NumericUpDown nSrvMid1;
        private System.Windows.Forms.Label lSrvName6;
        private System.Windows.Forms.NumericUpDown nSrvMin8;
        private System.Windows.Forms.Label lSrvName7;
        private System.Windows.Forms.NumericUpDown nSrvMin7;
        private System.Windows.Forms.Label lSrvName8;
        private System.Windows.Forms.NumericUpDown nSrvMin6;
        private System.Windows.Forms.NumericUpDown nSrvRate1;
        private System.Windows.Forms.NumericUpDown nSrvMin5;
        private System.Windows.Forms.NumericUpDown nSrvRate2;
        private System.Windows.Forms.NumericUpDown nSrvMin4;
        private System.Windows.Forms.NumericUpDown nSrvRate3;
        private System.Windows.Forms.NumericUpDown nSrvMin3;
        private System.Windows.Forms.NumericUpDown nSrvRate5;
        private System.Windows.Forms.NumericUpDown nSrvMin2;
        private System.Windows.Forms.NumericUpDown nSrvRate6;
        private System.Windows.Forms.NumericUpDown nSrvMin1;
        private System.Windows.Forms.NumericUpDown nSrvRate7;
        private System.Windows.Forms.NumericUpDown nSrvRate8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nPAlarm;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nVBatCritical;
        private System.Windows.Forms.NumericUpDown nVBatWarn2;
        private System.Windows.Forms.NumericUpDown nVBatWarn1;
        private System.Windows.Forms.NumericUpDown nVBatScale;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lMaxThr;
        private System.Windows.Forms.NumericUpDown nFSThr;
        private System.Windows.Forms.NumericUpDown nMinThr;
        private System.Windows.Forms.Label lMinCommand;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lLife;
        private System.Windows.Forms.Label lArms;
        private System.Windows.Forms.Button bBind;
        private System.Windows.Forms.TabPage tabSensorGraph;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private ZedGraph.ZedGraphControl zgMonitor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox cb_dbg1;
        private System.Windows.Forms.Label l_dbg1;
        private System.Windows.Forms.CheckBox cb_dbg2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label l_dbg2;
        private System.Windows.Forms.CheckBox cb_dbg3;
        private System.Windows.Forms.Label l_dbg4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label l_dbg3;
        private System.Windows.Forms.CheckBox cb_dbg4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_uncheck_all_ACC;
        private System.Windows.Forms.Button b_check_all_ACC;
        private System.Windows.Forms.Label l_acc_z;
        private System.Windows.Forms.Label l_acc_pitch;
        private System.Windows.Forms.Label l_acc_roll;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox cb_acc_z;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cb_acc_pitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cb_acc_roll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_uncheck_all_GYRO;
        private System.Windows.Forms.Button b_check_all_GYRO;
        private System.Windows.Forms.Label l_gyro_yaw;
        private System.Windows.Forms.Label l_gyro_pitch;
        private System.Windows.Forms.Label l_gyro_roll;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox cb_gyro_yaw;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox cb_gyro_pitch;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox cb_gyro_roll;
        private System.Windows.Forms.CheckBox cb_alt;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_uncheck_all_MAG;
        private System.Windows.Forms.Button b_check_all_MAG;
        private System.Windows.Forms.Label l_mag_yaw;
        private System.Windows.Forms.Label l_mag_pitch;
        private System.Windows.Forms.Label l_mag_roll;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox cb_mag_yaw;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox cb_mag_pitch;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox cb_mag_roll;
        private System.Windows.Forms.Label l_alt;
        private System.Windows.Forms.CheckBox cb_head;
        private System.Windows.Forms.Label l_head;
        private System.Windows.Forms.Label label26;
        private MultiWiiGUIControls.altitude_meter altitude_meter1;
        private MultiWiiGUIControls.vertical_speed_indicator vertical_speed_indicator1;
        private System.Windows.Forms.Label labelSentPackets;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label lNavState;
        private System.Windows.Forms.Label lGpsMode;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label lNavError;
        private System.Windows.Forms.Label labelNoise;
        private System.Windows.Forms.Label labelRSSI;
        private MultiWiiGUIControls.ColorProgressBar barRSSI;
        private MultiWiiGUIControls.ColorProgressBar barNoise;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label81;
        private MultiWiiGUIControls.GpsIndicatorInstrumentControl gpsIndicator2;
        private MultiWiiGUIControls.altitude_meter altitude_meter2;
        private MultiWiiGUIControls.vertical_speed_indicator vertical_speed_indicator2;
        private MultiWiiGUIControls.CheckBoxEx cbShowGauges;
        private MultiWiiGUIControls.CheckBoxEx cbAutoPan;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddWP;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPosholdTimed;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPosholdUnlim;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddRTH;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddJump;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddPOI;
        private System.Windows.Forms.ToolStripMenuItem tsMenuSetHead;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem clearMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCircleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkAltitudeChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuDeleteWP;
        private System.Windows.Forms.Label label75;
        private MultiWiiGUIControls.CheckBoxEx cbNavSlowNav;
        private MultiWiiGUIControls.CheckBoxEx cbNavWaitRTHAlt;
        private MultiWiiGUIControls.CheckBoxEx cbNavRTHHead;
        private MultiWiiGUIControls.CheckBoxEx cbNavTailFirst;
        private MultiWiiGUIControls.CheckBoxEx cbNavHeadingControl;
        private MultiWiiGUIControls.CheckBoxEx cbNavResetHome;
        private MultiWiiGUIControls.CheckBoxEx cbNavGPS_Lead;
        private MultiWiiGUIControls.CheckBoxEx cbNavGPS_filtering;
        private System.Windows.Forms.NumericUpDown nWPRadius;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.NumericUpDown nBanking;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.NumericUpDown nCrosstrack;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.NumericUpDown nRTHAlt;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.NumericUpDown nMinSpeed;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.NumericUpDown nMaxSpeed;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.NumericUpDown nMaxAlt;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.NumericUpDown nSafeWPDist;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.CheckBox cbGUISpeechEnabled;
        private MultiWiiGUIControls.ColorProgressBar barRSSIMission;
        private System.Windows.Forms.GroupBox naviGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem fetchMapTilesToolStripMenuItem;
        private System.Windows.Forms.Label label70;
        private MultiWiiGUIControls.CheckBoxEx cbNavDisableSticks;
        private MultiWiiGUIControls.CheckBoxEx cbNavBaroTakeover;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.NumericUpDown nFence;
        private System.Windows.Forms.ToolStripMenuItem tsMenuAddLand;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewComboBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Par3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LATCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LONCOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTCOL;
        private System.Windows.Forms.DataGridViewImageColumn UP;
        private System.Windows.Forms.DataGridViewImageColumn Down;
        private System.Windows.Forms.DataGridViewImageColumn DEL;
        private MultiWiiGUIControls.battery_indicator battery_indicator1;
        private System.Windows.Forms.ComboBox cbCellcount;
        private MultiWiiGUIControls.battery_indicator battery_indicator2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown nLandSpeed;
        private System.Windows.Forms.Button btnMapZoopDown;
        private System.Windows.Forms.Button btnMapZoomUp;
        private System.Windows.Forms.Label lVBatConf;
        private System.Windows.Forms.Label labelvbat;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox comboSpeakInterval;
        private System.Windows.Forms.CheckBox cbSpeakDist;
        private System.Windows.Forms.CheckBox cbSpeakAlt;
        private System.Windows.Forms.CheckBox cbSpeakBattery;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Timer timer_announce;
    }
}

