using System;

namespace App_3_7_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your birthdate?");
            var birthdate = Console.ReadLine();

            Console.WriteLine("Hello {0}, you're {1} years old, your birthdate is {2}", name, age, birthdate);

            Console.ReadKey();
        }
    }
}
