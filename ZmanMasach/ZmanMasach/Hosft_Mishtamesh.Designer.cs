namespace ZmanMasach
{
    partial class Hosft_Mishtamesh
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
            this.textBox_Hosafat_Shem = new System.Windows.Forms.TextBox();
            this.textBox_Hosafat_tmuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Hosafat_text_sium = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Shmirt_Mishtamesh = new System.Windows.Forms.Button();
            this.button_bitul_Shmirt_Mishtamesh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Hosafat_Shem
            // 
            this.textBox_Hosafat_Shem.Location = new System.Drawing.Point(30, 29);
            this.textBox_Hosafat_Shem.Name = "textBox_Hosafat_Shem";
            this.textBox_Hosafat_Shem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Hosafat_Shem.Size = new System.Drawing.Size(177, 20);
            this.textBox_Hosafat_Shem.TabIndex = 0;
            this.textBox_Hosafat_Shem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_Hosafat_Shem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Hosafat_tmuna
            // 
            this.textBox_Hosafat_tmuna.Location = new System.Drawing.Point(33, 66);
            this.textBox_Hosafat_tmuna.Name = "textBox_Hosafat_tmuna";
            this.textBox_Hosafat_tmuna.Size = new System.Drawing.Size(174, 20);
            this.textBox_Hosafat_tmuna.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = ":שם";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ":קובץ תמונה";
            // 
            // textBox_Hosafat_text_sium
            // 
            this.textBox_Hosafat_text_sium.Location = new System.Drawing.Point(33, 108);
            this.textBox_Hosafat_text_sium.Name = "textBox_Hosafat_text_sium";
            this.textBox_Hosafat_text_sium.Size = new System.Drawing.Size(173, 20);
            this.textBox_Hosafat_text_sium.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(211, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = ":טקסט סיום";
            // 
            // button_Shmirt_Mishtamesh
            // 
            this.button_Shmirt_Mishtamesh.Location = new System.Drawing.Point(90, 216);
            this.button_Shmirt_Mishtamesh.Name = "button_Shmirt_Mishtamesh";
            this.button_Shmirt_Mishtamesh.Size = new System.Drawing.Size(86, 29);
            this.button_Shmirt_Mishtamesh.TabIndex = 6;
            this.button_Shmirt_Mishtamesh.Text = "שמור";
            this.button_Shmirt_Mishtamesh.UseVisualStyleBackColor = true;
            this.button_Shmirt_Mishtamesh.Click += new System.EventHandler(this.button_Shmirt_Mishtamesh_Click);
            // 
            // button_bitul_Shmirt_Mishtamesh
            // 
            this.button_bitul_Shmirt_Mishtamesh.Location = new System.Drawing.Point(214, 216);
            this.button_bitul_Shmirt_Mishtamesh.Name = "button_bitul_Shmirt_Mishtamesh";
            this.button_bitul_Shmirt_Mishtamesh.Size = new System.Drawing.Size(72, 29);
            this.button_bitul_Shmirt_Mishtamesh.TabIndex = 7;
            this.button_bitul_Shmirt_Mishtamesh.Text = "בטל";
            this.button_bitul_Shmirt_Mishtamesh.UseVisualStyleBackColor = true;
            this.button_bitul_Shmirt_Mishtamesh.Click += new System.EventHandler(this.button_bitul_Shmirt_Mishtamesh_Click);
            // 
            // Hosft_Mishtamesh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 261);
            this.Controls.Add(this.button_bitul_Shmirt_Mishtamesh);
            this.Controls.Add(this.button_Shmirt_Mishtamesh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Hosafat_text_sium);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Hosafat_tmuna);
            this.Controls.Add(this.textBox_Hosafat_Shem);
            this.Name = "Hosft_Mishtamesh";
            this.Text = "הוספת משתמש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Hosafat_Shem;
        private System.Windows.Forms.TextBox textBox_Hosafat_tmuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Hosafat_text_sium;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Shmirt_Mishtamesh;
        private System.Windows.Forms.Button button_bitul_Shmirt_Mishtamesh;
    }
}