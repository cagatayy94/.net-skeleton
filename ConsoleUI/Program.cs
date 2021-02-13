using System;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

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
