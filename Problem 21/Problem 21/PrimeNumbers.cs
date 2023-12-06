using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Problem_21
{
    public class PrimeNumbers
    {
        protected static List<int> ImportPrimes(int numberUpTo)
        {

            List<int> primes = new List<int>();

            var fileStream = new FileStream(@"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Problem 21\Primes.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var prime = Convert.ToInt32(line);
                    if (prime <= numberUpTo)
                    {
                        primes.Add(prime);
                    }
                    else
                        break;
                    
                }
            }

            return primes;
        }
        
    }
}