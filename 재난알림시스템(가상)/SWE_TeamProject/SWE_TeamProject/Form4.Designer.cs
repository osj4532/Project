namespace SWE_TeamProject
{
    partial class Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doorOpen_Radio = new System.Windows.Forms.RadioButton();
            this.doorClose_Radio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valveOpen_Radio = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.valveClose_Radio = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.window1Open_Radio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.window1Close_Radio = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.window2Open_Radio = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.window2Close_Radio = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "재난 알림 어플";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "현관";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doorOpen_Radio
            // 
            this.doorOpen_Radio.AutoSize = true;
            this.doorOpen_Radio.Checked = true;
            this.doorOpen_Radio.ForeColor = System.Drawing.Color.White;
            this.doorOpen_Radio.Location = new System.Drawing.Point(82, 11);
            this.doorOpen_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorOpen_Radio.Name = "doorOpen_Radio";
            this.doorOpen_Radio.Size = new System.Drawing.Size(39, 16);
            this.doorOpen_Radio.TabIndex = 10;
            this.doorOpen_Radio.TabStop = true;
            this.doorOpen_Radio.Text = "On";
            this.doorOpen_Radio.UseVisualStyleBackColor = true;
            // 
            // doorClose_Radio
            // 
            this.doorClose_Radio.AutoSize = true;
            this.doorClose_Radio.ForeColor = System.Drawing.Color.White;
            this.doorClose_Radio.Location = new System.Drawing.Point(130, 11);
            this.doorClose_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorClose_Radio.Name = "doorClose_Radio";
            this.doorClose_Radio.Size = new System.Drawing.Size(38, 16);
            this.doorClose_Radio.TabIndex = 11;
            this.doorClose_Radio.Text = "Off";
            this.doorClose_Radio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 18);
            this.button1.TabIndex = 20;
            this.button1.Text = "Auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doorOpen_Radio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.doorClose_Radio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(10, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(224, 33);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valveOpen_Radio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.valveClose_Radio);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(10, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(224, 33);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // valveOpen_Radio
            // 
            this.valveOpen_Radio.AutoSize = true;
            this.valveOpen_Radio.Checked = true;
            this.valveOpen_Radio.ForeColor = System.Drawing.Color.White;
            this.valveOpen_Radio.Location = new System.Drawing.Point(82, 11);
            this.valveOpen_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valveOpen_Radio.Name = "valveOpen_Radio";
            this.valveOpen_Radio.Size = new System.Drawing.Size(39, 16);
            this.valveOpen_Radio.TabIndex = 10;
            this.valveOpen_Radio.TabStop = true;
            this.valveOpen_Radio.Text = "On";
            this.valveOpen_Radio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "가스 벨브";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valveClose_Radio
            // 
            this.valveClose_Radio.AutoSize = true;
            this.valveClose_Radio.ForeColor = System.Drawing.Color.White;
            this.valveClose_Radio.Location = new System.Drawing.Point(130, 11);
            this.valveClose_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valveClose_Radio.Name = "valveClose_Radio";
            this.valveClose_Radio.Size = new System.Drawing.Size(38, 16);
            this.valveClose_Radio.TabIndex = 11;
            this.valveClose_Radio.Text = "Off";
            this.valveClose_Radio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 18);
            this.button2.TabIndex = 20;
            this.button2.Text = "Auto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.window1Open_Radio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.window1Close_Radio);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(10, 297);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(224, 33);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // window1Open_Radio
            // 
            this.window1Open_Radio.AutoSize = true;
            this.window1Open_Radio.Checked = true;
            this.window1Open_Radio.ForeColor = System.Drawing.Color.White;
            this.window1Open_Radio.Location = new System.Drawing.Point(82, 11);
            this.window1Open_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window1Open_Radio.Name = "window1Open_Radio";
            this.window1Open_Radio.Size = new System.Drawing.Size(39, 16);
            this.window1Open_Radio.TabIndex = 10;
            this.window1Open_Radio.TabStop = true;
            this.window1Open_Radio.Text = "On";
            this.window1Open_Radio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "창문1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // window1Close_Radio
            // 
            this.window1Close_Radio.AutoSize = true;
            this.window1Close_Radio.ForeColor = System.Drawing.Color.White;
            this.window1Close_Radio.Location = new System.Drawing.Point(130, 11);
            this.window1Close_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window1Close_Radio.Name = "window1Close_Radio";
            this.window1Close_Radio.Size = new System.Drawing.Size(38, 16);
            this.window1Close_Radio.TabIndex = 11;
            this.window1Close_Radio.Text = "Off";
            this.window1Close_Radio.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 18);
            this.button3.TabIndex = 20;
            this.button3.Text = "Auto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.window2Open_Radio);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.window2Close_Radio);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(10, 331);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(224, 33);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // window2Open_Radio
            // 
            this.window2Open_Radio.AutoSize = true;
            this.window2Open_Radio.Checked = true;
            this.window2Open_Radio.ForeColor = System.Drawing.Color.White;
            this.window2Open_Radio.Location = new System.Drawing.Point(82, 11);
            this.window2Open_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window2Open_Radio.Name = "window2Open_Radio";
            this.window2Open_Radio.Size = new System.Drawing.Size(39, 16);
            this.window2Open_Radio.TabIndex = 10;
            this.window2Open_Radio.TabStop = true;
            this.window2Open_Radio.Text = "On";
            this.window2Open_Radio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "창문2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // window2Close_Radio
            // 
            this.window2Close_Radio.AutoSize = true;
            this.window2Close_Radio.ForeColor = System.Drawing.Color.White;
            this.window2Close_Radio.Location = new System.Drawing.Point(130, 11);
            this.window2Close_Radio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.window2Close_Radio.Name = "window2Close_Radio";
            this.window2Close_Radio.Size = new System.Drawing.Size(38, 16);
            this.window2Close_Radio.TabIndex = 11;
            this.window2Close_Radio.Text = "Off";
            this.window2Close_Radio.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 18);
            this.button4.TabIndex = 20;
            this.button4.Text = "Auto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(12, 169);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(224, 29);
            this.button5.TabIndex = 21;
            this.button5.Text = "주변 대피소 보기";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "재난 현황 및 행동 수칙";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "현재 집 상황";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 54);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 108);
            this.richTextBox1.TabIndex = 29;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(247, 389);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Application";
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton doorOpen_Radio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton doorClose_Radio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton valveOpen_Radio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton valveClose_Radio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton window1Open_Radio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton window1Close_Radio;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton window2Open_Radio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton window2Close_Radio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}