using System;

namespace VariablePracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;  //declare the variable
            int num2;

            Console.Write($"Type a number for num1: ");
            num1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write($"Type a number for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num1 * num2);



        }
    }
}
