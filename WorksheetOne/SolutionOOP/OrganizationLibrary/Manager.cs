using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationLibrary
{
    public class Manager : Employee
    {
        private List<Programmer> _programmers;

        public int NumberOfProgrammers
        {
            get { return _programmers.Count; }
        }
        public Programmer this[int index]
        {
            get { return _programmers[index]; }
        }

        public Manager(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate, salary)
        {
            _programmers = new List<Programmer>();
        }

        public void addProgrammer(Programmer programmer)
        {
            _programmers.Add(programmer);
        }

        public override string Print()
        {
            string output = base.Print();

            output += $"{NumberOfProgrammers} Programmers:" + Environment.NewLine;

            foreach (Programmer programmer in _programmers)
            {
                output += $"- Name: {programmer.FullName}\tAge: {programmer.Age}\t\tGender: {programmer.Gender}" + Environment.NewLine;
            }

            output += "-----------------------------------------------------------------------" + Environment.NewLine;

            return output;
        }
    }
}
