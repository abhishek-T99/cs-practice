using System;

class Program
{
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        int n = 5;
        Console.WriteLine($"Factorial of {n} is {Factorial(n)}");
    }
}
