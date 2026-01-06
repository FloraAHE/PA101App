using PA101App.Data;
using PA101App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PA101App.Controllers
{
    internal class ProductControllers
    {
        private readonly AppDbContext _context;
        public ProductControllers()
        {
            _context = new AppDbContext();
        }
        public void ShowDatas()
        {
            Product[] products = _context.GetAllProducts();
            ShowItems(products);
            
        }
        public void SearchByName()
        {
            Product[] products = _context.GetAllProducts();

            Console.WriteLine("Add search text");
            string searcText = Console.ReadLine();

            if (string.IsNullOrEmpty(searcText))
            {
                ShowItems(products);
            }
            var searchedPoducts = Array.FindAll(products, m=>m.Name.Trim().Contains(searcText.Trim() ,StringComparison.OrdinalIgnoreCase));
            ShowItems(searchedPoducts);
        }
        public void ShowById()
        {
            Product[] products = _context.GetAllProducts();
            Console.WriteLine("Add product id");

        Id: string idStr = Console.ReadLine();

            if (string.IsNullOrEmpty(idStr))
            {
                Console.WriteLine("Cant be empty");
                goto Id;
            }
            int id = int .Parse(idStr);
            Product product = Array.Find(products, m => m.Id == id);
            if(product is null)
            {
                Console.WriteLine("Product is not found");
                goto Id;
            }
            string data = $"{product.Id} - {product.Name} - {product.Description} {product.Price}";
            Console.WriteLine(data);
        }

        public void SortByPrice()
        {
            Product[] products = _context.GetAllProducts();
            Console.WriteLine("Ad sort text ( asc/desc )");

            string sortText = Console.ReadLine();

            
            switch (sortText)
            {
                case "asc":
                    Array.Sort(products, (a, b) => a.Price.CompareTo(b.Price));
                    ShowItems(products);
                    break;
                case "desc":
                    Array.Sort(products, (a, b) => b.Price.CompareTo(a.Price));
                    ShowItems(products);
                    break;
                default:
                    ShowItems(products);
                    break;
            }
          
        }
        public void ShowSumOfPrice()
        {
            Product[] products = _context.GetAllProducts();
            double sum = 0;
            for (int i = 0; i < products.Length; i++)
            {
                sum += products[i].Price;

                Console.WriteLine(sum);
            }

        }
        public void ShowCount()
        {
            Product[] products = _context.GetAllProducts();
            Console.WriteLine(products.Length);
        }
        private void ShowItems(Product[] datas)
        {
            foreach (var item in datas)
            {
                string data = $"{item.Id} - {item.Name} - {item.Description} {item.Price}";
                Console.WriteLine(data);
            }
            return;
        }

    }
}
