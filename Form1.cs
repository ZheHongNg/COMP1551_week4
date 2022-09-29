using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1551_week4
{
    public partial class Form1 : Form
    {

        private int viewing = -1;
        private List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string firstName = FNameTxt.Text.Trim();
            string lastName = LNameTxt.Text.Trim();
            string email = EmailTxt.Text.Trim();

            //Person person = new Person(firstName, lastName, email);
            //people.Add(person);
            people.Add(new Person(firstName, lastName, email));
            viewing = people.Count - 1;

            UpdateStatus();
            ShowRecord();
        }

        private void ShowRecord()
        {
            if (people.Count == 0  || viewing == -1)
            {
                FNameTxt.Clear();
                LNameTxt.Clear();
                EmailTxt.Clear();
                return;
            }
            Person person = people[viewing];

            FNameTxt.Text = person.FirstName;
            LNameTxt.Text = person.lastName;
            EmailTxt.Text = person.Email;

            FNameTxt.Focus();


        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (people.Count == 0 || viewing == -1)
            {
                return;
            }
            Person person = people[viewing];
            string message = string.Format("Confirm deleting {0}", person.ToString());
            if (MessageBox.Show(message, "Delete", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                people.RemoveAt(viewing);
                PrvBtn_Click(null, null); //make it jump to previous record automatically
            }
        }

        private void UpdateStatus()
        {
            if (people.Count == 0)
            {
                label4.Text = "No record";
            }
            else
            {
                int recordnumber = viewing + 1;
                int totalrecord = people.Count;
                label4.Text = String.Format( "Record{0}/{1}", recordnumber, totalrecord);
            }
        }

        private void PrvBtn_Click(object sender, EventArgs e)
        {
            viewing = Math.Max(0, viewing - 1);
            UpdateStatus();
            ShowRecord();
        }

        private void NxtBtn_Click(object sender, EventArgs e)
        {
            viewing = Math.Min(people.Count-1, viewing +1);
            ShowRecord();
            UpdateStatus();

        }
    }
}
