using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoman
{
    public partial class Form1 : Form
    {

        public List<string> noteList = new List<string>();
        //private Dictionary<string, decimal> noteList = new Dictionary<string, decimal>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void addnoteButton_Click(object sender, EventArgs e)
        {
           string noot = nootCombo.Text;
           decimal time = timeNummeric.Value;
           string note = noot + "," + time;

           noteList.Add(note);
           fillMusicList();                            
        }

        private void fillMusicList()
        {
            listBox1.Items.Clear();
           foreach(string notes in noteList)
            {
                listBox1.Items.Add(notes);
            }
        }

    }
}
