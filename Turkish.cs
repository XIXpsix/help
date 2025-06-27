using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Turkish : Person
    {
        public Turkish(string name) : base(name) { }
        public override void SayGreeting()
        {
            Console.WriteLine($"Merhaba, {Name}!");
        }
    }
}
