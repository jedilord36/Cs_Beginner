//
// Udemy Course C# Basics for Beginners
// Exercise 43-3
//
// Write a program and ask the user to enter the width and height of an image.
// Then tell if the image is landscape or portrait.
//

using System;

namespace Exercise_43_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter image width: ");
            var width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter image height: ");
            var height = Int32.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is in landscape.");
            }
            else
            {
                Console.WriteLine("The image is in portrait.");
            }
        }
    }
}
