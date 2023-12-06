using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Divisors d = new Divisors();

            int sumAmicableNumbs = 0;


            for (int i = 1; i <= 10000; i++)
            {
                List<int> divisorsFirst = d.FindDivisors(i);

                int sumFirst = sumList(divisorsFirst);

                List<int> divisorsSecond = d.FindDivisors(sumFirst);

                int sumSecond = sumList(divisorsSecond);

                if (i == sumSecond & i != sumFirst)
                {
                    sumAmicableNumbs = i + sumAmicableNumbs;
                }

            }

            Console.WriteLine(sumAmicableNumbs);
        }

        public static int sumList(List<int> list)
        {
            int sum = 0;

            foreach (int div in list)
            {
                sum = sum + div;
            }

            return sum;
        }
    }
}
