using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile2
{
    class Program
    {
        static void Main(string[] args)
        {
            Contents contents = new Contents("drew", "otteson", "22");
            Contents contents1 = new Contents("matt", "Smith", "33");
            Contents contents2 = new Contents("mike", "jones", "44");
            FileOptions fileOptions = new FileOptions();
            Search search = new Search();

            fileOptions.addToList(contents);
            fileOptions.addToList(contents1);
            fileOptions.addToList(contents2);

            fileOptions.writeToFile();
            search.searchForKeyword("33");

            Console.ReadLine();
        }
    }
}
