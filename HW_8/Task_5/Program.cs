/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] array = CreatesSpiralArray(6, 6);
OutputArrayToConsole(array);


// Метод для создания массива размером m×m, заполненного 'спиралью' целыми числами.
int[,] CreatesSpiralArray(int m, int n)
{
    int[,] array = new int[m, m];
    int i = 0;
    int j = 0;
    int num = 0;
    while (num < m * m)
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < m - 1)
            j += 1;
        else if (i < j && i + j >= m - 1)
            i += 1;
        else if (i >= j && i + j > m - 1)
            j -= 1;
        else
            i -= 1;
        num += 1;
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
            if (array[i, j] > 9)
            {
                Console.Write($"{array[i, j]}   ");
            }
            else
            {
                Console.Write($"0{array[i, j]}   ");
            }
        }
        Console.WriteLine();
    }
}
