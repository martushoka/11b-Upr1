using System;
using System.Collections.Generic;
using System.Linq;


namespace Garderob
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> clothesColor = new Dictionary<string, string>();
            Dictionary<string, int> clothesCount = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0].ToLower() == "show")
                {
                    break;
                }

                if (input[0].ToLower() == "addcolor")
                {
                    if (!input[1].ToLower().StartsWith('t'))
                    {
                        Console.WriteLine("Invalid input!");
                    }

                    else
                    {
                        if (!clothesColor.ContainsKey(input[1]))
                        {
                            clothesColor.Add(input[1], input[2]);
                            clothesCount.Add(input[1], 1);
                        }

                        else
                        {
                            clothesColor[input[1]] = input[2];
                            clothesCount[input[1]] += 1;
                        }
                    }
                }

                if (input[0].ToLower() == "addquantity")
                {
                    if (clothesCount.ContainsKey(input[1]) && clothesCount[input[1]] != 0)
                    {
                        clothesCount[input[1]] += int.Parse(input[2]);
                    }
                }

                if (input[0].ToLower() == "remove")
                {
                    if (!clothesCount.ContainsKey(input[1]) || clothesCount[input[1]] < int.Parse(input[2]) || clothesCount[input[1]] == 0)
                    {
                        Console.WriteLine("Not enough quantity");
                    }

                    else
                    {
                        clothesCount[input[1]] -= int.Parse(input[2]);
                    }
                }

                if (input[0].ToLower() == "empty")
                {
                    foreach (var item in clothesColor.ToList())
                    {
                        clothesColor[item.Key] = "blank";
                    }

                    foreach (var item in clothesCount.ToList())
                    {
                        clothesCount[item.Key] = 0;
                    }

                }

                input = Console.ReadLine().Split();
            }

            int grandTotal = 0;
            foreach (var element in clothesColor)
            {
                string key = element.Key;
                string clothColor = element.Value;
                int clothQuantity = clothesCount[key];
                grandTotal += clothQuantity;

                Console.WriteLine($"{key}: {clothColor} - {clothQuantity}");
            }
            Console.WriteLine($"Grand Total : {grandTotal}");
        }
    }
}
