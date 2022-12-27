/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


int[,] array = CreatingRandomArray(8, 9);
OutputArrayToConsole(array);
Console.WriteLine();
OutputArrayToConsole(SortingArrayRowElements(array));



// Метод для упорядочивания по убыванию элементов каждой строки двумерного массива.
int[,] SortingArrayRowElements(int[,] array)
{
    int[,] sortedArrayRowElements = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] arrayRowElements = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRowElements[j] = array[i, j];
        }
        arrayRowElements = SortingRowElements(arrayRowElements);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            sortedArrayRowElements[i, k] = arrayRowElements[k];
        }
    }
    Console.WriteLine();
    return sortedArrayRowElements;
}


// Метод для сортировки строки двумерного массива.
int[] SortingRowElements(int[] arrayRowElements)
{
    int temp;
    for (int i = 0; i < arrayRowElements.Length; i++)
    {
        for (int j = i + 1; j < arrayRowElements.Length; j++)
        {
            if (arrayRowElements[i] < arrayRowElements[j])
            {
                temp = arrayRowElements[i];
                arrayRowElements[i] = arrayRowElements[j];
                arrayRowElements[j] = temp;
            }
        }
    }
    return arrayRowElements;
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