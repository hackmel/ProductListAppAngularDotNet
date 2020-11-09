using ProductApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ProductApp.Repositories
{
    public interface IProductRepository
    {
        public IDictionary<string,Product> GetAllProducts();
    }


    public class ProductRepository : IProductRepository
    {
  
        public IDictionary<string,Product> GetAllProducts() =>  Constants.ProductList;
        
    }
}