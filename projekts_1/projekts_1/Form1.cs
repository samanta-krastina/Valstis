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
    public partial class Form1 : Form
    {
        public static int punkti=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void butSakt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Jaut1 = new Form2();
            Jaut1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atmini visas valstis pēc to formām!" + Environment.NewLine + Environment.NewLine+  
                "1., 2., jautājums: viegli" + Environment.NewLine+ Environment.NewLine +
                "3., 4., 5., 6. jautājums: vidēji grūti" + Environment.NewLine+ Environment.NewLine+
                "7., 8. jautājums: grūti" + Environment.NewLine+ Environment.NewLine+
                "9., 10. jautājums: ļoti grūti" + Environment.NewLine + Environment.NewLine + Environment.NewLine
                + "Izveidoja:" + Environment.NewLine + "Samanta Krastiņa 11.PROG  05.2022",

                "Tests", MessageBoxButtons.OK, MessageBoxIcon.Question);


        }
    }
}
