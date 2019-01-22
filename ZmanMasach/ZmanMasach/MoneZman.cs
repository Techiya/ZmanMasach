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
    public partial class MoneZman : Form
    {
        public MoneZman()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label_moneZman_Click(object sender, EventArgs e)
        {

        }

        public void onAvraShniya(object sender, EventArgs e)
        {
            label_moneZman.Text = Program.myMenahelZman.getShniotShenotru().ToString();
            Refresh();
        }
    }
}
