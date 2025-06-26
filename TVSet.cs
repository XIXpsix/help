using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class TVSet : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включён.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен.");
        }
    }
}
