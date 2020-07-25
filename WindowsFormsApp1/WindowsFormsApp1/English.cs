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
    public partial class English : Form
    {
        public Курсы form;
        public English()
        {
            InitializeComponent();
        }
        public English(Курсы form)
        {
            InitializeComponent();
            this.form = form;
        }
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");//показ справки
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Info ha8 = new Info();//создание экземпляра формы заказа
            ha8.Show();//показать форму заказа
            this.Hide();//убрать данную форму1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Курсы ha9 = new Курсы();//создание экземпляра формы курсов
            ha9.Show();//показать форму курсов
            this.Hide();//убрать данную форму
        }

        private void English_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();//закрыть форму
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
