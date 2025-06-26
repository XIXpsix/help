using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class InterfaceC : InterfaceA, InterfaceB
    {
        public void ShowInterfaceA()
        {
            Console.WriteLine("Реализация ShowInterfaceA");
        }

        // Реализация метода из InterfaceB
        public void ShowInterfaceB()
        {
            Console.WriteLine("Реализация ShowInterfaceB");
        }

        // Реализация собственного метода
        public void ShowInterfaceC()
        {
            Console.WriteLine("Реализация ShowInterfaceC");
        }
    }
}
