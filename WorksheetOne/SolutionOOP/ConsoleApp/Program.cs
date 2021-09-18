using OrganizationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tWORKSHEET ONE" + Environment.NewLine);

            Console.WriteLine("\tProgrammers");

            Programmer programmer1 = new Programmer("Ana", "Silva", new DateTime(2002, 5, 12), 1200.60);
            programmer1.Gender = GenderType.Feminine;

            Console.WriteLine(programmer1.Print());

            Programmer programmer2 = new Programmer("Rita", "Lisboa", new DateTime(2001, 3, 5), 2300.00);
            programmer2.Gender = GenderType.Feminine;

            Console.WriteLine(programmer2.Print());

            Console.WriteLine("\tManager");

            Manager manager = new Manager("Sofia", "Torres", new DateTime(1982, 8, 31), 5000.34);
            manager.Gender = GenderType.Feminine;

            manager.addProgrammer(programmer1);
            manager.addProgrammer(programmer2);

            Console.WriteLine(manager.Print());

            // --------------------------------------------------------------------------------------------------------

            Console.WriteLine("\t\t\t\tEXTRA" + Environment.NewLine);

            Console.WriteLine("\tCustomers");

            Customer customer1 = new Customer("João", "Russo", new DateTime(1929, 4, 18), "Rua Padre Miguel, Leiria");
            customer1.Gender = GenderType.Masculine;

            Console.WriteLine(customer1.Print());

            Customer customer2 = new Customer("Ricardo", "Mendes", new DateTime(1930, 11, 8), "Rua Dom João, Lisboa");
            customer2.Gender = GenderType.Masculine;

            Console.WriteLine(customer2.Print());

            Customer customer3 = new Customer("Alex", "Madeira", new DateTime(1931, 3, 24), "Rua Dom Pedro, Leiria");
            customer3.Gender = GenderType.Masculine;

            Console.WriteLine(customer3.Print());

            Customer customer4 = new Customer("Abilio", "Fernades", new DateTime(1932, 6, 5), "Rua da Igreja, Lisboa");
            customer4.Gender = GenderType.Masculine;

            Console.WriteLine(customer4.Print());

            List<Customer> customers = new List<Customer>();

            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);

            IEnumerable<Customer> filteredCustomers = customers.Where(c => c.FullName.StartsWith("A"));

            Console.WriteLine("Filtered (name starts with an 'A'):");

            foreach (Customer customer in filteredCustomers)
            {
                Console.WriteLine("- " + customer.FullName);
            }
            Console.WriteLine();

            filteredCustomers = from c in customers
                                where c.FullName.StartsWith("A")
                                where c.Address.Contains("Leiria")
                                select c;

            Console.WriteLine("Filtered (name starts with an 'A' and from Leiria):");

            foreach (Customer customer in filteredCustomers)
            {
                Console.WriteLine("- " + customer.FullName);
            }
            Console.WriteLine();

            filteredCustomers = customers.Where(c => c.Age > 40);

            Console.WriteLine("Filtered (count of older than 40):");
            Console.WriteLine($"{filteredCustomers.ToList().Count}" + Environment.NewLine);

            Persons people = new Persons();

            try
            {
                Console.WriteLine("Adding people to collection ..." + Environment.NewLine);

                Console.WriteLine("Adding Customer 1");
                people.addPerson(customer1);

                Console.WriteLine("Adding Programmer 1");
                people.addPerson(programmer1);

                Console.WriteLine("Removing Programmer 1");
                people.removePerson(programmer1);

                Console.WriteLine("Adding Manager");
                people.addPerson(manager);

                Console.WriteLine(Environment.NewLine + "Currently " + people.NumberOfPersons() + " people are in the collection.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
