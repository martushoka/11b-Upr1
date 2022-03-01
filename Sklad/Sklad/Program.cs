using System;
using System.Collections.Generic;
using System.Linq;

namespace Sklad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Toys = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0] == "Stop")
                {
                    foreach (var item in Toys)
                    {

                        Console.WriteLine($"{input[1]} –> {input[2]}");
                    }
                    break;
                }

                if (!input[1].StartsWith("d"))
                {
                    Console.WriteLine("Input is not correct!.");
                }


                if (input[0].ToLower() == "Purchase")
                {
                    if (!Toys.ContainsKey(input[1]))
                    {
                        input[2] += input[2];
                        Console.WriteLine($"{input[1]} -> {input[2]}");
                    }
                }

                if (input[0].ToLower() == "Sell")
                {
                    int count = int.Parse(input[2]);
                    if (Toys.ContainsKey(input[2]))
                    {
                        count = -1;
                    }

                    else
                    {
                        Console.WriteLine($"{input[1]} does not exists.!");
                    }

                }

                if (input[0].ToLower() == "All Sale")
                {
                    Toys.Remove(input[2]);
                }


                input = Console.ReadLine().Split();
            }



        }
    }
}
