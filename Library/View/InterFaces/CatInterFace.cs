using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface CatInterFace
    {
        int id { get; set; }
        int Row { get; set; }
        string name { get; set; }
        object Data { get; set; }

        int selectedRow { get; set; }
        object btnNew { get; set; }
        object btnAdd { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }
    }
}
