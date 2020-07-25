using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.study-english.info/links-06.php");//переход на веб страницу с курсами по английскому языку
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.pythonworld.ru");//переход на веб-страницу с курсами по python
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.metanit.com/cpp/tutorial/");//переход на веб страницу с курсамии по c++
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filecs fl = new Filecs();//создание экземпляра формы File
            fl.Show();//показ формы File
         
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teacher cs = new Teacher();//создание экземпляра формы Teacher
            cs.Show();//показ формы Teacher
            this.Hide();//убрать данную форму
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал Гордиенко А.П.");//показ информации о разработчике
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//закрытие приложения
        }
    }
}
