using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.CSharpExercises
{
    class Lists
    {
        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 56-1
        // Write a program and continuously ask the use to enter different names, until the user presses Enter (blank name)
        // Depending on the number of names provided, display a message similar to the Facebook like repsonse text.
        // </summary>
        public static void Exercise1()
        {
            var count = 0;
            List<string> namesList = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name, or leave empty and hit Enter to stop: ");
                var input = Console.ReadLine();
                if (!(String.IsNullOrEmpty(input)))
                {
                    count++;
                    namesList.Add(input);
                }
                else
                    break;
            }

            Console.WriteLine("Output:");
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine(namesList[0] + " likes your post.");
                    break;
                case 2:
                    Console.WriteLine(namesList[0] + " and " + namesList[1] + " like your post.");
                    break;
                default:
                    Console.WriteLine(namesList[0] + ", " + namesList[1] + " and " + (count - 2) + " others like your post.");
                    break;
            }
        }
    }
}
