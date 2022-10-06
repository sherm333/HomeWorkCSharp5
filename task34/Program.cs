/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Random rnd = new Random();
int[] arr = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(100, 1000);
}

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    count++;
}

Console.WriteLine($"Количество чётных элементов: {count}");