using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoman
{
    class writeToTXT
    {
        public writeToTXT(List<string> noteList, string songName)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = songName + ".txt";            
            if(save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());
                for(int i = 0; i < noteList.Count; i++)
                {
                    writer.WriteLine(noteList[i]);
                }
                writer.Dispose();
                writer.Close();
            }            
        }
    }
}
