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
    public partial class Курсы : Form
    {
        public Курсы()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            python ha1 = new python();//создание экземпляра формы python
            ha1.Show();//открыть форму python
            this.Hide();//закрыть данную форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ha2 = new Form3();
            ha2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            English ha3 = new English(this);
            ha3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Преподаватели ha4 = new Преподаватели();
            ha4.Show();
            this.Hide();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"Справка.chm");
        }

        private void Курсы_Load(object sender, EventArgs e)
        {
            label1.Text = Class1.user;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал Гордиенко А.П.");
        }
    }
}
