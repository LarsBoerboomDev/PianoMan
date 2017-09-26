using System;
using System.Collections.Generic;
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

        public void PlayNote(string note, string interval)
        {
            notes = note;
            Timer time = new Timer();
            time.Interval = Convert.ToInt32(interval);
            time.Elapsed += new ElapsedEventHandler(timer_elapsed);
            time.Enabled = true;
        }
        public void timer_elapsed(object sender , ElapsedEventArgs e)
        {
            string soundFile = "";
            switch (notes)
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
            SoundPlayer player = new SoundPlayer(@"\notes\" + soundFile);
            player.Play();
        }
    }
}
