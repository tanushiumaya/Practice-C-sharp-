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
            Console.WriteLine("Decisions - 3rd method -- can only be used when there are only 2 possible outcomes......");

            Console.WriteLine("Hello! Welcome To The Bob's Big Giveaway!! ");
            Console.WriteLine("Choose A Door : 1 or 2  ");
            string input3 = Console.ReadLine();
            string message3;

            message3 = (input3 == "1") ? "Cat" : "Kettle";
            Console.Write("You Won A ");
            Console.Write(message3);
            Console.Write(".");
            Console.ReadLine();
        }
    }
}
