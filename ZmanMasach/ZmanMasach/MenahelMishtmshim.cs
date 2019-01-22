using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ZmanMasach
{
    class MenahelMishtmshim
    {
        private static List<String> mistamshimStringList { get; set; }
        public static BindingList<Mishtamesh> mishtamshimList;
        private String sismatMenahel;
        private Mishtamesh mishtameshNivchar;

        public MenahelMishtmshim()
        {
        }

        public void init()
        {
            mistamshimStringList = Program.menahelKvazim.Teina();
            mishtamshimList = new BindingList<Mishtamesh>();
            foreach (String mishString in mistamshimStringList)
            {
               mishtamshimList.Add(new Mishtamesh(mishString));
            }

            //Add initial anonymous user for the first time. later it is not empty. 
            //if (mistamshimStringList.empty ) {
                Mishtamesh anonymous = new Mishtamesh("אנונימי", null, null, "נגמר הזמן!");
                mistamshimStringList.Add(anonymous.createString());
                mishtamshimList.Add(anonymous);
                mishtameshNivchar = anonymous;
            //}
        }

        public void hosefMistamesh(String shem_lehosafa, String kovetzTmuna_lehosafa, String text_lehosafa)
        {
            Mishtamesh mishmesh = new Mishtamesh();
            mishmesh.shem = shem_lehosafa;

            mishmesh.kovetzTmuna = kovetzTmuna_lehosafa;

            mishmesh.text = text_lehosafa;

            mistamshimStringList.Add(mishmesh.createString());
            mishtamshimList.Add(mishmesh);

            Program.menahelKvazim.Shmira(mistamshimStringList);
        }

        public void mechakMishtamesh()
        {

        }
    }
}
