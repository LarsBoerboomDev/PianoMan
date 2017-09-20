using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pianoman
{
    public partial class ConnectionForm : Form
    {
        private EV3Messenger eV3Messenger;
        public ConnectionForm()
        {
            InitializeComponent();
            eV3Messenger = new EV3Messenger();
            FillSerialPortSelectionBoxWithAvailablePorts();
        }
        private void FillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            serialPortSelectionBox.Items.Clear();
            foreach(String port in ports)
            {
                serialPortSelectionBox.Items.Add(port);
            }
        }
    }
}
