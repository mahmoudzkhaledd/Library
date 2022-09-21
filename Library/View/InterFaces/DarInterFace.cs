using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface DarInterFace
    {
        int id { get; set; }
        string name { get; set; }

        object DataGridDataSource { get; set; }

        object cmbDataSource { get; set; }

        int SelectedCountryValue { get; set; }

        int SelectedDataGridRow { get; set; }

        int CurrentRow { set; get; }

        object btnNew { get; set; }
        object btnAdd { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }

        object btnArrowLeft { get; set; }
        object btnArrowRight { get; set; }
        object btnDoubleArrowLeft { get; set; }
        object btnDoubleArrowRight { get; set; }


    }
}
