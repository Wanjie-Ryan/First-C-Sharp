using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //the below is a string
            string name = "Mister";
            string prog = "This is a " + "Program written in C#";

            //this is a character, now the single quotation marks
            char letter = 'c';

            int age = 10;

            //representing decimal number ...... use float, double, decimal

            double marks = 3.2;

            bool isMale = true;

            double num = 3.5;
            num++;



            Console.WriteLine("Excited to start off with C# ");
            Console.WriteLine("My name is " + name + "and I am " + age + " years old");
            Console.WriteLine("Hey mahn, C#.");
            Console.WriteLine("Give me 6 months.");
            Console.WriteLine("");
            Console.WriteLine("Ryan \nWanjie");
            Console.WriteLine(prog.ToUpper());
            Console.WriteLine(num);
            Console.WriteLine(Math.Floor(3.5));



            Console.ReadLine();
        }
    }
}
