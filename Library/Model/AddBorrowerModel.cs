using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class AddBorrowerModel
    {
      public  AddBorrowerModel() { }
        public AddBorrowerModel(int id ,string name , string p1, string p2) { 
            this.id = id;
            this.name = name;
            this.phone_1 = p1;
            this.phone_2 = p2;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string phone_1 { get; set; }
        public string phone_2 { get; set; }
        public string Date { get; set; }
    }
}
