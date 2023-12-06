using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> Intergers = new List<int>();
            int a = 0;
            for (int i = 0; i < 101; i++)
            {
                int b = a++;   
                Intergers.Add(b);
            }
            var sum1 = 0;
            foreach(int i in Intergers)
            {
                sum1 += i;
            }
            var sumsquared = sum1 * sum1;


            
            List<int> addsquare = new List<int>();
            var c = 0;
            for (int i =0; i < 101; i++)
            {
                int d = c++;
                addsquare.Add(d * d);
            }
            
            var sum2 = 0;
            foreach (int i in addsquare)
            {
                sum2 += i;
            }
            Console.WriteLine(sumsquared-sum2);
        }
    }
}
