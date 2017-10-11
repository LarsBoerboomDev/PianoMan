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
            if(!(notes[0] == "RUST"))
            {
                timeNummeric.Enabled = false;
                
            }
            else
            {
                timeNummeric.Value = Convert.ToDecimal(notes[1]);
            }
            
            nootCombo.Text = notes[0];

        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            if(nootCombo.Text == "RUST")
            {
                note = nootCombo.Text + "." + timeNummeric.Value.ToString();
            }
            else
            {
                note = nootCombo.Text;
            }
            
            Close();
        }

        private void nootCombo_TextChanged(object sender, EventArgs e)
        {
            if(nootCombo.Text == "RUST")
            {
                timeNummeric.Enabled = true;
            }
            else
            {
                timeNummeric.Enabled = false;
            }
        }
    }
}
