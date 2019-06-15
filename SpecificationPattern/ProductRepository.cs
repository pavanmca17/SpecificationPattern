using SpecificationPattern.Interface;
using SpecificationPattern.Model;
using System.Collections.Generic;


namespace SpecificationPattern
{
    public class ProductRepository
    {
        private static List<Product> _items = new List<Product>();

        static ProductRepository()
        {
            _items = new List<Product>() { new Product() { Category="New", Price = 100, SellingMode="OnLine" },
                                           new Product() { Category="Old", Price= 150,SellingMode="OnLine" },
                                           new Product() { Category="Old", Price= 75,SellingMode="Store" },
                                           new Product() { Category="Old", Price= 50, SellingMode="Store" },
                                           new Product() { Category="New" , Price =300,SellingMode="Store" }
                                         };
        }
        

        public IEnumerable<Product> GetProducts(ISpecification<Product> specification)
        {
            bool spec = false;
            foreach (var product in _items)
            {
                spec = specification.IsSatisfiedBy(product);
                if (spec)
                {  yield return product;
                }
            }
                
        }
    }
}
