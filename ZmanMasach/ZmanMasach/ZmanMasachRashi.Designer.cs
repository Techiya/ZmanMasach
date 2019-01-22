namespace ZmanMasach
{
    partial class Form_Zman_Masach_Knisa
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
            this.button_hosafat_mishtamesh = new System.Windows.Forms.Button();
            this.button_mechak_mishtamesh = new System.Windows.Forms.Button();
            this.button_hafala = new System.Windows.Forms.Button();
            this.button_hagdarot = new System.Windows.Forms.Button();
            this.pictureBox_tmuna = new System.Windows.Forms.PictureBox();
            this.listBox_mishtamshim = new System.Windows.Forms.ListBox();
            this.numeric_zman = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tmuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zman)).BeginInit();
            this.SuspendLayout();
            // 
            // button_hosafat_mishtamesh
            // 
            this.button_hosafat_mishtamesh.Location = new System.Drawing.Point(191, 131);
            this.button_hosafat_mishtamesh.Name = "button_hosafat_mishtamesh";
            this.button_hosafat_mishtamesh.Size = new System.Drawing.Size(70, 40);
            this.button_hosafat_mishtamesh.TabIndex = 2;
            this.button_hosafat_mishtamesh.Text = "הוסף משתמש";
            this.button_hosafat_mishtamesh.UseVisualStyleBackColor = true;
            this.button_hosafat_mishtamesh.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_mechak_mishtamesh
            // 
            this.button_mechak_mishtamesh.Location = new System.Drawing.Point(267, 131);
            this.button_mechak_mishtamesh.Name = "button_mechak_mishtamesh";
            this.button_mechak_mishtamesh.Size = new System.Drawing.Size(69, 40);
            this.button_mechak_mishtamesh.TabIndex = 3;
            this.button_mechak_mishtamesh.Text = "מחק משתמש";
            this.button_mechak_mishtamesh.UseVisualStyleBackColor = true;
            // 
            // button_hafala
            // 
            this.button_hafala.Location = new System.Drawing.Point(12, 184);
            this.button_hafala.Name = "button_hafala";
            this.button_hafala.Size = new System.Drawing.Size(45, 41);
            this.button_hafala.TabIndex = 5;
            this.button_hafala.Text = "הפעל";
            this.button_hafala.UseVisualStyleBackColor = true;
            this.button_hafala.Click += new System.EventHandler(this.button_hafala_Click);
            // 
            // button_hagdarot
            // 
            this.button_hagdarot.Image = global::ZmanMasach.Properties.Resources.hagdarot;
            this.button_hagdarot.Location = new System.Drawing.Point(281, 182);
            this.button_hagdarot.Name = "button_hagdarot";
            this.button_hagdarot.Size = new System.Drawing.Size(55, 44);
            this.button_hagdarot.TabIndex = 6;
            this.button_hagdarot.UseVisualStyleBackColor = true;
            // 
            // pictureBox_tmuna
            // 
            this.pictureBox_tmuna.Location = new System.Drawing.Point(12, 23);
            this.pictureBox_tmuna.Name = "pictureBox_tmuna";
            this.pictureBox_tmuna.Size = new System.Drawing.Size(158, 135);
            this.pictureBox_tmuna.TabIndex = 1;
            this.pictureBox_tmuna.TabStop = false;
            // 
            // listBox_mishtamshim
            // 
            this.listBox_mishtamshim.DisplayMember = "shem";
            this.listBox_mishtamshim.FormattingEnabled = true;
            this.listBox_mishtamshim.Location = new System.Drawing.Point(191, 23);
            this.listBox_mishtamshim.Name = "listBox_mishtamshim";
            this.listBox_mishtamshim.Size = new System.Drawing.Size(145, 95);
            this.listBox_mishtamshim.TabIndex = 8;
            this.listBox_mishtamshim.SelectedIndexChanged += new System.EventHandler(this.listBox_mishtamshim_SelectedIndexChanged);
            // 
            // numeric_zman
            // 
            this.numeric_zman.Location = new System.Drawing.Point(63, 184);
            this.numeric_zman.Name = "numeric_zman";
            this.numeric_zman.Size = new System.Drawing.Size(107, 20);
            this.numeric_zman.TabIndex = 9;
            // 
            // Form_Zman_Masach_Knisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.numeric_zman);
            this.Controls.Add(this.listBox_mishtamshim);
            this.Controls.Add(this.button_hagdarot);
            this.Controls.Add(this.button_hafala);
            this.Controls.Add(this.button_mechak_mishtamesh);
            this.Controls.Add(this.button_hosafat_mishtamesh);
            this.Controls.Add(this.pictureBox_tmuna);
            this.Name = "Form_Zman_Masach_Knisa";
            this.Text = "Zman Masach";
            this.Load += new System.EventHandler(this.FormZmanMasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tmuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_zman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_tmuna;
        private System.Windows.Forms.Button button_hosafat_mishtamesh;
        private System.Windows.Forms.Button button_mechak_mishtamesh;
        private System.Windows.Forms.Button button_hafala;
        private System.Windows.Forms.Button button_hagdarot;
        private System.Windows.Forms.ListBox listBox_mishtamshim;
        private System.Windows.Forms.NumericUpDown numeric_zman;
    }
}

