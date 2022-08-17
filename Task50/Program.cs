// Задача 50
// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или 
// же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите номер строки необходимого элемента: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца необходимого элемента: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > m || b > n)
    Console.WriteLine("Такого элемента в массиве нет.");
else
    Console.WriteLine("Значение заданного элемента: " + array[a - 1, b - 1]);


