using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace help
{
    internal class Converter
    {
        private double usdRate;
        private double eurRate;
        private double rubRate;

        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

        public double FromBYNToUSD(double byn)
        {
            return byn / usdRate;
        }

        public double FromBYNToEUR(double byn)
        {
            return byn / eurRate;
        }

        public double FromBYNToRUB(double byn)
        {
            return byn / rubRate;
        }

        public double FromUSDToBYN(double usd)
        {
            return usd * usdRate;
        }

        public double FromEURToBYN(double eur)
        {
            return eur * eurRate;
        }

        public double FromRUBToBYN(double rub)
        {
            return rub * rubRate;
        }
    }
}
