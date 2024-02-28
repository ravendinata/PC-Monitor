namespace PC_Monitor
{
    partial class Widget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widget));
            this.lblDisp = new System.Windows.Forms.Label();
            this.uiDegree = new System.Windows.Forms.Label();
            this.uiBackground = new System.Windows.Forms.PictureBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.indiCaps = new System.Windows.Forms.Button();
            this.indiScroll = new System.Windows.Forms.Button();
            this.indiNum = new System.Windows.Forms.Button();
            this.kbCheckTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uiBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.BackColor = System.Drawing.Color.Black;
            this.lblDisp.Font = new System.Drawing.Font("Unispace", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.Location = new System.Drawing.Point(13, 11);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(66, 44);
            this.lblDisp.TabIndex = 0;
            this.lblDisp.Text = "--";
            this.lblDisp.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDoubleClick);
            this.lblDisp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            this.lblDisp.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.lblDisp.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            this.lblDisp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseMove);
            this.lblDisp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseUp);
            // 
            // uiDegree
            // 
            this.uiDegree.AutoSize = true;
            this.uiDegree.BackColor = System.Drawing.Color.Black;
            this.uiDegree.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDegree.Location = new System.Drawing.Point(66, 15);
            this.uiDegree.Name = "uiDegree";
            this.uiDegree.Size = new System.Drawing.Size(21, 14);
            this.uiDegree.TabIndex = 1;
            this.uiDegree.Text = "°C";
            this.uiDegree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDoubleClick);
            this.uiDegree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            this.uiDegree.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.uiDegree.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            this.uiDegree.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseMove);
            this.uiDegree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseUp);
            // 
            // uiBackground
            // 
            this.uiBackground.BackColor = System.Drawing.Color.Transparent;
            this.uiBackground.Image = ((System.Drawing.Image)(resources.GetObject("uiBackground.Image")));
            this.uiBackground.Location = new System.Drawing.Point(0, 0);
            this.uiBackground.Name = "uiBackground";
            this.uiBackground.Size = new System.Drawing.Size(100, 100);
            this.uiBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.uiBackground.TabIndex = 2;
            this.uiBackground.TabStop = false;
            this.uiBackground.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDoubleClick);
            this.uiBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            this.uiBackground.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.uiBackground.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            this.uiBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseMove);
            this.uiBackground.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseUp);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.Red;
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitch.Location = new System.Drawing.Point(17, 66);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(66, 23);
            this.btnSwitch.TabIndex = 3;
            this.btnSwitch.Text = "STOP";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseClick);
            this.btnSwitch.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.btnSwitch.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            // 
            // indiCaps
            // 
            this.indiCaps.BackColor = System.Drawing.Color.Gray;
            this.indiCaps.Enabled = false;
            this.indiCaps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.indiCaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indiCaps.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indiCaps.Location = new System.Drawing.Point(118, 11);
            this.indiCaps.Name = "indiCaps";
            this.indiCaps.Size = new System.Drawing.Size(66, 23);
            this.indiCaps.TabIndex = 4;
            this.indiCaps.Text = "CAPS";
            this.indiCaps.UseVisualStyleBackColor = false;
            // 
            // indiScroll
            // 
            this.indiScroll.BackColor = System.Drawing.Color.Gray;
            this.indiScroll.Enabled = false;
            this.indiScroll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.indiScroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indiScroll.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indiScroll.Location = new System.Drawing.Point(118, 65);
            this.indiScroll.Name = "indiScroll";
            this.indiScroll.Size = new System.Drawing.Size(66, 23);
            this.indiScroll.TabIndex = 5;
            this.indiScroll.Text = "SCROLL";
            this.indiScroll.UseVisualStyleBackColor = false;
            // 
            // indiNum
            // 
            this.indiNum.BackColor = System.Drawing.Color.Gray;
            this.indiNum.Enabled = false;
            this.indiNum.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.indiNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indiNum.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indiNum.Location = new System.Drawing.Point(118, 38);
            this.indiNum.Name = "indiNum";
            this.indiNum.Size = new System.Drawing.Size(66, 23);
            this.indiNum.TabIndex = 6;
            this.indiNum.Text = "NUM";
            this.indiNum.UseVisualStyleBackColor = false;
            // 
            // kbCheckTimer
            // 
            this.kbCheckTimer.Interval = 10;
            this.kbCheckTimer.Tick += new System.EventHandler(this.kbCheckTimer_Tick);
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.ControlBox = false;
            this.Controls.Add(this.indiNum);
            this.Controls.Add(this.indiScroll);
            this.Controls.Add(this.indiCaps);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.uiDegree);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.uiBackground);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Widget";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Widget";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.MidnightBlue;
            this.Load += new System.EventHandler(this.Widget_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Widget_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Widget_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Widget_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.uiBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Label uiDegree;
        private System.Windows.Forms.PictureBox uiBackground;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button indiCaps;
        private System.Windows.Forms.Button indiScroll;
        private System.Windows.Forms.Button indiNum;
        private System.Windows.Forms.Timer kbCheckTimer;
    }
}