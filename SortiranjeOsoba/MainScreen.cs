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
    public partial class MainScreen : Form
    {
        PeopleService service;
        private int? sortColumnIndex = null;

        public MainScreen()
        {
            InitializeComponent();
            service = PeopleService.GetInstance();
            dataGridView1.DataSource = service.GetPeople();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AddPerson addpersonForm = new AddPerson();
            addpersonForm.ShowDialog();
            SortList();
        }

        private void SortList()
        {
            List<Person> sorted = new List<Person>();

            switch (sortColumnIndex)
            {
                case null:
                    return;
                case 0:
                    sorted = service.GetPeople().OrderBy(p => p.FirstName).ToList();
                    break;
                case 1:
                    sorted = service.GetPeople().OrderBy(p => p.LastName).ToList();
                    break;
                case 2:
                    sorted = service.GetPeople().OrderBy(p => p.Gender).ToList();
                    break;
                case 3:
                    sorted = service.GetPeople().OrderBy(p => p.BirthDate).ToList();
                    break;
                case 4:
                    sorted = service.GetPeople().OrderBy(p => p.CountryOfBirth).ToList();
                    break;
                case 5:
                    sorted = service.GetPeople().OrderBy(p => p.PlaceOfBirth).ToList();
                    break;
            }

            service.GetPeople().Clear();

            foreach (var item in sorted)
            {
                service.GetPeople().Add(item);
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sortColumnIndex = e.ColumnIndex;
            SortList();
        }
    }
}
