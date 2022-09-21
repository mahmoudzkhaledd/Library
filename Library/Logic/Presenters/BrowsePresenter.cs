using Library.Logic.Services;
using Library.View.InterFaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic.Presenters
{
    public class BrowsePresenter
    {
        BrowseBooksInterFace interFace;
       public BrowsePresenter(BrowseBooksInterFace i) {
            interFace = i;
            LoadData();
        }
        void GetAllData(DataTable dt)
        {
            interFace.DataGridDataSource = dt;
        }
        public void LoadData() {
            GetAllData(BrowseBookServises.AllBooks());
            interFace.CatDataSource = CatServices.GetAllData();
            interFace.DarDataSource = DarServices.GetAllData();
            interFace.CountryDataSource = CountriesServices.GetAllData();
            interFace.AuthorDataSource = BookServices.GetAuthors() ;
            interFace.PlaceDataSource = BoockPlaceServices.GetAllData();
        }
        public void Search() {
            if (interFace.All) { GetAllData(BrowseBookServises.AllBooks());}
            else if(interFace.ID) { GetAllData(BrowseBookServises.BookByID(interFace.SelectedBookId)); }
            else if(interFace.name) { GetAllData(BrowseBookServises.BookByName(interFace.SelectedBookName)); }
            else if(interFace.Cat) { GetAllData(BrowseBookServises.BookByCat(interFace.CatSelectedValue)); }
            else if(interFace.Dar) { GetAllData(BrowseBookServises.BookByDar(interFace.DarSelectedValue)); }
            else if(interFace.Country) { GetAllData(BrowseBookServises.BookByCountry(interFace.CountrySelectedValue)); }
            else if(interFace.Author) { GetAllData(BrowseBookServises.BookByAuthor(interFace.AuthorSelectedValue)); }
            else if(interFace.Place) { GetAllData(BrowseBookServises.BookByPlace(interFace.PlaceSelectedValue)); }
            else if(interFace.subCat) { GetAllData(BrowseBookServises.BookBySubCat(interFace.SelectedsubCat)); }
            else if(interFace.Date) { GetAllData(BrowseBookServises.BookByDate(interFace.SelectedDate)); }
        }
    }
}
