using System;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public static int Counting(string searchWord, string sentence)
        {
            int jj;
            if (int.TryParse(searchWord, out jj))
            {
                Console.WriteLine("Please use only letters");
                return -1;
            }
            var counter = 0;
            var words = sentence.Split(null);
            foreach (var word in words)
                if (searchWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    counter++;

            return counter;
        }
    }
}