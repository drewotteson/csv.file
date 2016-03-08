using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile2
{
    class Search
    {
        Contents contents = new Contents();
        FileOptions fileOptions = new FileOptions();

        public void searchForKeyword(string wordToCheck)
        {
            int counter = 1;
            bool stringFound = false;
            foreach (var line in File.ReadAllLines(fileOptions.filePath))
            {       
                if (line.Contains(wordToCheck))
                {
                    Console.WriteLine("word found!" + Environment.NewLine + line);
                    Console.WriteLine(counter.ToString() + ":");
                    stringFound = true;
                    break;
                }         
                counter++;
            }
            if (stringFound == false)
            {
                Console.WriteLine("string not found");
            }            
        }
    }
}
