using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Printer
    {
        public static void Print(string stroka, int color)
        {
            if (Enum.IsDefined(typeof(MyColor), color))
                Console.ForegroundColor = (ConsoleColor)color;
            else
                Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
