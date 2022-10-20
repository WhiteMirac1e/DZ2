//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

Console.Write("Введите число: ");

int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string str = Convert.ToString(num);
if ( num > 99 )
    {
     Console.Write("Третья цифра: " + $"{str[2]}");
    }
else
{
    Console.WriteLine("Нет третьей цифры");
}
