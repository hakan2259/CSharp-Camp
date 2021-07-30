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
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 Gb Ram",UnitPrice=7000,UnitsInStock=5},
                new Product{ProductId=3,CategoryId=1,ProductName="Casper Laptop",QuantityPerUnit="8 Gb Ram",UnitPrice=4400,UnitsInStock=7},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung J5 Pro",QuantityPerUnit="2 Gb Ram",UnitPrice=1600,UnitsInStock=3},
                new Product{ProductId=5,CategoryId=2,ProductName="İphone 11",QuantityPerUnit="256 Gb İnternal Memory",UnitPrice=7500,UnitsInStock=2},

            };
            Console.WriteLine("Algorithmic---------");
            foreach (var product in products)
            {
                if(product.UnitPrice>5000 && product.UnitsInStock > 3)
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
            GetProducts(products);
            GetProductsLinq(products);
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
}
