using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Problem_21
{
    public class FindingPrimeDivisors : PrimeNumbers
    {
        private List<int> primes { get; set; } = new List<int>();
        protected List<int> PrimeDivisors(int number)
        {
            //To workout prime divisors for number
            if (primes.Count == 0)
            {
                foreach (int prime in ImportPrimes(10000))
                {
                    primes.Add(prime);
                }
            }
            
            

            List<int> primeDivisors = new List<int>();

            
            foreach (int prime in primes)
            {
                int numberToEdit = number;
                if (prime > Math.Sqrt(number))
                {
                    break;
                }

                bool allNumberFactors = false;
                while (!allNumberFactors)
                {
                    if (numberToEdit % prime == 0)
                    {
                        primeDivisors.Add(prime);

                        try
                        {
                            numberToEdit /= prime;
                        }
                        catch
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
            }

            return primeDivisors;
        }
    }
}