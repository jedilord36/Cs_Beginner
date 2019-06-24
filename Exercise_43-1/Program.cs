
//
// Udemy Course C# Basics for Beginners
// Exercise 43-1
//
// Write a program and ask the user to enter a number.  The number should be between 1 to 10.
// If valid, display "Valid" in console.  Otherwise display "Invalid".
//

using System;

namespace Exercise_43_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numInput = 1;

            while (true)
            {
                Console.WriteLine("Please enter a number from 1 to 10: ");
                numInput = Int32.Parse(Console.ReadLine());

                if (numInput >= 1 && numInput <= 10)
                {
                    Console.WriteLine("Valid!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid!");
                    break;
                }
            }

        }
    }
}
