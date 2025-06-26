using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class MyClass : IMyInterface
    {
        public double GetPi()
        {
            return Math.PI;
        }

        public int GetInt()
        {
            return 25;
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
