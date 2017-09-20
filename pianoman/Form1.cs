using EV3MessengerLib;
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

        private EV3Messenger eV3Messenger;


        public Form1()
        {
            InitializeComponent();
            eV3Messenger = new EV3Messenger();
        }
    }
}
