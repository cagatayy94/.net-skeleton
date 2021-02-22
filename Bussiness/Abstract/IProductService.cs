using System;
using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussiness.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetAllByUnitsInStock(int min, int max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
    }
}
