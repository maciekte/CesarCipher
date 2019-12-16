using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_rozne
{
    class Listy
    {
        public static void Main(string[] args)
        {
            List<Person> oPersonsList = new List<Person>();
            oPersonsList.Add(new Person(1, "jan", "kowalski", 24));
            oPersonsList.Add(new Person(2, "Jan", "Nowak", 26));
            oPersonsList.Add(new Person(3, "Anna", "Gruszka", 28));

            Console.WriteLine(oPersonsList.Count);

            //oPersonsList.Clear();
            Person oFoundPerson = oPersonsList.Find(oElement => oElement.Age == 26);


            Console.ReadKey();
        }
    }
    
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int nPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = nPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
        }
    }
}
