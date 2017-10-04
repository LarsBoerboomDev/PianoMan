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
    public partial class replaceForm : Form
    {

        public string note;

        public replaceForm(string v)
        {
            InitializeComponent();
            string[] notes = v.Split('.');
            timeNummeric.Value = Convert.ToDecimal(notes[1]);
            nootCombo.Text = notes[0];

        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            note = nootCombo.Text + "." + timeNummeric.Value.ToString();
            Close();
        }
    }
}
