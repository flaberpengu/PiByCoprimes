using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiByCoprimes
{
    class Program
    {
        static void Main(string[] args)
        {
            double actualPi = Math.PI; 
            Maths math = new Maths();
            Random rnd = new Random();
            RandomExtMethods rem = new RandomExtMethods();
            long maxNum = 1000000000000;
            long iterations = 5000000000;
            int times = 1;
            long coprimes;
            long firstNum;
            long secondNum;
            decimal pi;
            for (int j = 0; j < times; j++)
            {
                coprimes = 0;
                for (long i = 0; i < iterations; i++)
                {
                    firstNum = rem.NextLong(rnd, 1, maxNum);
                    secondNum = rem.NextLong(rnd, 1, maxNum);
                    if (math.GCD((ulong)firstNum, (ulong)secondNum) == 1)
                    {
                        coprimes++;
                    }
                    if (i % 1000000 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                pi = math.GetPi(coprimes, iterations);
                Console.WriteLine(pi);
                double percentageDifference = (math.GetPercentDifference(actualPi, pi))*100;
                Console.WriteLine(percentageDifference);
            }
            Console.ReadLine();
        }
    }
}
