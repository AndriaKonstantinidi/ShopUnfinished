using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Buyer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Products> Buyerthings{ get; set; }
        public int Id { get; set; }
    }
}
