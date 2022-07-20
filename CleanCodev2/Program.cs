using System;

namespace NamingConvensitionsGood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var persons = PersonService.GetAllPersons();
            foreach (var person in persons)
            {
                Console.WriteLine(person.Id + "-" + person.Name);
            }

            var getPersonById = PersonService.GetPersonById(5);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(getPersonById.Id + "-" + getPersonById.Name);
        }
    }
}
