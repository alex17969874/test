using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter: ");
        int n = int.Parse(Console.ReadLine());

        n = Math.Abs(n);
        int product = 1;
        bool hasOdd = false;

        foreach (char ch in n.ToString())
        {
            int digit = ch - '0';
            if (digit % 2 != 0)
            {
                product *= digit;
                hasOdd = true;
            }
        }

        if (hasOdd)
            Console.WriteLine(product);
        else
            Console.WriteLine(0);
    }
}