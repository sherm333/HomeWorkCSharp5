/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Random rnd = new Random();
double[] arr = new double[4];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(2, 10);
}

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

double maxNum = arr[1];
double minNum = arr[1];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>maxNum)
    maxNum=arr[i];
    
    if (arr[i]<minNum)
    minNum=arr[i];
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {maxNum-minNum}");