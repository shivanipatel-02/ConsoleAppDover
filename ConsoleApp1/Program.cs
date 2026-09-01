using System;

class Program
{
    static void PrintFibonacci(int n)
    {
        long a = 0, b = 1;
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            long next = a + b;
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int terms = 10; // Number of terms to print
        Console.Write($"Fibonacci Series ({terms} terms): ");
        PrintFibonacci(terms);
    }
}
