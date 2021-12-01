
namespace CookieClickerBot.PannelFoms
{
    partial class TestEnvForm
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
            this.btnShowTetsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowTetsForm
            // 
            this.btnShowTetsForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowTetsForm.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowTetsForm.Image = global::CookieClickerBot.Properties.Resources.testEnv_256;
            this.btnShowTetsForm.Location = new System.Drawing.Point(0, 0);
            this.btnShowTetsForm.Name = "btnShowTetsForm";
            this.btnShowTetsForm.Size = new System.Drawing.Size(800, 450);
            this.btnShowTetsForm.TabIndex = 0;
            this.btnShowTetsForm.Text = "Show Test Environment";
            this.btnShowTetsForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowTetsForm.UseVisualStyleBackColor = true;
            this.btnShowTetsForm.Click += new System.EventHandler(this.btnShowTetsForm_Click);
            // 
            // TestEnvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowTetsForm);
            this.Name = "TestEnvForm";
            this.Text = "TEST ENVIRONMENT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowTetsForm;
    }
}