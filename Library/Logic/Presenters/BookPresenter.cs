using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library;
using Library.View;
using Library.View.InterFaces;
using Library.Model;
using Library.Logic.Presenters;
using Library.Logic.Services;
using System.Data.SqlClient;
namespace Library.Logic.Presenters
{

    public class BookPresenter 
    {
        BookModel model = new BookModel();
        BookInterFace interFace;
        public BookPresenter(BookInterFace i) { 
            interFace = i;
            NewBook();
        }
        void ConnectModelInterFace() {
            model.id = interFace.id;
            model.BooksNumber = interFace.BooksNumber;
            model.name = interFace.name;
            model.PageNumber = interFace.PageNumber;
            model.SubCar = interFace.SubCar;
            model.PlaceId = interFace.PlaceId;
            model.AuthorID = interFace.AuthorID;
            model.BookPrice = interFace.BookPrice;
            model.BookStat = interFace.BookStat;
            model.CatID = interFace.CatID;
            model.CountryID = interFace.CountryID;
            model.Date = interFace.Date;
            model.DarID = interFace.DarID;
            model.Note = interFace.Note;
            model.BorrowPrice = interFace.BorrowPrice;
        }
        public void Insert() {
            ConnectModelInterFace();
            Disable(true);
            if (interFace.name != "")
            {
                if (BookServices.Insert(
                    model.id,
                    interFace.name,
                    model.BooksNumber,
                    model.CatID,
                    model.AuthorID,
                    model.CountryID,
                    model.DarID,
                    model.SubCar,
                    DateTime.Parse(model.Date),
                    model.PageNumber,
                    model.PlaceId,
                    model.BookStat,
                    model.BookPrice,
                    model.BorrowPrice,
                    model.Note)
                    )
                { MessageBox.Show("تمت العمليه "); }
                else
                    MessageBox.Show("فشلت العمليه");
                NewBook();
            }
            else {
                MessageBox.Show("من فضلك ادخل اسم الكتاب");
            }
        }
        public void Update()
        {
            ConnectModelInterFace();
            if (interFace.name != "")
            {
                if (BookServices.Update(
                    model.id,
                    interFace.name,
                    model.BooksNumber,
                    model.CatID,
                    model.AuthorID,
                    model.CountryID,
                    model.DarID,
                    model.SubCar,
                    model.Date,
                    model.PageNumber,
                    model.PlaceId,
                    model.BookStat,
                    model.BookPrice,
                    model.BorrowPrice,
                    model.Note)
                )
                MessageBox.Show("تمت العمليه");
            else
                MessageBox.Show("فشلت العمليه");
            }
        }
        public void Disable(bool x)
        {
            if (x)
            {
                interFace.btnSave = false;
                interFace.btnDelete = false;
                interFace.btnDeleteAll = false;
                interFace.btnAdd = true;
                interFace.btnNew = true;
            }
            else
            {
                interFace.btnSave = true;
                interFace.btnDelete = true;
                interFace.btnDeleteAll = true;
                interFace.btnAdd = false;
                interFace.btnNew = true;
            }
        }


        public void UpdateAuthor() { interFace.cmbAuthorDataSource = BookServices.GetAuthors(); Check(); }
        public void UpdateCountry() { interFace.cmbCountriesDataSource = CountriesServices.GetAllData(); Check(); }
        public void UpdateCat() { interFace.cmbCatDataSource = CatServices.GetAllData(); Check(); }
        public void UpdateDar() { interFace.cmbDarDataSource = DarServices.GetAllData(); Check(); }
        public void UpdatePlace() { interFace.cmbPlaceDataSource = BoockPlaceServices.GetAllData(); Check(); }
        public void DisableAll()
        {
            interFace.btnSave = false;
            interFace.btnDelete = false;
            interFace.btnDeleteAll = false;
            interFace.btnAdd = false;
            interFace.btnNew = false;
        }
        void Check() {
            if (interFace.cmbAuthorItemCount == 0 || interFace.cmbCountriesItemCount == 0 || interFace.cmbCatItemCount == 0 || interFace.cmbDarItemCount == 0 || interFace.cmbPlaceItemCount == 0)
                DisableAll();
            else Disable(true);
        }
        public void NewBook() {
            Disable(true); 
            interFace.cmbAuthorDataSource = BookServices.GetAuthors();
            interFace.cmbCountriesDataSource = CountriesServices.GetAllData();
            interFace.cmbCatDataSource = CatServices.GetAllData();
            interFace.cmbDarDataSource = DarServices.GetAllData();
            interFace.cmbPlaceDataSource = BoockPlaceServices.GetAllData();
            GetNextID();

            Check();


            interFace.name = "";
            interFace.SubCar = "";
            interFace.Date = DateTime.Now.ToString();
            interFace.PageNumber = 1;
            interFace.BookPrice = 1;
            interFace.BookStat = "متوفر";
            interFace.cmbBooksDataSource = BookServices.GetAllData();
            interFace.Note = "";
        }
        
        public void Delete() {
            ConnectModelInterFace();
            if(BookServices.Delete(model.id)) MessageBox.Show("تمت العمليه");
            else MessageBox.Show("فشلت العمليه");
            NewBook();
        }
        public void DeleteAll() {
            if (BookServices.DeleteAll()) MessageBox.Show("تمت العمليه");
            else MessageBox.Show("فشلت العمليه");
            NewBook();
        }
        public void GetNextID() {
            
            interFace.id = BookServices.GetNextID() + 1;
        }
        public DataTable GetAllData() { return BookServices.GetAllData(); }

        void SetData(
            int id ,
            string name,
            int BooksNumber,
            int catID ,
            int authorID ,
            int countryID ,
            int darID ,
            string subCat ,
            string date ,
            int pages,
            int placeID,
            string stat,
            decimal price ,
            decimal Borrowprice ,
            string note) {
            interFace.id = id;
            interFace.BooksNumber = BooksNumber;
            interFace.name = name;
            interFace.CatID = catID;
            interFace.AuthorID = authorID;
            interFace.CountryID = countryID;
            interFace.DarID = darID;
            interFace.SubCar = subCat;
            interFace.Date = date;
            interFace.PageNumber = pages;
            interFace.PlaceId = placeID;
            interFace.BookStat = stat;
            interFace.BookPrice = price;
            interFace.BorrowPrice = Borrowprice;
            interFace.Note = note;
        }
        public void ToFirstBook() {
            Disable(false);
            interFace.BookSelectedIndex = 0;
            DataRow dr = BookServices.GetByID(interFace.BookSelectedValue).Rows[0];
            SetData(
                Convert.ToInt32(dr[0]), 
                Convert.ToString(dr[1]),
                Convert.ToInt32(dr[2]), 
                Convert.ToInt32(dr[3]),
                Convert.ToInt32(dr[4]), 
                Convert.ToInt32(dr[5]), 
                Convert.ToInt32(dr[6]), 
                Convert.ToString(dr[7]),
                Convert.ToString(dr[8]), 
                Convert.ToInt32(dr[9]), 
                Convert.ToInt32(dr[10]), 
                Convert.ToString(dr[11]),
                Convert.ToDecimal(dr[12]), 
                Convert.ToDecimal(dr[13]),
                Convert.ToString(dr[14])
                );
            dr.Delete();

        }
        public void ToLastBook() { 
            Disable(false);
            interFace.BookSelectedIndex = -1;
            DataRow dr = BookServices.GetByID(interFace.BookSelectedValue).Rows[0];
            SetData(
                Convert.ToInt32(dr[0]),
                Convert.ToString(dr[1]),
                Convert.ToInt32(dr[2]),
                Convert.ToInt32(dr[3]),
                Convert.ToInt32(dr[4]),
                Convert.ToInt32(dr[5]),
                Convert.ToInt32(dr[6]),
                Convert.ToString(dr[7]),
                Convert.ToString(dr[8]),
                Convert.ToInt32(dr[9]),
                Convert.ToInt32(dr[10]),
                Convert.ToString(dr[11]),
                Convert.ToDecimal(dr[12]),
                Convert.ToDecimal(dr[13]),
                Convert.ToString(dr[14])
                );
            dr.Delete();
        }
        public void StepBack() { 
            Disable(false);
            if (interFace.BookSelectedIndex > 0) {
                interFace.BookSelectedIndex--;
            }
            else {
                interFace.BookSelectedIndex = interFace.BookItemCount - 1;
            }
            DataRow dr = BookServices.GetByID(interFace.BookSelectedValue).Rows[0];
            SetData(
                            Convert.ToInt32(dr[0]),
                Convert.ToString(dr[1]),
                Convert.ToInt32(dr[2]),
                Convert.ToInt32(dr[3]),
                Convert.ToInt32(dr[4]),
                Convert.ToInt32(dr[5]),
                Convert.ToInt32(dr[6]),
                Convert.ToString(dr[7]),
                Convert.ToString(dr[8]),
                Convert.ToInt32(dr[9]),
                Convert.ToInt32(dr[10]),
                Convert.ToString(dr[11]),
                Convert.ToDecimal(dr[12]),
                Convert.ToDecimal(dr[13]),
                Convert.ToString(dr[14])
                            );
            dr.Delete();

        }
        public void StepForward() { 
            Disable(false);
            if (interFace.BookSelectedIndex < interFace.BookItemCount - 1)
            {
                interFace.BookSelectedIndex++;
            }
            else
            {
                interFace.BookSelectedIndex = 0;
            }
            
            DataRow dr = BookServices.GetByID(interFace.BookSelectedValue).Rows[0];
            
            SetData(
                            Convert.ToInt32(dr[0]),
                Convert.ToString(dr[1]),
                Convert.ToInt32(dr[2]),
                Convert.ToInt32(dr[3]),
                Convert.ToInt32(dr[4]),
                Convert.ToInt32(dr[5]),
                Convert.ToInt32(dr[6]),
                Convert.ToString(dr[7]),
                Convert.ToString(dr[8]),
                Convert.ToInt32(dr[9]),
                Convert.ToInt32(dr[10]),
                Convert.ToString(dr[11]),
                Convert.ToDecimal(dr[12]),
                Convert.ToDecimal(dr[13]),
                Convert.ToString(dr[14])
                  );
            dr.Delete();
           
        }

    }
}
