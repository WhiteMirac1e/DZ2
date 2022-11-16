// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите несколько чисел через пробелы: ");
string numbers  = Convert.ToString(Console.ReadLine());
string[] subs = numbers.Split(' ');

int count = 0;
for (int i = 0; i < subs.Length; i++) 
{
  if (int.Parse(subs[i]) > 0)
  {
    count++;
  }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");
