using Business.Services.Abstracts;
using Core.Model;
using Core.RepAbstracts;
using Data.RepositoryConcretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class ProductService: IModelService<Product>
    {
        IModelRepository<Product> _productRepository = new ProductRepository();
        public void AddModel(Product product)
        {
            string command = $"Insert Into Products (Title,Description,Price,CategoryId) values ('{product.Title}','{product.Description}',{product.Price},{product.CategoryId})";
            _productRepository.Add(command);
        }

        public void DeleteModel(int id)
        {
            string command = $"DELETE FROM Products WHERE Id = {id}";
            _productRepository.Delete(command);
        }

        public List<Product> GetAllModels()
        {
            string command = "SELECT * FROM Products";
            return _productRepository.GetAll(command);
        }

        public Product GetModel(int id)
        {
            string command = $"SELECT * FROM Products WHERE Id = {id}";
            return _productRepository.Get(command);
        }

        public void UpdateModel(int id, Product newProduct)
        {
            string command = $"SELECT * FROM Products WHERE Id = {id}";
            Product product = _productRepository.Get(command);

            if (product == null) throw new NullReferenceException();

            product.Title = newProduct.Title;
            product.Description = newProduct.Description;
            product.Price = newProduct.Price;
            product.CategoryId = newProduct.CategoryId;

            string updateCommand = $"UPDATE Products SET Name = '{product.Title}', Description = '{product.Description}',Price ={product.Price},CategoryId={product.CategoryId} WHERE Id = {id}";
            _productRepository.Update(updateCommand);
        }
    }
}
