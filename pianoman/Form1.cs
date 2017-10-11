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
using System.IO;

namespace pianoman
{
    public partial class Form1 : Form
    {    
        private EV3Messenger mindstorm;
        public List<string> noteList = new List<string>();
        private int toChangeIndex;
        private Timer timer;     
        public Form1(EV3Messenger ev3)
        {
            mindstorm = ev3;
            timer = new Timer();
            timer.Interval = 10;
            timer.Tick += new System.EventHandler(timer_Tick);
            timer.Enabled = true;
            InitializeComponent();                              
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (mindstorm.IsConnected)
            {
                EV3Message message = mindstorm.ReadMessage();
                if(message.MailboxTitle == "Demo")
                {
                    loadSong load = new loadSong();
                    //string path2 = Path.Combine(projectFolder, @"notes\" + soundFile);
                    var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                    string path = Path.Combine(projectFolder, @"demoSongs");
                    DirectoryInfo d = new DirectoryInfo(path);
                    noteList.Clear();
                    foreach (var file in d.GetFiles("*.txt"))
                    {
                         load.readSong(file.DirectoryName);
                        foreach (var item in load.readSong(file.DirectoryName))
                        {
                            noteList.Add(item);
                        }
                    }
                    playSound play = new playSound();
                    play.playMusic(noteList);
                }
            }
        }
        private void addnoteButton_Click(object sender, EventArgs e)
        {
            if (timeNummeric.Value == 0)
            {
                MessageBox.Show("Geen noot of tijd ingevuld");
            }
            else
            {
                /*
                string noot = nootCombo.Text;
                //decimal time = timeNummeric.Value;
                string note = noot;
                */
                noteList.Add(nootCombo.Text);
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
            noteList.Clear();
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

        private void intervalButton_Click(object sender, EventArgs e)
        {
            if(timeNummeric.Value == 0)
            {
                MessageBox.Show("Geen tijd ingevuld");
            }
            else
            {
                string note = "RUST." + timeNummeric.Value.ToString();
                noteList.Add(note);
                fillMusicList();
            }
        }
    }
}
