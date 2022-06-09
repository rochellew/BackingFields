using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackingFields
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;

        public string Name 
        { 
            get => $"{_lastName}, {_firstName}"; 
        }

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
