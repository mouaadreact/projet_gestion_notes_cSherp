using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
namespace Model_DLL
{
    class Connexion
    {
        static IDbConnection con = null;
        static IDbCommand cmd = null;
        public static IDbConnection connect(string dbname, string dataSource = "", DatabaseType dbms = DatabaseType.MySql,
            string user = "root", string password = "1453", string server = "localhost", string port = "3306")
        {
            if (dbms == DatabaseType.MySql)
            {
                if (con == null)
                {
                    con = new MySqlConnection("server=" + server + ";user id=" + user + ";port = " + port + ";password=" + password +
                   ";persistsecurityinfo=True;database=" + dbname);
                    cmd = new MySqlCommand();
                }
                if (con.State.ToString() == "Closed")
                {
                    con.Open();
                    cmd.Connection = (MySqlConnection)con;
                }
                return con;
            }
            else if (dbms == DatabaseType.SqlServer)
            {
                if (con == null)
                {
                    con = new SqlConnection("Data Source= " + dataSource + ";Initial Catalog=" + dbname + ";User id=" + user
                            + ";Password=" + password);
                    cmd = new SqlCommand();
                }
                if (con.State.ToString() == "Closed")
                {
                    con.Open();
                    cmd.Connection = (SqlConnection)con;
                }
                return con;
            }
            return con;
        }



        public static int IUD(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteNonQuery();
        }

        public static IDataReader select(string req)
        {
            cmd.CommandText = req;
            return cmd.ExecuteReader();
        }
        public static Dictionary<string, string> getChamps_table(string table)
        {
            Dictionary<string, string> champs = new Dictionary<string, string>();
            string sql = "desc " + table;
            cmd.CommandText = sql;
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                switch (dr.GetString(1))
                {
                    case "varchar(255)":
                        champs.Add(dr.GetString(0), "string");
                        break;

                    default:
                        champs.Add(dr.GetString(0), dr.GetString(1));
                        break;
                }

            }
            return champs;
        }
    }
}
