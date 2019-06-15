using SpecificationPattern.Interface;
using SpecificationPattern.Model;

namespace SpecificationPattern.Specification
{
    public class ProductSellingMode : ISpecification<Product>
    {
        public ProductSellingMode(string sellingMode)
        {
            this.SellingMode = sellingMode;
        }

        public string SellingMode { get; set; }

        public bool IsSatisfiedBy(Product item) => item.SellingMode == this.SellingMode;
    }
}
