using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int a = 999; a > 100; a--)
            {
                for(int b = 999; b > 100; b--)
                {
                    int number = a * b;
                    IsPalindrome(number);
                }
            }



        }
        static void IsPalindrome(int number)
        {
            string NumberString = Convert.ToString(number);
            if(NumberString.Length % 2 != 0)
            {
                
            }
            else
            {
                int Length = NumberString.Length;
                
                string First = NumberString.Substring(0, Length / 2);
                int FirstLength = First.Length;
                string Second = NumberString.Substring(Length / 2, Length / 2);


                string ReversedSecondi = "";
                for (int i = 0; i < FirstLength; i++)
                {
                    ReversedSecondi = Second.Substring(i, 1);
                }
                        

                
                
                
                if (First == ReversedSecond)
                {
                    Console.WriteLine(NumberString);
                }
            }
        }
    }
}
