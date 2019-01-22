using System;

namespace ZmanMasach
{
    partial class MoneZman
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
            this.label_moneZman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_moneZman
            // 
            this.label_moneZman.AutoSize = true;
            this.label_moneZman.Font = new System.Drawing.Font("Guttman Adii", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_moneZman.Location = new System.Drawing.Point(30, 9);
            this.label_moneZman.Name = "label_moneZman";
            this.label_moneZman.Size = new System.Drawing.Size(68, 90);
            this.label_moneZman.TabIndex = 0;
            this.label_moneZman.Text = "0";
            this.label_moneZman.Click += new System.EventHandler(this.label_moneZman_Click);
            // 
            // MoneZman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.label_moneZman);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MoneZman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_moneZman;
    }
}