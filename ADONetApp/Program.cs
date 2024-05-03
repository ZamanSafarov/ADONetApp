using ADONetApp.Controller;

namespace ADONetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoryController categoryController = new CategoryController();
            ProductController productController = new ProductController();
            productController.AddProduct();

        }
    }
}
