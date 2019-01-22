using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZmanMasach
{
    public partial class Hosft_Mishtamesh : Form
    {
        public Hosft_Mishtamesh()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_bitul_Shmirt_Mishtamesh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Shmirt_Mishtamesh_Click(object sender, EventArgs e)
        {
            String shem = textBox_Hosafat_Shem.Text;
            string tmuna = textBox_Hosafat_tmuna.Text;
            string text = textBox_Hosafat_text_sium.Text;
            Program.myMenahel.hosefMistamesh(shem, tmuna, text);
            Close();
        }
    }
}