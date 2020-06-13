using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2nd method - using methods");

            Console.WriteLine("The Name Game");
            Console.WriteLine("Hi! Welcome to the game!!");
            Console.Write("Enter your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last name? ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Born city? ");
            string city = Console.ReadLine();

            Console.Write("Results : ");
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);
            Console.ReadLine();

        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }

    }
}

