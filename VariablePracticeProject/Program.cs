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
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Type a number for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num1 * num2);
        
        
            int num10;  //declare the variable
            int num20;

            Console.Write($"Type a number for num1: ");
            num10 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Type a number for num2: ");
            num20 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num1 divided by num2 is: " + num10 / num20);
        }
    }
}
