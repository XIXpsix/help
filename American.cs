using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class American : Person
    {
        public American(string name) : base(name) { }

        public override void SayGreeting()
        {
            Console.WriteLine($"Hi, {Name}!");
        }
    }
}
