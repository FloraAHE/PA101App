using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    internal class BookService : IBookService
    {
        public void ShowText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
