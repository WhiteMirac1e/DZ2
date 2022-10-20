// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите число от 1 до 7: ");
int day =Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1: day = 1;
    Console.WriteLine("Понедельник - Будний"); break;
    case 2: day = 2;
    Console.WriteLine("Вторник - Будний"); break;
    case 3: day = 3;
    Console.WriteLine("Среда - Будний"); break;
    case 4: day = 4;
    Console.WriteLine("Четверг - Будний"); break;
    case 5: day = 5;
    Console.WriteLine("Пятница - Будний"); break;
    case 6: day = 6;
    Console.WriteLine("Суббота - Выходной"); break;
    case 7: day = 7;
    Console.WriteLine("Воскресенье - Выходной"); break;
    default: Console.WriteLine("Введено неверное число, введите число от 1 до 7"); break;
}