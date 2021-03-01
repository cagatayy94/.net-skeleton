using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();
            DtoTest();

        }

        private static void DtoTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            int i = 1;
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(i + "->" + product.ProductName + " / " + product.CategoryName);
                i++;
            }
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
            foreach (var item in productManager.GetAllByUnitPrice(90, 100).Data)
            {
                Console.WriteLine(i + "->" + item.ProductName);
                i++;
            }
        }
    }
}
