using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class AuthorServices
    {
        private static void InsertDataParameters(SqlCommand cmd, int id, string name, int country, string date)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Country", System.Data.SqlDbType.Int).Value = country;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date;

        }
        public static bool InsertData(int id, string name, int country, string date)
        {
            return DBHelper.ExecuteCommand("InsertAuthor", () => InsertDataParameters(DBHelper.command, id, name, country, date));
        }



        private static void DeleteParameters(SqlCommand cmd, int id)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
        }
        public static bool Delete(int id)
        {
            return DBHelper.ExecuteCommand("DeleteAuthor", () => DeleteParameters(DBHelper.command, id));
        }


        private static void DeleteAllParameters()
        {

        }
        public static bool DeleteAll()
        {
            return DBHelper.ExecuteCommand("DeleteAllAuthor", () => DeleteAllParameters());
        }

        private static void UpdateParameters(SqlCommand cmd, int id, string name, int country, string date)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Country", System.Data.SqlDbType.Int).Value = country;
            cmd.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = date;
        }
        public static bool Update(int id, string name, int country, string date)
        {
            return DBHelper.ExecuteCommand("UpdateAuthor", () => UpdateParameters(DBHelper.command, id, name, country, date));
        }
        public static DataTable GetAllData()
        {
            return DBHelper.GetData("GetAllAuthors", () => { });
        }

        public static int GetLastID()
        {
            int id = 0;
            try
            {
                string? x = DBHelper.GetData("GetLastIDAuthor", () => { }).Rows[0][0].ToString();
                if (x != null)
                    id = Int32.Parse(x);
            }
            catch { }
            return id;
        }


        public static DataTable GetAllCountries(Action? a = null)
        {
            return DBHelper.GetData("GetAllCountry", a==null ?() => { }:a);
        }

    }
}
