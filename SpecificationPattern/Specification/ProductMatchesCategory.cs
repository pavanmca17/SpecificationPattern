using SpecificationPattern.Interface;
using SpecificationPattern.Model;

namespace SpecificationPattern.Specification
{
    public class ProductCategory : ISpecification<Product>
    {
        public ProductCategory(string category)
        {
            this.Category = category;
        }

        public string Category { get; set; }        

        public bool IsSatisfiedBy(Product item) => item.Category == this.Category;
    }
}
