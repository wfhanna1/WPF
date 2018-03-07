using SampleWPF.Common.Interfaces;
using SampleWPF.Common.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Common.Helpers
{
    public class MockData : IMockData
    {
        private List<Person> persons { get; set; }

        public MockData()
        {
            persons = new List<Person>();
        }

        public List<Person> GetPeople()
        {
            persons.Add(new Person
            {
                id = 1,
                firstName = "Hello",
                lastName = "World",
                universityName = "The Ohio State University"
            });

            persons.Add(new Person
            {
                id = 2,
                firstName = "Cardinal",
                lastName = "Solutions",
                universityName = "Ohio University"
            });

            persons.Add(new Person
            {
                id = 3,
                firstName = "Jack",
                lastName = "Smith",
                universityName = "The Ohio State University"
            });

            persons.Add(new Person
            {
                id = 4,
                firstName = "Corry",
                lastName = "World",
                universityName = "MIT"
            });

            persons.Add(new Person
            {
                id = 5,
                firstName = "Hannah",
                lastName = "Wells",
                universityName = "Harvard"
            });

            persons.Add(new Person
            {
                id = 6,
                firstName = "Cameron",
                lastName = "Joy",
                universityName = "Purdude"
            });
            return persons;
        }
    }
}
