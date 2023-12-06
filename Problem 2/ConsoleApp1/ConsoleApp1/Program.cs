using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Fibonacci = new List<int>();
            var a = 0;
            var b = 1;
            Fibonacci.Add(a);
            for (int i=0; i < 50000; i++)
            {
                var c = a + b;
                if (c >= 4000000)
                {
                    break;
                }
                if ((c % 2) == 0)
                {
                    Fibonacci.Add(c);
                }
                a = b;
                b = c;
            }
            int sum = 0;
            foreach (int i in Fibonacci)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            
        }

    }
}
