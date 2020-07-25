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
    public partial class Преподаватели2 : Form
    {
        public Преподаватели2()
        {
            InitializeComponent();
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Преподаватели3 ha = new Преподаватели3();
            ha.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Курсы ha13 = new Курсы();
            ha13.Show();
            this.Hide();
        }
    }
}
