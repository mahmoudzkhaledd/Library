using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface AuthorInterFace
    {
        int id { get; set; }
        
        string name { get; set; }
        
        int Row { get; set; }

        int CountryIndex { get; set; }
        object CountryData { get; set; } 



        int selectedRow { get; set; }
        

        object Data { get; set; }

        string AuthorDate { get; set; }

        object btnNew { get; set; }
        object btnAdd { get; set; }
        object btnSave { get; set; }
        object btnDelete { get; set; }
        object btnDeleteAll { get; set; }


    }
}
