﻿namespace ZmanMasach
{
    partial class Halon_Siyum_Zman
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
            this.button_Siyum_OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Siyum_OK
            // 
            this.button_Siyum_OK.Location = new System.Drawing.Point(226, 87);
            this.button_Siyum_OK.Name = "button_Siyum_OK";
            this.button_Siyum_OK.Size = new System.Drawing.Size(75, 23);
            this.button_Siyum_OK.TabIndex = 0;
            this.button_Siyum_OK.Text = "סגור";
            this.button_Siyum_OK.UseVisualStyleBackColor = true;
            this.button_Siyum_OK.Click += new System.EventHandler(this.button_Siyum_OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "נגמר הזמן, נא לפנות את המחשב!";
            // 
            // Halon_Siyum_Zman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Siyum_OK);
            this.Name = "Halon_Siyum_Zman";
            this.Text = "נגמר הזמן";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Siyum_OK;
        private System.Windows.Forms.Label label1;
    }
}