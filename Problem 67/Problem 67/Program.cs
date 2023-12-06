using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_67
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100;

            int[][] arr = new int[size][];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new int[i + 1];
            }

            string fileName = @"C:\Users\Connor\Desktop\Project Euler\Problem 67\Triangle.txt";

            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    var parsed = ln.Split(' ');
                    int parsedLength = Convert.ToInt32(parsed.Length);

                    var parsedInt = new int[parsedLength];
                    int j = 0;
                    foreach (string i in parsed)
                    {
                        int Int = Convert.ToInt32(i);

                        parsedInt[j] = Int;

                        j++;
                    }

                    arr[counter] = parsedInt;

                    counter++;
                }
                file.Close();
            }


            for (int i = size-2; i >= 0; i--)
            {

                for (int j = 0; j <= i; j++)
                {
                    int x = arr[i][j] + Math.Max(arr[i + 1][j], arr[i + 1][j + 1]);
                    arr[i][j] = x;
                }
            }

            Console.WriteLine(arr[0][0]);
        }
    }
}
