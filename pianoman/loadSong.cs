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

        public loadSong()
        {
            /*
           List<string> notes = new List<string>();
           OpenFileDialog dialog = new OpenFileDialog();
           string line = "";
           if(dialog.ShowDialog() == DialogResult.OK)
           {
               StreamReader sr = new StreamReader(dialog.FileName);
               while(line != null)
               {
                   line = sr.ReadLine();
                   if( line != null)
                   {
                       notes.Add(line);
                   }
               }
           }


           Stream myStream = null;
           OpenFileDialog openFile = new OpenFileDialog();
           openFile.InitialDirectory = "c:\\";
           openFile.Title = "Selecteer je liedje";
           openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
           if(openFile.ShowDialog() == DialogResult.OK)
           {
               try
               {
                   if ((myStream = openFile.OpenFile()) != null)
                   {
                       using (myStream = openFile.OpenFile())
                       {
                           var reader = new StreamReader(myStream);
                       }
                   }
               }
               catch(Exception ex)
               {
                   MessageBox.Show("Wrong file" + ex.Message);
               }
           }
           */

        }
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
    }
}
