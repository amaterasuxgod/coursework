using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Teacher : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Datab.mdb";//создание переменной для подключения
        private OleDbConnection MyConnection;//создание контейнера для переменной подключения
        public Teacher()
        {
            MyConnection = new OleDbConnection(connectionString);//переменная myCOnnection становится контейнером переменной connectionStrilng
            MyConnection.Open();//открыть соединение
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Method meth = new Method();//создание экземпляра формы с методическими указаниями
            meth.Show();//показ формы с методическими указаниями
            this.Hide();//убрать данную форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.databDataSet.Students);//обновить адаптер studentsTable
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int delete = dataGridView1.SelectedCells[0].RowIndex;//создаем переменную для нахождения индекса выделенной строки
            int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());//создаем переменную, которая будет содержать наш id
            dataGridView1.Rows.RemoveAt(delete);//удалить выделенные строки
            OleDbCommand command = new OleDbCommand("DELETE FROM Students WHERE id=" + id, MyConnection);//удаляем строки, в которых id в бд совпадает с нашей переменной i
            command.ExecuteNonQuery();
            if (dataGridView1.RowCount == 1)//если число оставшихся строк в дата гриде равно 1
            {
                MessageBox.Show("Удаление произведено");
                button2.Enabled = false;//деактивировать 2 кнопку
            }
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.databDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet.Students". При необходимости она может быть перемещена или удалена.
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал Гордиенко А.П.");//показ данных о разработчике
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
