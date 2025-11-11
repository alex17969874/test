//Въведете положително цяло число от клавиатура и изведете на екрана всички негови
//делители, които са по-малки от него на един ред, разделени с запетая и празно място след нея.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Divisors: ");

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                if (i < number / 2 && number % (i + 1) == 0)
                    Console.Write(i + ", ");
                else
                    Console.Write(i + (i == number - 1 ? "" : ", "));
            }
        }

        Console.WriteLine();
    }
}
