using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1st method - long cord");
            Console.WriteLine("The Name Game!! " + "Let's play");

            Console.Write("What Is Your First Name? ");
            string firstName = Console.ReadLine();

            Console.Write("What Is Your Last Name? ");
            string lastName = Console.ReadLine();

            Console.Write("What Is Your Born City? ");
            string bornCity = Console.ReadLine();

            Char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            Char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            Char[] bornCityArray = bornCity.ToCharArray();
            Array.Reverse(bornCityArray);

            string result = "";

            foreach (char letters in firstNameArray)
            {
                result = result + letters;
            }
            result = result + " ";

            foreach (char letters in lastNameArray)
            {
                result = result + letters;
            }
            result = result + " ";

            foreach (char letters in bornCityArray)
            {
                result = result + letters;
            }
            result = result + " ";

            Console.WriteLine("Results : " + result);
            Console.ReadLine();

            //using 1 large method
            Console.WriteLine("2nd method - short code using method calling");
            Console.WriteLine("The Name Game!! " + "Let's play");

            Console.Write("What Is Your First Name? ");
            string firstName2 = Console.ReadLine();

            Console.Write("What Is Your Last Name? ");
            string lastName2 = Console.ReadLine();

            Console.Write("What Is Your Born City? ");
            string bornCity2 = Console.ReadLine();

            Console.Write("Results : ");
            reverseName1(firstName2);
            reverseName1(lastName2);
            reverseName1(bornCity2);
            Console.ReadLine();
        }

        private static void reverseName1(string message)
        {
            Char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");

        }
    }
}