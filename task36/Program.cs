/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Random rnd = new Random();
int[] arr = new int[4];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(2, 10);
}

var result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int summ = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 == 0)
        summ = summ + arr[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {summ}");