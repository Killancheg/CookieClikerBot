
namespace CookieClickerBot.PannelFoms
{
    partial class BotStartForm
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
            this.cbWindowList = new System.Windows.Forms.ComboBox();
            this.lbWindowList = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.chbDrawRectangle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbWindowList
            // 
            this.cbWindowList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWindowList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWindowList.FormattingEnabled = true;
            this.cbWindowList.Location = new System.Drawing.Point(12, 39);
            this.cbWindowList.Name = "cbWindowList";
            this.cbWindowList.Size = new System.Drawing.Size(528, 31);
            this.cbWindowList.TabIndex = 0;
            this.cbWindowList.DropDown += new System.EventHandler(this.cbWindowList_DropDown);
            this.cbWindowList.Enter += new System.EventHandler(this.cbWindowList_Enter);
            // 
            // lbWindowList
            // 
            this.lbWindowList.AutoSize = true;
            this.lbWindowList.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWindowList.Location = new System.Drawing.Point(13, 13);
            this.lbWindowList.Name = "lbWindowList";
            this.lbWindowList.Size = new System.Drawing.Size(215, 23);
            this.lbWindowList.TabIndex = 1;
            this.lbWindowList.Text = "Выберите окно для работы:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Image = global::CookieClickerBot.Properties.Resources.play_64;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(17, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(162, 78);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Запуск\r\n(Insert)";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // chbDrawRectangle
            // 
            this.chbDrawRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbDrawRectangle.AutoSize = true;
            this.chbDrawRectangle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbDrawRectangle.Location = new System.Drawing.Point(12, 328);
            this.chbDrawRectangle.Name = "chbDrawRectangle";
            this.chbDrawRectangle.Size = new System.Drawing.Size(245, 24);
            this.chbDrawRectangle.TabIndex = 3;
            this.chbDrawRectangle.Text = "Выделить выбранное приложение";
            this.chbDrawRectangle.UseVisualStyleBackColor = true;
            this.chbDrawRectangle.CheckedChanged += new System.EventHandler(this.chbDrawRectangle_CheckedChanged);
            // 
            // BotStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 364);
            this.Controls.Add(this.chbDrawRectangle);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbWindowList);
            this.Controls.Add(this.cbWindowList);
            this.Name = "BotStartForm";
            this.Text = "АВТОКЛИККЕР";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWindowList;
        private System.Windows.Forms.Label lbWindowList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox chbDrawRectangle;
    }
}