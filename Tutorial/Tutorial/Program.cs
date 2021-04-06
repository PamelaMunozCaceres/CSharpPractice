// Importing libraries
using System;
using System.Collections.Generic;

// Namespace is for group and organize code 
namespace Tutorial
{
    class Program
    {
        // Every program needs a Main method to use as an entry point (This is where the program starts)
        // The main method needs to be static, this means it won't change dinamically in the execution
        // The word void indicates that this method wont  return anything, if we put int it means it will
        // return an int
        static void Main(string[] args)
        {
            Console.WriteLine("--Strings--\n");

            // Print
            Console.WriteLine("Hello World!");

            // string variable
            string myName = "Pamela";
            Console.WriteLine("Hello " + myName);

            // Format string (string interpolation)
            Console.WriteLine($"Hello {myName} again");

            // Length of a string
            Console.WriteLine($"Hello {myName} again, your name has {myName.Length} characters");

            // Delete spaces from strings
            string spaceName = "     Pamela     ";
            Console.WriteLine($"if we remove all the spaces at the beginning, the result is -->{spaceName.TrimStart()}<--");
            Console.WriteLine($"if we remove all the spaces at the end, the result is -->{spaceName.TrimEnd()}<--");
            Console.WriteLine($"if we remove all the spaces, the result is -->{spaceName.Trim()}<--");

            // Uppercase and lowercase
            Console.WriteLine($"Hello {myName.ToUpper()} again, your name in uppercase");
            Console.WriteLine($"Hello {myName.ToLower()} again, your name in lowercase");

            // Replace string
            string saySomething = "Hello World";
            Console.WriteLine($"I want to say {saySomething} but she is make me say {saySomething.Replace("Hello", "Bye")}");

            // Search string in string
            string unrealStatement = "My favorite program language is c#";
            Console.WriteLine($"-{unrealStatement}\n-Did she say she loves c#?\n-{unrealStatement.Contains("c#")}\n-She lied");

            // Store boolean result in variable
            var result = unrealStatement.Contains("c#");
            Console.WriteLine($"is c# in the string? {result}");

            Console.WriteLine("\n--Numbers--\n");

            // Integer variable
            int a = 10;
            int b = 20;
            int c = a - b;
            Console.WriteLine($"{a}+{b} is {a+b} and {a}-{b} is {c}");

            // Integer division always return an integer
            int a2 = 3;
            int b2 = 2;
            int c2 = a2 / b2;
            Console.WriteLine($"{a2}/{b2} is {c2}...wait what?");

            // There is a min and a max for integers in c# (buuuuuuuuuuu)
            int minInteger = int.MinValue;
            int maxInteger = int.MaxValue;
            Console.WriteLine($"The min is {minInteger}, the max is {maxInteger} and this happens when you try to add 1 to the max {maxInteger}+1 is {maxInteger + 1}");

            // If we want precission and greather numbers we can use double
            double a3 = 3;
            double b3 = 2;
            double c3 = a3 / b3;
            Console.WriteLine($"{a3}/{b3} is {c3}...that is right");
            Console.WriteLine($"The min double is {double.MinValue}, the max double is {double.MaxValue} and this happens when you try to add 1 to the max {maxInteger}+1 is {maxInteger + 1}");

            // Decimal has smaller range than double but more precision (we must add a M at the end of the numbre, again: buuuuuuuuuuuu)
            Decimal a4 = 1.0M;
            Decimal b4 = 3.0M;
            Decimal c4 = a4 / b4;
            Double a5 = 1;
            Double b5 = 3;
            Double c5 = a5 / b5;
            Console.WriteLine($"{a4}/{b4} is {c4} if we use Decimal and {c5} if we use Double");

            Console.WriteLine("\n--Branches and loops--\n");

            // First if
            int a6 = 5;
            int b6 = 6;
            if (a6 + b6 > 10)
                Console.WriteLine($"{a6}+{b6} is greater than 10.");

            // If and else
            int a7 = 5;
            int b7 = 2;
            if (a7 + b7 > 10)
                Console.WriteLine($"{a7}+{b7} is greater than 10.");
            else
                Console.WriteLine($"{a7}+{b7} is not greater than 10.");

            // And, or and equal
            Console.WriteLine($"((27+3>29) && (23>3)) is {((27+3>29) && (23>3))}");
            Console.WriteLine($"((27+3>29) || (23<3)) is {((27 + 3 > 29) || (23 < 3))}");
            Console.WriteLine($"((27+3==29)) is {(27 + 3 == 29)}");

            // While Loop
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine($"This is going to end in {counter}");
                // Decreases integer value by one
                counter--;
                // Decreases integer value by one
                // counter++;
            }
            Console.WriteLine($"Finally my awesome counter finish because counter is {counter}");

            // The while loop test the condition and then execute, we can use do to execute and then test the condition
            int counter2 = 2;
            do
            {
                Console.WriteLine("Hello beautiful world! ¬¬");
                counter2--;
            } while (counter2 > 0);

            // The awesome and the powerfull for loop!!!
            for (int index = 0; index < 3; index++) {
                Console.WriteLine($"This loop is so much better in python, the count is {index}");
            }

            // Put all together, find the sum of all number from 0 to 20 divisble by 3
            int totalSum = 0;
            for (int index = 0; index < 21; index++) {
                Console.WriteLine($"Number {index}");
                if (index % 3 == 0) {
                    Console.WriteLine("3 divisible!");
                    totalSum = totalSum + index;
                }
            }
            Console.WriteLine($"The sum of all numbers divisible by 3 between 0 and 20 is {totalSum}");


            Console.WriteLine("\n--Arrays, List, and Collections --\n");

            // Creating the first list
            var animals = new List<string> { "dog", "cat", "monkey", "tiger" };
            // Itarating over the list
            foreach (var animal in animals)
            {
                Console.WriteLine($"This is the animal: {animal}");
            }

            // Creating an empty list
            var letters = new List<string> { };
            // Append an element on the list
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            // Delete elements 
            letters.Remove("A");
            // This print the object
            Console.WriteLine($"If we just print the variable letters this is the output: {letters}");
            letters.ForEach(Console.WriteLine);
            // First element of the list
            Console.WriteLine($"The first letter is {letters[0]}");

            Console.WriteLine("\n--Sort, Search, and Index Lists --\n");

            // Search index of list element
            var students = new List<string> { "Pedro", "Juan", "Diego"};
            var indexDiego = students.IndexOf("Diego");
            Console.WriteLine($"The index of Diego is {indexDiego}");

            // Search for something that doesnt exists
            var indexAna = students.IndexOf("Ana");
            Console.WriteLine($"The index of Ana is {indexAna}, because it doesnt exists");

            // Sort a list
            Console.WriteLine($"The list before sort: {String.Join(", ", students)}");
            students.Sort();
            Console.WriteLine($"The list after sort: {String.Join(", ", students)}");

            Console.WriteLine("\n--Lists of Other Types --\n");

            // List of int
            var numbers = new List<int> {33, 18,45, 83,12 };
            // Find the first 20 numbers of Fibbonaci sequence
            var fibStart = new List<int> { 1, 1 };
            while (fibStart.Count < 20) {
                var prev1 = fibStart[fibStart.Count - 2];
                var prev2 = fibStart[fibStart.Count - 1];
                fibStart.Add(prev2 + prev1);
            }
            Console.WriteLine($"Fibbonaci sequence: {String.Join(", ", fibStart)}");
        }
    }
}
