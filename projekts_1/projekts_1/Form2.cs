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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butNakamais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Jaut2  = new Form3();
            Jaut2.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            radio1.Checked = false;
            labCheck.Text = "";
            butNakamais.Visible = false;
            butIesniegt.Left = butNakamais.Left;
        }

        private void butIesniegt_Click(object sender, EventArgs e)
        {
            if (radio4.Checked == true)
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
            radio1.Enabled = false;
            radio2.Enabled = false; 
            radio3.Enabled = false;
            radio4.Enabled = false;
        }
    }
}
