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
    public partial class Form_Zman_Masach_Knisa : Form
    {
        private Hosft_Mishtamesh halon_hosafat_mishtamesh;

        

        public Form_Zman_Masach_Knisa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            halon_hosafat_mishtamesh = new Hosft_Mishtamesh();
            halon_hosafat_mishtamesh.Show();
        }

        private void FormZmanMasach_Load(object sender, EventArgs e)
        {
            this.listBox_mishtamshim.DataSource = MenahelMishtmshim.mishtamshimList;
            this.listBox_mishtamshim.DisplayMember = "shem";
            this.listBox_mishtamshim.ValueMember = "shem";
        }

        private void comboBox_reshimat_mishtamshim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_mishtamshim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_hafala_Click(object sender, EventArgs e)
        {
            MoneZman mone = new MoneZman();
            Program.myMenahelZman.AvraShniya += mone.onAvraShniya;
            mone.Show();
            
            int zmanInt = Convert.ToInt32(numeric_zman.Value);
            Program.myMenahelZman.sfira(zmanInt,e);

            mone.Close();

            Halon_Siyum_Zman halon = new Halon_Siyum_Zman();
            halon.Show();
        }
    }
}
