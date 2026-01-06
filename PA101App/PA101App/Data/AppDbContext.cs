using PA101App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA101App.Data
{
    internal class AppDbContext
    {
        public Product[] GetAllProducts()
        {
            Product pr1 = new()
            {
                Id = 1,
                Name = "Iphone 15",
                Description = "Description 1",
                Price = 3000,
            };

            Product pr2 = new()
            {
                Id = 2,
                Name = "Samsung 12",
                Description = "Description 2",
                Price = 2000,
            };

            Product pr3 = new()
            {
                Id = 3,
                Name = "Nokia",
                Description = "Description 3",
                Price = 300,
            };

            Product pr4 = new()
            {
                Id = 4,
                Name = "Honor",
                Description = "Description 4",
                Price = 3400,
            };

            Product pr5 = new()
            {
                Id = 5,
                Name = "Xiomi",
                Description = "Description 5",
                Price = 700,
            };
            Product[] products = [pr1 ,pr2,pr3,pr4,pr5];
            return products;    
        }

    }
}
