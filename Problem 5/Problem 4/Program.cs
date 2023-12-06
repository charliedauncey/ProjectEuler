using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var d = 20;
            
            while ((d % 11) != 0 || (d % 13) != 0 || (d % 14) != 0 || (d % 16) != 0 || (d % 17) != 0 || (d % 18) != 0 || (d % 19) != 0 || (d % 20) != 0)
            {
                d += 20;
            }
            Console.WriteLine(d);
        }

    }
}
