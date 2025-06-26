using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Person[] people = {
                new Russian("Иван"),
                new Ukrainian("Олег"),
                new American("John"),
                new Turkish("Ahmet")
            };

            foreach (var p in people)
                p.SayGreeting();
        }
    }
}
