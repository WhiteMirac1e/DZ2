// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());  
  
double[,] array = GetArray(rows, colums, 0, 10);
    
PrintArray(array);
Console.WriteLine("Сортированный массив: ");
Sort(array);
PrintArray(array);
     
double[,] GetArray(int rows, int columns, int min, int max)
{
  double[,] result = new double[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
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
      Console.Write($"{inArray[i,j]:f0} ");
    }
      Console.WriteLine();
  }
}
void Sort(double [,] array)
{
  int columnSize = array.GetLength(1);
  int rowSize = array.GetLength(0);
  for (int column = 0; column <  rowSize ;  column++)
  {
    for (int row = 0; row < columnSize; row++)
    {
      for (int news = 0; news < columnSize - 1; news++)
      {
        if (array[column, news] < array[column, news + 1])
        {
          double temp = array[column, news + 1];
          array[column, news + 1] = array[column, news];
          array[column, news] = temp;
        }
      }
    }
  }    
}
