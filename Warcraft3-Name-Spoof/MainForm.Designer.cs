namespace Warcraft3_Name_Spoof
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbBuild = new System.Windows.Forms.GroupBox();
            this.lblBuild = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOriginalName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.pbxColor = new System.Windows.Forms.PictureBox();
            this.Refresh = new System.Windows.Forms.Timer(this.components);
            this.gbBuild.SuspendLayout();
            this.gbName.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuild
            // 
            this.gbBuild.Controls.Add(this.lblBuild);
            this.gbBuild.Location = new System.Drawing.Point(13, 67);
            this.gbBuild.Margin = new System.Windows.Forms.Padding(4);
            this.gbBuild.Name = "gbBuild";
            this.gbBuild.Padding = new System.Windows.Forms.Padding(4);
            this.gbBuild.Size = new System.Drawing.Size(235, 47);
            this.gbBuild.TabIndex = 9;
            this.gbBuild.TabStop = false;
            this.gbBuild.Text = " Build ";
            // 
            // lblBuild
            // 
            this.lblBuild.AutoSize = true;
            this.lblBuild.Location = new System.Drawing.Point(86, 19);
            this.lblBuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuild.Name = "lblBuild";
            this.lblBuild.Size = new System.Drawing.Size(42, 17);
            this.lblBuild.TabIndex = 0;
            this.lblBuild.Text = "None";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 186);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 28);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(120, 186);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 28);
            this.btnChange.TabIndex = 6;
            this.btnChange.Tag = "";
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.Location = new System.Drawing.Point(12, 150);
            this.txtNewName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewName.MaxLength = 15;
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(197, 22);
            this.txtNewName.TabIndex = 5;
            this.txtNewName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "New Name : ";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Enabled = false;
            this.txtCurrentName.Location = new System.Drawing.Point(12, 102);
            this.txtCurrentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(197, 22);
            this.txtCurrentName.TabIndex = 3;
            this.txtCurrentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCurrentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginalName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Current Name : ";
            // 
            // txtOriginalName
            // 
            this.txtOriginalName.Enabled = false;
            this.txtOriginalName.Location = new System.Drawing.Point(12, 54);
            this.txtOriginalName.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalName.Name = "txtOriginalName";
            this.txtOriginalName.Size = new System.Drawing.Size(197, 22);
            this.txtOriginalName.TabIndex = 1;
            this.txtOriginalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOriginalName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOriginalName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Name :";
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.btnReset);
            this.gbName.Controls.Add(this.btnChange);
            this.gbName.Controls.Add(this.txtNewName);
            this.gbName.Controls.Add(this.label7);
            this.gbName.Controls.Add(this.txtCurrentName);
            this.gbName.Controls.Add(this.label6);
            this.gbName.Controls.Add(this.txtOriginalName);
            this.gbName.Controls.Add(this.label1);
            this.gbName.Enabled = false;
            this.gbName.Location = new System.Drawing.Point(13, 121);
            this.gbName.Margin = new System.Windows.Forms.Padding(4);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(4);
            this.gbName.Size = new System.Drawing.Size(235, 228);
            this.gbName.TabIndex = 8;
            this.gbName.TabStop = false;
            this.gbName.Text = " Name Spoof ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(86, 22);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 17);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Not Running";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.lblStatus);
            this.gbStatus.Location = new System.Drawing.Point(13, 13);
            this.gbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Padding = new System.Windows.Forms.Padding(4);
            this.gbStatus.Size = new System.Drawing.Size(235, 47);
            this.gbStatus.TabIndex = 7;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = " Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Color : ";
            // 
            // pnlPreview
            // 
            this.pnlPreview.Enabled = false;
            this.pnlPreview.Location = new System.Drawing.Point(189, 270);
            this.pnlPreview.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(136, 50);
            this.pnlPreview.TabIndex = 8;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(89, 302);
            this.txtBlue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(64, 22);
            this.txtBlue.TabIndex = 7;
            this.txtBlue.Text = "0";
            this.txtBlue.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            this.txtBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRed_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Blue : ";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(89, 270);
            this.txtGreen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(64, 22);
            this.txtGreen.TabIndex = 5;
            this.txtGreen.Text = "0";
            this.txtGreen.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            this.txtGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green : ";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(89, 238);
            this.txtRed.Margin = new System.Windows.Forms.Padding(4);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(64, 22);
            this.txtRed.TabIndex = 3;
            this.txtRed.Text = "0";
            this.txtRed.TextChanged += new System.EventHandler(this.txtRed_TextChanged);
            this.txtRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRed_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Red : ";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.label5);
            this.gbColor.Controls.Add(this.pnlPreview);
            this.gbColor.Controls.Add(this.txtBlue);
            this.gbColor.Controls.Add(this.label4);
            this.gbColor.Controls.Add(this.txtGreen);
            this.gbColor.Controls.Add(this.label3);
            this.gbColor.Controls.Add(this.txtRed);
            this.gbColor.Controls.Add(this.label2);
            this.gbColor.Controls.Add(this.pbxColor);
            this.gbColor.Enabled = false;
            this.gbColor.Location = new System.Drawing.Point(256, 12);
            this.gbColor.Margin = new System.Windows.Forms.Padding(4);
            this.gbColor.Name = "gbColor";
            this.gbColor.Padding = new System.Windows.Forms.Padding(4);
            this.gbColor.Size = new System.Drawing.Size(351, 337);
            this.gbColor.TabIndex = 6;
            this.gbColor.TabStop = false;
            this.gbColor.Text = " Color ";
            // 
            // pbxColor
            // 
            this.pbxColor.Image = global::Warcraft3_Name_Spoof.Properties.Resources.colorpal1;
            this.pbxColor.Location = new System.Drawing.Point(21, 23);
            this.pbxColor.Margin = new System.Windows.Forms.Padding(4);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(304, 194);
            this.pbxColor.TabIndex = 1;
            this.pbxColor.TabStop = false;
            this.pbxColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxColor_MouseDown);
            this.pbxColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxColor_MouseMove);
            this.pbxColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxColor_MouseUp);
            // 
            // Refresh
            // 
            this.Refresh.Enabled = true;
            this.Refresh.Interval = 1000;
            this.Refresh.Tick += new System.EventHandler(this.Refresh_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 359);
            this.Controls.Add(this.gbBuild);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.gbColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Warcraft III Name Spoof";
            this.gbBuild.ResumeLayout(false);
            this.gbBuild.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBuild;
        private System.Windows.Forms.Label lblBuild;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOriginalName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxColor;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Timer Refresh;
    }
}

