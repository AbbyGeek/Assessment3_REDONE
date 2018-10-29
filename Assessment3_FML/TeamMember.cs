using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_FML
{
    class TeamMember : Person
    {
        public string Address { get; set; }
        public double Salary { get; set; }

        public TeamMember(string address, double salary, string firstName, string lastName, string email, int age) : base( firstName,  lastName,  email,  age)
            {
            Address = address;
            Salary = salary;
            }


        public static void PersonMaker(ref List<Person> AddingPerson)
        {
            while (true)
            {

                Console.Write("Enter First Name:");
                string FirstName = Console.ReadLine();
                Console.Write("Enter Last Name:");
                string LastName = Console.ReadLine();
                Console.Write("Enter Email:");
                string Email = Console.ReadLine();
                Console.Write("Enter Age:");
                int Age = int.Parse(Console.ReadLine());
                if (Age < 18) { Console.WriteLine("Team Member does not meet age requirements. Try again"); continue; }
                
                Console.Write("Enter Address:");
                string Address = Console.ReadLine();
                Console.Write("Enter Salary:");
                double Salary = double.Parse(Console.ReadLine());

                AddingPerson.Add(new TeamMember(Address, Salary, FirstName, LastName, Email, Age));
                break;
            }
        }

        public static void Print(Person x)
        {
            Console.WriteLine($"\nName: {x.FirstName} {x.LastName}");
            Console.WriteLine($"Email: {x.Email}");
        }

    }


}
