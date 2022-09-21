using Library.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Library.View.InterFaces
{
    public interface BorrowBookInterFace
    {
        int id { set; get; }
        int BorrowerID { set; get; }
        string StartDate { set; get; }
        string EndDate { set; get; }
        string Note { set; get; }
        int RowCount { set; get; }
        bool btnBorrowEnabled { set; get; }
        decimal price { set; get; }
        decimal TotalRowPrice { set; get; }
        bool ShowUnAvailable { set; get; }
        int cmbBorrowersSelectedValue { set; get; }
        object cmbBorrowersDataSource { set; get; }
        object DataGridDataSource { set; get; }
        DataGridViewRow GetRow(int id);
    }
}
