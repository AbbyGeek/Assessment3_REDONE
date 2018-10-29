using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_FML
{
    class Program
    {
        public static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            


            while (true)
            {
                Console.WriteLine("Create new person? (y/n)");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    TeamMember.PersonMaker(ref people);
                }

                Console.WriteLine("Print Team MemberS? (y/n)");
                ans = Console.ReadLine();
                if (ans == "y")
                {
                    foreach (Person x in people)
                    {
                        TeamMember.Print(x);
                    }
                }


            }





            
            // call to add TM
            //call to print



        }
    }
}
