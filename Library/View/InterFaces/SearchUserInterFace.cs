using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface SearchUserInterFace
    {
        object dgvDataSource { get; set; }
        Dictionary<string, string> Filters { get; set; }
    }
}
