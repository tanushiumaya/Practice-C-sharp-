using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3rd method - using tiny, many methods");
            Console.WriteLine("The Name Game!! " + "Let's play");

            Console.Write("What Is Your First Name? ");
            string firstName = Console.ReadLine();

            Console.Write("What Is Your Last Name? ");
            string lastName = Console.ReadLine();

            Console.Write("What Is Your Born City? ");
            string bornCity = Console.ReadLine();

            reverseName(firstName);
            reverseName(lastName);
            reverseName(bornCity);

            displayResults(reverseName(firstName), reverseName(lastName), reverseName(bornCity));
            Console.WriteLine();

            displayResults(reverseName(firstName) + " " + reverseName(lastName) + " " + reverseName(bornCity));
            Console.ReadLine();
        }

        private static string reverseName(string message)
        {
            Char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        private static void displayResults(string reversedFirstName, string reversedLastName, string reversedBornCity)
        {
            Console.Write("Results : ");
            Console.Write(string.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedBornCity));

        }

        private static void displayResults(string message)
        {
            Console.Write("Results : ");
            Console.Write(message);


        }
    }
    }

