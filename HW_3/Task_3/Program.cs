/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
 */
int num = InputNum();
int[] TableOfCubes = GetTableOfCubes(num);
PrintArray(TableOfCubes);

// Метод для валидации вводимых пользователем значений.
int InputNum()
{
    Console.WriteLine("Введите число.");
    string text = Console.ReadLine();
    if (!int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели НЕ число!", number);
        return -1;
    }
    else
    {
        int num = Convert.ToInt32(text);
        return num;
    }
}

// Метод для формирования массива кубов чисел.
int[] GetTableOfCubes(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 3));
    }
    return array;
}

// Метод для вывода массива кубов чисел в консоль.
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}