//
// Udemy Course C# Basics for Beginners
// Exercise 43-4
//
// Write a program for a speed camrea.  Ask user for speed limit and speed of the car.
// If the user enters a car speed value less than the speed limit, then display Ok on the console.
// If the value is above the speed limit, calculate the number of demerit points.
// For every 5km/hr above the limit, 1 demerit point is incurred.
// If over 12 demerits, the program should display "License Suspended".
//

using System;

namespace Exercise_43_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit (km/hr): ");
            var speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the speed of the car (km/hr): ");
            var carSpeed = Int32.Parse(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                var numDemerits = (carSpeed - speedLimit) / 5;
                Console.WriteLine("Demerits incurred: " + numDemerits);
                if (numDemerits > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
    }
}
