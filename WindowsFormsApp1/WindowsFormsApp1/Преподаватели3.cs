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
    public partial class Преподаватели3 : Form
    {
        public Преподаватели3()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Курсы ha14 = new Курсы();
            ha14.Show();
            this.Hide();
        }
    }
}
