using System;
using System.Collections.Generic;
using Core.Utilities.Results;
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
        IResult Add(Product product);
    }
}
