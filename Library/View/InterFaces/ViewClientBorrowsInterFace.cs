using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface ViewClientBorrowsInterFace
    {
        int id { get; set; }
        string name { get; set; }
        string phone_1 { get; set; }
        string phone_2 { get; set; }

        int BorrowID { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        string Note { get; set; }
        int BooksNumber { get; set; }
        int BookID { get; set; }

        object BooksDataSource { get; set; }
        object dataSource { get; set; }
        bool btnSave { get; set; }
        bool btnDelete { get; set; }
        bool btnDeleteAll { get; set; }
        DataGridViewRow CurrentRow { get; set; }
        int SelectedIndex { get; set; }
        int SelectedRow { get; set; }
        int RowCount { get; set; }
        
    }
}
