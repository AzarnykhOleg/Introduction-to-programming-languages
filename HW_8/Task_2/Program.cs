/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] array = CreatingRandomArray(4, 5);
OutputArrayToConsole(array);
Console.WriteLine();
OutputStringWithMinimumSumOfElements(array);



// Метод для вывода строки массива с наименьшей суммой элементов.
void OutputStringWithMinimumSumOfElements(int[,] array)
{
    int minStringNumber = 0;
    int minStringSumElements = 99999; // Доработать до присвоения переменной максимально возможного числа ----------------
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minStringSumElements_1 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            minStringSumElements_1 += array[i, j];
        }
        if (minStringSumElements_1 < minStringSumElements)
        {
            minStringNumber = i;
            minStringSumElements = minStringSumElements_1;
        }
    }
    Console.Write($"строка № {minStringNumber}, сумма элементов: {minStringSumElements}");
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