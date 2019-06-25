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
     
            Console.WriteLine("Please enter a series of numbers separated by hyphens");
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

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 68-2
        // Write a program and ask the user to enter a few numbers separated by a hyphen.  If the user simply presses Enter, without
        // supplying an input, exit immediately; otherwise, check to see if there are duplicates.  If so, display "Duplicate" on console.
        // </summary>
        public static void Exercise2()
        {
            Console.WriteLine("Please enter some numbers separated by hyphens");
            var numbers = Console.ReadLine();

            var numList = new List<int>();
            var newList = new List<int>();

            foreach (var number in numbers.Split('-'))
                numList.Add(Convert.ToInt32(number));

            var duplicates = false;

            for (var i = 0; i < numList.Count; i++)
            {
                if(newList.Contains(numList[i]))
                {
                    duplicates = true;
                    break;
                }
                newList.Add(numList[i]);
            }

            if (duplicates)
                Console.WriteLine("Duplicate");
            else
                Console.WriteLine("No duplicates");
        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 68-3
        // Write a program and ask the user to enter a time value in the 24-hour time format.  A valid time sould be between 00:00 and 23:59.
        // If the time is valid, display "Ok"; otherwise display "Invalid time".  If no value, consider invalid.
        // </summary>
        public static void Exercise3()
        {
            Console.WriteLine("Please enter a time value in the 24-hour time format (e.g. 19:00):");
            var input = Console.ReadLine();

            if (!String.IsNullOrEmpty(input))
            {
                var time = new List<int>();
                foreach (var number in input.Split(':'))
                    time.Add(Convert.ToInt32(number));

                if (time.Count == 2 && (time[0] >= 0 && time[0] < 24) && (time[1] >= 0 && time[1] < 60))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid time");
            }
            else
                Console.WriteLine("Invalid time");

        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 68-4
        // Write a program and ask the user to enter a few words separated by a space.  Use the words to create a variable in PascalCase.
        // </summary>
        public static void Exercise4()
        {
            Console.WriteLine("Please enter a few words separated by a space:");
            var input = Console.ReadLine();
            string[] words = input.Split(' ');

            var newWords = new List<string>();

            foreach (var word in words)
            {
                var first = word.Substring(0, 1);
                var rest = word.Substring(1, word.Length - 1);

                newWords.Add(string.Concat(first.ToUpper(), rest.ToLower()));
            }

            var final = String.Join("", newWords);

            Console.WriteLine("Variable name:  " + final);
        }
    }
}
