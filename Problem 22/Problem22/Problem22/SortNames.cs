using System.Collections.Generic;
using System.Linq.Expressions;

namespace Problem22
{
    public class SortNames
    {
        public Dictionary<string,int> SortList(List<string> nameList)
        {
            Dictionary<string,int> sortedDictionary = new Dictionary<string, int>();

            nameList.Sort();

            int index = 1;
            foreach (string name in nameList)
            {
                sortedDictionary.Add(name,index);
                index++;
            }

            return sortedDictionary;
        }
    }
}