// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.Write("Введите трехзначное число: ");

int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if ( num > 99 && num <= 999 )
    {
     Console.Write("Вторая цифра: " + ((num % 100)-( num % 10 ))/10);
    }
else
{
    Console.WriteLine("Введенное число не трехзначное");
}
