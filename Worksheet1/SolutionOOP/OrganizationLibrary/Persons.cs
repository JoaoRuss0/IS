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
        public new Person this[int index]
        {
            get { return base[index]; }
            set { base[index] = value; }
        }

        public void addPerson(Person person)
        {
            if (base.Contains(person))
            {
                throw new ExPersonAlreadyExists();
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
            return base.Count;
        }

        public int NumberOfManagers()
        {
            int quantity = 0;

            foreach (Person p in base.Items)
            {
                if (p is Manager)
                {
                    quantity++;
                }
            }

            return quantity;
        }

        public int NumberOfProgrammers()
        {
            IEnumerable<Person> programmers = base.Items.Where(p => p is Programmer);

            return programmers.ToList().Count;
        }
    }
}
