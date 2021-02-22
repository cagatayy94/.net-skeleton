using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
            
        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetAll().Data;
        }
    }
}
