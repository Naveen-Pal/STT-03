using System;
using System.Collections.Generic;
namespace LoopAndFunctionDemo
{
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Approach 1: Using for loop:");
            for (int i = 1; i <= 10; i++){
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\n Approach 2: Using foreach loop:");

            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++){
                numbers.Add(i);
            }
            foreach (int num in numbers) {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nUsing do-while loop:");
            string input;
            do  {
                Console.Write("Enter a number to find factorial or type 'exit' to quit: ");
                input = Console.ReadLine();
                if (input.ToLower() != "exit")
                {
                    int n = Convert.ToInt32(input);
                    Console.WriteLine($"Factorial of {n} = {Factorial(n)}\n");
                }
            } while (input.ToLower() != "exit");

            Console.WriteLine("Program ended.");
        }
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}