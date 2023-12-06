using System;
using System.IO;

namespace Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[15][];

            for (int i = 0; i < 15; i++)
            {
                arr[i] = new int[i+1];
            }

            string fileName = @"C:\Users\Connor\OneDrive\Documents\C# Training\C# Training\Project Euler\Problem 18\Numbers.txt";
            
            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    var parsed = ln.Split(',');
                    int parsedLength = Convert.ToInt32(parsed.Length);

                    var parsedInt = new int[parsedLength];
                    int j = 0;
                    foreach( string i in parsed)
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


            for(int i = 13; i>=0; i--)
            {
                
                for (int j = 0; j <= i; j++)
                {
                    int x = arr[i][j] + Math.Max(arr[i+1][j],arr[i+1][j+1]);
                    arr[i][j] = x;
                }
            }

            Console.WriteLine(arr[0][0]);

        }
    }
}
