using System;
using System.Collections;
using System.Linq;

namespace CSharpPuzzlesProject
{
    class Program
    {
        // needed for Tower of Hanoi Puzzle
        static int counter = 0;

        // needed for Sieve Puzzle
        static bool[] allNumbers;
        // Needed for Log Pairs Puzzle
        static int[] boxes1 = { 1, 2, 3, 4, 5 };
        static int[] boxes2 = { 6, 7, 8, 2, 0 };

        static string[] strings = new string[] { "a", "b", "c", "d" };
        // the memory needed is 4 strings at 4 bytes each = 16 bytes
        static int[] array1 = { 0, 3, 4, 31 };
        static int[] array2 = { 4, 6, 30 };

        static string stringValue = "dog";
        static string stringValue2 = "cad";

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
            //Console.WriteLine("Please enter the number of values to check: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //var arraySize = n + 1; // arrays are index based and start at 0 instead of 1
            //MakeArrayFromUserInput(arraySize);
            //SieveFunction(arraySize);

            // Log Pairs Puzzle
            // LogPairs(boxes);

            //CompareArrays Function
            // Console.WriteLine(CompareArrays(boxes1, boxes2));

            // Console.WriteLine(CompareArrays2(boxes1, boxes2));

            strings.ToList().ForEach(i => Console.Write(i.ToString()));
            Console.WriteLine("");
            Console.WriteLine(strings.Length);
            AddAtFirst(ref strings, "e");

            Console.WriteLine("");
            Console.WriteLine("");
            strings.ToList().ForEach(i => Console.Write(i.ToString()));
            Console.WriteLine("");
            Console.WriteLine(strings.Length);

            Console.WriteLine("");
            Console.WriteLine("");
            AddAtLast(ref strings, "f");
            strings.ToList().ForEach(i => Console.Write(i.ToString()));
            Console.WriteLine("");
            Console.WriteLine(strings.Length);

            Console.WriteLine("");
            Console.WriteLine("");
            AddAtMiddle(ref strings, "g");
            strings.ToList().ForEach(i => Console.Write(i.ToString()));
            Console.WriteLine("");
            Console.WriteLine(strings.Length);

            Console.WriteLine("");
            Console.WriteLine("");
            RemoveAtEnd(ref strings);
            strings.ToList().ForEach(i => Console.Write(i.ToString()));
            Console.WriteLine("");
            Console.WriteLine(strings.Length);

            // reverse a string
            // first ask the user for the string
            //Console.WriteLine("Enter a string for the next method: ");
            //var stringToReverse = Console.ReadLine();
            // Console.WriteLine(ReverseAString(stringToReverse));
            //Console.WriteLine(ReverseAString2(stringToReverse));

            // merge arrays and sort the merged array
            //var mergedArray = MergeSortedArrays(array1, array2);
            //mergedArray.ToList().ForEach(i => Console.Write(i.ToString()));

            // string contains duplicate
            //Console.WriteLine("Does this string contain any duplicates? ");
            //var userInput = Console.ReadLine();
            //Console.WriteLine(IsUniqueChars(userInput));

            // check if the strings are permutations of each other
            Console.WriteLine("Are these two strings permutations of each other?");
            Console.WriteLine(AreStringsPermutations(stringValue, stringValue2));


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

        private static void LogPairs(string[] boxes)
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                for (int j = 0; j < boxes.Length; j++)
                {
                    Console.WriteLine(boxes[i], boxes[j]);
                }
            }
        }

        private static bool CompareArrays(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool CompareArrays2(int[] array1, int[] array2)
        {
            var map = new Hashtable();
            for (int i = 0; i < array1.Length; i++)
            {
                if (!map.ContainsKey(array1[i]))
                {
                    var item = array1[i];
                    map[item] = true;
                }
            }

            for (int j = 0; j < array2.Length; j++)
            {
                if (map.ContainsKey(array2[j])) return true;
            }
            return false;
        }

        // types of operations we can perform on an array
        // add = depends on position

        // add at FIRST
        static string[] AddAtFirst(ref string[] stringArray, string newString)
        {
            // first add space for new string in array
            Array.Resize(ref stringArray, stringArray.Length + 1);

            for (int i = stringArray.Length - 1; i > 0; i--)
            {
                stringArray[i] = stringArray[i - 1];
            }

            stringArray[stringArray.GetLowerBound(0)] = newString;

            return stringArray;
        }

        // add at LAST
        static string[] AddAtLast(ref string[] stringArray, string newString)
        {
            // first add space for new string in array
            Array.Resize(ref stringArray, stringArray.Length + 1);

            stringArray[stringArray.Length - 1] = newString;

            return stringArray;
        }

        // add at MIDDLE
        static string[] AddAtMiddle(ref string[] stringArray, string newString)
        {
            // first add space for new string in array
            Array.Resize(ref stringArray, stringArray.Length + 1);

            // new middle index value
            int newMiddleIndex = stringArray.Length / 2;

            for (int i = stringArray.Length - 1; i > newMiddleIndex; i--)
            {
                stringArray[i] = stringArray[i - 1];
            }

            stringArray[newMiddleIndex] = newString;

            return stringArray;
        }

        // remove at END
        static string[] RemoveAtEnd(ref string[] stringArray)
        {
            // first add space for new string in array
            Array.Resize(ref stringArray, stringArray.Length - 1);

            return stringArray;
        }

        static string ReverseAString(string userInput)
        {

            // creating my var for the reversing the user string
            string reversedString = "";

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedString += userInput[i];
            }
            return reversedString;
        }

        static string ReverseAString2(string userInput)
        {
            // creating my var to handle the reversing of user string
            char[] reversedString = new char[userInput.Length];
            int reversedIndex = 0;

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversedString[reversedIndex++] = userInput[i];
            }
            return new string(reversedString);
        }

        static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            // creating a new array  as long as the two arrays passed in
            int[] mergedArray = new int[array1.Length + array2.Length];
            // must combine the two arrays into the one array

            // first step is get the first array values into the new merged array
            for (int i = 0; i < array1.Length; i++)
            {
                mergedArray[i] = array1[i];
            }

            // nest step: get the second array values into the merged array BUT have to start after the first array values
            for (int i = 0; i < array2.Length; i++)
            {
                mergedArray[array1.Length + i] = array2[i];
            }

            // create a sorting flag value
            bool sorted = false;

            // now perform the sort on the merged array values
            while (!sorted)
            {
                sorted = true;
                for (int i = 1; i < mergedArray.Length; i++)
                {
                    if (mergedArray[i - 1] > mergedArray[i])
                    {
                        sorted = false;
                        var temp = mergedArray[i - 1];
                        mergedArray[i - 1] = mergedArray[i];
                        mergedArray[i] = temp;
                    }
                }
            }
            return mergedArray;
        }

        static bool IsUniqueChars(string userInput)
        {
            // first is a check on the userInput value (checking against the ASCII character library)
            if (userInput.Length > 128) return false;

            // make a bool array of values against the ASCII library
            bool[] checkedValues = new bool[128];

            // loop over the userInput and set true into the bool array if the value is found
            for (int i = 0; i < userInput.Length; i++)
            {
                // a var to hold the index of the character found in the userInput
                int value = userInput[i];

                if (checkedValues[value])
                {
                    return false; // if found
                }
                checkedValues[value] = true;
            }
            return true;
        }

        static bool AreStringsPermutations(string str1, string str2)
        {
            // first a check on the length, because if the strings are diff lengths then they cant be permutations
            if (str1.Length != str2.Length) return false;

            // sort the characters of the two strings in question with built-in function
            char[] sortedStr1 = str1.ToCharArray();
            char[] sortedStr2 = str2.ToCharArray();

            Array.Sort(sortedStr1);
            Array.Sort(sortedStr2);

            for (int i = 0; i < str1.Length; i++)
            {
                if (sortedStr1[i] != sortedStr2[i]) return false;
            }

            return true;
        }
    }
}
