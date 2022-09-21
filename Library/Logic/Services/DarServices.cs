using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class DarServices
    {
        static void InsertParameters(int id, string name, int country , SqlCommand cmd) {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = country;
        }
        public static bool Intert(int id, string name, int country) {
           return DBHelper.ExecuteCommand("InsertDar", ()=>InsertParameters(id,name,country , DBHelper.command));
        }

         static void UpdateParameters(int id, string name, int country, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@Country", SqlDbType.Int).Value = country;
        }
        public static bool Update(int id, string name, int country)
        {
            return DBHelper.ExecuteCommand("UpdateDar", () => UpdateParameters(id, name, country, DBHelper.command));
        }

         static void DeleteParameters(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        public static bool Delete(int id)
        {
            return DBHelper.ExecuteCommand("DeleteDar", () => DeleteParameters(id, DBHelper.command));
        }


         static void DeleteAllParameters() { }
        public static bool DeleteAll()
        {
            return DBHelper.ExecuteCommand("DeleteAllDar", () => DeleteAllParameters());
        }

        public static DataTable GetAllData() { 
            return DBHelper.GetData("GetAllDar", ()=>{ });
        }

        public static int GetLastId() {
            try {
                DataTable dt = DBHelper.GetData("GetLastIDDar", () => { });
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            catch
            {
                return 0;
            }
        }
    }
}
