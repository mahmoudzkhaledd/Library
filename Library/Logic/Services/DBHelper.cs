using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library.Logic.Services
{
    public class DBHelper
    {
        public static SqlCommand command;
        private static SqlConnection GetSqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.serverName;
            builder.InitialCatalog = Properties.Settings.Default.DBNAME;
            builder.UserID = Properties.Settings.Default.DBUserName;
            builder.Password = Properties.Settings.Default.DBPassword;
            return new SqlConnection(builder.ConnectionString);
        }


        private static SqlConnection GetSqlConnection(string serverName, string DBName, string UserName, string Password)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverName;
            builder.InitialCatalog = DBName;
            builder.UserID = UserName;
            builder.Password = Password;
            return new SqlConnection(builder.ConnectionString);
        }
        public static bool Login()
        {
            bool x = false;
            using (SqlConnection con = GetSqlConnection())
            {
                try
                {
                    con.Open();
                    x = true;
                    con.Close();
                }
                catch
                {
                    con.Close();
                    x = false;
                    Properties.Settings.Default.DBUserName = ""; 
                    Properties.Settings.Default.DBPassword = "";
                    Properties.Settings.Default.Save(); 
                }
                finally { con.Close(); }
                con.Close();
            }

            return x;
        }
        public static bool TestConnection(string serverName ,string DBName ,string UserName ,string Password) {
            using (SqlConnection conn = GetSqlConnection(serverName, DBName, UserName, Password)) {
                bool x = false;
                try
                {
                    conn.Open();
                    conn.Close();
                    x = true;
                }
                catch {
                    conn.Close();
                    x = false;
                }
                return x;
            }
        }
        public static bool ExecuteCommand(string sPName, Action action, Action? a2 = null)
        {
            bool done = false;
            using (SqlConnection conn = GetSqlConnection())
            {
                command = new SqlCommand(sPName, conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();
                action.Invoke();
                command.ExecuteNonQuery();
                if (a2 != null) a2.Invoke();
                conn.Close();
                command.Dispose();
                done = true;
                try
                {
                
                }
                catch
                {
                    conn.Close();
                    command.Dispose();
                    done = false;
                }
                finally { conn.Close(); command.Dispose(); }
            }
            return done;
        }

        public static DataTable GetData(string sPName, Action action)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            using (SqlConnection conn = GetSqlConnection())
            { 
                try
                {
                    command = new SqlCommand(sPName, conn);
                    command.CommandType = CommandType.StoredProcedure;
                    action.Invoke();
                    da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    da.Dispose();
                    conn.Close();
                    command.Dispose();
                }
                catch
                {
                    conn.Close();
                    command.Dispose();
                }
                finally { conn.Close(); command.Dispose(); }
                return dt;
            }

        }

    }
}
