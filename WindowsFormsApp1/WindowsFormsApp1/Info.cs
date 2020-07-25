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
    public partial class Info : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Datab.mdb";//создание переменной подключения
        private OleDbConnection MyConnection;//создание контейнера для переменной подключения
        public Info()
        {
            InitializeComponent();
            MyConnection = new OleDbConnection(connectionString);//контейнер принимает значение переменной подключения
            MyConnection.Open();//открыть подключение
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Справка.chm");//показ справки
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")//если какой-либо из текстбоксов не заполнен, выдать сообщение
            {
                MessageBox.Show("Заполните все поля!");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            if (textBox4.Text == "")
            { 
                MessageBox.Show("Заполните все поля!");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
            }
            OleDbCommand command = new OleDbCommand("UPDATE `Students` SET `ФИО` = @FIO, `Телефон` = @Telephone,`Электронная почта` = @email,`Номер карты` = @card,`КУРС` = @course WHERE `user`= @login",MyConnection);//sql запрос на обновление данных в таблице
            command.Parameters.Add("@FIO", OleDbType.VarChar).Value = textBox1.Text;//добавление параметра, значение которого равно тексту текстбокса
            command.Parameters.Add("@Telephone", OleDbType.VarChar).Value = textBox3.Text;//добавление параметра, значение которого равно тексту текстбокса
            command.Parameters.Add("@email", OleDbType.VarChar).Value = textBox2.Text;//добавление параметра, значение которого равно тексту текстбокса
            command.Parameters.Add("@card", OleDbType.BigInt).Value = textBox4.Text;//добавление параметра, значение которого равно тексту текстбокса
            command.Parameters.Add("@course", OleDbType.VarChar).Value = textBox5.Text;//добавление параметра, значение которого равно тексту текстбокса
            command.Parameters.Add("@login", OleDbType.VarChar).Value = label4.Text;//добавление параметра, значение которого равно тексту текстбокса
            int number = command.ExecuteNonQuery();
            MessageBox.Show("Заказ оформлен успешно");//показ сообщение
            Курсы ff = new Курсы();//создание экземпляра формы курсов
            ff.Show();//показ формы курсов
            this.Hide();//убрать данную форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Курсы ff = new Курсы();//создание экземпляра формы курсов
            ff.Show();//показ формы курсов
            this.Hide();//убрать данную форму
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {
            label4.Text = Class1.user;//текст лейбла принимает значение логина текущего пользователя
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
