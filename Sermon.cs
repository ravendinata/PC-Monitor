using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Monitor
{
    public partial class Sermon : Form
    {
        YUI yui = new YUI();

        //FORM CONSTRUCTOR
        public Sermon()
        {
            InitializeComponent();
        }

        private SrvSoftware mainForm = null;

        public Sermon(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as SrvSoftware;
        }

        //EVENT HANDLER
        private void Sermon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearConsole();
        }

        private void receiveConsole_TextChanged(object sender, EventArgs e)
        {
            yui.autoscrollRichtext(receiveConsole);
        }

        //LISTENER INTERFACE
        public string receiveData
        {
            set { yui.appendHighlightText(receiveConsole, value, "Server: Disconnect Client\n\n", Color.White, Color.Red); }
            get { return receiveData; }
        }

        public void clearConsole()
        {
            receiveConsole.Clear();
        }
    }
}
