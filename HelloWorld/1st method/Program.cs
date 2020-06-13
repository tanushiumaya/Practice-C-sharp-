using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1st program - c#");
            Console.Write("Hello World!!");
            Console.ReadLine();

            Console.WriteLine("declaring variables");
            int x = 7;
            int y = x + 3;

            Console.Write(y);
            Console.ReadLine();

            Console.WriteLine("DECLARING VARIABLES");

            Console.Write("What Is Your First Name? ");
            string firstName = Console.ReadLine();

            Console.Write("Hi! What Is Your Last Name? ");
            string lastName = Console.ReadLine();

            Console.Write("Hi!  " + firstName + " " + lastName);
            Console.ReadLine();

            Console.WriteLine("Decisions - 1st method");

            Console.WriteLine("Hello! Welcome To The Bob's Big Giveaway!! ");
            Console.WriteLine("Choose A Door : 1 , 2 or 3 ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("You Won A Cat!!");
            }
            else if (input == "2")
            {
                Console.WriteLine("You Won A Car!!");
            }
            else if (input == "3")
            {
                Console.WriteLine("You Won A Kettle!!");
            }
            else
            {
                Console.WriteLine("Error!!");
            }
            Console.ReadLine();

            Console.WriteLine("operationsExpressionsStatements - SHORTNOTE");

            Console.WriteLine("int x, y, a, b = variable declararion"); 
            Console.WriteLine("x = 4; y = 2 assignment operation");
            Console.WriteLine("x + y additon operator");
            Console.WriteLine("x - y subtraction operator");
            Console.WriteLine("x / y division operator"); 
            Console.WriteLine("x * y multiplication operator");
            Console.WriteLine("f = (x + y) * (x / y) order of operations using parenthesis");
            Console.WriteLine("x == y equality operator");
            Console.WriteLine("x <y less than operator");
            Console.WriteLine("x >y greater than operator");
            Console.WriteLine("x <=y less than or equal operator");
            Console.WriteLine("x >=y greater than or equal operator");
            Console.WriteLine("(x+y) && (x-y) AND Conditional operator");
            Console.WriteLine("(x+y) || (x-y) OR Conditional operator");
           
               

        }
    }
}
