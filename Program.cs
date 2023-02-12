// Напишите программу, которая принимает на вход 
//число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 ->

void main(string[]args)
{
    Console.WriteLine("Введи число: ");
    int n=int.Parse(Console.ReadLine()!);
    int sum=0;
    int ost=0;
    {
        while (n>0)
        {
            ost=n%10;
            sum=sum+ost;
            n=n/10;
        }
        Console.WriteLine($"Сума цифр числа равна {sum}");
    }
}
main(args);

