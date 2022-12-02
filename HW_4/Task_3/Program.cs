// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Массив какой длинны Вы хотите создать?");
int arrayLenght = InputInt();
Console.WriteLine("Введите элементы массива.");
double[] array = InputArray(arrayLenght);
Console.WriteLine("[{0}]", string.Join(", ", array));


// Метод для валидации элементов массива.
double InputDouble()
{
    string text = Console.ReadLine();
    if (!double.TryParse(text, out double number))
    {
        throw new Exception("Вы ввели НЕ число!");
    }
    else
    {
        double num = Convert.ToDouble(text);
        return num;
    }
}


// Метод для валидации размера массива.
int InputInt()
{
    string text = Console.ReadLine();
    if (!int.TryParse(text, out int number))
    {
        throw new Exception("Вы ввели НЕ число или НЕ натуральное число!");
    }
    else
    {
        int num = Convert.ToInt32(text);
        return num;
    }
}


// Метод для ввода массива.
double[] InputArray(int arrayLenght)
{
    double[] result = new double[arrayLenght];
    for (int i = 0; i < arrayLenght; i++)
    {
        double num = InputDouble();
        result[i] = num;
    }
    return result;
}