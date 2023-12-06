using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 1000000;
            
            Dictionary<int, int> chains = new Dictionary<int, int>();
            
            
            for (int i = 1; i <= Max; i++)
            {
                long x = i;
                int counter = 0;
                bool t = true;
                int newLength = 0;
                while (x != 1 && t)
                {
                    if (x>=i)
                    {
                        if (x % 2 == 0)
                        {
                            x = x / 2;
                            counter = counter + 1;
                        }
                        else
                        {
                            x = 3 * x + 1;
                            counter = counter + 1;
                        }
                    }
                    else if (x<i)
                    {
                        int y = Convert.ToInt32(x);
                        newLength = chains[y] + counter;
                        t = false;
                    }
                }
                if (newLength != 0)
                {
                    chains.Add(i, newLength);
                }
                else
                {
                    chains.Add(i, counter);
                }
            }
            
            int largestValue = chains.Values.Max();
            var myKey = chains.FirstOrDefault(x => x.Value == largestValue).Key;

            Console.WriteLine("Number with longest chain = " + largestValue);
            Console.WriteLine("How long is the chain = " + myKey);
        }

    }
}
