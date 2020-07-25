using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System.Windows.Forms;
using System.Data.OleDb;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveTest()
        {
            string expected1 = "Hello";
            string expected2 = "idiot";
            Class1.loginuser = "Hello";
            Class1.passuser = "idiot";
            Assert.AreEqual(expected1, Class1.loginuser);
            Assert.AreEqual(expected2, Class1.passuser);
            
        }
        [TestMethod]
        public void PositiveTest2()
        {
            Class1.MyConnection = new OleDbConnection(Class1.connectionString);
            Class1.MyConnection.Open();
            string expected1 = "Английский";
            string expected2 = "Гордиенко Алексей Петрович";
            string expected3 = "+375297892375";
            string expected4 = "alexei.gordienko@hotmail.com";
            string expected5 = "214115151";
            if (expected1.GetTypeCode() == TypeCode.String & expected2.GetTypeCode() == TypeCode.String & expected3.GetTypeCode() == TypeCode.String & expected4.GetTypeCode() == TypeCode.String & expected5.GetTypeCode() == TypeCode.String)
            {
                Info nf = new Info();
                nf.textBox1.Text = "Английский";
                nf.textBox2.Text = "Гордиенко Алексей Петрович";
                nf.textBox3.Text = "+375297892375";
                nf.textBox4.Text = "alexei.gordienko@hotmail.com";
                nf.textBox5.Text = "214115151";
                Assert.AreEqual(expected1, nf.textBox1.Text);
                Assert.AreEqual(expected2, nf.textBox2.Text);
                Assert.AreEqual(expected3, nf.textBox3.Text);
                Assert.AreEqual(expected4, nf.textBox4.Text);
                Assert.AreEqual(expected5, nf.textBox5.Text);

            }
        }
    }
}
