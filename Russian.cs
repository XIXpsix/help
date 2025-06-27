using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Russian : Person
    {
        public Russian(string name) : base(name) { }
        public override void SayGreeting()
        {
            Console.WriteLine($"Привет, {Name}!");
        }
    }
}
