using System;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            int i = 1;
            foreach (var item in productManager.GetAllByUnitPrice(90,100))
            {
                Console.WriteLine(i+"->"+item.ProductName);
                i++;
            }
        }
    }
}
