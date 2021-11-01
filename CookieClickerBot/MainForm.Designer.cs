
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
            this.cbDrawRectangle = new System.Windows.Forms.CheckBox();
            this.butStart = new System.Windows.Forms.Button();
            this.cbProcessNamesList = new System.Windows.Forms.ComboBox();
            this.lbSearchInSource = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.butTestFormStart = new System.Windows.Forms.Button();
            this.butTestScreenCapture = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.butTestScreenCapture);
            this.splitContainer1.Panel1.Controls.Add(this.cbDrawRectangle);
            this.splitContainer1.Panel1.Controls.Add(this.butStart);
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
            // cbDrawRectangle
            // 
            this.cbDrawRectangle.AutoSize = true;
            this.cbDrawRectangle.Location = new System.Drawing.Point(15, 413);
            this.cbDrawRectangle.Name = "cbDrawRectangle";
            this.cbDrawRectangle.Size = new System.Drawing.Size(200, 17);
            this.cbDrawRectangle.TabIndex = 4;
            this.cbDrawRectangle.Text = "Выделить выбранное приложение";
            this.cbDrawRectangle.UseVisualStyleBackColor = true;
            this.cbDrawRectangle.CheckedChanged += new System.EventHandler(this.cbDrawRectangle_CheckedChanged);
            // 
            // butStart
            // 
            this.butStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butStart.Image = global::CookieClickerBot.Properties.Resources.Small_start_img;
            this.butStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butStart.Location = new System.Drawing.Point(15, 64);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(107, 70);
            this.butStart.TabIndex = 3;
            this.butStart.Text = "Начать";
            this.butStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
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
            // butTestScreenCapture
            // 
            this.butTestScreenCapture.Location = new System.Drawing.Point(15, 167);
            this.butTestScreenCapture.Name = "butTestScreenCapture";
            this.butTestScreenCapture.Size = new System.Drawing.Size(214, 23);
            this.butTestScreenCapture.TabIndex = 5;
            this.butTestScreenCapture.Text = "TestScreenCapture";
            this.butTestScreenCapture.UseVisualStyleBackColor = true;
            this.butTestScreenCapture.Click += new System.EventHandler(this.butTestScreenCapture_Click);
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
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.CheckBox cbDrawRectangle;
        private System.Windows.Forms.Button butTestScreenCapture;
    }
}

