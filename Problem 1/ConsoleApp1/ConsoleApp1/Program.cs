using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            List<int> List = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                var n = i * 3;
                if (n >= 1000)
                {
                    break;
                }
                List.Add(n);
            }

            for (var i = 0; i < 1000; i++)
            {
                var m = i * 5;
                if (m >= 1000)
                {
                    break;
                }
                
                List.Add(m);
            }

            List<int> distinct = List.Distinct().ToList();

            foreach (int i in distinct)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
