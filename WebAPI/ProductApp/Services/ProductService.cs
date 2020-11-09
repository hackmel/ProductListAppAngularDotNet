using ProductApp.Models;
using ProductApp.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductApp.Services
{

    public interface IProductService
    {

        IDictionary<string, Product> GetAllProducts();
    }

    public class ProductService: IProductService
    {
        private IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public IDictionary<string,Product> GetAllProducts() => this.repository.GetAllProducts();
        
    }
}