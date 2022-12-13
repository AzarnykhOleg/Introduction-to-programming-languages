/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

double[,] randomArray = CreatingRandomArray(8, 8);
OutputArrayToConsole(randomArray);
OutputArrayElementToConsole(randomArray, EnteringValuesArrayElement());


// Метод для поиска элемента в двумерном массиве и вывода его значения в консоль.
void OutputArrayElementToConsole(double[,] randomArray, int[] positionArrayElements)
{
    if (positionArrayElements[0] < randomArray.GetLength(0) & positionArrayElements[1] < randomArray.GetLength(1) & positionArrayElements[0] >= 0 & positionArrayElements[1] >= 0)
    {
        Console.WriteLine($"Элемент {positionArrayElements[0]},{positionArrayElements[1]} = {randomArray[positionArrayElements[0], positionArrayElements[1]]}");
    }
    else
    {
        Console.WriteLine($"Элемента {positionArrayElements[0]},{positionArrayElements[1]} в массиве не существует");
    }
}


// Метод для ввода значений позиций элемента массива.
int[] EnteringValuesArrayElement()
{
    int[] positionArrayElements = new int[2];
    for (int i = 0; i <= positionArrayElements.Length - 1; i++)
    {
        Console.WriteLine("Введите позицию элемента двумерного массива");
        positionArrayElements[i] = InputDouble(Console.ReadLine());
    }
    return positionArrayElements;
}


// Метод для валидации вводимых значений.
int InputDouble(string text)
{
    if (!int.TryParse(text, out int number))
    {
        throw new Exception("Вы ввели НЕ число или не натуральное число!");
    }
    else
    {
        int num = Convert.ToInt32(text);
        return num;
    }
}


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