using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Model
{
    public class Product
    {
        public string Category { get; internal set; }
        public string SellingMode { get; internal set; }
        public decimal Price { get; internal set; }
    }
}
