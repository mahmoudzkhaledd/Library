using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class BorrowBookServices
    {

       static void InsertParameters(SqlCommand cmd,
           int id ,
           int BorrowerId , 
           int bookID ,
           int BooksNumber,
           string startDate ,
           string endDate ,
           decimal Total,
           string note) {
            cmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@borrowerID", SqlDbType.Int).Value = BorrowerId;
            cmd.Parameters.Add("@BooksNumber", SqlDbType.Int).Value = BooksNumber;
            cmd.Parameters.Add("@bookId", SqlDbType.Int).Value = bookID;
            cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = startDate;
            cmd.Parameters.Add("@endDate", SqlDbType.Date).Value = endDate;
            cmd.Parameters.Add("@Note", SqlDbType.Text).Value = note;
            cmd.Parameters.Add("@Total", SqlDbType.Real).Value = Total;
        }
        public static bool Insert(
            int id,
            int BorrowerId,
            int bookID, 
            int BooksNumber,
            string startDate, 
            string endDate, 
            decimal Total,
            string note) {
            return DBHelper.ExecuteCommand("InsertBorrowBook", ()=> InsertParameters(DBHelper.command, id,  BorrowerId,  bookID, BooksNumber ,  startDate,  endDate,Total, note));
        }



        static void UpdateParameters(SqlCommand cmd, int id, int BorrowerId, int bookID, int BooksNumber, string startDate, string endDate, string note)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@borrowerID", SqlDbType.Int).Value = BorrowerId;
            cmd.Parameters.Add("@BooksNumber", SqlDbType.Int).Value = BooksNumber;
            cmd.Parameters.Add("@bookId", SqlDbType.Int).Value = bookID;
            cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = startDate;
            cmd.Parameters.Add("@endDate", SqlDbType.Date).Value = endDate;
            cmd.Parameters.Add("@Note", SqlDbType.Text).Value = note;
        }
        public static bool Update(
            int id, 
            int BorrowerId, 
            int bookID,
            int BooksNumber, 
            string startDate,
            string endDate, 
            string note)
        {
            return DBHelper.ExecuteCommand("UpdateBorrowBook", () => UpdateParameters(DBHelper.command, id, BorrowerId, bookID,BooksNumber, startDate, endDate, note));
        }

        static void DeleteParameters(SqlCommand cmd, int id) {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        
        public static bool Delete(int id) {
            return DBHelper.ExecuteCommand("DeleteBorrowBook", ()=>DeleteParameters(DBHelper.command,id)); 
        }
        public static bool DeleteAll() {
            return DBHelper.ExecuteCommand("DeleteAllBorrowBook", () => { });
        }
        
        public static DataTable GetAllData(bool showUnAvailable)
        {
            return DBHelper.GetData(showUnAvailable ? "GetAllBooksBorrow" : "GetAvailableBooksBorrow", () => { }); 
        }
        public static int GetLastID() {
            int id = 0;
            try { 
                id= Convert.ToInt32(DBHelper.GetData("GetLastIDBorrowBook", () => { }).Rows[0][0]); 
            } catch { id = 0; }
            return id;
        }
    }
}
