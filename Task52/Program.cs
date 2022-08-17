// Задача 52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
double[] sumOfColumns = new double[n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "\t");
        sumOfColumns[j] += array[i, j];
    }
    Console.WriteLine();
}

for (int i = 0; i < m; i++)
{
    sumOfColumns[i] = Math.Round(sumOfColumns[i] / m, 1);
}
Console.WriteLine("[" + string.Join(", ", sumOfColumns) + "]");
