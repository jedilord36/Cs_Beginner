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
        // Write a program and continuously ask the use to enter different names, until the user presses Enter (blank name).
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

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 56-2
        // Write a program and ask the user to enter their name. Use an array to reverse the new and then store the result in a
        // new string.  Display the reversed name on the console.
        // </summary>
        public static void Exercise2()
        {
            Console.WriteLine("What is your name so that I can reverse it?");
            var name = Console.ReadLine();

            char[] chars = name.ToCharArray();

            for (int i = 0, j = name.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }

            var reverseName = new String(chars);

            Console.WriteLine("Reverse name: " + reverseName);
        }
    }
}
