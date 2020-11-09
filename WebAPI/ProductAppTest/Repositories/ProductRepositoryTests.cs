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

namespace ProductAppTest.Repositories
{
   
    public class ProductRepositoryTests
    {
        private ProductRepository repository = new ProductRepository();

        [Test]
        public void Return_correct_total_number_of_products()
        {
            var products = repository.GetAllProducts();

            Assert.IsTrue(products.Count == 3);
        }

        [Test]
        public void Return_the_correct_keys_of_products()
        {
            var products = repository.GetAllProducts();

            Assert.IsTrue(products.ContainsKey("Cookies"));
            Assert.IsTrue(products.ContainsKey("Cake"));
            Assert.IsTrue(products.ContainsKey("Candy"));
        }

    }
}
