using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoman
{
    class loadSong
    {                
        public List<string> loadASong()
        {
            List<string> notes = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            string line = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {                
                StreamReader sr = new StreamReader(dialog.FileName);
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        notes.Add(line);
                    }
                }
            }
            return notes;
        }

        public List<string> readSong(string fileName)
        {
            List<string> notes = new List<string>();
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while(line != null)
            {
                line = sr.ReadLine();
                if(line != null)
                {
                    notes.Add(line);
                }
            }
            return notes;
        }
    }
}
