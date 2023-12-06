using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Problem_21
{
    public class FindingDivisors : FindingPrimeDivisors
    {
        public List<int> Divisors(int number)
        {
            List<int> divisors = new List<int>();

            

            List<int> primeDivisorsList = PrimeDivisors(number);
            //int[] primeDivisorsArray = ArrayMaker(primeDivisorsList);
            int[] primeDivisorsArray = new int[4] { 1, 2, 3, 4 };

            int amountOfNumbers = primeDivisorsList.Count;
            int noOfCombinations = Convert.ToInt32(Math.Pow(2, amountOfNumbers));
            int[] combinations = new int[noOfCombinations];
            int[][] array = new int[16][];
            int indexGreg = 0;


            int[] greg = Combinations(primeDivisorsArray, combinations,array, indexGreg);

            //var combinationgrs = PrintPowerSet(primeDivisorsArray, 4, combinations);

            //Finding all combinations


            return divisors;
        }
       
        public static int[] Combinations(int[] primeDivisorsList, int[] combinations, int[][] array, int indexGreg)
        {
            if (primeDivisorsList.Length == 0)
            {
                return combinations;
            }

            int prime = primeDivisorsList[0];
                
            var rest = Split(primeDivisorsList);

            array.SetValue(rest, indexGreg);
            indexGreg++;

            var combsWithoutFirst = Combinations(rest, combinations, array, indexGreg);

            int[] combsWithFirst = new int[combsWithoutFirst.Length];


            int index = 0;
            foreach (int x in combsWithoutFirst)
            {
                combsWithFirst.SetValue(x, index);
                index++;
            }
           

            return combinations;
        }

        public static int[] Combinations2(int[] primeDivisorsList, int[] combinations, int[][] array, int indexGreg)
        {
            if (primeDivisorsList.Length == 0)
            {
                return combinations;
            }

            int prime = primeDivisorsList[0];

            var rest = Split(primeDivisorsList);

            array.SetValue(rest, indexGreg);
            indexGreg++;

            var combsWithoutFirst = Combinations(rest, combinations, array, indexGreg);

            
            return combsWithoutFirst;
        }




















        private static int[] Split(int[] array)
        {
            List<int> list = ListMaker(array);
            list.RemoveAt(0);

            int[] primeMinusOneArray = ArrayMaker(list);


            return primeMinusOneArray;
        }

        private static int[] ArrayMaker(List<int> list)
        {
            int length = list.Count;

            int[] array = new int[length];
            int index = 0;
            foreach (var prime in list)
            {
                
                array.SetValue(prime, index);
                index++;
            }

            return array;
        }
        private static List<int> ListMaker(int[] array)
        {
            int length = array.Length;

            List<int> list = new List<int>();
            foreach (var prime in array)
            {
                
                list.Add(prime);
                
            }

            return list;
        }
    }
}