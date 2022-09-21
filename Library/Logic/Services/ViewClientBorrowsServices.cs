using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class ViewClientBorrowsServices
    {
        static void GetClientDataParameters(SqlCommand cmd , int id) { cmd.Parameters.Add("@id",SqlDbType.Int).Value = id; }
        public static DataTable GetClientData(int id) {
            return DBHelper.GetData("GetAllDataBorrowBook",()=>GetClientDataParameters(DBHelper.command , id) );
        }
        public static bool Delete(int id) {
            return DBHelper.ExecuteCommand("DeleteBorrowBook", 
                () => { DBHelper.command.Parameters.Add("@id", SqlDbType.Int).Value = id; });
        }
        public static bool DeleteAll(int id) {
            return DBHelper.ExecuteCommand(id == -1 ? "DeleteAllBorrowBook": "DeleteByBorrowerID",
                () => {
                    if (id != -1) {
                        DBHelper.command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    }
                });
        }

        public static DataTable GetAllData() {
            return DBHelper.GetData("GetAllBorrows", () => { }); ; 
       }
    }
}
