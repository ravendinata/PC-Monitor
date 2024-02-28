namespace PC_Monitor
{
    partial class SrvSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SrvSoftware));
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIntercal = new System.Windows.Forms.Label();
            this.ComboInterval = new System.Windows.Forms.ComboBox();
            this.ComboPort = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsRealtime = new System.Windows.Forms.ToolStripStatusLabel();
            this.testStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.timerProcessingUnitLoad = new System.Windows.Forms.Timer(this.components);
            this.timerTempSensor = new System.Windows.Forms.Timer(this.components);
            this.comboCpuUsageInterval = new System.Windows.Forms.ComboBox();
            this.lblCpuLoadInterval = new System.Windows.Forms.Label();
            this.comboTempInterval = new System.Windows.Forms.ComboBox();
            this.lblTempInterval = new System.Windows.Forms.Label();
            this.lblIntervals = new System.Windows.Forms.Label();
            this.timerRamUsage = new System.Windows.Forms.Timer(this.components);
            this.comboRamUsageInterval = new System.Windows.Forms.ComboBox();
            this.lblRamUsage = new System.Windows.Forms.Label();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayLblOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.trayConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.trayDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleWidgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSensorTiming = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWidgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeTimer = new System.Windows.Forms.Timer(this.components);
            this.grpConsole = new System.Windows.Forms.GroupBox();
            this.btnClearConsole = new System.Windows.Forms.Button();
            this.console = new System.Windows.Forms.RichTextBox();
            this.portWatcherTimer = new System.Windows.Forms.Timer(this.components);
            this.btnIdent = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.resetWidgetPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.grpSensorTiming.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(26, 41);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(72, 13);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Set COM Port";
            // 
            // lblIntercal
            // 
            this.lblIntercal.AutoSize = true;
            this.lblIntercal.Location = new System.Drawing.Point(26, 121);
            this.lblIntercal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntercal.Name = "lblIntercal";
            this.lblIntercal.Size = new System.Drawing.Size(64, 13);
            this.lblIntercal.TabIndex = 1;
            this.lblIntercal.Text = "Port Interval";
            // 
            // ComboInterval
            // 
            this.ComboInterval.FormattingEnabled = true;
            this.ComboInterval.Items.AddRange(new object[] {
            "500",
            "750",
            "1000",
            "1500",
            "2000"});
            this.ComboInterval.Location = new System.Drawing.Point(28, 138);
            this.ComboInterval.Margin = new System.Windows.Forms.Padding(2);
            this.ComboInterval.Name = "ComboInterval";
            this.ComboInterval.Size = new System.Drawing.Size(138, 21);
            this.ComboInterval.TabIndex = 2;
            this.ComboInterval.Text = "1000";
            // 
            // ComboPort
            // 
            this.ComboPort.FormattingEnabled = true;
            this.ComboPort.Location = new System.Drawing.Point(28, 57);
            this.ComboPort.Margin = new System.Windows.Forms.Padding(2);
            this.ComboPort.Name = "ComboPort";
            this.ComboPort.Size = new System.Drawing.Size(77, 21);
            this.ComboPort.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.StsRealtime,
            this.testStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 511);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(346, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // StsRealtime
            // 
            this.StsRealtime.BackColor = System.Drawing.SystemColors.Control;
            this.StsRealtime.Name = "StsRealtime";
            this.StsRealtime.Size = new System.Drawing.Size(88, 17);
            this.StsRealtime.Text = "Realtime Status";
            // 
            // testStrip
            // 
            this.testStrip.Name = "testStrip";
            this.testStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BtnConnect
            // 
            this.BtnConnect.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnConnect.FlatAppearance.BorderSize = 0;
            this.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnect.ForeColor = System.Drawing.Color.White;
            this.BtnConnect.Location = new System.Drawing.Point(249, 57);
            this.BtnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 21);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = false;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.BackColor = System.Drawing.Color.Red;
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.FlatAppearance.BorderSize = 0;
            this.BtnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisconnect.ForeColor = System.Drawing.Color.White;
            this.BtnDisconnect.Location = new System.Drawing.Point(249, 82);
            this.BtnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(75, 21);
            this.BtnDisconnect.TabIndex = 6;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = false;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(26, 80);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(40, 13);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "Status:";
            // 
            // timerProcessingUnitLoad
            // 
            this.timerProcessingUnitLoad.Interval = 500;
            this.timerProcessingUnitLoad.Tick += new System.EventHandler(this.TimerProcessingUnitLoad_Tick);
            // 
            // timerTempSensor
            // 
            this.timerTempSensor.Interval = 500;
            this.timerTempSensor.Tick += new System.EventHandler(this.TimerTempSensor_Tick);
            // 
            // comboCpuUsageInterval
            // 
            this.comboCpuUsageInterval.FormattingEnabled = true;
            this.comboCpuUsageInterval.Items.AddRange(new object[] {
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "5000"});
            this.comboCpuUsageInterval.Location = new System.Drawing.Point(16, 38);
            this.comboCpuUsageInterval.Margin = new System.Windows.Forms.Padding(2);
            this.comboCpuUsageInterval.Name = "comboCpuUsageInterval";
            this.comboCpuUsageInterval.Size = new System.Drawing.Size(130, 21);
            this.comboCpuUsageInterval.TabIndex = 9;
            this.comboCpuUsageInterval.Text = "1000";
            // 
            // lblCpuLoadInterval
            // 
            this.lblCpuLoadInterval.AutoSize = true;
            this.lblCpuLoadInterval.Location = new System.Drawing.Point(14, 22);
            this.lblCpuLoadInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpuLoadInterval.Name = "lblCpuLoadInterval";
            this.lblCpuLoadInterval.Size = new System.Drawing.Size(84, 13);
            this.lblCpuLoadInterval.TabIndex = 8;
            this.lblCpuLoadInterval.Text = "CPU/GPU Load";
            // 
            // comboTempInterval
            // 
            this.comboTempInterval.FormattingEnabled = true;
            this.comboTempInterval.Items.AddRange(new object[] {
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "5000"});
            this.comboTempInterval.Location = new System.Drawing.Point(16, 85);
            this.comboTempInterval.Margin = new System.Windows.Forms.Padding(2);
            this.comboTempInterval.Name = "comboTempInterval";
            this.comboTempInterval.Size = new System.Drawing.Size(130, 21);
            this.comboTempInterval.TabIndex = 11;
            this.comboTempInterval.Text = "1000";
            // 
            // lblTempInterval
            // 
            this.lblTempInterval.AutoSize = true;
            this.lblTempInterval.Location = new System.Drawing.Point(14, 69);
            this.lblTempInterval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTempInterval.Name = "lblTempInterval";
            this.lblTempInterval.Size = new System.Drawing.Size(103, 13);
            this.lblTempInterval.TabIndex = 10;
            this.lblTempInterval.Text = "Temperature Sensor";
            // 
            // lblIntervals
            // 
            this.lblIntervals.AutoSize = true;
            this.lblIntervals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervals.Location = new System.Drawing.Point(26, 107);
            this.lblIntervals.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIntervals.Name = "lblIntervals";
            this.lblIntervals.Size = new System.Drawing.Size(83, 13);
            this.lblIntervals.TabIndex = 12;
            this.lblIntervals.Text = "Intervals (ms)";
            // 
            // timerRamUsage
            // 
            this.timerRamUsage.Tick += new System.EventHandler(this.TimerRamUsage_Tick);
            // 
            // comboRamUsageInterval
            // 
            this.comboRamUsageInterval.FormattingEnabled = true;
            this.comboRamUsageInterval.Items.AddRange(new object[] {
            "500",
            "750",
            "1000",
            "1500",
            "2000",
            "2500",
            "3000",
            "5000"});
            this.comboRamUsageInterval.Location = new System.Drawing.Point(158, 38);
            this.comboRamUsageInterval.Margin = new System.Windows.Forms.Padding(2);
            this.comboRamUsageInterval.Name = "comboRamUsageInterval";
            this.comboRamUsageInterval.Size = new System.Drawing.Size(130, 21);
            this.comboRamUsageInterval.TabIndex = 16;
            this.comboRamUsageInterval.Text = "2000";
            // 
            // lblRamUsage
            // 
            this.lblRamUsage.AutoSize = true;
            this.lblRamUsage.Location = new System.Drawing.Point(156, 22);
            this.lblRamUsage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRamUsage.Name = "lblRamUsage";
            this.lblRamUsage.Size = new System.Drawing.Size(133, 13);
            this.lblRamUsage.TabIndex = 15;
            this.lblRamUsage.Text = "Volatile Mem. Load Sensor";
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "PC Monitor is Running in Background";
            this.trayIcon.BalloonTipTitle = "Notification";
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "PC Monitor Client";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayLblOperation,
            this.trayConnect,
            this.trayDisconnect,
            this.toggleWidgetToolStripMenuItem,
            this.toolStripSeparator1,
            this.trayExit});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(166, 120);
            this.trayContextMenu.Text = "Operation";
            // 
            // trayLblOperation
            // 
            this.trayLblOperation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.trayLblOperation.Enabled = false;
            this.trayLblOperation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trayLblOperation.Name = "trayLblOperation";
            this.trayLblOperation.Size = new System.Drawing.Size(165, 22);
            this.trayLblOperation.Text = "Operation Menu";
            // 
            // trayConnect
            // 
            this.trayConnect.Name = "trayConnect";
            this.trayConnect.Size = new System.Drawing.Size(165, 22);
            this.trayConnect.Text = "Connect";
            this.trayConnect.Click += new System.EventHandler(this.trayConnect_Click);
            // 
            // trayDisconnect
            // 
            this.trayDisconnect.Name = "trayDisconnect";
            this.trayDisconnect.Size = new System.Drawing.Size(165, 22);
            this.trayDisconnect.Text = "Disconnect";
            this.trayDisconnect.Visible = false;
            this.trayDisconnect.Click += new System.EventHandler(this.trayDisconnect_Click);
            // 
            // toggleWidgetToolStripMenuItem
            // 
            this.toggleWidgetToolStripMenuItem.Name = "toggleWidgetToolStripMenuItem";
            this.toggleWidgetToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.toggleWidgetToolStripMenuItem.Text = "Toggle Widget";
            this.toggleWidgetToolStripMenuItem.Click += new System.EventHandler(this.toggleWidgetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // trayExit
            // 
            this.trayExit.Name = "trayExit";
            this.trayExit.Size = new System.Drawing.Size(165, 22);
            this.trayExit.Text = "Exit";
            this.trayExit.Click += new System.EventHandler(this.trayExit_Click);
            // 
            // grpSensorTiming
            // 
            this.grpSensorTiming.Controls.Add(this.lblCpuLoadInterval);
            this.grpSensorTiming.Controls.Add(this.lblRamUsage);
            this.grpSensorTiming.Controls.Add(this.comboTempInterval);
            this.grpSensorTiming.Controls.Add(this.comboRamUsageInterval);
            this.grpSensorTiming.Controls.Add(this.lblTempInterval);
            this.grpSensorTiming.Controls.Add(this.comboCpuUsageInterval);
            this.grpSensorTiming.Location = new System.Drawing.Point(22, 170);
            this.grpSensorTiming.Margin = new System.Windows.Forms.Padding(2);
            this.grpSensorTiming.Name = "grpSensorTiming";
            this.grpSensorTiming.Padding = new System.Windows.Forms.Padding(2);
            this.grpSensorTiming.Size = new System.Drawing.Size(302, 126);
            this.grpSensorTiming.TabIndex = 17;
            this.grpSensorTiming.TabStop = false;
            this.grpSensorTiming.Text = "Sensor Timing Intervals";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.serialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(346, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWidgetToolStripMenuItem,
            this.resetWidgetPositionToolStripMenuItem,
            this.saveIntervalToolStripMenuItem,
            this.toolStripSeparator3,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // openWidgetToolStripMenuItem
            // 
            this.openWidgetToolStripMenuItem.Name = "openWidgetToolStripMenuItem";
            this.openWidgetToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openWidgetToolStripMenuItem.Text = "Open Widget";
            this.openWidgetToolStripMenuItem.Click += new System.EventHandler(this.openWidgetToolStripMenuItem_Click);
            // 
            // saveIntervalToolStripMenuItem
            // 
            this.saveIntervalToolStripMenuItem.Name = "saveIntervalToolStripMenuItem";
            this.saveIntervalToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveIntervalToolStripMenuItem.Text = "Save Intervals";
            this.saveIntervalToolStripMenuItem.Click += new System.EventHandler(this.saveIntervalToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(186, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialMonitorToolStripMenuItem});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.serialToolStripMenuItem.Text = "Tools";
            // 
            // serialMonitorToolStripMenuItem
            // 
            this.serialMonitorToolStripMenuItem.Name = "serialMonitorToolStripMenuItem";
            this.serialMonitorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.serialMonitorToolStripMenuItem.Text = "Serial Monitor";
            this.serialMonitorToolStripMenuItem.Click += new System.EventHandler(this.serialMonitorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // minimizeTimer
            // 
            this.minimizeTimer.Interval = 1000;
            this.minimizeTimer.Tick += new System.EventHandler(this.minimizeTimer_Tick);
            // 
            // grpConsole
            // 
            this.grpConsole.Controls.Add(this.btnClearConsole);
            this.grpConsole.Controls.Add(this.console);
            this.grpConsole.Location = new System.Drawing.Point(22, 301);
            this.grpConsole.Name = "grpConsole";
            this.grpConsole.Size = new System.Drawing.Size(302, 190);
            this.grpConsole.TabIndex = 17;
            this.grpConsole.TabStop = false;
            this.grpConsole.Text = "Console - Client Status";
            // 
            // btnClearConsole
            // 
            this.btnClearConsole.BackColor = System.Drawing.Color.Red;
            this.btnClearConsole.FlatAppearance.BorderSize = 0;
            this.btnClearConsole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearConsole.ForeColor = System.Drawing.Color.White;
            this.btnClearConsole.Location = new System.Drawing.Point(235, 164);
            this.btnClearConsole.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearConsole.Name = "btnClearConsole";
            this.btnClearConsole.Size = new System.Drawing.Size(59, 21);
            this.btnClearConsole.TabIndex = 20;
            this.btnClearConsole.Text = "Clear";
            this.btnClearConsole.UseVisualStyleBackColor = false;
            this.btnClearConsole.Click += new System.EventHandler(this.btnClearConsole_Click);
            // 
            // console
            // 
            this.console.BackColor = System.Drawing.Color.Black;
            this.console.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.White;
            this.console.Location = new System.Drawing.Point(6, 19);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.Size = new System.Drawing.Size(290, 144);
            this.console.TabIndex = 0;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // portWatcherTimer
            // 
            this.portWatcherTimer.Tick += new System.EventHandler(this.portWatcherTimer_Tick);
            // 
            // btnIdent
            // 
            this.btnIdent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIdent.FlatAppearance.BorderSize = 0;
            this.btnIdent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdent.ForeColor = System.Drawing.Color.White;
            this.btnIdent.Location = new System.Drawing.Point(109, 57);
            this.btnIdent.Margin = new System.Windows.Forms.Padding(2);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(59, 21);
            this.btnIdent.TabIndex = 19;
            this.btnIdent.Text = "Identify";
            this.btnIdent.UseVisualStyleBackColor = false;
            this.btnIdent.Click += new System.EventHandler(this.btnIdent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(172, 57);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 21);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // resetWidgetPositionToolStripMenuItem
            // 
            this.resetWidgetPositionToolStripMenuItem.Name = "resetWidgetPositionToolStripMenuItem";
            this.resetWidgetPositionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.resetWidgetPositionToolStripMenuItem.Text = "Reset Widget Position";
            this.resetWidgetPositionToolStripMenuItem.Click += new System.EventHandler(this.resetWidgetPositionToolStripMenuItem_Click);
            // 
            // SrvSoftware
            // 
            this.AcceptButton = this.BtnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(346, 533);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnIdent);
            this.Controls.Add(this.grpConsole);
            this.Controls.Add(this.grpSensorTiming);
            this.Controls.Add(this.lblIntervals);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ComboPort);
            this.Controls.Add(this.ComboInterval);
            this.Controls.Add(this.lblIntercal);
            this.Controls.Add(this.lblPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "SrvSoftware";
            this.Text = "PC Monitor Server";
            this.Load += new System.EventHandler(this.SrvSoftware_Load);
            this.Resize += new System.EventHandler(this.SrvSoftware_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.trayContextMenu.ResumeLayout(false);
            this.grpSensorTiming.ResumeLayout(false);
            this.grpSensorTiming.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpConsole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIntercal;
        private System.Windows.Forms.ComboBox ComboInterval;
        private System.Windows.Forms.ComboBox ComboPort;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel StsRealtime;
        private System.Windows.Forms.Timer timerProcessingUnitLoad;
        private System.Windows.Forms.Timer timerTempSensor;
        private System.Windows.Forms.ComboBox comboCpuUsageInterval;
        private System.Windows.Forms.Label lblCpuLoadInterval;
        private System.Windows.Forms.ComboBox comboTempInterval;
        private System.Windows.Forms.Label lblTempInterval;
        private System.Windows.Forms.Label lblIntervals;
        private System.Windows.Forms.Timer timerRamUsage;
        private System.Windows.Forms.ComboBox comboRamUsageInterval;
        private System.Windows.Forms.Label lblRamUsage;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.GroupBox grpSensorTiming;
        private System.Windows.Forms.ToolStripStatusLabel testStrip;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayConnect;
        private System.Windows.Forms.ToolStripMenuItem trayDisconnect;
        private System.Windows.Forms.ToolStripMenuItem trayLblOperation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem trayExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Timer minimizeTimer;
        private System.Windows.Forms.ToolStripMenuItem openWidgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox grpConsole;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Timer portWatcherTimer;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem serialMonitorToolStripMenuItem;
        private System.Windows.Forms.Button btnIdent;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnClearConsole;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem toggleWidgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetWidgetPositionToolStripMenuItem;
    }
}

