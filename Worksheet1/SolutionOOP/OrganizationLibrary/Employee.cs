using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    public abstract class Employee : Person
    {
        private double _salary;

        public double Salary { get { return _salary; } }

        public Employee(string firstName, string lastName, DateTime birthDate, Double salary) : base(firstName, lastName, birthDate)
        {
            _salary = salary;
        }

        public override string Print()
        {
            string output = base.Print();

            output += $"Salary:\t{Salary}" + Environment.NewLine;

            output += "-----------------------------------------------------------------------" + Environment.NewLine;

            return output;
        }
    }
}
