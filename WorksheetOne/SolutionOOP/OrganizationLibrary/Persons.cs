using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    public class Persons : Collection<Person>
    {
        public Person this[int index]
        {
            get { return this[index]; }
            set { this[index] = value; }
        }

        public void addPerson(Person person)
        {
            if (this.Contains(person))
            {
                throw new ExPersonAlreadyExists("Person already exists.");
            }

            this.Add(person);
        }

        public void removePerson(Person person)
        {
            if (!this.Contains(person))
            {
                throw new ExPersonDoesNotExist();
            }

            this.Remove(person);
        }

        public int NumberOfPersons()
        {
            return this.ToList().Count;
        }

        /*public int NumberOfManagers()
        {
            IEnumerable<Person> managers = this.Where(p => p.);

            return managers.ToList().Count;
        }

        public int NumberOfProgrammers()
        {
            IEnumerable<Person> programmers = this.Where(p => true);

            return programmers.ToList().Count;
        }*/
    }
}
