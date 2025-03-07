using System;

class Program
{
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        return GCD(b, a % b);
    }

    static void Main()
    {
        int a = 56, b = 98;
        Console.WriteLine($"GCD of {a} and {b} is {GCD(a, b)}");
    }
}
