using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileName = @"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Problem 13\50 digit numbers.txt";
            
            List<String> txtFile = new List<string>();

            txtFile of = new txtFile();

            of.txtFileReader(fileName, txtFile);
            
            string sum = "37107287533902102798797998220837590246510135740250";

            for (int i = 1; i < txtFile.Count; i++)
            {

                string next = txtFile[i];

                int Length = next.Length;
                int LengthSum = sum.Length;
                string First50 = "";
                string Extra = "";

                if (LengthSum > Length)
                {
                    First50 = sum.Substring(LengthSum - Length, Length);
                    Extra = sum.Substring(0, LengthSum - Length);
                    
                }
                else
                {
                    First50 = sum;
                    
                }

                string newSum = "";
                string reversedNewSum = "";
                int c = 0;
                int d = 0;

                for (int x = Length-1; x >= 0; x--)
                {
                    int a = Convert.ToInt32(next.Substring(x, 1));
                    int b = Convert.ToInt32(First50.Substring(x, 1));

                    if (d == 0)
                    {
                        if (a + b > 9)
                        {
                            c = a + b - 10;
                            d = 1;

                        }
                        else
                        {
                            c = a + b;
                            d = 0;
                        }
                        newSum = newSum + Convert.ToString(c);
                    }
                    else if (d == 1)
                    {
                        c = a + b + d;
                        if (c > 9)
                        {
                            c = c - 10;
                            d = 1;
                        }
                        else
                        {
                            d = 0;

                        }
                        newSum = newSum + Convert.ToString(c);
                    }
                }

                string reversedExtra = "";
                string p = "";
                if (d == 1)
                {
                    if (Extra == "")
                    {

                        Extra = Convert.ToString(d);
                        p = newSum + Extra;

                    }
                    else if (Extra != "")
                    {
                        string Extra1 = Convert.ToString(Convert.ToInt32(Extra) + d);
                        int Extra1Length = Extra1.Length;
                        for (int j = Extra1Length - 1; j >= 0; j--)
                        {
                            reversedExtra = reversedExtra + Extra1.Substring(j, 1);
                        }
                        p = newSum + reversedExtra;
                    }

                    for (int j = p.Length - 1; j >= 0; j--)
                    {
                        reversedNewSum = reversedNewSum + p.Substring(j, 1);
                    }
                }
                else if (d == 0)
                {
                    if (Extra == "")
                    {
                        for (int j = newSum.Length - 1; j >= 0; j--)
                        {
                            reversedNewSum = reversedNewSum + newSum.Substring(j, 1);
                        }
                        p = reversedNewSum;
                    }

                    else if (Extra != "")
                    {
                        int ExtraLength = Extra.Length;
                        for (int j = ExtraLength - 1; j >= 0; j--)
                        {
                            reversedExtra = reversedExtra + Extra.Substring(j, 1);
                        }

                        p = newSum + reversedExtra;
                        for (int j = p.Length - 1; j >= 0; j--)
                        {
                            reversedNewSum = reversedNewSum + p.Substring(j, 1);
                        }
                    }
                }
                sum = reversedNewSum;
            }
            Console.WriteLine(sum.Substring(0, 10));
            Console.WriteLine(sum);
        }
    }
}
