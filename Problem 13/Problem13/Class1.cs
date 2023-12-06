using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem13
{
    class txtFile
    {
        public void txtFileReader(string fileName, List<String> txtFile)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                int counter = 0;
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    txtFile.Add(ln);
                    counter++;
                }
                file.Close();
            }
        }

        public void txtFileWriter(string newFileName, List<String> txtFile)
        {
            StreamWriter sw = new StreamWriter(newFileName);

            foreach (string x in txtFile)
            {
                sw.WriteLine(x);
            }
            sw.Close();
        }
    }
}
