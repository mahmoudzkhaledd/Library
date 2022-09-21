using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface BookInterFace
    {
        int id { get; set; }
        public int BooksNumber { get; set; }

        string name { get; set; }
        int CatID { get; set; }
        int AuthorID { get; set; }
        int CountryID { get; set; }
        int DarID { get; set; }
        string SubCar { get; set; }
        string Date { get; set; }
        int PageNumber { get; set; }
        int PlaceId { get; set; }
        string BookStat { get; set; }
        decimal BookPrice { get; set; }
        decimal BorrowPrice { get; set; }
        string Note { get; set; }
        object cmbCountriesDataSource { get; set; }
        object cmbCatDataSource { get; set; }
        object cmbAuthorDataSource { get; set; }
        object cmbDarDataSource { get; set; }
        object cmbPlaceDataSource { get; set; }
        object cmbBooksDataSource { get; set; }

        object cmbCountriesValue { get; set; }
        object cmbCatValue { get; set; }
        object cmbAuthorValue { get; set; }
        object cmbDarValue { get; set; }
        object cmbPlaceValue { get; set; }
        object cmbBooksValue { get; set; }


        int cmbCountriesItemCount { get; set; }
        int cmbCatItemCount { get; set; }
        int cmbAuthorItemCount { get; set; }
        int cmbDarItemCount { get; set; }
        int cmbPlaceItemCount { get; set; }



        int BookSelectedIndex { get; set; }
        int BookSelectedValue { get; set; }
        int BookItemCount { get; set; }

        bool btnNew { get; set; }
        bool btnAdd { get; set; }
        bool btnSave { get; set; }
        bool btnDelete { get; set; }
        bool btnDeleteAll { get; set; }
    }
}
