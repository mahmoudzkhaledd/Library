using Library.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class LoginServices
    {
        public static int Login(string u ,string p)
        {
            DataTable dt = DBHelper.GetData("GetUserNameAndPassword", 
                () => { DBHelper.command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = u; });
            if(dt.Rows.Count == 0) return -1;
            if (Convert.ToString(dt.Rows[0]["password"]) == p) 
            { return Convert.ToInt32(dt.Rows[0]["id"]); }
            else { return -1; }
        }
    }
}
