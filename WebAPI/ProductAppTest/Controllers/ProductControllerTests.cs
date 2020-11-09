using NUnit.Framework;
using ProductApp.Repositories;
using Moq;
using System.Collections.Generic;
using ProductApp.Models;
using ProductApp.Services;
using System.Threading.Tasks;
using System;
using Castle.Core.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = NUnit.Framework.Assert;
using ProductApp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace ProductAppTest.Controllers
{
    class ProductControllerTests
    {
        private Mock<IProductService> service = new Mock<IProductService>();
        private ProductsController controller;

        [SetUp]
        public void Setup()
        {
            service.Setup(x => x.GetAllProducts()).Returns(Constants.ProductList);
            controller = new ProductsController(service.Object);

        }

        [Test]
        public void Return_success()
        {
            var result = controller.Get();

            var response = (OkObjectResult)result;
            var value = (ResponseDto)response.Value;


            Assert.IsTrue(value.Status == Status.Success);
        }

        [Test]
        public void Return_OK_reponse()
        {
            var result = controller.Get();
            
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public void Return_correct_total_number_of_products()
        {
            var result = controller.Get();

            var response = (OkObjectResult)result;
            var value = (ResponseDto)response.Value;

            Assert.IsTrue(value.Products.Count == 3);
        }

        [Test]
        public void Return_not_found_response()
        {
            service.Setup(x => x.GetAllProducts()).Returns(new Dictionary<string,Product>());
            var result = controller.Get();

            Assert.IsInstanceOf<NotFoundResult>(result);
        }

    }
}
