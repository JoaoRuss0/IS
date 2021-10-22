using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    public class Customer : Person
    {
        public String Address { get; set; }

        public Customer(string firstName, string lastName, DateTime birthDate, String address) : base(firstName, lastName, birthDate)
        {
            Address = address;
        }

        public override string Print()
        {
            string output = base.Print();

            output += $"Address:\t{Address}" + Environment.NewLine;

            output += "-----------------------------------------------------------------------" + Environment.NewLine;

            return output;
        }
    }
}
