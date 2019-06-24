//
// Udemy Course C# Basics for Beginners
// Exercise 43-2
//
// Write a program which takes two numbers from the console and displays the maximum of the two.
//

using System;

namespace Exercise_43_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var numInput1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            var numInput2 = Int32.Parse(Console.ReadLine());

            if(numInput1 > numInput2)
            {
                Console.WriteLine("Maximum is: " + numInput1);
            }
            else
            {
                Console.WriteLine("Maximum is: " + numInput2);
            }

        }
    }
}
