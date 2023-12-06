using System.Data.SqlTypes;

namespace Problem_25
{
    class Fibonacci
    {
        public string NextFibonacci(string nMinus1, string nMinus2)
        {
            string nextFibonacci = nMinus1 + nMinus2;

            return nextFibonacci;
        }
    }
}