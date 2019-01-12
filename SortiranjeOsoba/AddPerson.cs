using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortiranjeOsoba
{
    public partial class AddPerson : Form
    {
        PeopleService service;

        public AddPerson()
        {
            InitializeComponent();
            service = PeopleService.GetInstance();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(lastName.Text)
                || string.IsNullOrEmpty(gender.Text) || dateOfBirth.Value == null
                || string.IsNullOrEmpty(countryOfBirth.Text) || string.IsNullOrEmpty(placeOfBirth.Text))
            {
                MessageBox.Show("Sva polja su obavezna!");
            }
            else
            {
                Person person = new Person(firstName.Text, lastName.Text, gender.Text, dateOfBirth.Value, countryOfBirth.Text, placeOfBirth.Text);
                service.AddPerson(person);
                Close();
            }    
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
