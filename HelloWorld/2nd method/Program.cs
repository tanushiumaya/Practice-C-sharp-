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
            Console.WriteLine("Decisions - 2nd method");
           
            string message = ("");
            Console.WriteLine("Hello! Welcome To The Bob's Big Giveaway!! ");
            Console.WriteLine("Choose A Door : 1 , 2 or 3 ");
            string door= Console.ReadLine();
            if(door == "1")
            {
                message = ("You Won A Cat!!");
            }
            else if (door == "2")
            {
                message = ("You Won A Car!!");
            }
            else if (door == "3")
            {
                message = ("You Won A Kettle!!");
            }
            else
            {
                message = ("Error!! ");
                message += ("You Lose!");
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}
