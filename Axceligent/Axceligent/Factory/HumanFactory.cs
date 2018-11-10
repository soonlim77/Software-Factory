using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axceligent.Model;
using Axceligent.Interface;

namespace Axceligent.Factory

{
    public static class HumanFactory
    {
         public static List<Person> CreatePersonList()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { FirstName = "John", LastName = "Smith", Age = 23, Gender = GenderType.male });
            persons.Add(new Person() { FirstName = "Taylor", LastName = "Smith", Age = 25, Gender = GenderType.male });
            persons.Add(new Person() { FirstName = "Peter", LastName = "Parker", Age = 28, Gender = GenderType.male });
            persons.Add(new Person() { FirstName = "Scott", LastName = "Lane", Age = 33, Gender = GenderType.male });
            persons.Add(new Person() { FirstName = "Ruby", LastName = "Chunk", Age = 28, Gender = GenderType.female });
            persons.Add(new Person() { FirstName = "Mary", LastName = "Jonas", Age = 23, Gender = GenderType.female });
            persons.Add(new Person() { FirstName = "Megan", LastName = "Fox", Age = 28, Gender = GenderType.female });


            return persons;


        }
    }
}
