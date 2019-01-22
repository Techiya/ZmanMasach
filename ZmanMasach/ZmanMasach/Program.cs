using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZmanMasach
{
    static class Program
    {
        public static MenahelZman myMenahelZman;
        public static MenahelMishtmshim myMenahel;
        public static NihulShmiraBeKovetz menahelKvazim;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            init1();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Zman_Masach_Knisa());
        }

        private static void init1()
        {
            menahelKvazim = new NihulShmiraBeKovetz("pirteyMishtamshim.txt");
            myMenahel = new MenahelMishtmshim();
            myMenahel.init();
            myMenahelZman = new MenahelZman();
           
        }
    }
}
