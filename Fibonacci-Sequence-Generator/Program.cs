using System;

namespace FibonacciGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonacci Sequence Generator!");
            Console.WriteLine("Please enter the number of Fibonacci numbers to generate:");

            // Read user input
            int count;
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            // Generate Fibonacci sequence
            int[] fibonacciSequence = GenerateFibonacciSequence(count);

            // Display the generated sequence
            Console.WriteLine("Generated Fibonacci sequence:");
            Console.WriteLine(string.Join(" ", fibonacciSequence));
        }

        // Method to generate Fibonacci sequence
        static int[] GenerateFibonacciSequence(int count)
        {
            int[] sequence = new int[count];
            if (count > 0)
            {
                sequence[0] = 0;
            }
            if (count > 1)
            {
                sequence[1] = 1;
            }
            for (int i = 2; i < count; i++)
            {
                sequence[i] = sequence[i - 1] + sequence[i - 2];
            }
            return sequence;
        }
    }
}
