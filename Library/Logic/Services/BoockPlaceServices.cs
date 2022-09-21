using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class BoockPlaceServices
    {
        private static void InsertDataParameters(SqlCommand cmd, int id, string name)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
        }
        public static bool InsertData(int id, string name)
        {
            return DBHelper.ExecuteCommand("InsertBoockPlace", () => InsertDataParameters(DBHelper.command, id, name));
        }



        private static void DeleteParameters(SqlCommand cmd, int id)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
        }
        public static bool Delete(int id)
        {
            return DBHelper.ExecuteCommand("DeleteBoockPlace", () => DeleteParameters(DBHelper.command, id));
        }


        private static void DeleteAllParameters()
        {

        }
        public static bool DeleteAll()
        {
            return DBHelper.ExecuteCommand("DeleteAllBoockPlaces", () => DeleteAllParameters());
        }

        private static void UpdateParameters(SqlCommand cmd, int id, string name)
        {
            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
        }
        public static bool Update(int id, string name)
        {
            return DBHelper.ExecuteCommand("UpdateBoockPlace", () => UpdateParameters(DBHelper.command, id, name));
        }
        public static DataTable GetAllData()
        {
            return DBHelper.GetData("GetAllBoockPlace", () => { });
        }

        public static int GetLastID()
        {
            int id = 0;
            try
            {
                string? x = DBHelper.GetData("GetLastIDBoockPlace", () => { }).Rows[0][0].ToString();
                if (x != null)
                    id = Int32.Parse(x);
            }
            catch { }
            return id;
        }
    }
}
