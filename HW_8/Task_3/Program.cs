/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.WriteLine("Матрица № 1:");
int[,] arrayMatrix1 = CreatingRandomArray(2, 3);
OutputArrayToConsole(arrayMatrix1);
Console.WriteLine("Матрица № 2:");
int[,] arrayMatrix2 = CreatingRandomArray(3, 4);
OutputArrayToConsole(arrayMatrix2);
OutputArrayToConsole(MultipliesTwoMatrices(arrayMatrix1, arrayMatrix2));


// Метод для вычисления произведения двух матриц.
int[,] MultipliesTwoMatrices(int[,] arrayMatrix1, int[,] arrayMatrix2)
{
    /*Матрицу arrayMatrix1 можно умножить на матрицу arrayMatrix2 только в том случае, 
    если число столбцов матрицы arrayMatrix1 равняется числу строк матрицы arrayMatrix2.
    Проверяем возможность умножения.*/
    int[,] arrayMultipliesMatrices = new int[arrayMatrix1.GetLength(0), arrayMatrix2.GetLength(1)];
    if (arrayMatrix1.GetLength(1) != arrayMatrix2.GetLength(0))
    {
        Console.WriteLine("Матрицы невозможно перемножить");
    }
    else
    {
        Console.WriteLine("Произведение матриц:");
        /*Перемножаем матрицы*/
        for (int i = 0; i < arrayMatrix1.GetLength(0); i++)
        {
            for (int j = 0; j < arrayMatrix2.GetLength(1); j++)
            {
                for (int k = 0; k < arrayMatrix2.GetLength(0); k++)
                {
                    arrayMultipliesMatrices[i, j] += arrayMatrix1[i, k] * arrayMatrix2[k, j];
                }
            }
        }
    }
    return arrayMultipliesMatrices;
}


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
            int number = Convert.ToInt32(num.Next(1, 10));
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