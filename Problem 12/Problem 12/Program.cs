using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12
{
    class Program
    {
        static void Main(string[] args)
        {

            bool trianglenumber500 = false;
            int plus = 9;
            int num = 36;

            while (!trianglenumber500)
            {
                int amountofFactors = 1;
                    if (num != 1)
                    {
                        int num1 = num;
                        int x = 2;
                        List<int> factors = new List<int>();
                        for (int j = 1 ; x <= num1; j++)
                        {
                            if(num1 % x == 0)
                            {
                                num1 = num1 / x;
                                factors.Add(x);
                            }
                            else if (num1 % x != 0)
                            {
                                x = x + 1;
                            }
                        }

                        int y = 0;
                        List<int> instances = new List<int>();

                        for (int c = 0; y < factors.Count;c++)
                        {
                            int factor = factors[y];
                            
                            int totalcount = 0;
                            foreach (int p in factors)
                            {
                                int count = 0;
                                if (p == factor)
                                {
                                    count = count + 1;
                                    
                                    totalcount = totalcount + count;
                                }
                            }
                            instances.Add(totalcount);
                            y = y + totalcount;
                        }
                        
                        foreach (int p in instances)
                        {
                            amountofFactors = amountofFactors * (p + 1);
                        }
                    }
                    if (amountofFactors > 999)
                    {
                        Console.WriteLine(num);
                        Console.WriteLine(plus);
                        trianglenumber500 = true;
                    }
                else
                {
                    num = num + plus;
                    plus = plus + 1;
                }
            }
        }
    }
}
