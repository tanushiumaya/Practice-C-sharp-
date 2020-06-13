using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            //for loop - example 1
            Console.WriteLine("Example 1");
            for (int i = 0; i <11; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            //for loop - example 2
            Console.WriteLine("Example 2");
            for (int i = 0; i < 11; i++)
            {
              if ( i ==7)
                {
                    Console.WriteLine("Found seven!!");
                    break;
                }
              else
                {
                    Console.WriteLine("Not Seven");
                }
            }
            Console.ReadLine();
            //arrays
            Console.WriteLine("Declaring arrays - 1st method");
            int[] myArray = new int[5];
            myArray[0] = 1;
            myArray[1] = 11;
            myArray[2] = 122;
            myArray[3] = 132;
            myArray[4] = 123;

            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray.Length);
            Console.ReadLine();

            Console.WriteLine("Declaring arrays - 2nd method");
            int[] mineArray = new int[] { 1, 2, 3, 4, 5 };
            {
                Console.WriteLine(mineArray[4]);
                Console.WriteLine(mineArray.Length);
                Console.ReadLine();

                Console.WriteLine("Declaring a string array - using for loop");
   
                   string[] names = new string[] { "Bob", "Tabor", "Michael", "Raven" };
                {
                    for(int i=0; i < names.Length; i++)
                    {
                        Console.WriteLine(names[i]);
                    }

                    Console.ReadLine();
                }
            }
            Console.WriteLine("Declaring a string array - using foreach loop");
            string[] names1 = new string[] { "Bob", "Tabor", "Michael", "Raven" };
            foreach(string name in names1)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            Console.WriteLine("Reversing a string");
            string sentence = ("Hi! How are you? Hope you are doing fine. Keep Studying. You Can Do This!!");
            char [] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);

            foreach (char item in sentenceArray)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }

    }
}

