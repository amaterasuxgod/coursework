using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Teacher : Form
    {
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb";
        public static OleDbConnection MyConnection;
        public IPStatus status;
        public Teacher()
        {
            InitializeComponent();
            MyConnection = new OleDbConnection(connectionString);
            MyConnection.Open();
            Ping p = new Ping();
            PingReply pr = p.Send(@"server.ru");
            status = pr.Status;
            if (status == IPStatus.Success)
            {
                BackgroundImage = Image.FromStream(new WebClient().OpenRead("https://media.giphy.com/media/j1tK8Puk8RspqBP2cs/giphy.gif"));
                ImageAnimator.Animate(BackgroundImage, OnFrameChanged);
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                BackColor = Color.LightCyan;
            }
        }
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => OnFrameChanged(sender, e)));
                return;
            }
            ImageAnimator.UpdateFrames();
            Invalidate(false);
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Method meth = new Method();
            meth.Show();
            this.Hide();
        }


        public void Teacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.dataDataSet1.Students);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Update(this.dataDataSet1.Students);
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


        private void button4_Click(object sender, EventArgs e)
        {


           
        }
    }
}
