//Създайте променлива с цяло число по ваш избор (не се въвежда от клавиатура, а се задава стойност в самия код).
//Приемайте догадки от потребителя докато той не познае това число. Ако числото, въведено от потребителя е по-малко
//от стойността на променливата, изведете насочващо съобщение - “Your guess is lower”. Съответно ако числото на потребителя
//е по-голямо - “Your guess is higher”. Когато числото е познато изведете съобщение “You win!”

using System;

class Program
{
    static void Main()
    {
        int secretNumber = 42;
        int guess;
        bool isGuessed = false;

        while (!isGuessed)
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());

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
                isGuessed = true;
            }
        }
    }
}
