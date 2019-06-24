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
        public static void Exercise1()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    count++;

            Console.WriteLine("Total numbers between 1 and 100 divisible by 3 with no remainder: " + count);
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 49-2
        // Write a program and continuously ask the user to enter a number or "ok" to exit.
        // Calculate the sum of all the previously entered numbers and display it on the console.
        // </summary>
        public static void Exercise2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number to add to the sum or OK to end");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                else
                    sum += Int32.Parse(input);
            }

            Console.WriteLine("Sum is: " + sum);
        }


    }
}
