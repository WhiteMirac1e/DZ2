//   Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());  
    
double[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
  double[,] result = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      result[i,j] = new Random().NextDouble()*(max-min);
    }
  }
  return result;
}

void PrintArray(double[,] inArray)
{
  for (int i = 0; i <  inArray.GetLength(0) ;  i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i,j]:f2} ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Введите позицию строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию строки: ");
int b = Convert.ToInt32(Console.ReadLine());  
if (a >= rows || b >= colums)
Console.WriteLine("такого числа нет"); 
else
  {
  object c = array.GetValue(a,b);
  Console.WriteLine($"{c:f2}");
  }
