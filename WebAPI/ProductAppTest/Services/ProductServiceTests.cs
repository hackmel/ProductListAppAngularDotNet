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

namespace ProductAppTest
{
    public class ProductServiceTests
    {

        private Mock<IProductRepository> repository = new Mock<IProductRepository>();
        private ProductService service;

        [SetUp]
        public void Setup()
        {
            repository.Setup(x => x.GetAllProducts()).Returns(Constants.ProductList);

            service = new ProductService(repository.Object);

        }

        [Test]
        public void Return_correct_total_number_of_products()
        {
            var products =  service.GetAllProducts();

            Assert.IsTrue(products.Count == 3);
        }

        [Test]
        public void Return_the_correct_keys_of_products()
        {
            var products = service.GetAllProducts();

            Assert.IsTrue(products.ContainsKey("Cookies"));
            Assert.IsTrue(products.ContainsKey("Cake"));
            Assert.IsTrue(products.ContainsKey("Candy"));
        }

        [Test]
        public void Retuns_an_empty_data()
        {
            repository.Setup(x => x.GetAllProducts()).Returns(new Dictionary<string, Product>());
            var products = service.GetAllProducts();

            Assert.IsTrue(products.IsNullOrEmpty());
           
        }

    }
}