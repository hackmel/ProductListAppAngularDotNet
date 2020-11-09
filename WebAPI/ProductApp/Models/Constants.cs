using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApp.Models
{
    public static class Constants
    {
        public static IDictionary<string, Product> ProductList = new Dictionary<string, Product>()
        {
            {"Cookies",
                new Product()
                    {
                        ProductId = "1",
                        Name = "Cookies",
                        Price = 200.45M,
                        Stock = 2,
                        Image = ""
                    }
            },

            {"Cake",
                new Product()
                    {
                        ProductId = "2",
                        Name = "Cake",
                        Price = 10.45M,
                        Stock = 2,
                        Image = ""
                    }
            },

            {"Candy",
                 new Product()
                    {
                        ProductId = "3",
                        Name = "Candy",
                        Price = 11.45M,
                        Stock = 3,
                        Image = ""
                    }
            },


        };
    }
}
