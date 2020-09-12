using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter any number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Until what value do you want the multiplication to go: ");
            int multiplier = int.Parse(Console.ReadLine());

            for (int i = 1; i <= multiplier; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
