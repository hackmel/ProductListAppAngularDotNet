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
                        Image = "https://www.handletheheat.com/wp-content/uploads/2018/02/BAKERY-STYLE-CHOCOLATE-CHIP-COOKIES-9.jpg" 
                    }
            },

            {"Cake",
                new Product()
                    {
                        ProductId = "2",
                        Name = "Cake",
                        Price = 10.45M,
                        Stock = 2,
                        Image = "https://www.cakewarehouse.co.nz/image/cache/catalog/frozengroup-1000x1000h.jpg"
                    }
            },

            {"Candy",
                 new Product()
                    {
                        ProductId = "3",
                        Name = "Candy",
                        Price = 11.45M,
                        Stock = 3,
                        Image = "https://st.depositphotos.com/1064024/3289/i/950/depositphotos_32891271-stock-photo-mixed-colorful-fruit-bonbon.jpg"
                    }
            },


        };
    }
}
