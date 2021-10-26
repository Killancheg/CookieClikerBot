﻿
namespace CookieClickerBot
{
    partial class TestForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbImageLocation = new System.Windows.Forms.TextBox();
            this.butChoseImage = new System.Windows.Forms.Button();
            this.labChoseImage = new System.Windows.Forms.Label();
            this.pbImageToCompare = new System.Windows.Forms.PictureBox();
            this.lbClickCount = new System.Windows.Forms.Label();
            this.lbClickCounter = new System.Windows.Forms.Label();
            this.butClickCounterClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToCompare)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.butClickCounterClear);
            this.splitContainer1.Panel2.Controls.Add(this.lbClickCounter);
            this.splitContainer1.Panel2.Controls.Add(this.lbClickCount);
            this.splitContainer1.Size = new System.Drawing.Size(687, 528);
            this.splitContainer1.SplitterDistance = 519;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.pbImageToCompare);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labChoseImage);
            this.splitContainer2.Panel2.Controls.Add(this.butChoseImage);
            this.splitContainer2.Panel2.Controls.Add(this.tbImageLocation);
            this.splitContainer2.Size = new System.Drawing.Size(519, 528);
            this.splitContainer2.SplitterDistance = 429;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbImageLocation
            // 
            this.tbImageLocation.Location = new System.Drawing.Point(12, 38);
            this.tbImageLocation.Name = "tbImageLocation";
            this.tbImageLocation.Size = new System.Drawing.Size(488, 20);
            this.tbImageLocation.TabIndex = 0;
            this.tbImageLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbImageLocation_KeyDown);
            this.tbImageLocation.Validating += new System.ComponentModel.CancelEventHandler(this.tbImageLocation_Validating);
            // 
            // butChoseImage
            // 
            this.butChoseImage.Location = new System.Drawing.Point(12, 64);
            this.butChoseImage.Name = "butChoseImage";
            this.butChoseImage.Size = new System.Drawing.Size(75, 23);
            this.butChoseImage.TabIndex = 1;
            this.butChoseImage.Text = "Обзор";
            this.butChoseImage.UseVisualStyleBackColor = true;
            this.butChoseImage.Click += new System.EventHandler(this.butChoseImage_Click);
            // 
            // labChoseImage
            // 
            this.labChoseImage.AutoSize = true;
            this.labChoseImage.Location = new System.Drawing.Point(13, 19);
            this.labChoseImage.Name = "labChoseImage";
            this.labChoseImage.Size = new System.Drawing.Size(128, 13);
            this.labChoseImage.TabIndex = 2;
            this.labChoseImage.Text = "Выберите изображение";
            // 
            // pbImageToCompare
            // 
            this.pbImageToCompare.Location = new System.Drawing.Point(12, 13);
            this.pbImageToCompare.Name = "pbImageToCompare";
            this.pbImageToCompare.Size = new System.Drawing.Size(488, 396);
            this.pbImageToCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageToCompare.TabIndex = 0;
            this.pbImageToCompare.TabStop = false;
            this.pbImageToCompare.Click += new System.EventHandler(this.pbImageToCompare_Click);
            // 
            // lbClickCount
            // 
            this.lbClickCount.AutoSize = true;
            this.lbClickCount.Location = new System.Drawing.Point(17, 13);
            this.lbClickCount.Name = "lbClickCount";
            this.lbClickCount.Size = new System.Drawing.Size(112, 13);
            this.lbClickCount.TabIndex = 0;
            this.lbClickCount.Text = "Кликов по картинке:";
            // 
            // lbClickCounter
            // 
            this.lbClickCounter.AutoSize = true;
            this.lbClickCounter.Location = new System.Drawing.Point(17, 37);
            this.lbClickCounter.Name = "lbClickCounter";
            this.lbClickCounter.Size = new System.Drawing.Size(13, 13);
            this.lbClickCounter.TabIndex = 1;
            this.lbClickCounter.Text = "0";
            // 
            // butClickCounterClear
            // 
            this.butClickCounterClear.Location = new System.Drawing.Point(20, 65);
            this.butClickCounterClear.Name = "butClickCounterClear";
            this.butClickCounterClear.Size = new System.Drawing.Size(106, 23);
            this.butClickCounterClear.TabIndex = 2;
            this.butClickCounterClear.Text = "Обнулить счетчик";
            this.butClickCounterClear.UseVisualStyleBackColor = true;
            this.butClickCounterClear.Click += new System.EventHandler(this.butClickCounterClear_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 528);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageToCompare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labChoseImage;
        private System.Windows.Forms.Button butChoseImage;
        private System.Windows.Forms.TextBox tbImageLocation;
        private System.Windows.Forms.PictureBox pbImageToCompare;
        private System.Windows.Forms.Button butClickCounterClear;
        private System.Windows.Forms.Label lbClickCounter;
        private System.Windows.Forms.Label lbClickCount;
    }
}