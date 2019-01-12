using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortiranjeOsoba
{
    class Person
    {
        [System.ComponentModel.DisplayName("Ime")]
        public string FirstName { get; set; }
        [System.ComponentModel.DisplayName("Prezime")]
        public string LastName { get; set; }
        [System.ComponentModel.DisplayName("Spol")]
        public string Gender { get; set; }
        [System.ComponentModel.DisplayName("Datum rođenja")]
        public DateTime BirthDate { get; set; }
        [System.ComponentModel.DisplayName("Država rođenja")]
        public string CountryOfBirth { get; set; }
        [System.ComponentModel.DisplayName("Mjesto rođenja")]
        public string PlaceOfBirth { get; set; }

        public Person(string firstName, string lastName, string gender, DateTime birthDate, string countryOfBirth, string placeOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            BirthDate = birthDate;
            CountryOfBirth = countryOfBirth;
            PlaceOfBirth = placeOfBirth;
        }
    }

}
