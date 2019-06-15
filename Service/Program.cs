using FluentDemo;
using SpecificationPattern;
using SpecificationPattern.Interface;
using SpecificationPattern.Model;
using SpecificationPattern.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
           var result =  Calculator.WithValue(10).Subtract(1);
           Console.WriteLine($"Result of Subtract Opeartion {result.Result()}");
           result = Calculator.WithValue(10).Add(1);
           Console.WriteLine($"Result of Add Opeartion {result.Result()}");
           result = Calculator.WithValue(10).Multiple(5);
           Console.WriteLine($"Result of Multiple Opeartion {result.Result()}");
           ProductSpecifications();
           Console.ReadLine();
        }

        private static void ProductSpecifications()
        {
            var repo = new ProductRepository();
            var newproductCategory = new ProductCategory("New");
            var oldproductCategory = new ProductCategory("Old");
            var productSellingMode = new ProductSellingMode("OnLine");
            var lowproductPriceInRange = new ProductPriceInRange(0,50);
            var mediumproductPriceInRange = new ProductPriceInRange(50, 100);
            var highproductPriceInRange = new ProductPriceInRange(100, 200);

            Console.WriteLine(Environment.NewLine);

            var newproducts = repo.GetProducts(newproductCategory).ToList();

            Console.WriteLine("Displaying New Products");

            for(int i = 0; i < newproducts.Count(); i++)
            {
                Console.WriteLine($"Category - {newproducts[i].Category} and Price -{newproducts[i].Price}");
            }

            Console.WriteLine(Environment.NewLine);

            var oldproducts = repo.GetProducts(oldproductCategory).ToList();

            Console.WriteLine("Displaying Old Products");

            for (int i = 0; i < oldproducts.Count(); i++)
            {
                Console.WriteLine($"Category - {oldproducts[i].Category} and Price -{oldproducts[i].Price}");
            }

            Console.WriteLine(Environment.NewLine);

            AndSpecification<Product> productsSpecifications = new AndSpecification<Product>();
            productsSpecifications.Left = oldproductCategory;
            productsSpecifications.Right = lowproductPriceInRange;               
            var oldlowcostproducts = repo.GetProducts(productsSpecifications).ToList();
            Console.WriteLine("Displaying Old Low Cost Products");

            for (int i = 0; i < oldlowcostproducts.Count(); i++)
            {
                Console.WriteLine($"Category - {oldlowcostproducts[i].Category} and Price -{oldlowcostproducts[i].Price}");
            }

            Console.WriteLine(Environment.NewLine);

            NotSpecification<Product> notSpecifications = new NotSpecification<Product>();
            notSpecifications.Specification = productSellingMode;           
            var nononlineproducts = repo.GetProducts(notSpecifications).ToList();
            Console.WriteLine("Displaying Non-online Products");

            for (int i = 0; i < nononlineproducts.Count(); i++)
            {
                Console.WriteLine($"Category - {nononlineproducts[i].Category} and Price -{nononlineproducts[i].Price} and {nononlineproducts[i].SellingMode}");
            }

            Console.WriteLine(Environment.NewLine);
        }
    }
}
