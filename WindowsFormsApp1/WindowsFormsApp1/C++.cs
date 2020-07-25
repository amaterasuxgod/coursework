using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Курсы ha8 = new Курсы();
            ha8.Show();
            this.Hide();
        }


        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info ha7 = new Info();
            ha7.Show();
            this.Hide();
        }

    }
}
