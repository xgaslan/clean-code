using System;
using System.Collections.Generic;
using System.Linq;

namespace NamingConvensitionsGood
{
    public class PersonService
    {
        private static List<Person> GetGeneratedPersonList()
        {
            List<Person> persons = new List<Person>()
            {
                new Person(){Id = 1, Name = "Max"},
                new Person(){Id = 2, Name = "Rose"},
                new Person(){Id = 3, Name = "Alex"},
                new Person(){Id = 4, Name = "Carol"}
            };
            return persons;
        }
        public static List<Person> GetAllPersons()
        {
            var personList = GetGeneratedPersonList();
            return personList;
        }

        public static Person GetPersonById(int id)
        {
            var personList = GetGeneratedPersonList();
            var person = personList.FirstOrDefault(s => s.Id == id);

            if (person != null)
            {
                return person;
            }

            throw new SystemException($"There is no data for person with id {id}.");
        }

    }
}