using Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface UsersInterFace
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }
        int age { get; set; }
        string address { get; set; }
        string CardID { get; set; }
        string phone1 { get; set; }
        string phone2 { get; set; }
        decimal salary { get; set; }
        string UserTaken { get; set; }
        string Date { get; set; }
        int ID { get; set; }
        bool IsAdmin { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        void CheckItem(int index ,bool b);
        UserPermissions permissions { get; set; }
    }
}
