using System;
using EV3MessengerLib;
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
        private EV3Messenger mindstorm;
        public List<string> noteList = new List<string>();
        private int toChangeIndex;        
        public Form1(EV3Messenger ev3)
        {
            mindstorm = ev3;
            InitializeComponent();                              
        }
        
        private void addnoteButton_Click(object sender, EventArgs e)
        {
            if (timeNummeric.Value == 0)
            {
                MessageBox.Show("Geen noot of tijd ingevuld");
            }
            else
            {
                string noot = nootCombo.Text;
                decimal time = timeNummeric.Value;
                string note = noot + "." + time;

                noteList.Add(note);
                fillMusicList();
            }           
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
            if(deletedNote < 0)
            {

            }
            else
            {
                noteList.RemoveAt(deletedNote);
                fillMusicList();
            }
            
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
            fillNoteList();
            play.playMusic(noteList);
        }


        private void playSongRobot_Click(object sender, EventArgs e)
        {
            //play song on the robot
            playRobotSong robot = new playRobotSong();
            fillNoteList();            
            robot.playSongAsync (mindstorm, noteList);
        }
        private void fillNoteList()
        {            
            clearNotelist();
            foreach (var item in listBox1.Items)
            {
                noteList.Add(item.ToString());
            }
        }
        
              
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            replaceForm replace = new replaceForm(listBox1.SelectedItem.ToString());
            int index = listBox1.SelectedIndex;
            replace.ShowDialog();
            string note = replace.note;
            listBox1.ClearSelected();
            replaceNote(index, note);
        }

        private void clearNotelist()
        {
            noteList.Clear();
        }

        private void replaceNote(int index, string note)
        {
            listBox1.Items[index] = note;
        }
    }
}
