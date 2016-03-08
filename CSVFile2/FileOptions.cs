using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile2
{
    public class FileOptions
    {
        public string filePath = "people.txt";
        Contents contents = new Contents();
        public List<List<string>> peopleList = new List<List<string>>();

        public void addToList(Contents newcontent)
        {
            peopleList.Add(newcontent.peopleDetails);
        }

        public void writeToFile()
        {
            foreach (List<string> detail in peopleList)
            {
                string person = "";
                foreach (var item in detail)
                {
                    person += item + ",";
                }
                File.AppendAllText(filePath, person + Environment.NewLine);
            }
        }
    }
}
