using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            MyClass classObj = new MyClass();
            MyStruct structObj = new MyStruct();

            classObj.change = "не изменено";
            structObj.change = "не изменено";

            ClassTaker(classObj);
            StruktTaker(structObj);

            Console.WriteLine("classObj.change = {0}", classObj.change);   // изменено
            Console.WriteLine("structObj.change = {0}", structObj.change); // не изменено
        }
    }
}
