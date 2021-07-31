using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Computer"},
                new Category{CategoryId=2,CategoryName="Phone"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 Gb Ram",UnitPrice=12000,UnitsInStock=4},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 Gb Ram",UnitPrice=12000,UnitsInStock=5},
                new Product{ProductId=3,CategoryId=1,ProductName="Casper Laptop",QuantityPerUnit="8 Gb Ram",UnitPrice=4400,UnitsInStock=7},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung J5 Pro",QuantityPerUnit="2 Gb Ram",UnitPrice=1600,UnitsInStock=3},
                new Product{ProductId=5,CategoryId=2,ProductName="İphone 11",QuantityPerUnit="256 Gb İnternal Memory",UnitPrice=7500,UnitsInStock=2},

            };
            //Test(products);
            //GetProducts(products);
            //GetProductsLinq(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);
            //ClassicLinqTest(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice>5500 orderby p.UnitPrice 
                         select new ProductDto 
                         { ProductId = p.ProductId, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var productDto in result)
            {
                Console.WriteLine("Product Name => " + productDto.ProductName + " Category Name => " + productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName descending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            //Single Line Query
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algorithmic---------");
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }
            Console.WriteLine("Linq--------------");
            var result = products.Where(p => p.UnitPrice > 3000 && p.UnitsInStock > 3);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if(product.UnitPrice>5000 && product.UnitsInStock > 5)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000).ToList();
        }
        
       
    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
