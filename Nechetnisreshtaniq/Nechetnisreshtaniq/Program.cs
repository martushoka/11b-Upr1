using System;
using System.Collections.Generic;
using System.Linq;

namespace words
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            var input = Console.ReadLine().Split();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 1);
                }
                else
                {
                    words[word] += 1;
                }
            }
            var listOfWords = new List<string>();

            foreach (var word in words)
            {
                if (word.Value % 2 != 0)
                {
                    listOfWords.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", listOfWords));







        }
    }
}
