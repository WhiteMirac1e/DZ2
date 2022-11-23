Console.WriteLine("Введите количество строк первой матрицы : ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы и количество строк второй матрицы: ");
int column1Row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы : ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] firstMartrix = new int[rows1, column1Row2];
GetArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
PrintArray(firstMartrix);

int[,] secondMartrix = new int[column1Row2, columns2];
GetArray(secondMartrix);
Console.WriteLine($"\nВторая матрица:");
PrintArray(secondMartrix);

int[,] resultMatrix = new int[rows1,column1Row2];
MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < rows1; i++)
  {
    for (int j = 0; j < column1Row2; j++)
    {  
      int sum = 0;
      for (int g = 0; g < column1Row2; g++)
      {
        sum += firstMartrix[i,g] * secondMartrix[g,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}    
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
     
int[,] GetArray(int[,] inArray)
{
  for (int i = 0; i < inArray.GetLength(0); i++)
  {
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
      inArray[i,j] = new Random().Next(range);
    }
  }
  return inArray;
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
