using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            Import var = new Import();

            List<string> names = var.ImportNames();

            SortNames sort = new SortNames();

            Dictionary<string,int> sortedNames = sort.SortList(names);


            NameCounter n = new NameCounter();

            int totalOfAllNameScores = 0;

            Import letter = new Import();

            Dictionary<string, int> letterCount = letter.LetterScores();

            foreach (KeyValuePair<string, int> kvp in sortedNames)
            {
                string name = kvp.Key;
                int nameNo = kvp.Value;

                int letterTotal = n.NameCount(name, letterCount);

                int total = nameNo * letterTotal;
                totalOfAllNameScores = total + totalOfAllNameScores;
            }

            Console.WriteLine(totalOfAllNameScores);
        }
    }
}
