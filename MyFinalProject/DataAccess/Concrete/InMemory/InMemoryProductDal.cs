using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product>
            {
                new Product{
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Fincan",
                    UnitsInStock=15,
                    UnitPrice=75
                },
                new Product{
                    ProductId=2,
                    CategoryId=1,
                    ProductName="Bardak",
                    UnitsInStock=10,
                    UnitPrice=20
                },
                new Product{
                    ProductId=3,
                    CategoryId=2,
                    ProductName="Laptop",
                    UnitsInStock=3,
                    UnitPrice=3999
                },
                   new Product{
                    ProductId=4,
                    CategoryId=2,
                    ProductName="Phone",
                    UnitsInStock=5,
                    UnitPrice=7500
                },
                    new Product{
                    ProductId=5,
                    CategoryId=2,
                    ProductName="Klavye",
                    UnitsInStock=20,
                    UnitPrice=50
                },

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }
        //LINQ - Language Integrated Query
        //Lambda
        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId==product.ProductId);
            _products.Remove(productToDelete);

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
