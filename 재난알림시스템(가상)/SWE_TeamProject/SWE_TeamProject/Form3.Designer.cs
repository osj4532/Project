namespace SWE_TeamProject
{
    partial class shelterLocation
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
            this.shelterLocation_Web = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // shelterLocation_Web
            // 
            this.shelterLocation_Web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelterLocation_Web.Location = new System.Drawing.Point(0, 0);
            this.shelterLocation_Web.MinimumSize = new System.Drawing.Size(20, 20);
            this.shelterLocation_Web.Name = "shelterLocation_Web";
            this.shelterLocation_Web.Size = new System.Drawing.Size(461, 437);
            this.shelterLocation_Web.TabIndex = 0;
            // 
            // shelterLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 437);
            this.Controls.Add(this.shelterLocation_Web);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "shelterLocation";
            this.Text = "주위 대피소";
            this.Load += new System.EventHandler(this.shelterLocation_Web_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser shelterLocation_Web;
    }
}