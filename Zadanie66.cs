// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if(start == end) return;
    PrintNumbers(start + 1, end);
}

void SumOf(int m, int n, int sum)
{
    if (m > n)
    {
        Console.Write($"сумма натуральных элементов в промежутке от M до N = {sum} ");
        return;
    }
    else
    {
    sum += m;
    SumOf(m + 1, n, sum);
    }
}

if (m > n)
{
    Console.WriteLine("Число M должно быть меньше N, введите правильные числа");
    return;
}
else
{
    PrintNumbers(m, n);
    Console.WriteLine();
    SumOf(m, n, 0);
}
