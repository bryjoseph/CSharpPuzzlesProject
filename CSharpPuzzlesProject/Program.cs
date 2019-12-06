using System;

namespace CSharpPuzzlesProject
{
    class Program
    {
        // needed for Tower of Hanoi Puzzle
        static int counter = 0;

        // needed for Sieve Puzzle
        static bool[] allNumbers;

        static void Main(string[] args)
        {
            // the factorial Puzzle
            // Console.WriteLine("Please enter the nth value as an integer:");
            // var n = Convert.ToInt32(Console.ReadLine());

            // call the loop
            // Console.WriteLine($"Loop Calculation: Factorial of {n} is {CalculateLoop(n)}");
            // call recursion
            // Console.WriteLine($"Recursion Calculation: Factorial of {n} is {CalculateRecursion(n)}");



            // FizzBuzz Puzzle
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
            //Console.WriteLine("The Recursive FizzBuzz Solution:");
            //FizzBuzzRecursion(1);



            // Fibonacci Sequence Puzzle
            // FibonacciSequence(15);

            // Fibonacci Sequence with Recrusion (hybrid)
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(RecursiveFibonacciSequence(i));
            //}



            // Tower of Hanoi Puzzle (recursion only)
            // - Pieces to know for the puzzle
            // : The number of discs
            // : The number of available pegs to place a disk into
            // : The source peg
            // : the destination peg
            //var discs = 0; // instantiating the discs number
            //Console.WriteLine("Please enter the number of discs to use: ");
            //discs = Convert.ToInt32(Console.ReadLine()); // converting the string input to an int
            //Tower(discs, 1, 3, 2); // discs the user provides, 1 = sourcePeg, 3 = destinationPeg, 2 = sparePeg




            // Sieve of Eratosthenes Puzzle (given a number by the user, determine how many numbers are prime)
            Console.WriteLine("Please enter the number of values to check: ");
            var n = Convert.ToInt32(Console.ReadLine());
            var arraySize = n + 1; // arrays are index based and start at 0 instead of 1
            MakeArrayFromUserInput(arraySize);
            SieveFunction(arraySize);


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

        private static void FibonacciSequence(int n)
        {
            var tempNum1 = 0;
            var tempNum2 = 1;

            for (int i = 0; i <= n; i++)
            {
                var sum = tempNum1 + tempNum2;
                tempNum1 = tempNum2;
                tempNum2 = sum;

                Console.WriteLine(sum);
            }
        }

        private static int RecursiveFibonacciSequence(int n)
        {
            if (n <= 0) return 1;

            return RecursiveFibonacciSequence(n - 2) + RecursiveFibonacciSequence(n - 1);
        }

        private static void Tower(int numberOfDiscs, int sourcePeg, int destPeg, int sparePeg)
        {
            // the check stopping the recursion (the smallest disc moving to the top of the tower, is the last move)
            if (numberOfDiscs == 1)
            {
                Console.WriteLine(counter + " " + sourcePeg + " -> " + destPeg);
                counter++;
            }
            else
            {
                // the first recursive call (explaining: the number of discs shrinks because one is being moved)
                // the sourcePeg stays the same (this is the origin of the disc)
                // the destPeg becomes the sparePeg (the open place where the disc moves to)
                // the destPeg becomes (what was) the open peg (because a disc moved to this peg)
                Tower(numberOfDiscs - 1, sourcePeg, sparePeg, destPeg);
                Console.WriteLine(counter + " " + sourcePeg + " -> " + destPeg);
                counter++;

                // the second recursive call (explaining: the final of the the dics is moved)
                // the sparePeg is the source of the disc we are moving
                // the destPeg is where the disc is being moved to
                // the sourcePeg is the final resting place of the moved disc
                Tower(numberOfDiscs - 1, sparePeg, destPeg, sourcePeg);
            }
        }


        private static void MakeArrayFromUserInput(int n)
        {
            allNumbers = new bool[n];

            for (int i = 0; i < allNumbers.Length; i++)
            {
                allNumbers[i] = true;
            }
        }

        private static void SieveFunction(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (allNumbers[i])
                {
                    for (int c = i; i * c < n; c++)
                    {
                        allNumbers[i * c] = false;
                    }
                }
            }

            int variableCounter = 0;
            for (int i = 2; i < n; i++)
            {
                if(allNumbers[i])
                {
                    Console.Write(i + "  ");
                    variableCounter++;
                }

                if(variableCounter == 10)
                {
                    Console.Write("\n");
                    variableCounter = 0;
                }
            }
        }
    }
}
