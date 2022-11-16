// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементов массива
using System;
class Program
{
  public static void Main (string[] args)
  {
    
  int[] GetRandomArray(int size, int minValue, int maxValue)
    {
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
      {
      array[i] = new Random().Next(minValue,maxValue);
      }
    return array;
    }
    
    int[] array = GetRandomArray(8,0,100);
    
    int min = array[0];
    int max = array[0];
    
    for (int i = 0; i < array.Length; i++)
      {
        if (array[i] > max)
        {
          max = array[i];
        }
        if (array[i] < min)
        {
          min = array[i];
        }
      }
    
    int diff = max - min;
    Console.Write($"Разница между максимальным и минимальным элементом массива: [{String.Join(", ", array)}] = {diff}");
  
  }  
}
