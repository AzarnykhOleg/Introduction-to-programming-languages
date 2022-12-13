/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = CreatingRandomArray(4, 5);
OutputArrayToConsole(array);
OutputArithmeticMeanColumnElements(array);


// Метод для создания массива размером m×n, заполненного случайными целыми числами.
int[,] CreatingRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    int i = m;
    int j = n;
    Random num = new Random();
    for (i = 0; i < (m); i++)
    {
        for (j = 0; j < (n); j++)
        {
            int number = Convert.ToInt32(num.Next(1, 100));
            array[i, j] = number;
        }
    }
    return array;
}


// Метод для вывода массива в консоль.
void OutputArrayToConsole(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}      ");
        }
        Console.WriteLine();
    }
}


// Метод для вычисления среднего арифметического элементов в каждом столбце массива и вывода результата в консоль.
void OutputArithmeticMeanColumnElements(int[,] array)
{
    int[] arraySummColumnElements = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arraySummColumnElements[i] += array[j, i];
        }
    }
    double[] arrayArithmeticMeanColumnElements = new double[arraySummColumnElements.Length];
    for (int i = 0; i < arraySummColumnElements.Length; i++)
    {                                          // костыль для вывода результата деления целых чисел в виде дробных.
        arrayArithmeticMeanColumnElements[i] = Math.Round(Math.Pow(array.GetLength(0), -1) / Math.Pow(arraySummColumnElements[i], -1), 2);
    }
    Console.WriteLine("[{0}]", string.Join(";    ", arrayArithmeticMeanColumnElements));
}