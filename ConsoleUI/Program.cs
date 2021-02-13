using System;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            int i = 1;
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(i + "->" + category.CategoryName);
                i++;
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            int i = 1;
            foreach (var item in productManager.GetAllByUnitPrice(90, 100))
            {
                Console.WriteLine(i + "->" + item.ProductName);
                i++;
            }
        }
    }
}
