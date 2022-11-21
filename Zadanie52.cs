// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());  
  
double[,] array = GetArray(rows, colums, 0, 10);
    
PrintArray(array);

Average(array);
   
//Average(array);

  
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
      Console.Write($"{inArray[i,j]:f0} ");
    }
      Console.WriteLine();
  }
}
void Average(double [,] array)
{
  int columnsize =array.GetLength(1); 
  double[] b=new double[columnsize];
  for (int column = 0, count = 0; column <  columnsize ;  column++)
  {
    double average = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
      average += array[row,column];
    }
    b[count] = average / array.GetLength(0);
    Console.WriteLine("Среднее арифметическое столбца "+(column+1)+" равно: "+ $"{b[count]:f3}");
    count++;
  }
}
