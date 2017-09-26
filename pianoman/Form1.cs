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

        private void savesongButton_Click(object sender, EventArgs e)
        {
            writeToTXT save = new writeToTXT(noteList, songNameTextbox.Text);
        }

        private void clearsongButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void removenoteButton_Click(object sender, EventArgs e)
        {
            int deletedNote = listBox1.SelectedIndex;
            noteList.RemoveAt(deletedNote);            
            fillMusicList();
        }

        private void loadsongButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            loadSong song = new loadSong();
            foreach (var item in song.loadASong())
            {                
                listBox1.Items.Add(item);
            }
        }

        private void playsongButton_Click(object sender, EventArgs e)
        {
            //play song on the computer
            playSound play = new playSound();
            foreach (var item in listBox1.Items)
            {
                string items = item.ToString();
                string[] notes = items.Split(',');
                string note = notes[0];
                string timer = notes[1];
                play.PlayNote(note, timer);
            }
        }
    }
}
