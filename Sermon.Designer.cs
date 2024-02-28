namespace PC_Monitor
{
    partial class Sermon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sermon));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.receiveConsole = new System.Windows.Forms.RichTextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.btnClear);
            this.mainPanel.Controls.Add(this.receiveConsole);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(628, 381);
            this.mainPanel.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(550, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // receiveConsole
            // 
            this.receiveConsole.BackColor = System.Drawing.Color.Black;
            this.receiveConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiveConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiveConsole.ForeColor = System.Drawing.Color.White;
            this.receiveConsole.Location = new System.Drawing.Point(0, 0);
            this.receiveConsole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.receiveConsole.Name = "receiveConsole";
            this.receiveConsole.ReadOnly = true;
            this.receiveConsole.Size = new System.Drawing.Size(628, 381);
            this.receiveConsole.TabIndex = 1;
            this.receiveConsole.TabStop = false;
            this.receiveConsole.Text = "";
            this.receiveConsole.TextChanged += new System.EventHandler(this.receiveConsole_TextChanged);
            // 
            // Sermon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 381);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Sermon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sermon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sermon_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RichTextBox receiveConsole;
        private System.Windows.Forms.Button btnClear;
    }
}