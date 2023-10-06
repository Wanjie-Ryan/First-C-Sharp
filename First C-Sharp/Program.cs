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
            //string name = "Mister";
            //string prog = "This is a " + "Program written in C#";

            //this is a character, now the single quotation marks
            //char letter = 'c';

            //int age = 10;

            //representing decimal number ...... use float, double, decimal

            //double marks = 3.2;

            //bool isMale = true;

            //double num = 3.5;
            //num++;


            //the difference between writeline and write is that in writeline, it prints a statement and then goes to a new line whilst write prints a statement and remains in the same line

            //Console.WriteLine("Excited to start off with C# ");
            //Console.WriteLine("My name is " + name + "and I am " + age + " years old");
            //Console.WriteLine("Hey mahn, C#.");
            //Console.WriteLine("Give me 6 months.");
            //Console.WriteLine("");
            //Console.WriteLine("Ryan \nWanjie");
            //Console.WriteLine(prog.ToUpper());
            //Console.WriteLine(num);
            //Console.WriteLine(Math.Floor(3.5));

            //Console.Write("Enter your name:");
            //string your_name = Console.ReadLine();
            //Console.Write("What is your age");
            //string ages = Console.ReadLine();
            //Console.WriteLine("My name is: "+ your_name + " I am " + ages + " years old");

            //int num1 = Convert.ToInt32("45");
            //int num2 = Convert.ToInt16("48");

            //Console.WriteLine(num1 + 1);
            //Console.WriteLine(num2 + 1);

            //SIMPLE CALCULATOR

            //Console.Write("Enter a number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the Second number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("The answer is: " + (num1 + num2));

            //SIMPLE MADLIB GAME

            //string color, pn, celeb;

            //Console.Write("Enter your favourite color:");
            // color = Console.ReadLine();
            //Console.Write("Enter any plural noun:");
            // pn = Console.ReadLine();
            //Console.Write("Enter any celebrity you favour:");
            // celeb = Console.ReadLine();

            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine( pn+ " are blue");
            //Console.WriteLine("I love " + celeb);

            //ARRAYS

            //string[] randoms = new string[5];
            //randoms[0] = "xxxx";
            //randoms[1] = "yyyy";

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 4, 6, 7 };

            //Console.WriteLine(numbers[2]);
            //Console.Write(randoms[0]);

            // METHODS





            // Greeting("Wanjiku");


            //IF STATEMENTS
            /*
            int num = 4;

            if (5 < num)
            {
                Console.WriteLine("4 is smaller");
            }
            else if (5 > num)
            {
                Console.WriteLine("5 is greater true");
            }
            else
            {
                Console.WriteLine("waah saa utadu"); 
            }
            */

            //SIMPLE CALCULATOR

            SimpleCalc();


            Console.ReadLine();
        }

        //static void Greeting(string name)
        //{
         //   string greeting = "Good Morning";
          //  Console.WriteLine(greeting + " " + name);
        //}

        static void SimpleCalc()
        {

            string operation;
            int[] numbers = { 2, 4, 5, 6, 7, 8, 10 };

            double num1,num2;
            double result;

            Console.WriteLine("A simple Ryan Calc, YES");

            Console.WriteLine("Enter any number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the operation you want to perform");
            operation = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            if(operation == "+")
            {
                result = num1 + num2; 
                Console.Write("Answer is:" +result);

            }
            else if(operation == "-")
            {
               result = num1 - num2;
                Console.Write("Answer is:" + result);


            }
            else if(operation == "/")
            {
                result = num2 / num1;
                Console.Write("Answer is:" + result);


            }
            else if(operation == "*")
            {
                result = num1 * num2;
                Console.Write("Answer is:" + result);


            }
            else
            {
                Console.WriteLine("Hey that cannot be done");
            }

            for(int i=0; i<numbers.Length; i++)
            {

                Console.WriteLine(numbers[i]);

            }

            


            

        }
    }
}
