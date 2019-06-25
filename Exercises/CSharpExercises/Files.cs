using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.CSharpExercises
{
    class Files
    {
        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 76-1
        // Write a program that reads a text file and displays the number of words.
        // </summary>
        public static void Exercise1()
        {
            var wordCount = 0;
            string text = System.IO.File.ReadAllText(@"E:\CodeArea\C#_Beg\Exercises\Files\TextFile.txt");

            var allWords = text.Split(' ');

            Console.WriteLine("Total words: " + allWords.Length);

        }

        // <summary>
        // Udemy Course C# Basics for Beginners
        // Exercise 76-2
        // Write a program that reads a text file and displays the longest word in the file.
        // </summary>
        public static void Exercise2()
        {
            string text = System.IO.File.ReadAllText(@"E:\CodeArea\C#_Beg\Exercises\Files\TextFile.txt");

            var allWords = text.Split(' ');
            var longestWord = allWords[0];

            for (var i = 1; i < allWords.Length; i++)
            {
                if (allWords[i].Length > longestWord.Length)
                    longestWord = allWords[i];
            }

            Console.WriteLine("Longest word: " + longestWord);

        }
    }
}
