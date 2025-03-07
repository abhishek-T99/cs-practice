using System;

class Program
{
    static void TowerOfHanoi(int n, char fromRod, char toRod, char auxRod)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {fromRod} to {toRod}");
            return;
        }
        TowerOfHanoi(n - 1, fromRod, auxRod, toRod);
        Console.WriteLine($"Move disk {n} from {fromRod} to {toRod}");
        TowerOfHanoi(n - 1, auxRod, toRod, fromRod);
    }

    static void Main()
    {
        int n = 3;
        TowerOfHanoi(n, 'A', 'C', 'B');
    }
}
