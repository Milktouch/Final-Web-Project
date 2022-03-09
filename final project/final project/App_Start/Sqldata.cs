
using System;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
//mysql connectionstring = server=localhost;database=testDB;uid=root;pwd=abc123;

namespace Workingwithsql
{

    public class MySqldata
    {
        static string[] connstrs ={"",
        ""};
        //gets the connection string if its saved here ^
        //get use a connection string from here by typing local-x as the connection string
        //x being the connection string number
        public static string getconnstr(string connstr)
        {
            try
            {
                string[] arr = connstr.Split('-');

                return connstrs[int.Parse(arr[1])];

            }
            catch
            {
                return connstr;
            }
        }
        //other queuries exe
        public static void Queryexe(string connstr, string query)
        {

            MySqlConnection conn = new MySqlConnection(getconnstr(connstr));
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //update queries exe
        public static void Update(string connstr, string tablename, string where, string whatdata)
        {
            MySqlConnection conn = new MySqlConnection(getconnstr(connstr));
            string query = "UPDATE " + tablename + " set " + whatdata + "+where " + where;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        //insert queries exe
        public static void Insert(string connstr, string tablename, string whatdata, string towhere)
        {
            MySqlConnection conn = new MySqlConnection(getconnstr(connstr));
            string[] arr = whatdata.Split(',');
            string query = "INSERT into " + tablename + " (" + towhere + ") values ('";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    query += arr[i].ToString();
                    query += "')";
                }
                else
                {
                    query += arr[i].ToString();
                    query += "','";
                }
            }
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        //select queries only or else it will crash
        public static string[,] Getdata(string connstr, string tablename, string whatdata, string condition)
        {

            DataTable table = new DataTable();
            if (whatdata == "all")
            {
                whatdata = "*";
            }
            string query = "SELECT " + whatdata + " from " + tablename + " where " + condition;
            MySqlConnection conn = new MySqlConnection(getconnstr(connstr));
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            adapter.Fill(table);
            int rows = 1;
            foreach (DataRow row in table.Rows)
            {
                rows++;
            }
            int cols = 1;
            foreach (DataColumn column in table.Columns)
            {
                cols++;
            }
            string[,] Dataarr = new string[rows, cols];
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                int j = 0;
                foreach (DataColumn column in table.Columns)
                {
                    Dataarr[i, j] = row.Field<string>(column);
                    j++;
                }

                i++;
            }

            conn.Close();
            return Dataarr;

        }
    }
    public class MicrosoftSqldata
    {
        static string[] connstrs ={"",
        ""};
        //gets the connection string if its saved here ^
        //get use a connection string from here by typing local-x as the connection string
        //x being the connection string number
        public static string getconnstr(string connstr)
        {
            try
            {
                string[] arr = connstr.Split('-');

                return connstrs[int.Parse(arr[1])];

            }
            catch
            {
                return connstr;
            }
        }
        public static void Queryexe(string connstr, string query)
        {
            SqlConnection conn = new SqlConnection(getconnstr(connstr));
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void Update(string connstr, string tablename, string where, string whatdata)
        {
            SqlConnection conn = new SqlConnection(getconnstr(connstr));
            string query = "UPDATE " + tablename + " set " + whatdata + " where " + where;
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public static void Insert(string connstr, string tablename, string whatdata, string towhere)
        {
            SqlConnection conn = new SqlConnection(getconnstr(connstr));
            string[] arr = whatdata.Split(',');
            string query = "INSERT into " + tablename + " (" + towhere + ") values ('";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    query += arr[i].ToString();
                    query += "')";
                }
                else
                {
                    query += arr[i].ToString();
                    query += "','";
                }
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static dynamic[,] Getdata(string connstr, string tablename, string whatdata, string condition)
        {

            DataTable table = new DataTable();
            if (whatdata == "all")
            {
                whatdata = "*";
            }
            string query = "SELECT " + whatdata + " from " + tablename + " where " + condition;
            SqlConnection conn = new SqlConnection(getconnstr(connstr));
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(table);
            int rows = 1;
            foreach (DataRow row in table.Rows)
            {
                rows++;
            }
            int cols = 1;
            foreach (DataColumn column in table.Columns)
            {
                cols++;
            }
            dynamic[,] Dataarr = new dynamic[rows, cols];
            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                int j = 0;
                foreach (DataColumn column in table.Columns)
                {
                    Dataarr[i, j] = row.Field<dynamic>(column);
                    j++;
                }

                i++;
            }

            conn.Close();
            return Dataarr;

        }
    }
}
