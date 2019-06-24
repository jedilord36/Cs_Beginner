using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.CSharpExercises
{
    class Loops
    {
        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 49-1
        // Write a program to count how many numbers between 1 and 11 are divisible by 3 with no remainder.
        // Display the count on the console.
        // </summary>
        static void Main(string[] args)
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    count++;

            Console.WriteLine("Total numbers between 1 and 100 divisible by 3 with no remainder: " + count);
        }
    }
}
