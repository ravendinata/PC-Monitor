using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Monitor
{
    public partial class Settings : Form
    {
        private bool requireRestart = false;

        public Settings()
        {
            InitializeComponent();
        }

        //Events Handler
        private void Settings_Load(object sender, EventArgs e)
        {
            chkSaveInval.Checked = Properties.Settings.Default.SaveLastInterval;
            chkSkipDialog.Checked = Properties.Settings.Default.SkipCloseDialog;
            chkAutoconnect.Checked = Properties.Settings.Default.Autoconnect;

            if (chkAutoconnect.Checked)
                chkStartMinimized.Checked = Properties.Settings.Default.StartMinimized;
            else if (!chkAutoconnect.Checked)
                chkStartMinimized.Enabled = false;

            btnSave.Enabled = false;
            requireRestart = false;
        }


        //UI Elements Handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            if (requireRestart)
            {
                _ = MessageBox.Show("Successfully saved changes! Application will now restart!", "Settings Saved");
                Application.Restart();
            }
            else
            {
                _ = MessageBox.Show("Successfully saved changes!", "Settings Saved");
                btnSave.Enabled = false;
            }
        }

        //Checkbox Changed Event Handler
        private void chkSaveInval_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SaveLastInterval = chkSaveInval.Checked;
            requireRestart = true;
            btnSave.Enabled = true;
        }

        private void chkSkipDialog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SkipCloseDialog = chkSkipDialog.Checked;

            btnSave.Enabled = true;
        }

        private void chkAutoconnect_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Autoconnect = chkAutoconnect.Checked;

            if (chkAutoconnect.Checked)
            {
                if (!chkStartMinimized.Enabled)
                    chkStartMinimized.Enabled = true;
            }
            else if (!chkAutoconnect.Checked)
            {
                if (chkStartMinimized.Enabled)
                    chkStartMinimized.Enabled = false;

                if (chkStartMinimized.Checked)
                    chkStartMinimized.Checked = false;
            }

            btnSave.Enabled = true;
        }

        private void chkStartMinimized_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartMinimized = chkStartMinimized.Checked;

            btnSave.Enabled = true;
        }
    }
}
