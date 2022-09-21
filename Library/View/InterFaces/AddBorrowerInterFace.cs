using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface AddBorrowerInterFace
    {
        int id { get; set; }

        string name { get; set; }
        string phone_1 { get; set; }
        string phone_2 { get; set; }


        bool btnNew { get; set; }
        bool btnAdd { get; set; }
        bool btnSave { get; set; }
        bool btnDelete { get; set; }
        bool btnDeleteAll { get; set; }


        object DataGridDataSource { get; set; }
        int SelectedIndex { get; set; }
        int SelectedRow { get; set; }
        int ItemsCount { get; set; }


    }
}
