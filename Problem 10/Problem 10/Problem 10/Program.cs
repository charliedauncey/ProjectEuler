using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = 2000000;

            //making a list of the primes under 2 million using Primes.txt file then summing them.
            var Primes = new List<Int32>();
            var fileStream = new FileStream(@"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Probmel 7_1\Problem 7\Primes.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var Prime = Convert.ToInt32(line);
                    Primes.Add(Prime);
                }
            }

            long sum = 0;
            for(var i=0; Primes[i]<n; i++)
            {
                sum = Primes[i]+sum; 
            }
            Console.WriteLine(sum);

        }
    }
}
