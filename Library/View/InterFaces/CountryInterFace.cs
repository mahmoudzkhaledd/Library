using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Library.View.InterFaces
{
    public interface CountryInterFace
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
