/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

OutputArrayToConsole(CreatingRandomArray(4, 5));

// Метод для создания массива размером m×n, заполненного случайными вещественными числами.
double[,] CreatingRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    int i = m;
    int j = n;
    for (i = 0; i < (m); i++)
    {
        for (j = 0; j < (n); j++)
        {
            array[i, j] = GeneratingRandomRealNumbers();
        }
    }
    return array;
}


// Метод для генерирования случайных вещественных чисел.
double GeneratingRandomRealNumbers()
{
    Random num = new Random();
    double number = Convert.ToDouble(num.Next(-1000, 1000) / 10.0);
    return number;
}


// Метод для вывода массива в консоль.
void OutputArrayToConsole(double[,] array)
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
