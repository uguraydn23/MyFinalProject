using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open closed principle
    // Yeni özellik eklendiği zaman , mevcut koda dokunmamalısın. Memoryden entity e geçirdik.
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(2, 100))
            {
                Console.WriteLine(product.ProductName);

            }
        }
    }
}
