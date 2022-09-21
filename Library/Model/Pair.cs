using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }
       public Pair(int First ,int Second) { this.First = First;this.Second = Second; }
        public Pair() { }
    }
}
