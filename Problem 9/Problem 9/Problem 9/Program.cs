using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (var i = 2; i < 1000; i++)
            {
                
                for(var x = 1; x<i && x < 1000; x++)
                {
                    
                    for (var y = 0; y < x && y < 1000; y++)
                    {
                        
                        if (i + x + y == 1000)
                        {

                            if(i*i == x*x + y*y)
                            {
                                Console.WriteLine("i = " + i);
                                Console.WriteLine("x = "+ x);
                                Console.WriteLine("y = " + y);
                                Console.WriteLine(i*x*y);

                            }
                        }
                    }
                }
            }
        }
    }
}
