namespace SWE_TeamProject
{
    partial class Simulrator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDisaster_Btn = new System.Windows.Forms.Button();
            this.LocateLabel = new System.Windows.Forms.Label();
            this.LocateInfo = new System.Windows.Forms.TextBox();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.PowerInfo = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeInfo = new System.Windows.Forms.TextBox();
            this.Earthquake_radioBtn = new System.Windows.Forms.RadioButton();
            this.tsunami_radioBtn = new System.Windows.Forms.RadioButton();
            this.yellowDust_radioBtn = new System.Windows.Forms.RadioButton();
            this.tornado_radioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doorOpen_Radio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.doorClose_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.valveOpen_Radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.valveClose_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.window1Open_Radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.window1Close_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.window2Open_Radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.window2Close_Radio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDisaster_Btn
            // 
            this.startDisaster_Btn.Location = new System.Drawing.Point(246, 348);
            this.startDisaster_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDisaster_Btn.Name = "startDisaster_Btn";
            this.startDisaster_Btn.Size = new System.Drawing.Size(75, 50);
            this.startDisaster_Btn.TabIndex = 0;
            this.startDisaster_Btn.Text = "발생";
            this.startDisaster_Btn.UseVisualStyleBackColor = true;
            this.startDisaster_Btn.Click += new System.EventHandler(this.startDisaster_Btn_Click);
            // 
            // LocateLabel
            // 
            this.LocateLabel.BackColor = System.Drawing.Color.Black;
            this.LocateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocateLabel.ForeColor = System.Drawing.Color.White;
            this.LocateLabel.Location = new System.Drawing.Point(21, 94);
            this.LocateLabel.Name = "LocateLabel";
            this.LocateLabel.Size = new System.Drawing.Size(100, 24);
            this.LocateLabel.TabIndex = 4;
            this.LocateLabel.Text = "발생 위치";
            this.LocateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LocateInfo
            // 
            this.LocateInfo.Location = new System.Drawing.Point(128, 92);
            this.LocateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LocateInfo.Name = "LocateInfo";
            this.LocateInfo.Size = new System.Drawing.Size(201, 25);
            this.LocateInfo.TabIndex = 5;
            // 
            // PowerLabel
            // 
            this.PowerLabel.BackColor = System.Drawing.Color.Black;
            this.PowerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PowerLabel.ForeColor = System.Drawing.Color.White;
            this.PowerLabel.Location = new System.Drawing.Point(21, 141);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(100, 24);
            this.PowerLabel.TabIndex = 6;
            this.PowerLabel.Text = "재난 강도";
            this.PowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerInfo
            // 
            this.PowerInfo.Location = new System.Drawing.Point(128, 141);
            this.PowerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PowerInfo.Name = "PowerInfo";
            this.PowerInfo.Size = new System.Drawing.Size(201, 25);
            this.PowerInfo.TabIndex = 7;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Black;
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(21, 186);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(100, 24);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Text = "발생 시간";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeInfo
            // 
            this.TimeInfo.Location = new System.Drawing.Point(128, 186);
            this.TimeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeInfo.Name = "TimeInfo";
            this.TimeInfo.Size = new System.Drawing.Size(201, 25);
            this.TimeInfo.TabIndex = 9;
            // 
            // Earthquake_radioBtn
            // 
            this.Earthquake_radioBtn.AutoSize = true;
            this.Earthquake_radioBtn.Location = new System.Drawing.Point(24, 32);
            this.Earthquake_radioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Earthquake_radioBtn.Name = "Earthquake_radioBtn";
            this.Earthquake_radioBtn.Size = new System.Drawing.Size(58, 19);
            this.Earthquake_radioBtn.TabIndex = 10;
            this.Earthquake_radioBtn.TabStop = true;
            this.Earthquake_radioBtn.Text = "지진";
            this.Earthquake_radioBtn.UseVisualStyleBackColor = true;
            this.Earthquake_radioBtn.CheckedChanged += new System.EventHandler(this.Earthquake_radioBtn_CheckedChanged);
            // 
            // tsunami_radioBtn
            // 
            this.tsunami_radioBtn.AutoSize = true;
            this.tsunami_radioBtn.Location = new System.Drawing.Point(99, 32);
            this.tsunami_radioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tsunami_radioBtn.Name = "tsunami_radioBtn";
            this.tsunami_radioBtn.Size = new System.Drawing.Size(58, 19);
            this.tsunami_radioBtn.TabIndex = 11;
            this.tsunami_radioBtn.TabStop = true;
            this.tsunami_radioBtn.Text = "해일";
            this.tsunami_radioBtn.UseVisualStyleBackColor = true;
            this.tsunami_radioBtn.CheckedChanged += new System.EventHandler(this.tsunami_radioBtn_CheckedChanged);
            // 
            // yellowDust_radioBtn
            // 
            this.yellowDust_radioBtn.AutoSize = true;
            this.yellowDust_radioBtn.Location = new System.Drawing.Point(185, 32);
            this.yellowDust_radioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.yellowDust_radioBtn.Name = "yellowDust_radioBtn";
            this.yellowDust_radioBtn.Size = new System.Drawing.Size(58, 19);
            this.yellowDust_radioBtn.TabIndex = 12;
            this.yellowDust_radioBtn.TabStop = true;
            this.yellowDust_radioBtn.Text = "황사";
            this.yellowDust_radioBtn.UseVisualStyleBackColor = true;
            this.yellowDust_radioBtn.CheckedChanged += new System.EventHandler(this.yellowDust_radioBtn_CheckedChanged);
            // 
            // tornado_radioBtn
            // 
            this.tornado_radioBtn.AutoSize = true;
            this.tornado_radioBtn.Location = new System.Drawing.Point(266, 32);
            this.tornado_radioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tornado_radioBtn.Name = "tornado_radioBtn";
            this.tornado_radioBtn.Size = new System.Drawing.Size(58, 19);
            this.tornado_radioBtn.TabIndex = 13;
            this.tornado_radioBtn.TabStop = true;
            this.tornado_radioBtn.Text = "태풍";
            this.tornado_radioBtn.UseVisualStyleBackColor = true;
            this.tornado_radioBtn.CheckedChanged += new System.EventHandler(this.tornado_radioBtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yellowDust_radioBtn);
            this.groupBox1.Controls.Add(this.tornado_radioBtn);
            this.groupBox1.Controls.Add(this.Earthquake_radioBtn);
            this.groupBox1.Controls.Add(this.tsunami_radioBtn);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(338, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doorOpen_Radio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.doorClose_Radio);
            this.groupBox2.Location = new System.Drawing.Point(7, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(199, 41);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // doorOpen_Radio
            // 
            this.doorOpen_Radio.AutoSize = true;
            this.doorOpen_Radio.Checked = true;
            this.doorOpen_Radio.ForeColor = System.Drawing.Color.Black;
            this.doorOpen_Radio.Location = new System.Drawing.Point(94, 14);
            this.doorOpen_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorOpen_Radio.Name = "doorOpen_Radio";
            this.doorOpen_Radio.Size = new System.Drawing.Size(48, 19);
            this.doorOpen_Radio.TabIndex = 10;
            this.doorOpen_Radio.TabStop = true;
            this.doorOpen_Radio.Text = "On";
            this.doorOpen_Radio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "현관";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doorClose_Radio
            // 
            this.doorClose_Radio.AutoSize = true;
            this.doorClose_Radio.ForeColor = System.Drawing.Color.Black;
            this.doorClose_Radio.Location = new System.Drawing.Point(149, 14);
            this.doorClose_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorClose_Radio.Name = "doorClose_Radio";
            this.doorClose_Radio.Size = new System.Drawing.Size(48, 19);
            this.doorClose_Radio.TabIndex = 11;
            this.doorClose_Radio.Text = "Off";
            this.doorClose_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.valveOpen_Radio);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.valveClose_Radio);
            this.groupBox3.Location = new System.Drawing.Point(7, 264);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(199, 41);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // valveOpen_Radio
            // 
            this.valveOpen_Radio.AutoSize = true;
            this.valveOpen_Radio.Checked = true;
            this.valveOpen_Radio.ForeColor = System.Drawing.Color.Black;
            this.valveOpen_Radio.Location = new System.Drawing.Point(94, 14);
            this.valveOpen_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valveOpen_Radio.Name = "valveOpen_Radio";
            this.valveOpen_Radio.Size = new System.Drawing.Size(48, 19);
            this.valveOpen_Radio.TabIndex = 10;
            this.valveOpen_Radio.TabStop = true;
            this.valveOpen_Radio.Text = "On";
            this.valveOpen_Radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "가스 벨브";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valveClose_Radio
            // 
            this.valveClose_Radio.AutoSize = true;
            this.valveClose_Radio.ForeColor = System.Drawing.Color.Black;
            this.valveClose_Radio.Location = new System.Drawing.Point(149, 14);
            this.valveClose_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valveClose_Radio.Name = "valveClose_Radio";
            this.valveClose_Radio.Size = new System.Drawing.Size(48, 19);
            this.valveClose_Radio.TabIndex = 11;
            this.valveClose_Radio.Text = "Off";
            this.valveClose_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.window1Open_Radio);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.window1Close_Radio);
            this.groupBox4.Location = new System.Drawing.Point(7, 310);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(199, 41);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // window1Open_Radio
            // 
            this.window1Open_Radio.AutoSize = true;
            this.window1Open_Radio.Checked = true;
            this.window1Open_Radio.ForeColor = System.Drawing.Color.Black;
            this.window1Open_Radio.Location = new System.Drawing.Point(94, 14);
            this.window1Open_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window1Open_Radio.Name = "window1Open_Radio";
            this.window1Open_Radio.Size = new System.Drawing.Size(48, 19);
            this.window1Open_Radio.TabIndex = 10;
            this.window1Open_Radio.TabStop = true;
            this.window1Open_Radio.Text = "On";
            this.window1Open_Radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "창문 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // window1Close_Radio
            // 
            this.window1Close_Radio.AutoSize = true;
            this.window1Close_Radio.ForeColor = System.Drawing.Color.Black;
            this.window1Close_Radio.Location = new System.Drawing.Point(149, 14);
            this.window1Close_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window1Close_Radio.Name = "window1Close_Radio";
            this.window1Close_Radio.Size = new System.Drawing.Size(48, 19);
            this.window1Close_Radio.TabIndex = 11;
            this.window1Close_Radio.Text = "Off";
            this.window1Close_Radio.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.window2Open_Radio);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.window2Close_Radio);
            this.groupBox5.Location = new System.Drawing.Point(7, 356);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(199, 41);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // window2Open_Radio
            // 
            this.window2Open_Radio.AutoSize = true;
            this.window2Open_Radio.Checked = true;
            this.window2Open_Radio.ForeColor = System.Drawing.Color.Black;
            this.window2Open_Radio.Location = new System.Drawing.Point(94, 14);
            this.window2Open_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window2Open_Radio.Name = "window2Open_Radio";
            this.window2Open_Radio.Size = new System.Drawing.Size(48, 19);
            this.window2Open_Radio.TabIndex = 10;
            this.window2Open_Radio.TabStop = true;
            this.window2Open_Radio.Text = "On";
            this.window2Open_Radio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "창문 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // window2Close_Radio
            // 
            this.window2Close_Radio.AutoSize = true;
            this.window2Close_Radio.ForeColor = System.Drawing.Color.Black;
            this.window2Close_Radio.Location = new System.Drawing.Point(149, 14);
            this.window2Close_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window2Close_Radio.Name = "window2Close_Radio";
            this.window2Close_Radio.Size = new System.Drawing.Size(48, 19);
            this.window2Close_Radio.TabIndex = 11;
            this.window2Close_Radio.Text = "Off";
            this.window2Close_Radio.UseVisualStyleBackColor = true;
            // 
            // Simulrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 414);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeInfo);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.PowerInfo);
            this.Controls.Add(this.PowerLabel);
            this.Controls.Add(this.LocateInfo);
            this.Controls.Add(this.LocateLabel);
            this.Controls.Add(this.startDisaster_Btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Simulrator";
            this.Text = "Simulrator";
            this.Load += new System.EventHandler(this.Simulrator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startDisaster_Btn;
        private System.Windows.Forms.Label LocateLabel;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Label TimeLabel;
        public System.Windows.Forms.TextBox LocateInfo;
        public System.Windows.Forms.TextBox PowerInfo;
        public System.Windows.Forms.TextBox TimeInfo;
        private System.Windows.Forms.RadioButton Earthquake_radioBtn;
        private System.Windows.Forms.RadioButton tsunami_radioBtn;
        private System.Windows.Forms.RadioButton yellowDust_radioBtn;
        private System.Windows.Forms.RadioButton tornado_radioBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton doorClose_Radio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton valveClose_Radio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton window1Close_Radio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton window2Close_Radio;
        public System.Windows.Forms.RadioButton doorOpen_Radio;
        public System.Windows.Forms.RadioButton valveOpen_Radio;
        public System.Windows.Forms.RadioButton window1Open_Radio;
        public System.Windows.Forms.RadioButton window2Open_Radio;
    }
}

