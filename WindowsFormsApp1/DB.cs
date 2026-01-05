using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DB
    {


        //public static SqlConnection GetConnection()
        //{
        //    return new SqlConnection(
        //        @"Data Source=.;Initial Catalog=ATM;Integrated Security=True");
        //}
        public static DataSet Ds = new DataSet();

        public static string domain = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string concton = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + domain + "ATM.mdf;" + "Integrated Security=True";
        public static SqlConnection con = new SqlConnection(concton);
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlCommandBuilder cb = new SqlCommandBuilder();
    }
}

