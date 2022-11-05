using System;

namespace App_3_7_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = ("Антон", 30);
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", age);

            (string name_input, int age_input) anketa;

            Console.WriteLine("Введите ваше имя: ");
            anketa.name_input = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст цифрами: ");
            anketa.age_input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя {0}, ваш возраст цифрами {1}", anketa.name_input, anketa.age_input);
            
        }
    }
}
