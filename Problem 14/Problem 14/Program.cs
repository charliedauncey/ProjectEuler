using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 1000000;

            List<int> chainLength = new List<int>();
            List<int> chainValue = new List<int>();

            chainLength.Add(1);
            chainValue.Add(1);
            for(int i=13; i<=Max; i++)
            {
                long x = i;
                int counter = 1;
                while (x != 1)
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

                if (chainLength.Max() < counter)
                {
                    chainLength.Remove(chainLength.Max());
                    chainValue.Remove(chainValue.Max());

                    chainLength.Add(counter);
                    chainValue.Add(i);
                }

                //Chain.Add(i, counter);
            }

            Console.WriteLine("Number with longest chain = " + chainValue.Max());
            Console.WriteLine("How long is the chain = " + chainLength.Max());
            
            
            //int longestChain = Chain.Values.Max();
            //int key = KeyByValue(Chain, longestChain);

        }
        
    }
}
