//Създайте променлива с цяло число по ваш избор (не се въвежда от клавиатура, а се
//задава стойност в самия код). Приемайте догадки от потребителя докато той не познае
//това число. Ако числото, въведено от потребителя е по-малко от стойността на променливата,
//изведете насочващо съобщение - “Your guess is lower”. Съответно ако числото на потребителя
//е по-голямо - “Your guess is higher”. Когато числото е познато изведете съобщение “You win!”.

using System;
{

    Console.WriteLine("Welcome to the Guess the Number game!");

    int secretNumber = 42;

    {
        Console.ReadLine(num);
        if num < secretNumber;
        Console.WriteLine("Your guess is lower");
    else
        Console.ReadLine(num);
        if num > secretNumber;
        Console.WriteLine("Your guess is higher");
    }
}