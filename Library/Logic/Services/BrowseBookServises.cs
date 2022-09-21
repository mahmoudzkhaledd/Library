using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Services
{
    public class BrowseBookServises
    {
         static void PrarmetersID(SqlCommand cmd, int id) 
        { cmd.Parameters.Add("@id",SqlDbType.Int).Value = id; }
         static void PrarmetersName(SqlCommand cmd ,string Name)
        { cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = Name; }
         static void PrarmetersCat(SqlCommand cmd ,int Cat)
        { cmd.Parameters.Add("@CatID", SqlDbType.Int).Value = Cat; }
         static void PrarmetersDar(SqlCommand cmd ,int Dar)
        { cmd.Parameters.Add("@DarID", SqlDbType.Int).Value = Dar; }
         static void PrarmetersCountry(SqlCommand cmd ,int Country)
        { cmd.Parameters.Add("@CountryID", SqlDbType.Int).Value = Country; }
         static void PrarmetersAuthor(SqlCommand cmd ,int Author)
        { cmd.Parameters.Add("@AuthorID", SqlDbType.Int).Value = Author; }
         static void PrarmetersPlace(SqlCommand cmd ,int Place)
        { cmd.Parameters.Add("@PlaceID", SqlDbType.Int).Value = Place; }
         static void PrarmetersSubCat(SqlCommand cmd ,string Sub)
        { cmd.Parameters.Add("@SubCat", SqlDbType.NVarChar).Value = Sub; }
         static void PrarmetersDate(SqlCommand cmd ,string Date)
        { cmd.Parameters.Add("@Date", SqlDbType.Date).Value = Date; }

        public static DataTable AllBooks() { return DBHelper.GetData("SearchAllBooks", () => { }); }
        public static DataTable BookByID(int id) { return DBHelper.GetData("SearchBookByID", ()=> PrarmetersID(DBHelper.command,id)); }
        public static DataTable BookByName(string name) { return DBHelper.GetData("BookByName", () => PrarmetersName(DBHelper.command, name)); }
        public static DataTable BookByCat(int id) { return DBHelper.GetData("BookByCat", () => PrarmetersCat(DBHelper.command, id)); }
        public static DataTable BookByDar(int id) { return DBHelper.GetData("BookByDar", () => PrarmetersDar(DBHelper.command, id)); }
        public static DataTable BookByCountry(int id) { return DBHelper.GetData("BookByCountry", () => PrarmetersCountry(DBHelper.command, id)); }
        public static DataTable BookByAuthor(int id) { return DBHelper.GetData("BookByAuthor", () => PrarmetersAuthor(DBHelper.command, id)); }
        public static DataTable BookByPlace(int id) { return DBHelper.GetData("BookByPlace", () => PrarmetersPlace(DBHelper.command, id)); }
        public static DataTable BookBySubCat(string sub) { return DBHelper.GetData("BookBySubCat", () => PrarmetersSubCat(DBHelper.command, sub)); }
        public static DataTable BookByDate(string Date) { return DBHelper.GetData("BookByDate", () => PrarmetersDate(DBHelper.command, Date)); }
    }
}
