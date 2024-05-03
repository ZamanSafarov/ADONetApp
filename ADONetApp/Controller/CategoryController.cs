using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONetApp.Controller
{
    public class CategoryController
    {
        IModelService<Category> _categoryService = new CategoryService();


        public void AddCategory()
        {
            Console.WriteLine("Enter Category Name: ");
            string name = Console.ReadLine();

            Category category = new Category()
            {
                Name = name
            };

            _categoryService.AddModel(category);
        }

        public void DeleteCategory()
        {
            Console.WriteLine("Enter Category id: ");
            int id = int.Parse(Console.ReadLine());

            _categoryService.DeleteModel(id);
        }

        public void UpdateCategory()
        {
            GetAllCategories();
            Console.WriteLine("Enter Category id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category Name: ");
            string name = Console.ReadLine();

            Category newcategory = new Category()
            {
                Name = name
            };

            _categoryService.UpdateModel(id, newcategory);
        }

        public void GetAllCategories()
        {
            foreach (var item in _categoryService.GetAllModels())
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        public void GetCategory()
        {
            Console.WriteLine("Enter Category id: ");
            int id = int.Parse(Console.ReadLine());

            Category category = _categoryService.GetModel(id);

            Console.WriteLine($"{category.Name}");
        }
    }
}
