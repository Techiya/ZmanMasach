using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZmanMasach
{
    class NihulShmiraBeKovetz
    {
        private String shemKovetz;

        public NihulShmiraBeKovetz(String _shemKovetz)
        {
            shemKovetz = _shemKovetz;
        }

        public void Shmira(List<String> toWrite)
        {
            var csv = new StringBuilder();

            foreach (String line in toWrite)
            {
                csv.AppendLine(line);
            }

            File.WriteAllText(shemKovetz, csv.ToString());
        }

        public List<String> Teina()
        { 
            List<String> all = new List<string>();
            if (File.Exists(shemKovetz))
            {
                string[] lines = File.ReadAllLines(shemKovetz);
                foreach (string line in lines)
                {
                    all.Add(line);
                }
            }
            return all;
        }
    }
}
