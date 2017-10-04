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
            for (int i = 0; i < noteList.Count; i++)
            {
                string item = noteList[i];
                string[] notes = item.Split('.');
                Decimal time = Convert.ToDecimal(notes[1]) * 1000;
                await Task.Delay(Convert.ToInt32(time));
                playANote(notes[0]);
            }
        }      

        private void playANote(string noteType)
        {
            string soundFile = "";
            switch (noteType)
            {
                case "C":
                    soundFile = "C.wav";
                    break;
                case "D":
                    soundFile = "D.wav";
                    break;
                case "E":
                    soundFile = "E.wav";
                    break;
                case "F":
                    soundFile = "F.wav";
                    break;
                case "G":
                    soundFile = "G.wav";
                    break;
                case "A":
                    soundFile = "A.wav";
                    break;
                case "B":
                    soundFile = "B.wav";
                    break;
                case "C#":
                    soundFile = "C#.wav";
                    break;
                case "RUST":
                    break;
                default:
                    break;
            }
            
            if(noteType == "RUST")
            {

            }
            else
            {
                var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string path2 = Path.Combine(projectFolder, @"notes\" + soundFile);
                SoundPlayer player = new SoundPlayer(path2);
                player.Play();
            }
            
        }
             
    }
}
