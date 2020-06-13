using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4th_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decisions - 4th METHOD");
            Console.WriteLine("Hello! Welcome To The Bob's Big Giveaway!! ");
            Console.WriteLine("Choose A Door : 1 or 2  ");
            string input1 = Console.ReadLine();
            string message1;
            message1 = (input1 == "1") ? "Cat" : "Kettle";
            Console.Write("You Entered {0}, So You Won A {1}.", input1, message1);
            Console.ReadLine();
        }
    }
}
