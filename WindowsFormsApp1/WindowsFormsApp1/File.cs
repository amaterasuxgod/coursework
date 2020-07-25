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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Filecs : Form
    {
        public Filecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string filename = System.IO.Path.GetRandomFileName();
            string filename = textBox1.Text+".doc";
            if (File.Exists(filename))
            {
                MessageBox.Show("Файл с таким названием существует");
            }
            else
            using (var sw = new StreamWriter(filename))
            {
                    Process.Start(filename);
                   
            }
        }
    }
}
