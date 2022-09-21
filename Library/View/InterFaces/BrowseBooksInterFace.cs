using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface BrowseBooksInterFace
    {
        object DataGridDataSource { get; set; }
        bool All { get; set; }
        bool ID { get; set; }
        bool name { get; set; }
        bool Cat { get; set; }
        bool Dar { get; set; }
        bool Country { get; set; }
        bool Author { get; set; }
        bool Place { get; set; }
        bool subCat { get; set; }
        bool Date { get; set; }

        object CatDataSource { get; set; }
        object DarDataSource { get; set; }
        object CountryDataSource { get; set; }
        object AuthorDataSource { get; set; }
        object PlaceDataSource { get; set; }


        int CatSelectedValue { get; set; }
        int DarSelectedValue { get; set; }
        int CountrySelectedValue { get; set; }
        int AuthorSelectedValue { get; set; }
        int PlaceSelectedValue { get; set; }
        int SelectedBookId { get; set; }
        string SelectedBookName { get; set; }
        string SelectedsubCat { get; set; }
        string SelectedDate { get; set; }
    }
}
