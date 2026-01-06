using C_MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C_MyApp.Data
{
    internal class AppDbContext
    {
        public Product[] GetAllProducts()
        {
            Product product = new()
            {
                Id = 1,
                Name = "Iphon 15",


            };
        }
            



         
    }
}
