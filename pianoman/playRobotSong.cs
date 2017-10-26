using System;
using System.Collections.Generic;
using EV3MessengerLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace pianoman
{
    class playRobotSong
    {
        EV3Messenger mindstorm;

        public void playSongAsync(EV3Messenger messenger, List<string> noteList)
        {
            messenger.SendMessage("Music", "Start");
            mindstorm = messenger;
            for (int i = 0; i < noteList.Count; i++)
            {                
                string item = noteList[i];
                string[] notes = item.Split('.');
                if (notes[0] == "RUST")
                {
                    
                }
                else
                {
                    item = item + ".0,5";
                }
                string[] notes2 = item.Split('.');
                
                if(notes2.Length == 1)
                {

                }
                else
                {
                    decimal time = Convert.ToDecimal(notes2[1]) * 1000;
                    Thread.Sleep(Convert.ToInt32(time));
                    sendNoteRobot(notes[0]);
                }                
            }
            Thread.Sleep(1000);
            messenger.SendMessage("Music", "Finished");
        }


        private void sendNoteRobot(string noteType)
        {
            switch (noteType)
            {
                case "C":
                    mindstorm.SendMessage("Music", "c");
                    break;
                case "D":
                    mindstorm.SendMessage("Music", "d");
                    break;
                case "E":
                    mindstorm.SendMessage("Music", "e");
                    break;
                case "F":
                    mindstorm.SendMessage("Music", "f");
                    break;
                case "G":
                    mindstorm.SendMessage("Music", "g");
                    break;
                case "A":
                    mindstorm.SendMessage("Music", "a");
                    break;
                case "B":
                    mindstorm.SendMessage("Music", "b");
                    break;
                case "C2":
                    mindstorm.SendMessage("Music", "c2");
                    break;
                case "RUST":
                    break;
                default:
                    break;
            }
        }

        internal void playSongAsync(List<string> noteList)
        {
            throw new NotImplementedException();
        }
    }
}
