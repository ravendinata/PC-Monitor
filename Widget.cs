using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PC_Monitor
{
    public partial class Widget : Form
    {
        public int cpuTemp = 0;
        public bool isConn = false;

        int mouseEventCounter = 0;

        YUI yui = new YUI();


        //FORM CONSTRUCTOR
        public Widget()
        {
            InitializeComponent();
        }

        private SrvSoftware mainForm = null;

        public Widget(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as SrvSoftware;
        }

        // Hides window from ALT+TAB
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        // EXTRA FUNC
        public void setPosition(int x, int y)
        {
            this.Location = new Point(x, y);
        }

        //EVENT HANDLER -->
        //DRAG-DROP FUNCTION;
        private bool mouseDown;
        private Point lastLocation;

        private void Widget_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Widget_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Widget_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Properties.Settings.Default.WidgetLastPosX = this.Location.X;
            Properties.Settings.Default.WidgetLastPosY = this.Location.Y;
            Properties.Settings.Default.Save();
        }

        private void Widget_MouseClick(object sender, MouseEventArgs e)
        {
            if (isConn)
                btnSwitch.Text = "START";
            else
                btnSwitch.Text = "STOP";

            mainForm.relaySwitch();
        }

        private void Widget_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            mainForm.widgetStatus = "Widget Hidden\n";
            this.Hide();
        }

        //HOVERING EVENT;
        private void Widget_MouseEnter(object sender, EventArgs e)
        {
            mouseEventCounter++;

            if (mouseEventCounter > 0)
                yui.Fadein(this, 50, 0.05, 0.9);
        }

        private async void Widget_MouseLeave(object sender, EventArgs e)
        {
            mouseEventCounter--;
            await Task.Delay(1000);

            if (mouseEventCounter == 0)
                yui.Fadeout(this, 50, 0.05, 0.5);
        }

        //REGULAR EVENTS;
        private void Widget_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Properties.Settings.Default.WidgetLastPosX, Properties.Settings.Default.WidgetLastPosY);
            this.StartPosition = FormStartPosition.Manual;
            
            mainForm.widgetStatus = "Started Widget\n";
            kbCheckTimer.Start();
        }

        private void kbCheckTimer_Tick(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                indiCaps.BackColor = Color.Red;
            else
                indiCaps.BackColor = Color.Gray;

            if (Control.IsKeyLocked(Keys.NumLock))
                indiNum.BackColor = Color.Red;
            else
                indiNum.BackColor = Color.Gray;

            if (Control.IsKeyLocked(Keys.Scroll))
                indiScroll.BackColor = Color.Red;
            else
                indiScroll.BackColor = Color.Gray;

        }

        // INTERFACE -->
        public string dataIface
        {
            set { lblDisp.Text = value; }
        }

        public Point position
        {
            get { return new Point(this.Location.X, this.Location.Y); }
            set { this.Location = new Point(value.X, value.Y); }
        }
    }
}
