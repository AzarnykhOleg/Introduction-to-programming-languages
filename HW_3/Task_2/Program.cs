/* 
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
 */

Console.WriteLine("Введите трёхмерные координаты первой точки.");
double[] first = InputCoordinates();
Console.WriteLine("Введите трёхмерные координаты второй точки.");
double[] second = InputCoordinates();
double distances = distance(first, second);
Console.WriteLine($"Расстояние между точками равно {distances}");



// Метод для валидации вводимых пользователем значений каждой из координат.
double InputNum()
{
    string text = Console.ReadLine();
    if (!double.TryParse(text, out double number))
    {
        Console.WriteLine("Вы ввели НЕ число!", number);
        return -1;
    }
    else
    {
        double num = Convert.ToDouble(text);
        return num;
    }
}

// Метод для ввода трёхмерных координат.
double[] InputCoordinates()
{
    double[] result = new double[3];
    for (int i = 0; i < 3; i++)
    {
        double num = InputNum();
        result[i] = num;
    }
    return result;
}

// Метод для расчёта расстояния между точками.
double distance(double[] first, double[] second)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(second[0] - first[0], 2) +
                                           Math.Pow(second[1] - first[1], 2) +
                                           Math.Pow(second[2] - first[2], 2)), 2);
    return distance;
}



