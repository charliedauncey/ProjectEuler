using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Problem22
{
    class NameCounter
    {
        public int NameCount(string name, Dictionary<string, int> letterCount)
        {
            int nameCount = 0;

            foreach (char c in name)
            {
                nameCount = letterCount[c.ToString()] + nameCount;
            }


            return nameCount;
        }
    }
}