using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class AddBorrowerServices
    {
        static void InsertParameters(SqlCommand cmd , int id , string name ,string phone1,string phone2) {
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@date",SqlDbType.Date).Value = DateTime.Now.ToString();
            cmd.Parameters.Add("@phone_1",SqlDbType.NVarChar).Value = phone1;
            cmd.Parameters.Add("@phone_2",SqlDbType.NVarChar).Value = phone2;
        }
        public static bool Insert(int id, string name, string phone1, string phone2) {
            return DBHelper.ExecuteCommand("InsertBorrower", ()=> InsertParameters(DBHelper.command,id,name,phone1,phone2));
        }

        static void UpdateParameters(SqlCommand cmd, int id, string name, string phone1, string phone2)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@phone_1", SqlDbType.NVarChar).Value = phone1;
            cmd.Parameters.Add("@phone_2", SqlDbType.NVarChar).Value = phone2;
        }
        public static bool Update(int id, string name, string phone1, string phone2)
        {
            return DBHelper.ExecuteCommand("UpdateBorrower", () => UpdateParameters(DBHelper.command, id, name, phone1, phone2));
        }
        static void DeleteParameters(SqlCommand cmd, int id)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        public static bool Delete(int id)
        {
            return DBHelper.ExecuteCommand("DeleteBorrower", () => DeleteParameters(DBHelper.command, id));
        }
        static void DeleteAllParameters(){ }
        public static bool DeleteAll()
        {
            return DBHelper.ExecuteCommand("DeleteAllBorrower", () => DeleteAllParameters());
        }

        
        public static DataTable GetAllData()
        {
            return DBHelper.GetData("GetAllBorrower", () => { });
        }
        public static DataTable GetDataByID(int id)
        {
            return DBHelper.GetData("GetBorrowerByID", () => { DBHelper.command.Parameters.Add("@id",SqlDbType.Int).Value = id; });
        }
        public static int GetLastID() {
            int id = 0;
            try {id = Convert.ToInt32(DBHelper.GetData("GetLastID", () => { }).Rows[0][0]); } catch { id = 0; }
            return id;
        }


    }
}
