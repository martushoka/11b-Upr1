using System;
using System.Collections.Generic;
using System.Linq;

namespace Emaili
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                if (input[0] == "Stop")
                {
                    break;
                }





                if (input[0].ToLower() == "Add")
                {
                    if (!emailList.ContainsKey(input[1]))
                    {
                        emailList.Add(input[1], input[2]);
                    }

                    else
                    {
                        emailList[input[1]] = input[2];
                    }
                }

                if (input[0] == "Sent")
                {
                    if (emailList.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {emailList[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist");
                    }
                }

                input = Console.ReadLine().Split();
            }

            foreach ( var name in emailList)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
            
        }
    }
}
