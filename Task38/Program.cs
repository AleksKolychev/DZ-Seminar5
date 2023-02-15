/* Задайте массив целых чисел. 
Найдите разницу между макс. и мин. элементов массива.
*/
Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
    array[i] = new Random().Next(1, 100);
Console.WriteLine($"[{string.Join(" ", array)}]");
int max = array[0]; 
int min = array[0];
foreach (int element in array)
{
    if (min > element)
        min = element;
    if (max < element)
        max = element;
}
Console.WriteLine($"Разница межу max и min:{max - min}");

