// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Введите число элементов");
int num = Convert.ToInt32(Console.ReadLine());

int[] randomArray = new int[num];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,99);
    Console.Write(randomArray[i] + " ");
}
