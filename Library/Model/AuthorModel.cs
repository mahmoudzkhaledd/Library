using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public int countryIndex { get; set; }
    }
}
