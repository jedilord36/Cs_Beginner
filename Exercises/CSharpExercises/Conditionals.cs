using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.CSharpExercises
{
    public class Conditionals
    {
        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 43-1
        // Write a program and ask the user to enter a number.  The number should be between 1 to 10.
        // If valid, display "Valid" in console.  Otherwise display "Invalid".
        // </summary>
        public static void Exercise1()
        {
            Console.WriteLine("Please enter a number from 1 to 10: ");
            var numInput = Int32.Parse(Console.ReadLine());
            if (numInput >= 1 && numInput <= 10)
                Console.WriteLine("Valid!");
            else
                Console.WriteLine("Invalid!");
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 43-2
        // Write a program which takes two numbers from the console and displays the maximum of the two.
        // </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Please enter a number: ");
            var numInput1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var numInput2 = Int32.Parse(Console.ReadLine());

            if (numInput1 > numInput2)
                Console.WriteLine("Maximum is: " + numInput1);
            else
                Console.WriteLine("Maximum is: " + numInput2);
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 43-3
        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
        // </summary>
        public static void Exercise3()
        {
            Console.WriteLine("Please enter image width: ");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter image height: ");
            var height = Int32.Parse(Console.ReadLine());

            if (width > height)
                Console.WriteLine("The image is in landscape.");
            else
                Console.WriteLine("The image is in portrait.");
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 43-4
        // Write a program for a speed camrea.  Ask user for speed limit and speed of the car.
        // If the user enters a car speed value less than the speed limit, then display Ok on the console.
        // If the value is above the speed limit, calculate the number of demerit points.
        // For every 5km/hr above the limit, 1 demerit point is incurred.
        // If over 12 demerits, the program should display "License Suspended".
        // </summary>
        public static void Exercise4()
        {
            Console.WriteLine("Please enter the speed limit (km/hr): ");
            var speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car (km/hr): ");
            var carSpeed = Int32.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
                Console.WriteLine("Ok");
            else
            {
                var kmPerPoint = 5;
                var numDemerits = (carSpeed - speedLimit) / kmPerPoint;
                Console.WriteLine("Demerits incurred: " + numDemerits);
                if (numDemerits > 12)
                    Console.WriteLine("License Suspended");
            }
        }
    }
}

