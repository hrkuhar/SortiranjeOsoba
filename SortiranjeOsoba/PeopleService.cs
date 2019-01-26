using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortiranjeOsoba
{
    class PeopleService
    {
        private BindingList<Person> People { get; set; }

        private static PeopleService service;

        private PeopleService()
        {
            People = new BindingList<Person>();

            People.Add(new Person("Ana", "Anić", "Ž", new DateTime(1990, 5, 5), "Hrvatska", "Zagreb"));
            People.Add(new Person("Ivan", "Ivić", "M", new DateTime(1985, 6, 17), "Hrvatska", "Split"));
            People.Add(new Person("Marko", "Markić", "M", new DateTime(1995, 10, 10), "Hrvatska", "Rijeka"));
        }

        public static PeopleService GetInstance()
        {
            if (service == null)
            {
                service = new PeopleService();
            }
            return service;
        }

        public BindingList<Person> GetPeople()
        {
            return People;
        }

        public void AddPerson(Person person)
        {
            People.Add(person);
        }
    }
}
