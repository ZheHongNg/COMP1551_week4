using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1551_week4
{
    class Person
    {
        public string lastName;

        public string FirstName { get; set; }

        private string LastName
        {
            get
            {
                return lastName;
            }
        }

        public string Email { get; set; }

        public Person() : this("Error", "Error", "Error")
        {

        }

        public Person(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            this.lastName = lastName;
            Email = email;


        }
        public override string ToString()
        {

            return String.Format("{0},{1}", FirstName, LastName);
        }
    }
}

