using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekts_1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void butNakamais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 Jaut10 = new Form11();
            Jaut10.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            labCheck.Text = "";
            butNakamais.Visible = false;
            butIesniegt.Left = butNakamais.Left;
        }

        private void butIesniegt_Click(object sender, EventArgs e)
        {
            string valsts = "Polija";
            if (txtValsts.Text == valsts)
            {
                Form1.punkti++;
                labCheck.Text = "Pareizi!";
            }
            else
            {
                labCheck.Text = "X";
            }
            butIesniegt.Visible = false;
            butNakamais.Visible = true;
        }
    }
}
