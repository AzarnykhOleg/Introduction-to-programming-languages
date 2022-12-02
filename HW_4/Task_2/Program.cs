// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число.");
int num = InputInt();
int sumNumber = SumDigitsNumber(num);
Console.WriteLine(sumNumber);

// Метод для нахождения суммы цифр введённого числа.
int SumDigitsNumber(int num)
{
    int result = 0;
    for (int i = num; i >= 1; i /= 10)
    {
        result += i % 10;
    }
    return result;
}

// Метод для валидации вводимого числа.
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