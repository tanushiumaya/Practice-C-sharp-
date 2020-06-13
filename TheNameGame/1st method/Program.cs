using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ST METHOD");
            Console.WriteLine("The Name Game");
            Console.WriteLine("Hi! Welcome to the game!!");
            Console.Write("Enter your first name? ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last name? ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Born city? ");
            string city = Console.ReadLine();

            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            string result = "";
            foreach (char item in firstNameArray)
            {
                result += item;
            }
            result += " ";
            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            foreach (char item in lastNameArray)
            {
                result += item;
            }
            result += " ";
            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            foreach (char item in cityArray)
            {
                result += item;
            }
            Console.Write("Results : "+ result);
            Console.ReadLine();

        }

            
    }
}

