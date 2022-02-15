using System;
using System.Collections.Generic;
using System.Linq;

namespace Spisuchen_manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while(true)
            {
                string input = Console.ReadLine();

                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
                if (int.TryParse(input,out int n) == true)
                {
                    numbers.Sort();

                    Console.WriteLine(string.Join(" ", numbers));
                }

                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "add":
                        {
                            int element = int.Parse(commands[1]);
                            int index = int.Parse(commands[2]);

                            
                            if (!numbers.Contains(element))
                            {
                                numbers.Insert(element, index);
                            }

                            break;
                        }

                    case "contains":
                        {
                            int numberToSearch = int.Parse(commands[1]);
                            if (numbers.Contains(numberToSearch))
                            {
                                Console.WriteLine(numbers.IndexOf(numberToSearch));
                            }
                            else
                            {
                                Console.WriteLine("Sasho", "Petar");
                            }
                            break;
                        }
                }


            }
        }

    }
}
