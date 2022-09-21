using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string CardID { get; set; }
        public string phone1 { get; set; }
        public string phone2 { get; set; }
        public decimal salary { get; set; }
        public string Date { get; set; }
        public int ID { get; set; }
        public bool IsAdmin { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public UserPermissions permissions { get; set; }
    }
}
