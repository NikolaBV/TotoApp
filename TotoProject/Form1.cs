using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rb5ot35_Click(object sender, EventArgs e)
        {
            
        }
        private void buttonGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random RandomClass = new Random();
            var textBoxes = new List<TextBox>()
            {
                txtboxPurvoChislo,
                txtboxVtoroChislo,
                txtboxTretoChislo,
                txtboxChetvurtoChislo,
                txtboxPetoChislo,
                txtboxShestoChislo
            };
            if (rb6ot49.Checked)
            {
                foreach (var textbox in textBoxes)
                {
                    textbox.Text = RandomClass.Next(6, 49).ToString();
                }
            }
            if (rb6ot42.Checked)
            {
                foreach (var textbox in textBoxes)
                {
                    textbox.Text = RandomClass.Next(6, 42).ToString();
                }
            }
            if (rb5ot35.Checked)
            {
                lblShestoChislo.Hide();
                txtboxShestoChislo.Hide();
                foreach (var textbox in textBoxes)
                {
                    textbox.Text = RandomClass.Next(5, 35).ToString();
                }
            }
            else
            {
                lblShestoChislo.Show();
                txtboxShestoChislo.Show();
            }
            
        }
    }
}
