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

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 49-3
        // Write a program and ask the user to enter a number. 
        // Compute the factorial of the number and print it on the console.
        // </summary>
        public static void Exercise3()
        {
            Console.WriteLine("Please enter a number to calculate its factorial");
            var numInput = Int32.Parse(Console.ReadLine());
            var factorial = numInput;
            for (var i = numInput - 1; i > 0; i--)
                factorial *= i;
            Console.WriteLine(numInput + "! = " + factorial);
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 49-4
        // Write a program that picks a random number between 1 and 10. 
        // Give the user 4 chances to guess the number.
        // If the user guesses the number, display "You won!", otherwise display "You lost."
        // </summary>
        public static void Exercise4()
        {
            var random = new Random();
            var randomNum = random.Next(1, 10);
            var winnerFlag = false;
            Console.WriteLine("I've chosen a random number between 1 and 10!\n");
            for (var i = 1; i < 5; i++)
            {
                Console.WriteLine("Guess #" + i + " - Please try to guess the random number");
                var choice = Int32.Parse(Console.ReadLine());
                if (choice == randomNum)
                {
                    winnerFlag = true;
                    break;
                }
            }
            if (winnerFlag)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost.  The random number was " + randomNum);
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 49-5
        // Write a program and ask the user to enter a series of numbers separated by commas. 
        // Find the maximum of the numbers and display it on the console.
        // </summary>
        public static void Exercise5()
        {
            Console.WriteLine("Please enter a series of numbers seprated by commas");
            var numbers = Console.ReadLine();
            var numList = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries);

            var max = Int32.Parse(numList[0]);

            foreach (var number in numList)
                if (max < Int32.Parse(number))
                    max = Int32.Parse(number);

            Console.WriteLine("Max value is: " + max);
        }
    }
}
