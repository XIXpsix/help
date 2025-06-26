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

            Tour t = new Tour();
            t.TourCalc();
            t.TourCalc("Италия");
            t.TourCalc("Испания", 7);
        }
    }
}
