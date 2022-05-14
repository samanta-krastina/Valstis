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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void butNakamais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 Rezultats = new Form12();
            Rezultats.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            labCheck.Text = "";
            butNakamais.Visible = false;
            butIesniegt.Left = butNakamais.Left;
        }

        private void butIesniegt_Click(object sender, EventArgs e)
        {
            string valsts = txtValsts.Text;
            string parbaude = valsts.ToLower();
            if (parbaude == "čīle")
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
