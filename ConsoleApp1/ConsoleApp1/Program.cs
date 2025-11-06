using System;

class Program
{
    static void Main()
    {
        int secretNumber = 15;

        Console.WriteLine("Опитайте се да познаете числото!");

        while (true)
        {
            Console.Write("Въведете вашата догадка: ");
            int guess;
            bool isNumber = int.TryParse(Console.ReadLine(), out guess);

            if (!isNumber)
            {
                Console.WriteLine("Моля, въведете валидно число.");
                continue;
            }

            if (guess < secretNumber)
            {
                Console.WriteLine("Your guess is lower");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Your guess is higher");
            }
            else
            {
                Console.WriteLine("You win!");
                break;
            }
        }
    }
}
