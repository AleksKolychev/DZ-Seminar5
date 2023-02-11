/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

Console.Clear();
Console.Write("Введите количество элементов:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for (int i = 0; i < array.Length; i++)
    array[i] = Math.Abs(new Random().Next(100, 1000));
Console.WriteLine($"[{string.Join(", ", array)}]");
int countEven = 0, countOdd = 0;
foreach (int element in array)
{
    if(element % 2 == 0)
    countEven ++;
    else
    countOdd ++;
}
Console.WriteLine($"Четных:{countEven}");
Console.WriteLine($"Нечетных:{countOdd}");