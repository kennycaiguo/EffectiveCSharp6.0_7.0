using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortFilteredData
{
    public class Product
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return $"{{ Name={Name}, UnitsInStock={UnitsInStock} }}";
        }
    }
}
