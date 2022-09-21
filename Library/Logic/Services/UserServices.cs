using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class UserServices
    {
        static void InsertParameters
            (
            SqlCommand cmd,
            int id
           , string FirstName
           , string MiddleName
           , string LastName
           , string Email
           , string UserName
           , string password
           , int Age
           , string Address
           , string CardNumber
           , string phone1
           , string phone2
           , decimal salary
           , string Date
           , string Type
            )
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = CardNumber;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = phone1;
            cmd.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = phone2;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
        }
        public static bool Insert
            (
               int id
           , string FirstName
           , string MiddleName
           , string LastName
           , string Email
           , string UserName
           , string password
           , int Age
           , string Address
           , string CardNumber
           , string phone1
           , string phone2
           , decimal salary
           , string Date
           , string Type
            )
        {
            return DBHelper.ExecuteCommand("InsertUser", () => InsertParameters(
                DBHelper.command,
                id
           , FirstName
           , MiddleName
           , LastName
           , Email
           , UserName
           , password
           , Age
           , Address
           , CardNumber
           , phone1
           , phone2
           , salary
           , Date
           , Type
                ));
        }

        public static void insertPermission(int userID ,int pID) {
            DBHelper.ExecuteCommand("InsertUserPermission", () => {
                DBHelper.command.Parameters.Add("@userID", SqlDbType.Int).Value = userID;
                DBHelper.command.Parameters.Add("@PermissionID", SqlDbType.Int).Value = pID;
            });
        }



        static void UpdateParameters
            (
            SqlCommand cmd,
             int id
           , string FirstName
           , string MiddleName
           , string LastName
           , string Email
           , string UserName
           , string password
           , int Age
           , string Address
           , string CardNumber
           , string phone1
           , string phone2
           , decimal salary
           , string Date
           , string Type
            )
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
            cmd.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = MiddleName;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = UserName;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Address;
            cmd.Parameters.Add("@CardNumber", SqlDbType.NVarChar).Value = CardNumber;
            cmd.Parameters.Add("@phone1", SqlDbType.NVarChar).Value = phone1;
            cmd.Parameters.Add("@phone2", SqlDbType.NVarChar).Value = phone2;
            cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("@salary", SqlDbType.Real).Value = salary;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Date;
        }
        public static bool Update
            (
                int id
           , string FirstName
           , string MiddleName
           , string LastName
           , string Email
           , string UserName
           , string password
           , int Age
           , string Address
           , string CardNumber
           , string phone1
           , string phone2
           , decimal salary
           , string Date
           , string Type
            )
        {
            return DBHelper.ExecuteCommand("UpdateUser", () => UpdateParameters(
                DBHelper.command,
                id
           , FirstName
           , MiddleName
           , LastName
           , Email
           , UserName
           , password
           , Age
           , Address
           , CardNumber
           , phone1
           , phone2
           , salary
           , Date
           , Type
                ));
        }

       public static int GetPermissionID(string name)
        {
            int f = 0;
            DBHelper.ExecuteCommand("GetPermissionID",
                () => {
                    SqlCommand cmd = DBHelper.command;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                },
                () => {
                    SqlCommand cmd = DBHelper.command;
                    var returnParameter = cmd.Parameters["@ReturnVal"];
                    f = (int)returnParameter.Value;
                }
                );
            return f;
        }
        public static DataTable GetUserPermissions(int id) {
            return DBHelper.GetData("GetUserPermissions", 
                () => { DBHelper.command.Parameters.Add("@UserID", SqlDbType.Int).Value = id; });
        }
        public static DataTable GetUserByID(int id) {
            return DBHelper.GetData("GetUserByID", () => { DBHelper.command.Parameters.Add("@id",SqlDbType.Int).Value = id; });
        }
        public static bool DeleteAlluserPermissions() {
            return DBHelper.ExecuteCommand("DeleteAllUserPermissions", () => { });
        }
        public static bool DeleteUserPermissions(int id) {
            return DBHelper.ExecuteCommand("DeleteUserPermissions", () => {
                DBHelper.command.Parameters.Add("@id",SqlDbType.Int).Value = id;
            });
        }
        public static int GetLastID() {
            int id = 0;
            try { 
                id = Convert.ToInt32(DBHelper.GetData("GetLastIDUser", () => { }).Rows[0][0]); 
            }
            catch { id = 0; }
            return id;
        }

    }
}
