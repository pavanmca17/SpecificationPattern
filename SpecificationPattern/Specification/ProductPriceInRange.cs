using SpecificationPattern.Interface;
using SpecificationPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specification
{
    public class ProductPriceInRange : ISpecification<Product>
    {
        public decimal LowerBound { get; set; }
        public decimal UpperBound { get; set; }
        public ProductPriceInRange(decimal lowerBound, decimal upperBound)
        {
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
        }
        public bool IsSatisfiedBy(Product item) => (item.Price >= LowerBound) && (item.Price <= UpperBound);
    }
}
