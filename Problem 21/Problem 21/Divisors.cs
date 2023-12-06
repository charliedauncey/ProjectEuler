using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_21
{
    class Divisors
    {
        public List<int> FindDivisors(int number)
        {
            List<int> divisors = new List<int>();

            int temp = 1;

            while (temp < number)
            {
                if (number % temp == 0)
                {
                    divisors.Add(temp);
                }

                temp++;
            }

            return divisors;
        }
    }
}
