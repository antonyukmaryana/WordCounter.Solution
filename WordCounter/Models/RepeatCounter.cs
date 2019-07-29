using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Word Counter");
            Console.WriteLine("Please enter your word");
            string searchWord = Console.ReadLine();
            Console.WriteLine("Enter your sentence:");
            string sentence = Console.ReadLine();

            Console.WriteLine("Your word appears:" + Counting(sentence, searchWord));
        }

        static public int Counting(string searchWord, string sentence)
        {
            int jj;
            if (Int32.TryParse(searchWord, out jj))
            {
                return -1;
            } 
            
            int counter = 0;
            string[] words = sentence.Split(null);
            Console.WriteLine(words.Length);
            
            foreach (string word in words)
            {
                if (searchWord.Equals(word,StringComparison.OrdinalIgnoreCase))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
