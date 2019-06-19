namespace DataConnectProClientSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDeviceID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxMessagefromDataConnectPro = new System.Windows.Forms.RichTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email / Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(236, 448);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(184, 22);
            this.textBoxUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(23, 352);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(184, 22);
            this.textBoxPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Device ID";
            // 
            // textBoxDeviceID
            // 
            this.textBoxDeviceID.Location = new System.Drawing.Point(282, 420);
            this.textBoxDeviceID.Name = "textBoxDeviceID";
            this.textBoxDeviceID.ReadOnly = true;
            this.textBoxDeviceID.Size = new System.Drawing.Size(184, 22);
            this.textBoxDeviceID.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 392);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Equipment ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send CH0~3 Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Connecnt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Message";
            // 
            // richTextBoxMessagefromDataConnectPro
            // 
            this.richTextBoxMessagefromDataConnectPro.Location = new System.Drawing.Point(12, 224);
            this.richTextBoxMessagefromDataConnectPro.Name = "richTextBoxMessagefromDataConnectPro";
            this.richTextBoxMessagefromDataConnectPro.Size = new System.Drawing.Size(454, 80);
            this.richTextBoxMessagefromDataConnectPro.TabIndex = 11;
            this.richTextBoxMessagefromDataConnectPro.Text = "";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(13, 176);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(182, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Connect";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DataConnectProClientSample.Properties.Resources.DataConnectPro;
            this.pictureBox1.Location = new System.Drawing.Point(234, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 63);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // metroTextBoxUsername
            // 
            // 
            // 
            // 
            this.metroTextBoxUsername.CustomButton.Image = null;
            this.metroTextBoxUsername.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.metroTextBoxUsername.CustomButton.Name = "";
            this.metroTextBoxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxUsername.CustomButton.TabIndex = 1;
            this.metroTextBoxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxUsername.CustomButton.UseSelectable = true;
            this.metroTextBoxUsername.CustomButton.Visible = false;
            this.metroTextBoxUsername.Lines = new string[0];
            this.metroTextBoxUsername.Location = new System.Drawing.Point(13, 84);
            this.metroTextBoxUsername.MaxLength = 32767;
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.PasswordChar = '\0';
            this.metroTextBoxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUsername.SelectedText = "";
            this.metroTextBoxUsername.SelectionLength = 0;
            this.metroTextBoxUsername.SelectionStart = 0;
            this.metroTextBoxUsername.ShortcutsEnabled = true;
            this.metroTextBoxUsername.Size = new System.Drawing.Size(182, 23);
            this.metroTextBoxUsername.TabIndex = 14;
            this.metroTextBoxUsername.UseSelectable = true;
            this.metroTextBoxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(12, 133);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '\0';
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(184, 23);
            this.metroTextBoxPassword.TabIndex = 15;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 331);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.richTextBoxMessagefromDataConnectPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxDeviceID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ADLINK DataConnectPro Agent";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDeviceID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxMessagefromDataConnectPro;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
    }
}

