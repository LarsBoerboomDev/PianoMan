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
            mindstorm = messenger;
            for (int i = 0; i < noteList.Count; i++)
            {
                string item = noteList[i];
                string[] notes = item.Split(',');
                int time = Convert.ToInt32(notes[1]) * 1000;
                //await Task.Delay(time);
                Thread.Sleep(time);
                sendNoteRobot(notes[0]);
            }
        }


        private void sendNoteRobot(string noteType)
        {
            switch (noteType)
            {
                case "G":
                    mindstorm.SendMessage("Music", "A");
                    break;
                case "A":
                    mindstorm.SendMessage("Music", "b");
                    break;
                case "B":
                    mindstorm.SendMessage("Music", "c");
                    break;
                case "C":
                    mindstorm.SendMessage("Music", "d");
                    break;
                case "D":
                    mindstorm.SendMessage("Music", "e");
                    break;
                case "E":
                    mindstorm.SendMessage("Music", "f");
                    break;
                case "F":
                    mindstorm.SendMessage("Music", "g");
                    break;
                case "G#":
                    mindstorm.SendMessage("Music", "c#");
                    break;
                default:
                    break;
            }
        }
    }
}
