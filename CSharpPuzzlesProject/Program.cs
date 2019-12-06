using System;

namespace CSharpPuzzlesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // the factorial piece
            // Console.WriteLine("Please enter the nth value as an integer:");
            // var n = Convert.ToInt32(Console.ReadLine());

            // call the loop
            // Console.WriteLine($"Loop Calculation: Factorial of {n} is {CalculateLoop(n)}");
            // call recursion
            // Console.WriteLine($"Recursion Calculation: Factorial of {n} is {CalculateRecursion(n)}");

            // the FizzBuzz piece
            // Console.WriteLine("The loop solution for FizzBuzz:");
            // first without recursion
            //string text;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        text = "FizzBuzz";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        text = "Fizz";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        text = "Buzz";
            //    }
            //    else text = i.ToString();

            //    Console.WriteLine(text);
            //}

            // with recrusion
            Console.WriteLine("The Recursive FizzBuzz Solution:");
            FizzBuzzRecursion(1);
        }

        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int CalculateRecursion(int n)
        {
            if (n == 1) return 1;

            return n * CalculateRecursion(n - 1);
        }

        private static void FizzBuzzRecursion(int n)
        {
            string text;
            if (n > 100) return;

            if (n % 15 == 0)
            {
                text = "FizzBuzz";
            }
            else if (n % 3 == 0)
            {
                text = "Fizz";
            }
            else if (n % 5 == 0)
            {
                text = "Buzz";
            }
            else text = n.ToString();

            Console.WriteLine(text);

            FizzBuzzRecursion(n + 1);
        }
    }
}
