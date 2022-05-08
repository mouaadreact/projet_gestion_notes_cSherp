using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Newtonsoft.Json;
using System.Reflection;
using System.Data.SqlClient;
using System.Data.Common;


namespace Model_DLL
{
    public abstract partial class Model
    {
        private long id = 0;
        private string sql = "";
        private IDbConnection con;

        public long Id { get => id; set => id = value; }

        public Model()
        {
            this.con = Connexion.connect("gestion_etudiant");
        }


        public Dictionary<string, T> ToDictionary<T>(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var dico = JsonConvert.DeserializeObject<Dictionary<string, T>>(json);
            foreach (var entry in dico)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            return dico;
        }

        public dynamic DictionaryToObject(Dictionary<string, object> dico)
        {
            var model = Activator.CreateInstance((this).GetType());
            PropertyInfo[] properties = (this).GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.PropertyType.Name == "long")
                {
                    property.SetValue(model, (int)dico[property.Name]);
                }
                else
                    property.SetValue(model, dico[property.Name]);

            }
            return model;
        }
        // =====================================================================================


        public int delete(string procedure = null)
        {
            if (procedure == null)
            {
                Type type = this.GetType();
                string sql = "delete from " + type.Name + " where id = " + Id;
                return Connexion.IUD(sql);
            }
            return this.deleteProcedure(procedure);
        }

        public int save(string procedure = null)
        {
            if (procedure == null)
            {
                if (this.Id == 0)
                {
                    Dictionary<string, object> dico = new Dictionary<string, object>();
                    dico = ToDictionary<object>(this);
                    sql = "insert into " + this.GetType().Name + "(";
                    foreach (var entry in dico)
                    {
                        if (!entry.Key.Equals("Id"))
                            sql += entry.Key + ",";
                    }
                    sql = sql.Remove(sql.Length - 1, 1);
                    sql += ") values(";
                    foreach (var entry in dico)
                    {
                        if (!entry.Key.Equals("Id"))
                        {
                            if (entry.Key.GetType().Name.Equals("String"))
                            {
                                double tmp;
                                if (double.TryParse(entry.Value.ToString(), out tmp))
                                {
                                    string str = "";
                                    str += tmp;
                                    str = str.Replace(',', '.');
                                    sql += str + ",";
                                }
                                else
                                    sql += "'" + entry.Value + "',";
                            }
                            else
                                sql += entry.Value + ",";
                        }

                    }
                    sql = sql.Remove(sql.Length - 1, 1);
                    sql += ")";
                }
                else
                {
                    Dictionary<string, object> dico = new Dictionary<string, object>();
                    dico = ToDictionary<object>(this);
                    sql = "update " + this.GetType().Name + " set ";


                    foreach (var entry in dico)
                    {
                        if (!entry.Key.Equals("Id") && entry.Value != null)
                        {
                            if (entry.Key.GetType().Name.Equals("String"))
                            {
                                double tmp;
                                if (double.TryParse(entry.Value.ToString(), out tmp))
                                {
                                    string str = "";
                                    str += tmp;
                                    str = str.Replace(',', '.');
                                    sql += entry.Key + "=" + "" + str + ",";
                                }
                                else
                                    sql += entry.Key + "=" + "'" + entry.Value + "',";
                            }

                            else
                                sql += entry.Key + "=" + "" + entry.Value + ",";
                        }


                    }
                    sql = sql.Remove(sql.Length - 1, 1);
                    sql += " where id = " + Id;
                }
                Console.WriteLine(sql);
                return Connexion.IUD(sql);
            }
            else
            {
                Console.WriteLine(sql);
                if (con is MySqlConnection)
                    this.saveProcedureMySql(procedure);
                else if (con is SqlConnection)
                    this.saveProcedureSql(procedure);
                return save();
            }
        }

        public dynamic find()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            sql = "select * from " + this.GetType().Name + " where id=" + Id;
            IDataReader dr = Connexion.select(sql);

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string name = dr.GetName(i);
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    dico.Add(name, dr.GetValue(i));
                }
            }
            dr.Close();
            return DictionaryToObject(dico);
        }

        public List<dynamic> All()
        {
            List<dynamic> res = new List<dynamic>();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            sql = "select * from " + this.GetType().Name;
            IDataReader dr = Connexion.select(sql);

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string name = dr.GetName(i);
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    dico.Add(name, dr.GetValue(i));
                }

                res.Add(DictionaryToObject(dico));
                dico.Clear();
            }
            dr.Close();
            return res;
        }


        public static List<dynamic> all<T>()
        {
            List<dynamic> res = new List<dynamic>();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            Dictionary<string, string> ch = new Dictionary<string, string>();
            string sql = "select * from " + (typeof(T)).Name + ";";
            IDataReader dr = Connexion.select(sql);

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {

                    string name = dr.GetName(i);
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    dico.Add(name, dr.GetValue(i));
                }

                res.Add(new Dictionary<string, object>(dico));
                dico.Clear();
            }
            dr.Close();

            return res;
        }

        public List<dynamic> Select(Dictionary<string, object> dico)
        {
            List<dynamic> res = new List<dynamic>();
            Dictionary<string, object> dico1 = new Dictionary<string, object>();
            sql = "select * from " + this.GetType().Name + " where ";
            foreach (var entry in dico)
            {
                if (entry.Key.GetType().Name.Equals("String"))
                    sql += entry.Key + " = " + "'" + entry.Value.ToString() + "'" + " and ";
                else
                    sql += entry.Key + " = " + entry.Value.ToString() + " and ";
            }

            for (int i = 0; i < 4; i++)
            {
                sql = sql.Remove(sql.Length - 1, 1);
            }
            Console.WriteLine(sql);

            IDataReader dr = Connexion.select(sql);

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    string name = dr.GetName(i);
                    name = char.ToUpper(name[0]) + name.Substring(1);
                    dico1.Add(name, dr.GetValue(i));
                }

                res.Add(DictionaryToObject(dico1));
                dico1.Clear();
            }
            dr.Close();
            return res;
        }


        public static List<dynamic> select<T>(Dictionary<string, object> dico)
        {
            List<dynamic> res = new List<dynamic>();
            Dictionary<string, object> dico1 = new Dictionary<string, object>();
            string sql = "select * from " + (typeof(T)).Name + " where ";
            foreach (var entry in dico)
            {
                if (entry.Key.GetType().Name.Equals("String"))
                    sql += entry.Key + " = " + "'" + entry.Value.ToString() + "'" + " and ";
                else
                    sql += entry.Key + " = " + entry.Value.ToString() + " and ";
            }

            for (int i = 0; i < 4; i++)
            {
                sql = sql.Remove(sql.Length - 1, 1);
            }

            IDataReader dr = Connexion.select(sql);

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    dico1.Add(dr.GetName(i), dr.GetValue(i));


                }

                res.Add(new Dictionary<string, object>(dico1));
                dico1.Clear();
            }
            dr.Close();
            return res;
        }
        public static List<int> findId<T>(Dictionary<string, object> dico)
        {
            List<int> list = new List<int>();
            string sql = "select * from " + (typeof(T)).Name + " where ";
            foreach (var entry in dico)
            {
                if (entry.Key.GetType().Name.Equals("String"))
                    sql += entry.Key + " = " + "'" + entry.Value.ToString() + "'" + " and ";
                else
                    sql += entry.Key + " = " + entry.Value.ToString() + " and ";
            }
            for (int i = 0; i < 4; i++)
            {
                sql = sql.Remove(sql.Length - 1, 1);
            }
            IDataReader dr = Connexion.select(sql);
            while (dr.Read())
            {
                list.Add(dr.GetInt32(0));
            }
            dr.Close();
            return list;
        }

    }
}
