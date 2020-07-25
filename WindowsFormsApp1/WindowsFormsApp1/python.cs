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
    public partial class python : Form
    {
        public python()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Курсы ha11 = new Курсы();
            ha11.Show();
            this.Hide();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info ha10 = new Info();
            ha10.Show();
            this.Hide();
        }
    }
}
