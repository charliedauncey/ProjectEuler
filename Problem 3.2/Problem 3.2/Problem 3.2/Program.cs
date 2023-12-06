using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = new List<int>();
            using (StreamReader file = new StreamReader(@"C:\Users\Connor\OneDrive\Documents\C# Training\C# Training\Project Euler\Probmel 7_1 - StreamWriter and prime Txt file\Problem 7\Primes.txt"))
            {
                int counter = 0;
                string ln;


                while ((ln = file.ReadLine()) != null)
                {
                    var Prime = Convert.ToInt32(ln);
                    Primes.Add(Prime);
                    counter++;
                }
                file.Close();
            }

            var n = 600851475143;

            for (var i = 0; i < Primes.Count; i++)
            {
            if( n % Primes[i] == 0)
            {
                        Console.WriteLine(Primes[i]);
            }
            }

            
        }
    }
}
