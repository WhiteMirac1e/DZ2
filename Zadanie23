// Задача 23 Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

void Kub(int N)
{
    if ( N > 0 )
    {
        int count = 1;
        while (count <= N)
        {
            Console.WriteLine(Math.Pow(count, 3));
            count++;
        }
    }
    else
    {
        Console.Write("Не подходит условие");
    }
}

Console.WriteLine("Введите число больше 1: ");
int N = Convert.ToInt32(Console.ReadLine());
Kub(N);
