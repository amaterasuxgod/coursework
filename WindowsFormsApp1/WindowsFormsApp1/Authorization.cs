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
using MySql.Data.MySqlClient;
using SharpGL;



namespace WindowsFormsApp1
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
            Class1.MyConnection = new OleDbConnection(Class1.connectionString);//переменная класса myConnection становится контейнером переменной COnnectionString
            Class1.MyConnection.Open();//открытие соединения
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration ha5 = new registration();//создание экземпляра формы регистрации
            ha5.Show();//показ формы регистрации
            Hide();//убрать данную форму
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");//показ справки
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//если данные не введены в поле логина
            {
                MessageBox.Show("Заполните все поля!");//показ сообщения
            }
            if (textBox2.Text == "")//если данные не введены в поле пароля
            {
                MessageBox.Show("Заполните все поля!");//показ сообщения
            }
            Class1.loginuser = textBox1.Text;//переменная класса loginuser принимает значение текста текстбокса
            Class1.passuser = textBox2.Text;//переменная класса passuser принимает значение текста текстбокса

            DataTable table = new DataTable();//создание новой таблицы данных

            OleDbDataAdapter adapter = new OleDbDataAdapter();//создание нового адаптера

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Students` WHERE `user` = @uL AND `password` = @uP", Class1.MyConnection);//sql запрос на выгрузку данных из таблицы user

            command.Parameters.Add("@uL", OleDbType.VarChar).Value = Class1.loginuser;//создание параметра, значение которого равно значению переменной loginuser
            command.Parameters.Add("@uP", OleDbType.VarChar).Value = Class1.passuser;//создание параметра, значение которого равно значению переменной passuser
            Class1.user = Class1.loginuser;//переменная класса user равна переменной класса loginuser
            adapter.SelectCommand = command;//адаптер принимает значение sql запроса command
            adapter.Fill(table);//согласно значению адаптера происходит заполнение таблицы
            DataTable table1 = new DataTable();//создание новой таблицы
            OleDbDataAdapter adapter1 = new OleDbDataAdapter();//создание нового адаптера
            OleDbCommand command1 = new OleDbCommand("SELECT * FROM `Teachers` WHERE `user1` = @uL AND `password1` = @uP", Class1.MyConnection);//sql запрос на выгрузку данных из таблицы teacher
            command1.Parameters.Add("@uL", OleDbType.VarChar).Value = Class1.loginuser;//переменная класса loginuser принимает значение текста текстбокса
            command1.Parameters.Add("@uP", OleDbType.VarChar).Value = Class1.passuser;//переменная класса passuser принимает значение текста текстбокса
            adapter1.SelectCommand = command1;//адаптер принимает значение sql запроса command1
            adapter1.Fill(table1);//согласно значению адаптера происходит заполнение таблицы

            if (table.Rows.Count > 0)//если количество выгруженных в таблицу table полей больше нуля
            {
                Курсы hack1 = new Курсы();//создание экземпляра формы курсов
                hack1.Show();//показать форму курсов
                this.Hide();//убрать данную форму
            }
            if (table1.Rows.Count > 0)//если количество выгруженных в таблицу table1 полей больше нуля
            {
                Teacher cs = new Teacher();//создание экземпляра формы учителей
                cs.Show();//показать форму учителей
                this.Hide();//убрать данную форму
            }
            if (table.Rows.Count == 0 && table1.Rows.Count == 0)//если количество выгруженных полей таблицы table и количество выгруженных полей таблицы table1 равно нулю
            {
                MessageBox.Show("Вы ввели неправильные данные");//показ сообщения
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
