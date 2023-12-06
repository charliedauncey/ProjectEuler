using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Problem22
{
    public class Import
    {
        public List<string> ImportNames()
        {
            List<string> names = new List<string>();

            var fileStream =
                new FileStream(
                    @"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Problem 22\p022_names.txt",
                    FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    var nameLine = line;

                    string[] namesArray = line.Split('"');

                    foreach (string name in namesArray)
                    {
                        if (name != "" && name != ",")
                        {
                            names.Add(name);
                        }
                    }
                }
            }

            return names;
        }

        public Dictionary<string, int> LetterScores()
        {
            Dictionary<string, int> letterScores = new Dictionary<string, int>();


            var fileStream = new FileStream(@"C:\Users\charlie.dauncey\Documents\C# Training\Project Euler\Problem 22\letter_scores.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] numberAndScore = line.Split('=');
                    
                    letterScores.Add(numberAndScore[0],Convert.ToInt32(numberAndScore[1]));
                }
            }

            
            return letterScores;
        }
        

        
    }
}



    
