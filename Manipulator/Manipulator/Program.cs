using System;
using System.Collections.Generic;
using System.Linq;

namespace Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();



            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0].ToLower() == "add")
                {
                    if (!numbers.Contains(int.Parse(input[2])))

                    {
                        numbers.Insert(int.Parse(input[1]), int.Parse(input[2]));
                    }
                }

                if (input[0].ToLower() == "contains")
                {
                    if (numbers.Contains(int.Parse(input[1])))

                    {
                        Console.WriteLine(numbers.IndexOf(int.Parse(input[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }

                if (input[0].ToLower() == "swap")
                {
                    int element1 = numbers.IndexOf(int.Parse(input[1]));
                    int element2 = numbers.IndexOf(int.Parse(input[2]));

                    int temp = numbers[element1];
                    numbers[element1] = numbers[element2];
                    numbers[element2] = temp;

                }

                if (input[0].ToLower() == "remove")
                {
                    if (int.Parse(input[1]) >=0)
                    {
                        numbers.RemoveAt(int.Parse(input[1]));
                    }

                    else
                    {
                        Console.WriteLine("")
                    }
                }
            }
        }
    }
}
