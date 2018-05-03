namespace SWE_TeamProject
{
    partial class CellPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellPhone));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppBtn = new System.Windows.Forms.Button();
            this.currentLocation_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(-11, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 18);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 46);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(192, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 40);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(131, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 40);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(70, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 40);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(13, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 40);
            this.label2.TabIndex = 0;
            // 
            // AppBtn
            // 
            this.AppBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppBtn.BackgroundImage")));
            this.AppBtn.Location = new System.Drawing.Point(10, 94);
            this.AppBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AppBtn.Name = "AppBtn";
            this.AppBtn.Size = new System.Drawing.Size(44, 40);
            this.AppBtn.TabIndex = 2;
            this.AppBtn.UseVisualStyleBackColor = true;
            this.AppBtn.Click += new System.EventHandler(this.AppBtn_Click);
            // 
            // currentLocation_TextBox
            // 
            this.currentLocation_TextBox.ForeColor = System.Drawing.Color.Black;
            this.currentLocation_TextBox.Location = new System.Drawing.Point(10, 51);
            this.currentLocation_TextBox.Name = "currentLocation_TextBox";
            this.currentLocation_TextBox.Size = new System.Drawing.Size(225, 21);
            this.currentLocation_TextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "현재 위치";
            // 
            // CellPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(247, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currentLocation_TextBox);
            this.Controls.Add(this.AppBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CellPhone";
            this.Text = "CellPhone";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AppBtn;
        private System.Windows.Forms.TextBox currentLocation_TextBox;
        private System.Windows.Forms.Label label6;
    }
}