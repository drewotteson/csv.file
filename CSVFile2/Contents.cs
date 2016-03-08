using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVFile2
{
    public class Contents
    {
        public List<string> peopleDetails;
        public string FirstName;
        public string LastName;
        public string Age;
        
        public Contents(string firstName, string lastName, string age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.peopleDetails = new List<string>();
            addContentsToList();
        }

        public Contents()
        {
            
        }

        public void addContentsToList()
        {
            peopleDetails.Add(FirstName);
            peopleDetails.Add(LastName);
            peopleDetails.Add(Age);
        }
    }
}
