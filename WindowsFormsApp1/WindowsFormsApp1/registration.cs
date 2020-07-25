using MySql.Data.MySqlClient;
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
    public partial class registration : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Datab.mdb";//создание переменной для подключения
        private OleDbConnection MyConnection;//создание переменной-контейнера 
        public registration()
        {
            InitializeComponent();
            MyConnection = new OleDbConnection(connectionString);//переменная-контейнер принимает значение переменной connectionString
            MyConnection.Open();//открытие соединения
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"Справка.chm");//показ справки
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")//если не заполнен какой-либо из текстбоксов
            {
                MessageBox.Show("Заполните все поля!");//показ сообщения
            }
            if (textBox2.Text != textBox3.Text)
            {
                errorProvider1.SetError(textBox3,"Пароли не совпадают");
            }
            else
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO `Students` (`user`, `password`) VALUES(@login, @password)", MyConnection);//внести в поля user и password данные параметров               command.Parameters.Add("@login", OleDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@password", OleDbType.VarChar).Value = textBox3.Text;//создание параметра "пароль", который равен тексту из текстбокса
                command.Parameters.Add("@login", OleDbType.VarChar).Value = textBox1.Text;//создание параметра "пароль", который равен тексту из текстбокса
                if (command.ExecuteNonQuery() == 1)//если запрос был выполнен
                {
                    MessageBox.Show("Аккаунт был создан");//показ сообщения
                }
                else//если запрос не был выполнен
                    MessageBox.Show("Аккаунт не был создан");//показ сообщения
                authorization bb = new authorization();//создание экземпляра формы авторизации
                bb.Show();//показ формы авторизации
                this.Hide();//закрытие данной формы
            }
        }
        public Boolean checkUser()
        {

            DataTable table = new DataTable();//создание новой таблицы данных

            OleDbDataAdapter adapter = new OleDbDataAdapter();//создание нового адаптера

            OleDbCommand command = new OleDbCommand("SELECT * FROM `Students` WHERE `user` = @uL", MyConnection);//выгрузить данные из таблицы, где поле user совпадает с параметром @uL

            command.Parameters.Add("@uL", OleDbType.VarChar).Value = textBox1.Text;//Создание параметра @uL, значение которого равно тексту из текстбокса

            adapter.SelectCommand = command;//адаптер принимает значение запроса command
            adapter.Fill(table);//таблица table заполняется с использованием запроса

            if (table.Rows.Count > 0)//если в таблице table больше 0 записей
            {
                MessageBox.Show("Данный пользователь уже существует");//показ сообщения
                return true;
            }
            else//в ином случае не выполнять функцию
                return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            authorization hack = new authorization();//создание экземпляра формы авторизации
            hack.Show();//показать форму авторизации
            this.Hide();//убрать данную форму
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
