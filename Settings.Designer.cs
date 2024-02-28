namespace PC_Monitor
{
    partial class Settings
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
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkSkipDialog = new System.Windows.Forms.CheckBox();
            this.chkAutoconnect = new System.Windows.Forms.CheckBox();
            this.chkSaveInval = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.chkStartMinimized);
            this.grpSettings.Controls.Add(this.chkSkipDialog);
            this.grpSettings.Controls.Add(this.chkAutoconnect);
            this.grpSettings.Controls.Add(this.chkSaveInval);
            this.grpSettings.Location = new System.Drawing.Point(13, 13);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(294, 156);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Server Settings";
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(24, 120);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkStartMinimized.Size = new System.Drawing.Size(109, 17);
            this.chkStartMinimized.TabIndex = 4;
            this.chkStartMinimized.Text = "Minimized Startup";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            this.chkStartMinimized.CheckedChanged += new System.EventHandler(this.chkStartMinimized_CheckedChanged);
            // 
            // chkSkipDialog
            // 
            this.chkSkipDialog.AutoSize = true;
            this.chkSkipDialog.Location = new System.Drawing.Point(24, 55);
            this.chkSkipDialog.Name = "chkSkipDialog";
            this.chkSkipDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSkipDialog.Size = new System.Drawing.Size(235, 17);
            this.chkSkipDialog.TabIndex = 3;
            this.chkSkipDialog.Text = "Skip Dialog Box on Closing while Connected";
            this.chkSkipDialog.UseVisualStyleBackColor = true;
            this.chkSkipDialog.CheckedChanged += new System.EventHandler(this.chkSkipDialog_CheckedChanged);
            // 
            // chkAutoconnect
            // 
            this.chkAutoconnect.AutoSize = true;
            this.chkAutoconnect.Location = new System.Drawing.Point(24, 97);
            this.chkAutoconnect.Name = "chkAutoconnect";
            this.chkAutoconnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAutoconnect.Size = new System.Drawing.Size(127, 17);
            this.chkAutoconnect.TabIndex = 2;
            this.chkAutoconnect.Text = "Autoconnect on Start";
            this.chkAutoconnect.UseVisualStyleBackColor = true;
            this.chkAutoconnect.CheckedChanged += new System.EventHandler(this.chkAutoconnect_CheckedChanged);
            // 
            // chkSaveInval
            // 
            this.chkSaveInval.AutoSize = true;
            this.chkSaveInval.Location = new System.Drawing.Point(24, 32);
            this.chkSaveInval.Name = "chkSaveInval";
            this.chkSaveInval.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSaveInval.Size = new System.Drawing.Size(147, 17);
            this.chkSaveInval.TabIndex = 1;
            this.chkSaveInval.Text = "Save Last Interval Values";
            this.chkSaveInval.UseVisualStyleBackColor = true;
            this.chkSaveInval.CheckedChanged += new System.EventHandler(this.chkSaveInval_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(199, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 213);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox chkSaveInval;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkAutoconnect;
        private System.Windows.Forms.CheckBox chkSkipDialog;
        private System.Windows.Forms.CheckBox chkStartMinimized;
    }
}