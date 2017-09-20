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
            Form1 form = new Form1();
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
        }
    }
}
