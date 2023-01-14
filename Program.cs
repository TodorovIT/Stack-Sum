using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();
            int sum = 0;
            string com = command[0].ToLower();

            while (com != "end")
            {
                if (stack.Count() == 0)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        stack.Push(input[i]);
                    }
                }
                if (com == "add")
                {
                    stack.Push(int.Parse(command[1]));
                    stack.Push(int.Parse(command[2]));
                }
                else if (com == "remove")
                {
                    int a = int.Parse(command[1]);
                    if (a < stack.Count())
                    {
                        for (int i = 0; i < a; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                com = command[0].ToLower();
            }
            sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}