using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
        List<Product> GetAllByUnitsInStock(int min, int max);
    }
}
