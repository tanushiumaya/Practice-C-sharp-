using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1st method- for loop 
            Console.WriteLine("First method for declaring arrays");
            string[] names = new string[6];
            names[0] = "bob";
            names[1] = "michael";
            names[2] = "jane";
            names[3] = "rachel";
            names[4] = "spencer";
            names[5] = "toby";

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }
            Console.ReadLine();

            //2nd method - foreach
            Console.WriteLine("Second method for declaring arrays");
            foreach (string name in names)
            {
                Console.Write(name);
            }
            Console.ReadLine();

            //REVERSING A STRING
            Console.WriteLine("Reversing a string");
            string sentence = ("hi baby!");
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);

            foreach (char charSentence in charArray)
            {
                Console.Write(charSentence);
            }
            Console.ReadLine();
            {

            }
           
        }
    }
}
