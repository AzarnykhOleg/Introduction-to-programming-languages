// Напишите программу, которая принимает на вход два числа (A и B) и метод, который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()

Console.WriteLine("Введите число, возводимое в степень.");
double first = InputDouble();
Console.WriteLine("Введите степень, в которую необходимо возвести первое число).");
int second = InputInt();
double exponentiation = Exponentiation(first, second);
Console.WriteLine(exponentiation);


// Метод для возведения числа First в степень Second.
double Exponentiation(double first, int second)
{
    double result = 1;
    for (int i = 1; i <= second; i++)
    {
        result *= first;
    }
    return Math.Round(result, 2);
}


// Метод для валидации числа возводимого в степень.
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


// Метод для валидации числа степени.
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