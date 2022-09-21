using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class SearchUserServices
    {
        static void SearchParameters(SqlCommand cmd,Dictionary<string,string> Filters) {
            for (int i = 0; i < Filters.Count; i++) {
                cmd.Parameters.Add($"@{Filters.ElementAt(i).Key}",SqlDbType.NVarChar).Value = Filters.ElementAt(i).Value;
            }
        }
        public static DataTable Search(Dictionary<string, string> Filters) {
            return DBHelper.GetData("SearchUser", () => SearchParameters(DBHelper.command ,Filters));
        }

        public static bool Delete(int id) {
            DBHelper.ExecuteCommand("DeleteUserPermissions", () => { DBHelper.command.Parameters.Add("@id", SqlDbType.Int).Value = id; });
            return DBHelper.ExecuteCommand("DeleteUser", () => { DBHelper.command.Parameters.Add("@id", SqlDbType.Int).Value = id; });
        }
        public static bool DeleteAll() {return DBHelper.ExecuteCommand("DeleteAllUser", () => { });  }
        public static DataTable GetAllData()
        {
            DBHelper.ExecuteCommand("DeleteAllUserPermissions ", () => { });
            return DBHelper.GetData("SearchUser", () => { });
        }
    }
}
