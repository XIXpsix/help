using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Author
    {
        private string name;
        public Author(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Автор: " + name);
            Console.ResetColor();
        }
    }
}
