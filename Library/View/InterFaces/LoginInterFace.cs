using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.View.InterFaces
{
    public interface LoginInterFace
    {
         string userName { set; get; }
         string Password { set; get; }
         bool Remember { set; get; }
         bool Show { set; get; }
    }
}
