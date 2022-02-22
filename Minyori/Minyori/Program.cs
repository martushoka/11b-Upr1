using System;
using System.Collections.Generic;
using System.Linq;

namespace Minyori
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> minyori = new Dictionary<string, int>();

            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (!minyori.ContainsKey(word))
                {
                    minyori.Add(word, number);
                }

                else
                {
                    minyori[word] += number;
                }
                word = Console.ReadLine();
                if (word == "stop")
                {
                    break;
                }
                number = int.Parse(Console.ReadLine());
            }

            foreach(var item in minyori)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
