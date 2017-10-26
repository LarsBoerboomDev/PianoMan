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
using MetroFramework.Forms;

namespace pianoman
{
    public partial class Form1 : MetroForm
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
            //the timer tick method keeps checking of the demo button is pushed 
            //if button is pushed it puts all the songs from the demoSongs folder in a list and sends it to the robot
            if (mindstorm.IsConnected)
            {
                EV3Message message = mindstorm.ReadMessage();
                if (message != null)
                {
                    if (message.MailboxTitle == "Demo")
                    {
                        loadSong load = new loadSong();                        
                        var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                        string path = Path.Combine(projectFolder, @"demoSongs\");
                        DirectoryInfo d = new DirectoryInfo(path);
                        noteList.Clear();
                        foreach (var file in d.GetFiles("*.txt"))
                        {
                            Console.WriteLine(file.FullName);
                            load.readSong(file.FullName);
                            foreach (var item in load.readSong(file.FullName))
                            {
                                noteList.Add(item);
                            }
                            noteList.Add("RUST.1,0");
                        }

                        for (int i = 0; i <= 5; i++)
                        {
                            mindstorm.SendMessage("Test", "Test");
                        }
                        playRobotSong play = new playRobotSong();
                        play.playSongAsync(mindstorm , noteList);                        
                        
                    }
                }
            }
        }
        private void addnoteButton_Click(object sender, EventArgs e)
        {
            if(nootCombo.Text == "C" || nootCombo.Text == "D" || nootCombo.Text == "E" ||
                nootCombo.Text == "F" || nootCombo.Text == "G" || nootCombo.Text == "A" ||
                nootCombo.Text == "B" || nootCombo.Text == "C2" )
            {
                noteList.Add(nootCombo.Text);
                fillMusicList();
            }
            else
            {                
                
                nootCombo.Text = "C";
                MessageBox.Show("Geen valide noot");
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
            fillNoteList();
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
            for (int i = 0; i <= 5; i++)
            {
                mindstorm.SendMessage("Test", "Test");
            }
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
            //when a note is dubble clicked open the replaceForm
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
            noteList[index] = note;
            fillMusicList();
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
