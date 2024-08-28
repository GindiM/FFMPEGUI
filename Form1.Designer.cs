namespace FFMPEGUI
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_URI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox_trim = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_trimEndSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_trimEndMinuets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_trimStartSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_trimEndHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_trimStartMinuets = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_trimStartHours = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox_m3u8 = new System.Windows.Forms.GroupBox();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.button_m3u8 = new System.Windows.Forms.Button();
            this.textbox_m3u8 = new System.Windows.Forms.TextBox();
            this.comboBox_Format = new System.Windows.Forms.ComboBox();
            this.label_m3u8 = new System.Windows.Forms.Label();
            this.label_fileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_videoFile = new System.Windows.Forms.GroupBox();
            this.label_status = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndMinuets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartMinuets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartHours)).BeginInit();
            this.groupBox_m3u8.SuspendLayout();
            this.groupBox_videoFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "FFMPEG engine inside";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(25, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 47);
            this.button2.TabIndex = 0;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "mp4";
            // 
            // textBox_URI
            // 
            this.textBox_URI.Location = new System.Drawing.Point(25, 86);
            this.textBox_URI.Name = "textBox_URI";
            this.textBox_URI.Size = new System.Drawing.Size(283, 20);
            this.textBox_URI.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Convert to";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(25, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save To Desktop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox_trim
            // 
            this.checkBox_trim.AutoSize = true;
            this.checkBox_trim.Location = new System.Drawing.Point(6, 19);
            this.checkBox_trim.Name = "checkBox_trim";
            this.checkBox_trim.Size = new System.Drawing.Size(46, 17);
            this.checkBox_trim.TabIndex = 1;
            this.checkBox_trim.Text = "Trim";
            this.checkBox_trim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_trimEndSeconds);
            this.groupBox2.Controls.Add(this.numericUpDown_trimEndMinuets);
            this.groupBox2.Controls.Add(this.numericUpDown_trimStartSeconds);
            this.groupBox2.Controls.Add(this.numericUpDown_trimEndHours);
            this.groupBox2.Controls.Add(this.numericUpDown_trimStartMinuets);
            this.groupBox2.Controls.Add(this.numericUpDown_trimStartHours);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.checkBox_trim);
            this.groupBox2.Location = new System.Drawing.Point(61, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 96);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trim";
            // 
            // numericUpDown_trimEndSeconds
            // 
            this.numericUpDown_trimEndSeconds.Location = new System.Drawing.Point(155, 64);
            this.numericUpDown_trimEndSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimEndSeconds.Name = "numericUpDown_trimEndSeconds";
            this.numericUpDown_trimEndSeconds.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_trimEndSeconds.TabIndex = 7;
            // 
            // numericUpDown_trimEndMinuets
            // 
            this.numericUpDown_trimEndMinuets.Location = new System.Drawing.Point(98, 64);
            this.numericUpDown_trimEndMinuets.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimEndMinuets.Name = "numericUpDown_trimEndMinuets";
            this.numericUpDown_trimEndMinuets.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_trimEndMinuets.TabIndex = 6;
            // 
            // numericUpDown_trimStartSeconds
            // 
            this.numericUpDown_trimStartSeconds.Location = new System.Drawing.Point(155, 42);
            this.numericUpDown_trimStartSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimStartSeconds.Name = "numericUpDown_trimStartSeconds";
            this.numericUpDown_trimStartSeconds.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown_trimStartSeconds.TabIndex = 4;
            // 
            // numericUpDown_trimEndHours
            // 
            this.numericUpDown_trimEndHours.Location = new System.Drawing.Point(41, 64);
            this.numericUpDown_trimEndHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimEndHours.Name = "numericUpDown_trimEndHours";
            this.numericUpDown_trimEndHours.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_trimEndHours.TabIndex = 5;
            // 
            // numericUpDown_trimStartMinuets
            // 
            this.numericUpDown_trimStartMinuets.Location = new System.Drawing.Point(98, 42);
            this.numericUpDown_trimStartMinuets.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimStartMinuets.Name = "numericUpDown_trimStartMinuets";
            this.numericUpDown_trimStartMinuets.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_trimStartMinuets.TabIndex = 3;
            // 
            // numericUpDown_trimStartHours
            // 
            this.numericUpDown_trimStartHours.Location = new System.Drawing.Point(41, 42);
            this.numericUpDown_trimStartHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_trimStartHours.Name = "numericUpDown_trimStartHours";
            this.numericUpDown_trimStartHours.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown_trimStartHours.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "End";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Start";
            // 
            // groupBox_m3u8
            // 
            this.groupBox_m3u8.Controls.Add(this.label_status);
            this.groupBox_m3u8.Controls.Add(this.textBox_fileName);
            this.groupBox_m3u8.Controls.Add(this.button_m3u8);
            this.groupBox_m3u8.Controls.Add(this.textbox_m3u8);
            this.groupBox_m3u8.Controls.Add(this.comboBox_Format);
            this.groupBox_m3u8.Controls.Add(this.label_m3u8);
            this.groupBox_m3u8.Controls.Add(this.label_fileName);
            this.groupBox_m3u8.Controls.Add(this.label1);
            this.groupBox_m3u8.Location = new System.Drawing.Point(371, 55);
            this.groupBox_m3u8.Name = "groupBox_m3u8";
            this.groupBox_m3u8.Size = new System.Drawing.Size(334, 273);
            this.groupBox_m3u8.TabIndex = 1;
            this.groupBox_m3u8.TabStop = false;
            this.groupBox_m3u8.Text = "m3u8 Fuser";
            this.groupBox_m3u8.Enter += new System.EventHandler(this.groupBox_m3u8_Enter);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(134, 93);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(100, 20);
            this.textBox_fileName.TabIndex = 11;
            // 
            // button_m3u8
            // 
            this.button_m3u8.Location = new System.Drawing.Point(6, 127);
            this.button_m3u8.Name = "button_m3u8";
            this.button_m3u8.Size = new System.Drawing.Size(322, 23);
            this.button_m3u8.TabIndex = 10;
            this.button_m3u8.Text = "Save to Desktop";
            this.button_m3u8.UseVisualStyleBackColor = true;
            this.button_m3u8.Click += new System.EventHandler(this.button_m3u8_Click);
            // 
            // textbox_m3u8
            // 
            this.textbox_m3u8.Location = new System.Drawing.Point(6, 48);
            this.textbox_m3u8.Name = "textbox_m3u8";
            this.textbox_m3u8.Size = new System.Drawing.Size(322, 20);
            this.textbox_m3u8.TabIndex = 9;
            this.textbox_m3u8.Text = "Http://...../index.m3u8";
            // 
            // comboBox_Format
            // 
            this.comboBox_Format.FormattingEnabled = true;
            this.comboBox_Format.Items.AddRange(new object[] {
            "mp4",
            "avi",
            "flv",
            "mkv",
            "mov",
            "wmv",
            "mpeg",
            "mpg",
            "3gp",
            "vob",
            "ts",
            "m2ts",
            "ogg",
            "asf",
            "rm",
            "swf",
            "mxf",
            "nut"});
            this.comboBox_Format.Location = new System.Drawing.Point(6, 93);
            this.comboBox_Format.Name = "comboBox_Format";
            this.comboBox_Format.Size = new System.Drawing.Size(122, 21);
            this.comboBox_Format.TabIndex = 1;
            this.comboBox_Format.Text = "mp4";
            // 
            // label_m3u8
            // 
            this.label_m3u8.AutoSize = true;
            this.label_m3u8.Location = new System.Drawing.Point(6, 30);
            this.label_m3u8.Name = "label_m3u8";
            this.label_m3u8.Size = new System.Drawing.Size(106, 13);
            this.label_m3u8.TabIndex = 9;
            this.label_m3u8.Text = "Web link to m3u8 file";
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.Location = new System.Drawing.Point(131, 76);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(52, 13);
            this.label_fileName.TabIndex = 9;
            this.label_fileName.Text = "File name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Convert to";
            // 
            // groupBox_videoFile
            // 
            this.groupBox_videoFile.Controls.Add(this.button2);
            this.groupBox_videoFile.Controls.Add(this.groupBox2);
            this.groupBox_videoFile.Controls.Add(this.comboBox1);
            this.groupBox_videoFile.Controls.Add(this.button1);
            this.groupBox_videoFile.Controls.Add(this.textBox_URI);
            this.groupBox_videoFile.Controls.Add(this.label4);
            this.groupBox_videoFile.Location = new System.Drawing.Point(12, 55);
            this.groupBox_videoFile.Name = "groupBox_videoFile";
            this.groupBox_videoFile.Size = new System.Drawing.Size(344, 273);
            this.groupBox_videoFile.TabIndex = 0;
            this.groupBox_videoFile.TabStop = false;
            this.groupBox_videoFile.Text = "Video Format Converter";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Miriam Fixed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_status.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_status.Location = new System.Drawing.Point(102, 198);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(114, 27);
            this.label_status.TabIndex = 12;
            this.label_status.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 336);
            this.Controls.Add(this.groupBox_m3u8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox_videoFile);
            this.Name = "Form1";
            this.Text = "FFMPEGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndMinuets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimEndHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartMinuets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trimStartHours)).EndInit();
            this.groupBox_m3u8.ResumeLayout(false);
            this.groupBox_m3u8.PerformLayout();
            this.groupBox_videoFile.ResumeLayout(false);
            this.groupBox_videoFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_URI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox_trim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimStartHours;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimStartSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimStartMinuets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimEndSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimEndMinuets;
        private System.Windows.Forms.NumericUpDown numericUpDown_trimEndHours;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox_m3u8;
        private System.Windows.Forms.GroupBox groupBox_videoFile;
        private System.Windows.Forms.TextBox textbox_m3u8;
        private System.Windows.Forms.Label label_m3u8;
        private System.Windows.Forms.Button button_m3u8;
        private System.Windows.Forms.ComboBox comboBox_Format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Label label_status;
    }
}

