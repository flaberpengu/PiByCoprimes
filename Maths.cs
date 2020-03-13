using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiByCoprimes
{
    class Maths
    {
        public ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public decimal GetPi(long coprimes, long iterations)
        {
            decimal coDivIt = (decimal)coprimes / (decimal)iterations;
            //Console.WriteLine($"coprimes: {coprimes}, iterations: {iterations}, co/it: {coDivIt}");
            //Console.ReadLine();
            decimal pi = (decimal)Math.Sqrt((6 / (double)coDivIt));
            return pi;
        }

        public double GetPercentDifference(double actualPiDbl, decimal estimatedPi)
        {
            decimal actualPiDcm = (decimal)actualPiDbl;
            decimal difference;
            if (estimatedPi < actualPiDcm)
            {
                difference = actualPiDcm - estimatedPi;
            }
            else
            {
                difference = estimatedPi - actualPiDcm;
            }
            double percentageDifference = ((double)difference / actualPiDbl);
            return percentageDifference;
        }
    }
}
