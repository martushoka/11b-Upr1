using System;
using System.Collections.Generic;
using System.Linq;

namespace Emaili07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> email = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "List")
                {
                    foreach (var item in email)
                    {

                        Console.WriteLine($"{ item.Key} –> {item.Value}");
                    }
                    break;
                }

                if (input[0] == "Add")
                {
                    string name = input[1];

                    string str = "@";

                    int count = int.Parse(input[2]);
                    if (!email.ContainsKey(name))
                    {
                        email.Add(name, count);
                    }
                    else
                    {
                        email[name] = count;
                    }
                    if (!name.StartsWith(str))
                    {
                        Console.WriteLine($"„Input is not correct!“.");
                    }

                }
                if (input[0] == "Sent")
                {
                    string name = input[1];
                    string str = "@";
                    int count = int.Parse(input[2]);
                    if (email.ContainsKey(name))
                    {
                        email[name] = count - 1;
                    }
                    else
                    {
                        Console.WriteLine($"{name} already exists!");
                    }
                    if (!email.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} alraedy exists!");
                    }
                }
                if (input[0] == "Receive")
                {
                    string name = input[1];
                    int count = int.Parse(input[2]);

                }

            }
        }
    }
}
        
    
