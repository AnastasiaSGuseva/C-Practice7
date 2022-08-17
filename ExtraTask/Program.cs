// Транспонирование - 4

// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.
// Первая строка входного файла INPUT.TXT содержит два натуральных числа 
// N и M – количество строк и столбцов матрицы. В каждой из последующих N строк 
// записаны M целых чисел – элементы матрицы. Все числа во входных данных не 
// превышают 100 по абсолютной величине.

// 3 4
// 5 9 2 6
// 6 2 4 3
// 1 2 8 7  

// 1 2 8 7
// 6 2 4 3
// 5 9 2 6

Console.WriteLine("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < n; i++)
{
    if (i < n / 2)
    {
        for (int j = 0; j < m; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[n - 1 - i, j];
            array[n - 1 - i, j] = temp;
            Console.Write(array[i, j] + "\t");
        }
    }
    else
    {
        for (int j = 0; j < m; j++)
            Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}