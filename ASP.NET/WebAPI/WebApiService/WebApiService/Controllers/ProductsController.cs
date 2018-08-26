using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiService.Models;

namespace WebApiService.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product{ProductId=1, ProductName="Product 1", ProductCategory="Category 1", Price=120},
            new Product{ProductId=2, ProductName="Product 2", ProductCategory="Category 1", Price=100},
            new Product{ProductId=3, ProductName="Product 3", ProductCategory="Category 2", Price=100},
            new Product{ProductId=4, ProductName="Product 4", ProductCategory="Category 3", Price=150},
            new Product{ProductId=5, ProductName="Product 5", ProductCategory="Category 2", Price=90}
        };

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProduct(int id)
        {
            var product = products.ToList().FirstOrDefault(prod => prod.ProductId == id);
            return product;
        }

        public void DeleteProduct(int id)
        {
            Product[] updatedProducts = new Product[products.Length - 1];
            var current = 0;
            for (var index = 0; index < products.Length; index++)
            {
                var product = products[index];
                if(product.ProductId!=id)
                {
                    updatedProducts[current] = product;
                    current++;
                }
            }
            products = updatedProducts;
        }
    }
}
