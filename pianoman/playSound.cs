using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace pianoman
{
    class playSound
    {
        string notes;


        public async void playMusic(List<string> noteList)
        {
            Timer noteTimer = new Timer();
            
            for (int i = 0; i < noteList.Count; i++)
            {
                string item = noteList[i];
                string[] notes = item.Split(',');
                int time = Convert.ToInt32(notes[1]) * 1000;
                await Task.Delay(time);
                playANote(notes[0]);
            }

        }      

        private void playANote(string noteType)
        {
            string soundFile = "";
            switch (noteType)
            {
                case "G":
                    soundFile = "highestG.wav";
                    break;
                case "A":
                    soundFile = "higherA.wav";
                    break;
                case "B":
                    soundFile = "higherB.wav";
                    break;
                case "C":
                    soundFile = "higherC.wav";
                    break;
                case "D":
                    soundFile = "higherD.wav";
                    break;
                case "E":
                    soundFile = "higherE.wav";
                    break;
                case "F":
                    soundFile = "higherF.wav";
                    break;
                case "G#":
                    soundFile = "higherG.wav";
                    break;
                default:
                    break;
            }
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path2 = Path.Combine(projectFolder, @"notes\" + soundFile);

            SoundPlayer player = new SoundPlayer(path2);
            player.Play();
        }
             
    }
}
