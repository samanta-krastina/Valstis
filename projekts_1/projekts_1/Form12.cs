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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            labPunkti.Text = Form1.punkti.ToString();
        }

        private void butSakums_Click(object sender, EventArgs e)
        {
            Form1.punkti = 0;
            this.Hide();
            Form1 Sakums = new Form1();
            Sakums.Show();
        }
    }
}
