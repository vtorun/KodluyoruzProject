using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Phone;

        public Person()
        {
        }

        public Person(int ıd, string firstName, string lastName, string phone)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }
    }
}
