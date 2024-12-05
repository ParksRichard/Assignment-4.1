using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment_4._1
{
    internal class MockData
    {
        //public string FullName;
        ////Student Collection
        //private Dictionary<string,Person> Persons;

        ////populate collection
        //public static void CreateData()
        //{
        //    Persons = new Dictionary<string,Person>()
        //    {
        //        { "Dude Guy", new Person() { FirstName = "Dude", LastName = "Guy", MobilePhone = "515-867-5309", WorkPhone = "800-588-9300", Address = "400 N. Avenue"} }
        //    };
        //}

        //copy paster
        public static Dictionary<string, Person> CreateData()
        {
            Dictionary<string, Person> Persons = new Dictionary<string, Person>();

            Person person1 = new Person() { FirstName = "Kevin", LastName = "Liu", MobilePhone = "916-555-1234", WorkPhone = "916-555-4567", Address = "Sequim WA" };
            Persons.Add(person1.FullName, person1);

            Person person2 = new Person() { FirstName = "James", LastName = "Smith", MobilePhone = "916-555-7890", WorkPhone = "916-555-6543", Address = "Seattle WA" };
            Persons.Add(person2.FullName, person2);

            return Persons;
        }

        //try get value for search?

        public static Person SearchPerson(Dictionary<string, Person> contacts, string fullName)
        {
            //for some reason this seems overly complicated
            contacts.TryGetValue(fullName, out Person person);
            return person;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {


        }
    }

}
