using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int categoryId);
        List<Product> GetAllByUnitPrice(decimal min, decimal max);
        List<Product> GetAllByUnitsInStock(int min, int max);
        List<ProductDetailDto> GetProductDetails();
        Product GetById(int productId);
        void Add(Product product);
    }
}
