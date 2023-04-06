using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lottery
{
    internal static class DB
    {
        static SqlConnection conn = new SqlConnection("Data Source=103S-12\\MSSQLSERVER01;Initial Catalog=Lottery;Integrated Security=True");

        static SqlDataAdapter da;
        static DataTable dt;
        static DataSet ds;
        static SqlCommand cmd;
        static SqlDataReader dr;

        static string cmdText;

        public static void AddLottery(string name, string surname, int ticketnumber)
        {
            conn.Open();
            cmdText = "insert Loto(Name,Surname,TicketNumber)\r\nvalues(@name,@surname,@ticketnumber)";

            //cmdText = $"insert Employees(FirstName,LastName,City,Country)\r\nvalues('{name}','{surname}','{city}','{country}')";

            cmd = new SqlCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@ticketnumber", ticketnumber);


            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public static Dictionary<string, string> GetLotosByNumber(int number)
        {
            conn.Open();
            cmdText = "select Name,Surname from dbo.Loto where TicketNumber =@number ";

            cmd = new SqlCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("@number", number);

            Dictionary<string,string> keyValues = new Dictionary<string,string>();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                keyValues.Add("Name", dr[0].ToString());
                keyValues.Add("Surname", dr[1].ToString());
            }

            conn.Close();
            return keyValues;

        }
    }
}
