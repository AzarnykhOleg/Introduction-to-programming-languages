/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine(countPositiveNumbersFunction());

string countPositiveNumbersFunction()
{
    int countPositiveNumbers = 0;
    int countNumbers = 0;
    while (true)
    {
        Console.WriteLine("Введите числа. Для прекращения - введите 'Q'");
        string text = Console.ReadLine();
        if (text == "Q")
        {
            return ($"Введено {countNumbers} чисел, из которых {countPositiveNumbers} - положительных.");
        }
        else if (InputDouble(text) > 0)
        {
            countNumbers++;
            countPositiveNumbers++;
        }
        else
        {
            countNumbers++;
        }
    }
}

// Метод для валидации вводимых чисел.
double InputDouble(string text)
{
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
