using System.Collections.Generic;
using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Bussiness.Concrete
{
    public class ProductManager:IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //rules
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAllByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<Product> GetAllByUnitsInStock(int min, int max)
        {
            return _productDal.GetAll(p => p.UnitsInStock >= min && p.UnitsInStock <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
