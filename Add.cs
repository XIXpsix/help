using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    public class Add : ICalculation
    {
        private double addValue;
        public Add(double addValue)
        {
            this.addValue = addValue;
        }
        public double Perform(double value)
        {
            return value + addValue;
        }
    }
}
