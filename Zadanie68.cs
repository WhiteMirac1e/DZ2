// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());

int Ack( int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if ((m > 0) && (n == 0))
{
return Ack(m - 1, 1);
}
else if ((m > 0) && (n > 0))
{
return Ack(m - 1, Ack(m, n - 1));
} else
return n + 1;
}

if (m < 0 || n < 0)
{ 
    Console.WriteLine("Введите два неотрицательных числа m и n ");
    return;
}
Console.WriteLine("A(m,n) = " + Ack(m, n));
