namespace ITRIPMS
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.metroButtonStart = new MetroFramework.Controls.MetroButton();
            this.metroButtonStop = new MetroFramework.Controls.MetroButton();
            this.metroButtonSetting = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxUnbalanceIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxMisalignmentIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxBentshaftIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLoosenessIndex = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxEHI = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::ITRIPMS.Properties.Resources.misaligments;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(158, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ITRIPMS.Properties.Resources.unbalance;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(23, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 98);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::ITRIPMS.Properties.Resources.loose;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(578, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 83);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::ITRIPMS.Properties.Resources.bent_shaft;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(350, 176);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(205, 89);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // metroButtonStart
            // 
            this.metroButtonStart.Location = new System.Drawing.Point(23, 289);
            this.metroButtonStart.Name = "metroButtonStart";
            this.metroButtonStart.Size = new System.Drawing.Size(222, 23);
            this.metroButtonStart.TabIndex = 5;
            this.metroButtonStart.Text = "Start";
            this.metroButtonStart.UseSelectable = true;
            this.metroButtonStart.Click += new System.EventHandler(this.metroButtonStart_Click);
            // 
            // metroButtonStop
            // 
            this.metroButtonStop.Location = new System.Drawing.Point(261, 289);
            this.metroButtonStop.Name = "metroButtonStop";
            this.metroButtonStop.Size = new System.Drawing.Size(235, 23);
            this.metroButtonStop.TabIndex = 6;
            this.metroButtonStop.Text = "Stop";
            this.metroButtonStop.UseSelectable = true;
            this.metroButtonStop.Click += new System.EventHandler(this.metroButtonStop_Click);
            // 
            // metroButtonSetting
            // 
            this.metroButtonSetting.Location = new System.Drawing.Point(519, 289);
            this.metroButtonSetting.Name = "metroButtonSetting";
            this.metroButtonSetting.Size = new System.Drawing.Size(207, 23);
            this.metroButtonSetting.TabIndex = 7;
            this.metroButtonSetting.Text = "Setting";
            this.metroButtonSetting.UseSelectable = true;
            this.metroButtonSetting.Click += new System.EventHandler(this.metroButtonSetting_Click);
            // 
            // metroTextBoxUnbalanceIndex
            // 
            // 
            // 
            // 
            this.metroTextBoxUnbalanceIndex.CustomButton.Image = null;
            this.metroTextBoxUnbalanceIndex.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.metroTextBoxUnbalanceIndex.CustomButton.Name = "";
            this.metroTextBoxUnbalanceIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUnbalanceIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUnbalanceIndex.CustomButton.TabIndex = 1;
            this.metroTextBoxUnbalanceIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUnbalanceIndex.CustomButton.UseSelectable = true;
            this.metroTextBoxUnbalanceIndex.CustomButton.Visible = false;
            this.metroTextBoxUnbalanceIndex.Lines = new string[] {
        "0"};
            this.metroTextBoxUnbalanceIndex.Location = new System.Drawing.Point(23, 138);
            this.metroTextBoxUnbalanceIndex.MaxLength = 32767;
            this.metroTextBoxUnbalanceIndex.Name = "metroTextBoxUnbalanceIndex";
            this.metroTextBoxUnbalanceIndex.PasswordChar = '\0';
            this.metroTextBoxUnbalanceIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUnbalanceIndex.SelectedText = "";
            this.metroTextBoxUnbalanceIndex.SelectionLength = 0;
            this.metroTextBoxUnbalanceIndex.SelectionStart = 0;
            this.metroTextBoxUnbalanceIndex.ShortcutsEnabled = true;
            this.metroTextBoxUnbalanceIndex.Size = new System.Drawing.Size(109, 23);
            this.metroTextBoxUnbalanceIndex.TabIndex = 8;
            this.metroTextBoxUnbalanceIndex.Text = "0";
            this.metroTextBoxUnbalanceIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxUnbalanceIndex.UseSelectable = true;
            this.metroTextBoxUnbalanceIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUnbalanceIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxMisalignmentIndex
            // 
            // 
            // 
            // 
            this.metroTextBoxMisalignmentIndex.CustomButton.Image = null;
            this.metroTextBoxMisalignmentIndex.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.metroTextBoxMisalignmentIndex.CustomButton.Name = "";
            this.metroTextBoxMisalignmentIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxMisalignmentIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMisalignmentIndex.CustomButton.TabIndex = 1;
            this.metroTextBoxMisalignmentIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMisalignmentIndex.CustomButton.UseSelectable = true;
            this.metroTextBoxMisalignmentIndex.CustomButton.Visible = false;
            this.metroTextBoxMisalignmentIndex.Lines = new string[] {
        "0"};
            this.metroTextBoxMisalignmentIndex.Location = new System.Drawing.Point(187, 138);
            this.metroTextBoxMisalignmentIndex.MaxLength = 32767;
            this.metroTextBoxMisalignmentIndex.Name = "metroTextBoxMisalignmentIndex";
            this.metroTextBoxMisalignmentIndex.PasswordChar = '\0';
            this.metroTextBoxMisalignmentIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxMisalignmentIndex.SelectedText = "";
            this.metroTextBoxMisalignmentIndex.SelectionLength = 0;
            this.metroTextBoxMisalignmentIndex.SelectionStart = 0;
            this.metroTextBoxMisalignmentIndex.ShortcutsEnabled = true;
            this.metroTextBoxMisalignmentIndex.Size = new System.Drawing.Size(109, 23);
            this.metroTextBoxMisalignmentIndex.TabIndex = 9;
            this.metroTextBoxMisalignmentIndex.Text = "0";
            this.metroTextBoxMisalignmentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxMisalignmentIndex.UseSelectable = true;
            this.metroTextBoxMisalignmentIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMisalignmentIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxBentshaftIndex
            // 
            // 
            // 
            // 
            this.metroTextBoxBentshaftIndex.CustomButton.Image = null;
            this.metroTextBoxBentshaftIndex.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.metroTextBoxBentshaftIndex.CustomButton.Name = "";
            this.metroTextBoxBentshaftIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxBentshaftIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxBentshaftIndex.CustomButton.TabIndex = 1;
            this.metroTextBoxBentshaftIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxBentshaftIndex.CustomButton.UseSelectable = true;
            this.metroTextBoxBentshaftIndex.CustomButton.Visible = false;
            this.metroTextBoxBentshaftIndex.Lines = new string[] {
        "0"};
            this.metroTextBoxBentshaftIndex.Location = new System.Drawing.Point(399, 138);
            this.metroTextBoxBentshaftIndex.MaxLength = 32767;
            this.metroTextBoxBentshaftIndex.Name = "metroTextBoxBentshaftIndex";
            this.metroTextBoxBentshaftIndex.PasswordChar = '\0';
            this.metroTextBoxBentshaftIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxBentshaftIndex.SelectedText = "";
            this.metroTextBoxBentshaftIndex.SelectionLength = 0;
            this.metroTextBoxBentshaftIndex.SelectionStart = 0;
            this.metroTextBoxBentshaftIndex.ShortcutsEnabled = true;
            this.metroTextBoxBentshaftIndex.Size = new System.Drawing.Size(109, 23);
            this.metroTextBoxBentshaftIndex.TabIndex = 10;
            this.metroTextBoxBentshaftIndex.Text = "0";
            this.metroTextBoxBentshaftIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxBentshaftIndex.UseSelectable = true;
            this.metroTextBoxBentshaftIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxBentshaftIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxLoosenessIndex
            // 
            // 
            // 
            // 
            this.metroTextBoxLoosenessIndex.CustomButton.Image = null;
            this.metroTextBoxLoosenessIndex.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.metroTextBoxLoosenessIndex.CustomButton.Name = "";
            this.metroTextBoxLoosenessIndex.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLoosenessIndex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxLoosenessIndex.CustomButton.TabIndex = 1;
            this.metroTextBoxLoosenessIndex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxLoosenessIndex.CustomButton.UseSelectable = true;
            this.metroTextBoxLoosenessIndex.CustomButton.Visible = false;
            this.metroTextBoxLoosenessIndex.Lines = new string[] {
        "0"};
            this.metroTextBoxLoosenessIndex.Location = new System.Drawing.Point(600, 138);
            this.metroTextBoxLoosenessIndex.MaxLength = 32767;
            this.metroTextBoxLoosenessIndex.Name = "metroTextBoxLoosenessIndex";
            this.metroTextBoxLoosenessIndex.PasswordChar = '\0';
            this.metroTextBoxLoosenessIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLoosenessIndex.SelectedText = "";
            this.metroTextBoxLoosenessIndex.SelectionLength = 0;
            this.metroTextBoxLoosenessIndex.SelectionStart = 0;
            this.metroTextBoxLoosenessIndex.ShortcutsEnabled = true;
            this.metroTextBoxLoosenessIndex.Size = new System.Drawing.Size(109, 23);
            this.metroTextBoxLoosenessIndex.TabIndex = 11;
            this.metroTextBoxLoosenessIndex.Text = "0";
            this.metroTextBoxLoosenessIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxLoosenessIndex.UseSelectable = true;
            this.metroTextBoxLoosenessIndex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLoosenessIndex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxEHI
            // 
            // 
            // 
            // 
            this.metroTextBoxEHI.CustomButton.Image = null;
            this.metroTextBoxEHI.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.metroTextBoxEHI.CustomButton.Name = "";
            this.metroTextBoxEHI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxEHI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxEHI.CustomButton.TabIndex = 1;
            this.metroTextBoxEHI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxEHI.CustomButton.UseSelectable = true;
            this.metroTextBoxEHI.CustomButton.Visible = false;
            this.metroTextBoxEHI.Lines = new string[] {
        "0"};
            this.metroTextBoxEHI.Location = new System.Drawing.Point(291, 80);
            this.metroTextBoxEHI.MaxLength = 32767;
            this.metroTextBoxEHI.Name = "metroTextBoxEHI";
            this.metroTextBoxEHI.PasswordChar = '\0';
            this.metroTextBoxEHI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxEHI.SelectedText = "";
            this.metroTextBoxEHI.SelectionLength = 0;
            this.metroTextBoxEHI.SelectionStart = 0;
            this.metroTextBoxEHI.ShortcutsEnabled = true;
            this.metroTextBoxEHI.Size = new System.Drawing.Size(117, 23);
            this.metroTextBoxEHI.TabIndex = 12;
            this.metroTextBoxEHI.Text = "0";
            this.metroTextBoxEHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBoxEHI.UseSelectable = true;
            this.metroTextBoxEHI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxEHI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Equipment Health Index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Unbalance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "Misalignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bent Shaft";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Looseness";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 340);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTextBoxEHI);
            this.Controls.Add(this.metroTextBoxLoosenessIndex);
            this.Controls.Add(this.metroTextBoxBentshaftIndex);
            this.Controls.Add(this.metroTextBoxMisalignmentIndex);
            this.Controls.Add(this.metroTextBoxUnbalanceIndex);
            this.Controls.Add(this.metroButtonSetting);
            this.Controls.Add(this.metroButtonStop);
            this.Controls.Add(this.metroButtonStart);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "ITRI PMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MetroFramework.Controls.MetroButton metroButtonStart;
        private MetroFramework.Controls.MetroButton metroButtonStop;
        private MetroFramework.Controls.MetroButton metroButtonSetting;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUnbalanceIndex;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMisalignmentIndex;
        private MetroFramework.Controls.MetroTextBox metroTextBoxBentshaftIndex;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLoosenessIndex;
        private MetroFramework.Controls.MetroTextBox metroTextBoxEHI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

