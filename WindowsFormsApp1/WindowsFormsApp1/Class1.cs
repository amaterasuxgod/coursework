using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Class1
    {
        public static string user;
        public static string loginuser;
        public static string passuser;
        public static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Datab.mdb";
        public static OleDbConnection MyConnection;
    }
}
