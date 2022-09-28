/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
int[] massiv = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите {0}-й элемент", i + 1);
    massiv[i] = int.Parse(Console.ReadLine());
}

var result = string.Join(", ", massiv);
Console.Write($"Массив: [{result}]");