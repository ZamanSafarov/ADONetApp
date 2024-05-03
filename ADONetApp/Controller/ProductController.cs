using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetApp.Controller
{
    public class ProductController
    {
        IModelService<Product> _productService = new ProductService();

        public void AddProduct()
        {
            Console.WriteLine("Enter Product Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Product Description: ");
            string desc = Console.ReadLine();

            Console.WriteLine("Enter Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product CategoryId: ");
            int categoryId = int.Parse(Console.ReadLine());

            Product product = new Product()
            {
                Title = title,
                Description = desc,
                Price = price,
                CategoryId = categoryId,
            };

            _productService.AddModel(product);
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter Product id: ");
            int id = int.Parse(Console.ReadLine());

            _productService.DeleteModel(id);
        }

        public void UpdateProduct()
        {
            GetAllProducts();
            Console.WriteLine("Enter Product id: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Product Description: ");
            string desc = Console.ReadLine();

            Console.WriteLine("Enter Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product CategoryId: ");
            int categoryId = int.Parse(Console.ReadLine());

            Product newStudent = new Product()
            {
                Title = title,
                Description = desc,
                Price = price,
                CategoryId = categoryId,
            };

            _productService.UpdateModel(id, newStudent);
        }

        public void GetAllProducts()
        {
            foreach (var item in _productService.GetAllModels())
            {
                Console.WriteLine($"{item.Title} - {item.Description} - {item.Price} - {item.CategoryId}");
            }
        }

        public void GetProduct()
        {
            Console.WriteLine("Enter Product id: ");
            int id = int.Parse(Console.ReadLine());

            Product product = _productService.GetModel(id);

            Console.WriteLine($"{product.Title} - {product.Description} - {product.Price} - {product.CategoryId}");
        }
    }
}
