using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to Word Counter");
            Console.WriteLine("Please enter your word");
            var searchWord = Console.ReadLine();
            Console.WriteLine("Enter your sentence:");
            var sentence = Console.ReadLine();

            Console.WriteLine("Your word appears:" + RepeatCounter.Counting(searchWord, sentence));
        }
    }
}