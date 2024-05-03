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
    public class CategoryService : IModelService<Category>
    {
        IModelRepository<Category> _categoryRepository = new CategoryRepository();
        public void AddModel(Category category)
        {
            string command = $"Insert Into Categories (Name) values ('{category.Name}')";
            _categoryRepository.Add(command);
        }

        public void DeleteModel(int id)
        {
            string command = $"DELETE FROM Categories WHERE Id = {id}";
            _categoryRepository.Delete(command);
        }

        public List<Category> GetAllModels()
        {
            string command = "SELECT * FROM Categories";
            return _categoryRepository.GetAll(command);
        }

        public Category GetModel(int id)
        {
            string command = $"SELECT * FROM Categories WHERE Id = {id}";
            return _categoryRepository.Get(command);
        }

        public void UpdateModel(int id, Category newCategory)
        {
            string command = $"SELECT * FROM Categories WHERE Id = {id}";
            Category category = _categoryRepository.Get(command);

            if (category == null) throw new NullReferenceException();

            category.Name = newCategory.Name;

            string updateCommand = $"UPDATE Categories SET Name = '{category.Name}' WHERE Id = {id}";
            _categoryRepository.Update(updateCommand);
        }
    }
}
