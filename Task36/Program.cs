/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/

Console.Clear();
Console.Write("Введите количество элементов:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine($"[{string.Join(", ", array)}]");

int sumOddIndex = 0;
for (int i = 0; i < n; i++)
    if (i % 2 == 1)
    sumOddIndex = sumOddIndex + array[i];
Console.WriteLine($"Сумма элементов с нечетными индексами: {sumOddIndex}");