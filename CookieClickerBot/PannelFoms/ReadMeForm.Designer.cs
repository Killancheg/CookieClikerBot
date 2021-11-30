
namespace CookieClickerBot.PannelFoms
{
    partial class ReadMeForm
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
            this.wbReadMe = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbReadMe
            // 
            this.wbReadMe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbReadMe.Location = new System.Drawing.Point(0, 0);
            this.wbReadMe.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbReadMe.Name = "wbReadMe";
            this.wbReadMe.Size = new System.Drawing.Size(800, 450);
            this.wbReadMe.TabIndex = 0;
            this.wbReadMe.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wbReadMe_Navigating);
            // 
            // ReadMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbReadMe);
            this.Name = "ReadMeForm";
            this.Text = "О ПРОГРАММЕ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbReadMe;
    }
}