using System;

namespace VariablePracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;  //declare the variable
            int num2;

            Console.Write("Multiplication Calculator\n");
            Console.WriteLine();
            Console.Write($"Please enter a number for num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please enter a second number for num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num1 * num2);


            Console.WriteLine();
        
        
            double num10;  //declare the variable
            double num20;

            Console.Write("Dividing Calculator\n");
            Console.WriteLine();
            Console.Write($"Please enter a number for num1: ");
            num10 = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Please enter a second number for num2: ");
            num20 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("num1 divided by num2 is: " + num10 / num20);
        }
    }
}
