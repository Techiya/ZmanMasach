using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmanMasach
{
    class MenahelZman
    {
        private int zmanHatchalati;
        private int ShniotSenotru;

        public event EventHandler AvraShniya;

        public void sfira(int shniot, EventArgs e)
        {
            zmanHatchalati = shniot;
            ShniotSenotru = shniot;
            AvraShniya(this, e);

            while (ShniotSenotru>0)
            {
                System.Threading.Thread.Sleep(1000);
                ShniotSenotru--;
                AvraShniya(this, e);              
            }
        }

        public int getShniotShenotru()
        {
            return ShniotSenotru;
        }
    }
}