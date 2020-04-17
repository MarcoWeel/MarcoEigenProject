using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using MySql.Data.MySqlClient;

namespace DataLayerLibrary.DataAccess
{
    class SQLAccessData
    {
        public static string GetConnectionString()
        {
            return "Server=84.86.167.197;port=3306;user=root;password=W9p$4eR#;database=app_db;";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                return con.Query<T>(sql).ToList();
            }
        }

        public static void SaveData<T>(string sql, T data)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql, data);
            }
        }

        public static void DeleteData(string sql)
        {
            using (IDbConnection con = new MySqlConnection(GetConnectionString()))
            {
                con.Execute(sql);
            }
        }
    }
}
