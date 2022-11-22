// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());  
int range = InputNumbers("Введите диапазон: от 1 до ");


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
int[,] array = GetArray(rows, colums);
    
PrintArray(array);

     
int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i,j] = new Random().Next(range);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
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
int Sum(int [,] array, int row)
{
  int rowSize = array.GetLength(0);
  int sum = array[row, 0];
  for (int column = 0; column <  rowSize ;  column++)
  {  
    sum += array[row, column];
  }
  return sum;
}
int minSumLine = 0;
int sumLine = Sum(array, 0);
int rowSize = array.GetLength(0);
for (int row = 1; row < rowSize; row++)
{
  int tempSumLine = Sum(array, row);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = row;
  }
}
Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
