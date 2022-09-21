using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Library.Logic.Services
{
    public class BookServices
    {
        static void  InsertParameters(
            SqlCommand cmd, 
            int id, 
            string name,
            int BooksNumber,
            int CatID, 
            int AuthorID,
            int CountryID,
            int DarID, 
            string SubCar,
            DateTime Date, 
            int PageNumber,
            int PlaceId,
            string BookStat,
            decimal BookPrice,
            decimal BorrowPrice,
            string Note)
        {
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@BooksNumber", SqlDbType.Int).Value = BooksNumber;
            cmd.Parameters.Add("@name",SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@catId", SqlDbType.Int).Value = CatID;
            cmd.Parameters.Add("@authorId", SqlDbType.Int).Value = AuthorID;
            cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = CountryID;
            cmd.Parameters.Add("@DarID", SqlDbType.Int).Value = DarID;
            cmd.Parameters.Add("@SubCat", SqlDbType.NVarChar).Value = SubCar;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Date;
            cmd.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PageNumber;
            cmd.Parameters.Add("@placeId", SqlDbType.Int).Value = PlaceId;
            cmd.Parameters.Add("@BookState", SqlDbType.NVarChar).Value = BookStat;
            cmd.Parameters.Add("@bookPrice", SqlDbType.Real).Value = BookPrice;
            cmd.Parameters.Add("@BorrowPrice", SqlDbType.Real).Value = BorrowPrice;
            cmd.Parameters.Add("@Notes", SqlDbType.Text).Value = Note;
        }
        public static bool Insert(int id, string name, int BooksNumber, int CatID, int AuthorID, int CountryID, int DarID, string SubCar, DateTime Date, int PageNumber, int PlaceId, string BookStat, decimal BookPrice, decimal BorrowPrice, string Note)
        {
            bool x = DBHelper.ExecuteCommand("InsertBook", () => InsertParameters(DBHelper.command, id, name,BooksNumber, CatID, AuthorID, CountryID, DarID, SubCar, Date, PageNumber, PlaceId, BookStat, BookPrice, BorrowPrice, Note));
            return x;
        }
       public static bool UpdateBooksNumber(int n ,int id) {
            return DBHelper.ExecuteCommand("UpdateBooksNumber", 
                () => { 
                    DBHelper.command.Parameters.Add("@number",SqlDbType.Int).Value = n; 
                    DBHelper.command.Parameters.Add("@id",SqlDbType.Int).Value = id; 
                });
        }
        static void UpdateParameters(
            SqlCommand cmd,
            int id,
            string name,
            int BooksNumber,
            int CatID,
            int AuthorID,
            int CountryID,
            int DarID,
            string SubCar,
            string Date,
            int PageNumber,
            int PlaceId,
            string BookStat,
            decimal BookPrice, 
            decimal BorrowPrice,
            string Note)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@BooksNumber", SqlDbType.Int).Value = BooksNumber;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@catId", SqlDbType.Int).Value = CatID;
            cmd.Parameters.Add("@authorId", SqlDbType.Int).Value = AuthorID;
            cmd.Parameters.Add("@countryID", SqlDbType.Int).Value = CountryID;
            cmd.Parameters.Add("@DarID", SqlDbType.Int).Value = DarID;
            cmd.Parameters.Add("@SubCat", SqlDbType.NVarChar).Value = SubCar;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = Date;
            cmd.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PageNumber;
            cmd.Parameters.Add("@placeId", SqlDbType.Int).Value = PlaceId;
            cmd.Parameters.Add("@BookState", SqlDbType.NVarChar).Value = BookStat;
            cmd.Parameters.Add("@bookPrice", SqlDbType.Real).Value = BookPrice;
            cmd.Parameters.Add("@Notes", SqlDbType.Text).Value = Note; 
            cmd.Parameters.Add("@BorrowPrice", SqlDbType.Real).Value = BorrowPrice;
        }
        public static bool Update(int id, string name, int BooksNumber, int CatID, int AuthorID, int CountryID, int DarID, string SubCar, string Date, int PageNumber, int PlaceId, string BookStat, decimal BookPrice, decimal BorrowPrice, string Note)
        {
            bool x = DBHelper.ExecuteCommand("UpdateBook", () => UpdateParameters(DBHelper.command, id, name,  BooksNumber, CatID, AuthorID, CountryID, DarID, SubCar, Date, PageNumber, PlaceId, BookStat, BookPrice,BorrowPrice, Note));
            return x;
        }

        static void DeleteParameters(SqlCommand cmd ,int id) { cmd.Parameters.Add("@id", SqlDbType.Int).Value = id; }
        public static bool Delete(int id) {
            bool x = DBHelper.ExecuteCommand("DeleteBook", ()=>DeleteParameters(DBHelper.command,id));
            return x;
        }
        public static bool DeleteAll() {
            bool x = DBHelper.ExecuteCommand("DeleteAllBooks", () => { });
            return x;
        }

       public static DataTable GetAllData() {
            return DBHelper.GetData("GetAllBooks", () => { });
       }
        static void  GetByIDParameters(SqlCommand cmd,int id) {
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
        }
        public static DataTable GetByID(int id) { 
            return DBHelper.GetData("GetBookByID", ()=> GetByIDParameters(DBHelper.command,id));
        }
        public static int GetNextID() {
            int id = 0;
            try {id = Convert.ToInt32(DBHelper.GetData("GetLastIDBook", () => { }).Rows[0][0]);  } catch { id = 0; }
            return id ;
        }
        public static DataTable GetAuthors()
        {
            DataTable authors =  DBHelper.GetData("GetAuthorBook", () => { });
            return authors;
        }
    }
}
