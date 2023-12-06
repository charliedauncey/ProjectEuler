using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_3
//Takes about 30 mins 
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 600851475143;

            var rootn = Math.Sqrt(n);
            var a = 0;
            List<int> Factors = new List<int>();
            List<int> AllNumbers = new List<int>();
            for (int i = 0; i < rootn; i++)
            {
                int b = a++;
                AllNumbers.Add(b);
            }

            var c = 2;
            for (int i = 0; i <= rootn; i++)
            {
                int d = c;
                if ((n % d) == 0)
                {
                    int Multiple = 2;
                    for (int x = 0; x <= rootn; x++)
                    {
                        int factors = d * Multiple; 
                        AllNumbers.Remove(factors);
                        ++Multiple;
                        if (x > (n / d))
                        {
                            break;
                        }
                    }
                }
                else
                {
                    AllNumbers.Remove(d);
                }
                c = ++d;
            }
                AllNumbers.ForEach(Console.WriteLine);
            Console.ReadLine();
            
        }
    }
}
