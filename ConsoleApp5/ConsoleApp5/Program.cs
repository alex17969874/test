int num = int.Parse(Console.ReadLine());
if (num < 0) 
        
    Console.WriteLine("Error");

else
{
    double sum = 1;
    if (num == 0)
    {
        Console.WriteLine(1);
    }
     else
    {
        for (int i = num; i > 0; i--)
        {
            sum = sum * 1;
        }
        Console.WriteLine(sum);
    }
}