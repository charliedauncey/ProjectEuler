using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_7
{
    class Program
    {
         static void Main(string[] args)
         {
                    var n = 200000000;
                    //List<long> AllNumbers = new List<long>();
                    //var a = 21;

                    //for (var i = 1; i <= n; i++)
                    //{
                    //    var b = a++;
                    //    AllNumbers.Add(b);
                    //}
                    List<int> Primes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19 };


                    for (int i=21; i<=n; i+= 2)
                    {

                        bool isPrime = false;
                        int index = 0;
                        while (!isPrime && index < Primes.Count && Primes[index] <= Math.Sqrt(i))
                        {
                            if (i % Primes[index] == 0)
                            {
                                isPrime = true;
                            }
                            else
                            {
                                index += 1;
                            }
                        }
                        if (isPrime == false)
                        {
                            Primes.Add(i);
                        }

                    }
                    
                    Console.WriteLine(Primes[10000]);
                    Console.WriteLine(Primes.Count);
                    Console.WriteLine(Primes.Max());


            //StreamWriter sw = new StreamWriter(@"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Probmel 7_1\Problem 7\Primes.txt");
                    
            //        foreach (int x in Primes)
            //        {
            //            sw.WriteLine(x);
            //        }
            //        sw.Close();
    
                
                

         }
            
        
    }
    
}
