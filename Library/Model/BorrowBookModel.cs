using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{ 
    public class BorrowBookModel
    {
        public int id { set; get; }
        public int BorrowerID { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public decimal TotalPrice { set; get; }
        public string Note { set; get; }
    }
}
