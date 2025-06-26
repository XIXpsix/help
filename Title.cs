using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Title
    {
        private string text;
        public Title(string text)
        {
            this.text = text;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Название: " + text);
            Console.ResetColor();
        }
    }
}
