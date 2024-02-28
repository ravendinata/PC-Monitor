using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using OpenHardwareMonitor.Hardware;
using System.Security.Cryptography;

namespace PC_Monitor
{
    public partial class SrvSoftware : Form
    {
        bool isConnected = false;
        float gpuTemp, cpuUsage, gpuUsage, cpuTemp, ramUsage, vramUsage;
        int mizeCount = 1;
        string serialSend;
        string roomTemp;

        Widget widget = null;
        Sermon sermon = null;

        YUI yui = new YUI();
        Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            RAMEnabled = true,
            MainboardEnabled = true,
            FanControllerEnabled = true
        };

        private SerialPort port = new SerialPort();

        public SrvSoftware()
        {
            InitializeComponent();
            Init();

            this.Opacity = 0;

            widget = new Widget(this);
            sermon = new Sermon(this);
            widget.Show();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SrvSoftware_FormClosing);
        }

        //EVENT HANDLER -->
        private void Init()
        {
            try
            {
                port.Parity = Parity.None;
                port.StopBits = StopBits.One;
                port.DataBits = 8;
                port.Handshake = Handshake.None;
                port.RtsEnable = true;
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    ComboPort.Items.Add(port);
                }
                port.BaudRate = 9600;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SrvSoftware_Load(object sender, EventArgs e)
        {
            c.Open();

            if (ComboPort.Items.Count == 0)
                MessageBox.Show("No Device Connected to Ports Found!");
            else
                ComboPort.SelectedIndex = 0;

            ComboInterval.Text = Properties.Settings.Default.PortInterval;
            comboCpuUsageInterval.Text = Properties.Settings.Default.LoadInterval;
            comboRamUsageInterval.Text = Properties.Settings.Default.MemInterval;
            comboTempInterval.Text = Properties.Settings.Default.TempInterval;

            if (Properties.Settings.Default.SaveLastInterval)
                saveIntervalToolStripMenuItem.Visible = false;

            if (Properties.Settings.Default.Autoconnect)
                connect();

            if (Properties.Settings.Default.StartMinimized)
                minimizeTimer.Start();
            else
                this.Opacity = 1;
        }

        private void SrvSoftware_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                trayIcon.Visible = true;
                trayIcon.ShowBalloonTip(50);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
                trayIcon.Visible = false;
        }

        private void SrvSoftware_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port.IsOpen == true)
            {
                if (e.CloseReason == CloseReason.WindowsShutDown || Properties.Settings.Default.SkipCloseDialog)
                    disconnect();
                else
                {
                    if (DialogResult.No == MessageBox.Show("Client on Port " + port.PortName + " is still connected and syncing! Disconnect and exit?", "Active client still connected", MessageBoxButtons.YesNo))
                        e.Cancel = true;
                    else
                        disconnect();
                }
            }

            if (Properties.Settings.Default.SaveLastInterval)
                saveIvals();
        }

        /* BEG UPDATER AREA --> */
        // x TEMP AREA;
        private void UpdateGpuTemp()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            gpuTemp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        private void UpdateCpuTemp()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            cpuTemp = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        // x LOAD AREA;
        private void UpdateGpuUsage()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("GPU Core"))
                        {
                            gpuUsage = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        private void UpdateCpuUsage()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.CPU)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name.Contains("CPU Total"))
                        {
                            cpuUsage = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        // x MEM AREA;
        private void UpdateVramUsage()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.SmallData && sensor.Name.Contains("Used"))
                        {
                            vramUsage = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        private void UpdateRamUsage()
        {
            foreach (var hardware in c.Hardware)
            {
                if (hardware.HardwareType == HardwareType.RAM)
                {
                    hardware.Update();
                    foreach (var sensor in hardware.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Data && sensor.Name.Contains("Used"))
                        {
                            ramUsage = sensor.Value.GetValueOrDefault();
                        }
                    }
                }
            }
        }

        /* EO UPDATER AREA --! */

        // TIMER AREA -->
        private void Timer_Tick(object sender, EventArgs e)
        {
            Status();
        }

        private void portWatcherTimer_Tick(object sender, EventArgs e)
        {
            WatchPort();
        }

        private void TimerProcessingUnitLoad_Tick(object sender, EventArgs e)
        {
            UpdateCpuUsage();
            UpdateGpuUsage();
        }

        private void TimerTempSensor_Tick(object sender, EventArgs e)
        {
            UpdateGpuTemp();
            UpdateCpuTemp();
        }

        private void TimerRamUsage_Tick(object sender, EventArgs e)
        {
            UpdateRamUsage();
            UpdateVramUsage();
        }

        private void minimizeTimer_Tick(object sender, EventArgs e)
        {
            if (mizeCount == 0) 
            { 
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 1;
                minimizeTimer.Stop();
            }

            StsRealtime.Text = "Minimizing in " + mizeCount;
            mizeCount--;
        }

        //OPERATION FUNCTION -->
        private void Status()
        {
            try
            {
                string currTime = DateTime.Now.ToString("HH:mm");
                // string currDate = DateTime.Now.ToShortDateString();
                // string dateTime = currTime + " | " + currDate;

                widget.dataIface = (int)cpuTemp + "";

                serialSend = 
                    (int)cpuTemp + "a" +
                    (int)gpuTemp + "b" +
                    cpuUsage.ToString("n2") + "c" +
                    ramUsage.ToString("n2") + "r" +
                    vramUsage.ToString("g4") + "v" +
                    gpuUsage.ToString("n2") + "g" +
                    currTime + "x";

                port.Write(serialSend);

                StsRealtime.Text = "Monitor Active. Syncing with client...";
            }
            catch (Exception ex)
            {
                disconnect();
                MessageBox.Show(ex.Message);
                StsRealtime.Text = StsRealtime.Text + " Exception Caught!";
            }
        }

        private void WatchPort()
        {
            string clientMsg = port.ReadExisting();
            if (clientMsg != String.Empty)
            {
                if (clientMsg.StartsWith("Temp.: "))
                {
                    string newTemp;

                    int found = clientMsg.IndexOf(": ");
                    newTemp = clientMsg.Substring(found + 2);
                    // console.Text = console.Text + roomTemp;

                    if (newTemp != roomTemp)
                    {
                        roomTemp = newTemp;

                        /* if (roomTemp.StartsWith("29"))
                            MessageBox.Show("Warning! Room Temperature close to 30 degrees!"); */
                    }
                }
                else
                {
                    console.Text = console.Text + clientMsg;
                    sermon.receiveData = "Client: " + clientMsg;
                }
            }
        }

        private void connect()
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.PortName = ComboPort.Text;
                    port.Open();

                    Timer.Interval = Convert.ToInt32(ComboInterval.Text);

                    //Sensor Interval Set and Adjust According to Port Interval
                    timerProcessingUnitLoad.Interval = Timer.Interval > Convert.ToInt32(comboCpuUsageInterval.Text) ? Timer.Interval : Convert.ToInt32(comboCpuUsageInterval.Text);
                    timerTempSensor.Interval = Timer.Interval > Convert.ToInt32(comboTempInterval.Text) ? Timer.Interval : Convert.ToInt32(comboTempInterval.Text);
                    timerRamUsage.Interval = Timer.Interval > Convert.ToInt32(comboRamUsageInterval.Text) ? Timer.Interval : Convert.ToInt32(comboRamUsageInterval.Text);

                    Timer.Start();
                    portWatcherTimer.Start();
                    timerProcessingUnitLoad.Start();
                    timerTempSensor.Start();
                    timerRamUsage.Start();

                    isConnected = widget.isConn = true;

                    //UI Element Handler
                    LblStatus.Text = "Status: Connected to " + ComboPort.Text;
                    console.Text = console.Text + "Connected to Client on " + ComboPort.Text + "!\n";

                    //Sermon Interface
                    sermon.receiveData = "Connected to Client on " + ComboPort.Text + "!" + "\nBaud Rate: 9600\n";

                    BtnConnect.Enabled = false;
                    trayConnect.Visible = false;
                    BtnDisconnect.Enabled = true;
                    trayDisconnect.Visible = true;

                    btnIdent.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void disconnect()
        {
            LblStatus.Text = "Status: Disconnected";
            StsRealtime.Text = "Disconnected. Awaiting connection...";
            console.Text = console.Text + "Disconnected!\n\n";
            sermon.receiveData = "Server: Disconnect Client\n\n";

            Timer.Stop();
            portWatcherTimer.Stop();
            timerProcessingUnitLoad.Stop();
            timerTempSensor.Stop();
            timerRamUsage.Stop();

            isConnected = widget.isConn = false;
            widget.dataIface = "--";

            BtnConnect.Enabled = true;
            trayConnect.Visible = true;
            BtnDisconnect.Enabled = false;
            trayDisconnect.Visible = false;

            btnIdent.Enabled = true;

            try
            {
                serialSend = "DIS";
                port.Write(serialSend);
                port.Close();
            }
            catch (Exception ex)
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    trayIcon.Visible = false;
                }

                MessageBox.Show(ex.Message);
            }
        }

        private void identify(bool working)
        {
            try
            {
                if (working)
                {
                    serialSend = "ID";

                    port.PortName = ComboPort.Text;
                    port.Open();
                    port.Write(serialSend);

                    //Sermon Interface
                    sermon.receiveData = "Server: Poking Potential Client on " + ComboPort.Text + '\n';
                }

                if (!working)
                {
                    serialSend = "DIS";

                    port.Write(serialSend);
                    port.Close();

                    sermon.receiveData = "Server: Disconnect Client\n\n";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveIvals()
        {
            Properties.Settings.Default.PortInterval = ComboInterval.Text;
            Properties.Settings.Default.LoadInterval = comboCpuUsageInterval.Text;
            Properties.Settings.Default.MemInterval = comboRamUsageInterval.Text;
            Properties.Settings.Default.TempInterval = comboTempInterval.Text;

            Properties.Settings.Default.Save();
        }

        //UI HANDLER -->
        //MAIN FORM;
        //FORM BUTTONS;;
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void btnIdent_Click(object sender, EventArgs e)
        {
            if (btnIdent.Text == "Identify")
            {
                identify(true);
                btnIdent.Text = "Poking";
                BtnConnect.Enabled = false;
            }
            else
            {
                identify(false);
                btnIdent.Text = "Identify";
                BtnConnect.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ComboPort.Items.Clear();
            ComboPort.Text = "";

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComboPort.Items.Add(port);
            }

            if (ComboPort.Items.Count == 0)
                MessageBox.Show("No Device Connected to Ports Found!");
            else
                ComboPort.SelectedIndex = 0;
        }

        //CONSOLE;;
        private void console_TextChanged(object sender, EventArgs e)
        {
            yui.autoscrollRichtext(console);
        }

        private void btnClearConsole_Click(object sender, EventArgs e)
        {
            console.Clear();
        }

        //TOOLSTRIP MENU ITEMS;
        private void saveIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveIvals();
        }

        private void openWidgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!widget.Visible)
                widget.Show();
        }

        private void resetWidgetPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (widget.position.X != 10 && widget.position.Y != 10)
                widget.setPosition(10, 10);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new Settings();
            window.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var window = new About();
            window.Show();
        }

        private void serialMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!sermon.Visible)
                sermon.Show();
        }

        //TRAY MENU;
        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
        }

        private void trayConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void trayDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void toggleWidgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!widget.Visible)
                widget.Show();
        }


        private void trayExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //INTERFACE -->
        public void relaySwitch()
        {
            if (isConnected)
                disconnect();
            else
                connect();
        }

        public string widgetStatus
        {
            set { console.Text = console.Text + value; }
        }
    }
}
