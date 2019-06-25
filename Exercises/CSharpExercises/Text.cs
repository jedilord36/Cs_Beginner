using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.CSharpExercises
{
    class Text
    {
        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 68-1
        // Write a program and ask the user to enter a few numbers separated by a hyphen.  Work out if the numbers are consecutive.
        // If the input is "5-6-7-8-9" or "20-19-18-17-16" display "Consecutive", otherwise display "Not Consecutive".
        // </summary>
        public static void Exercise1()
        {
     
            Console.WriteLine("Please enter a series of numbers seprated by hyphens");
            var numbers = Console.ReadLine();

            var numList = new List<int>();
            foreach (var number in numbers.Split('-'))
                numList.Add(Convert.ToInt32(number));

            numList.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numList.Count; i++)
            {
                if (numList[i] != numList[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            if (isConsecutive)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");

        }
    }
}
