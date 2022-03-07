using System;
using System.Collections.Generic;
using System.Linq;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> toys = new Dictionary<string, int>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Stop")
                {
                    foreach (var toy in toys)
                    {
                        Console.WriteLine($"{toy.Key} -> {toy.Value}");
                    }
                    break;
                }

                switch (input[0])
                {
                    case "Purchase":
                        {
                            string toy = input[1];
                            int count = int.Parse(input[2]);

                            if (toy.StartsWith("d"))
                            {
                                if (!toys.ContainsKey(toy))
                                {
                                    toys.Add(toy, count);
                                }

                                else
                                {
                                    toys[toy] += count;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input is not correct!");
                            }

                            break;
                        }

                    case "Sale":
                        {
                            string toy = input[1];

                            if (!toys.ContainsKey(toy))
                            {
                                Console.WriteLine($"{toy} does not exist");
                            }

                            else
                            {
                                if (toys[toy] > 0)
                                {
                                    toys[toy]--;
                                }
                                else
                                {
                                    Console.WriteLine("Sale is not allowed");
                                }
                            }
                            break;
                        }

                    case "All":
                        {
                            foreach (var toy in toys)
                            {
                                toys[toy.Key] = 0;
                            }
                            break;
                        }

                    default:
                        break;
                }
            }
        }
    }
}
