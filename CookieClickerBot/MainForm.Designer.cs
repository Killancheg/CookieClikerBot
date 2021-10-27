
namespace CookieClickerBot
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbProcessNamesList = new System.Windows.Forms.ComboBox();
            this.lbSearchInSource = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.butTestFormStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbProcessNamesList);
            this.splitContainer1.Panel1.Controls.Add(this.lbSearchInSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 597;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbProcessNamesList
            // 
            this.cbProcessNamesList.FormattingEnabled = true;
            this.cbProcessNamesList.Location = new System.Drawing.Point(15, 25);
            this.cbProcessNamesList.Name = "cbProcessNamesList";
            this.cbProcessNamesList.Size = new System.Drawing.Size(423, 21);
            this.cbProcessNamesList.TabIndex = 2;
            this.cbProcessNamesList.DropDown += new System.EventHandler(this.cbProcessNamesList_DropDown);
            // 
            // lbSearchInSource
            // 
            this.lbSearchInSource.AutoSize = true;
            this.lbSearchInSource.Location = new System.Drawing.Point(12, 9);
            this.lbSearchInSource.Name = "lbSearchInSource";
            this.lbSearchInSource.Size = new System.Drawing.Size(148, 13);
            this.lbSearchInSource.TabIndex = 1;
            this.lbSearchInSource.Text = "Выберите окно для работы:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.butTestFormStart);
            this.splitContainer2.Size = new System.Drawing.Size(199, 450);
            this.splitContainer2.SplitterDistance = 342;
            this.splitContainer2.TabIndex = 0;
            // 
            // butTestFormStart
            // 
            this.butTestFormStart.Location = new System.Drawing.Point(26, 22);
            this.butTestFormStart.Name = "butTestFormStart";
            this.butTestFormStart.Size = new System.Drawing.Size(149, 39);
            this.butTestFormStart.TabIndex = 0;
            this.butTestFormStart.Text = "Среда для тестирования";
            this.butTestFormStart.UseVisualStyleBackColor = true;
            this.butTestFormStart.Click += new System.EventHandler(this.butTestFormStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "CookieClickerBot";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button butTestFormStart;
        private System.Windows.Forms.ComboBox cbProcessNamesList;
        private System.Windows.Forms.Label lbSearchInSource;
    }
}

