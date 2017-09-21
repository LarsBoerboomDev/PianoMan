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
        public Form1()
        {
            InitializeComponent();
        }

        string noot;
        decimal time;

        private void addnoteButton_Click(object sender, EventArgs e)
        {
            noot = nootCombo.Text;
            time = timeNummeric.Value;

            List<string>[] list = new List<String>[];
            list[0] = new List<string>();
            list[1] = new List<string>();

            list[0].add("hello");
            list[1].add("world");
        }
    }
}
