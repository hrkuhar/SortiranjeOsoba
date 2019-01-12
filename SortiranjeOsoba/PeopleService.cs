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
