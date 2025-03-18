//@atakanclskn 14 March 2024
using System;
using System.Collections.Generic;

namespace Math_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("<<< Please Select the Operation You Want to Perform Below >>>");
                Console.WriteLine("[1] Addition of two numbers (a+b)");
                Console.WriteLine("[2] Subtraction of two numbers (a-b)");
                Console.WriteLine("[3] Division of two numbers (a/b)");
                Console.WriteLine("[4] Multiplication of two numbers (a*b)");
                Console.WriteLine("[5] Listing prime numbers up to the entered number (a)");
                Console.WriteLine("[6] Listing odd numbers up to the entered number (a)");
                Console.WriteLine("[7] Calculating the factorial of the entered number");
                Console.WriteLine("[0] Exit");

                Console.Write("Your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the first number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Sum: {a + b}");
                        break;

                    case 2:
                        Console.Write("Enter the first number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Difference: {a - b}");
                        break;

                    case 3:
                        Console.Write("Enter the first number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        if (b == 0)
                            Console.WriteLine("A number cannot be divided by zero!");
                        else
                            Console.WriteLine($"Quotient: {(double)a / b}");
                        break;

                    case 4:
                        Console.Write("Enter the first number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the second number: ");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Product: {a * b}");
                        break;

                    case 5:
                        Console.Write("Enter a number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Prime numbers up to {a}:");
                        for (int i = 2; i <= a; i++)
                            if (IsPrime(i)) Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Write("Enter a number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Odd numbers up to {a}:");
                        for (int i = 1; i <= a; i += 2)
                            Console.Write(i + " ");
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Write("Enter a number: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{a}! = {Factorial(a)}");
                        break;
                }
                Console.WriteLine();

            } while (choice != 0);
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
                if (number % i == 0) return false;
            return true;
        }

        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;
            return result;
        }
    }
}
