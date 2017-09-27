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
        public EV3Messenger eV3Messenger;

        private Timer messageReceiverTimer;
        public ConnectionForm()
        {
            InitializeComponent();                        
                
            eV3Messenger = new EV3Messenger();

            //Starts timer 
            messageReceiverTimer = new Timer();
            messageReceiverTimer.Interval = 10;
            messageReceiverTimer.Tick += new System.EventHandler(messageReadTimer_Tick);

            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        //fill a selectionbox with available ports
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



        //just a test button to open form1 to be changed
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(eV3Messenger);
            form.Show();
        }

        //rescans the ports
        private void rescanPortsButton_Click(object sender, EventArgs e)
        {
            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectPortButton_Click(object sender, EventArgs e)
        {
            String port = serialPortSelectionBox.Text;
            if (eV3Messenger.Connect(port))
            {
                messageReceiverTimer.Start();
                UpdateButtonsAndConnectionInfo();
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Failed to connect to port");
            }
        }
        private void messageReadTimer_Tick(object sender, EventArgs e)
        {
           
        }
        private void UpdateButtonsAndConnectionInfo()
        {
            bool isConnected = eV3Messenger.IsConnected;
            connectPortButton.Enabled = !isConnected;

            if (isConnected)
            {
                connectedDeviceLabel.Text = "Connected to: " + eV3Messenger.Port;
                connectedDeviceLabel.BackColor = Color.LightGreen;
            }
            else
            {
                connectedDeviceLabel.Text = "No connection";
                connectedDeviceLabel.BackColor = Color.Red;
            }
        }

        private void disconnectPortButton_Click(object sender, EventArgs e)
        {
            eV3Messenger.Disconnect();
            UpdateButtonsAndConnectionInfo();
            messageReceiverTimer.Stop();
        }

        private void sendArm1Button_Click(object sender, EventArgs e)
        {
            if (eV3Messenger.IsConnected)
            {
                eV3Messenger.SendMessage("Music", "g");
            }
        }

        private void sendArm2Button_Click(object sender, EventArgs e)
        {
            if (eV3Messenger.IsConnected)
            {
                eV3Messenger.SendMessage("Music", "a");
            }
        }

        private void sendArm3Button_Click(object sender, EventArgs e)
        {
            if (eV3Messenger.IsConnected)
            {
                eV3Messenger.SendMessage("Music", "b");
            }
        }

        private void sendArm4Button_Click(object sender, EventArgs e)
        {
            if (eV3Messenger.IsConnected)
            {
                eV3Messenger.SendMessage("Music", "c");                
            }
        }
    }
}
