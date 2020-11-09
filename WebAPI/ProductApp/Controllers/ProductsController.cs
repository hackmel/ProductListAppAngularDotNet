using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using ProductApp.Services;

namespace ProductApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService services;

        public ProductsController(IProductService ProductsServices)
        {
            this.services = ProductsServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var product = services.GetAllProducts();
            if (product == null || product.Count == 0)
                return NotFound();

            return Ok(new ResponseDto() { 
                Products = product.Values.ToList<Product>()
            });
        }
    }
}
