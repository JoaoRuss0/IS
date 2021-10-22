using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    public abstract class Person
    {
        private String _firstName;
        private String _lastName;
        private DateTime _birthDate;

        public DateTime BirthDate { get; set; }
        public GenderType Gender { get; set; }
        public String FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - _birthDate.Year;

                if (today.Month > _birthDate.Month || today.Month == _birthDate.Month && today.Day > _birthDate.Day)
                {
                    age--;
                }

                return age;
            }
        }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;

            Gender = GenderType.Undefined;
        }

        public virtual String Print()

        {
            string output = "-----------------------------------------------------------------------" + Environment.NewLine;

            output += $"Name:\t\t{FullName}" + Environment.NewLine;
            output += $"Age:\t\t{Age}" + Environment.NewLine;
            output += $"Gender:\t\t{Gender}" + Environment.NewLine;

            output += "-----------------------------------------------------------------------" + Environment.NewLine;

            return output;
        }

        public string PrintHTML()
        {
            throw new NotImplementedException();
        }

        public string PrintXML()
        {
            throw new NotImplementedException();
        }
    }
}
