using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class BookModel
    {
        public int id { get; set; }
        public int BooksNumber { get; set; }
        public string name { get; set; }
        public int CatID { get; set; }
        public int AuthorID { get; set; }
        public int CountryID { get; set; }
        public int DarID { get; set; }
        public string SubCar { get; set; }
        public string Date { get; set; }
        public int PageNumber { get; set; }
        public int PlaceId { get; set; }
        public string BookStat { get; set; }
        public decimal BookPrice { get; set; }
        public decimal BorrowPrice { get; set; }
        public string Note { get; set; }
    }
}
