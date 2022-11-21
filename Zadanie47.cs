// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
    
Console.WriteLine("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine());   

double[,] array =GetArray(rows, colums, 0, 10);
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
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
      Console.Write($"{inArray[i,j]:f5} ");
    }
    Console.WriteLine();
  }
}
