/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
k1 = 5, b1 = 2, k2 = 9, b2 = 4, -> (-0, 5; -0,5) */

Console.WriteLine("[{0}]", string.Join("; ", intersectionPointCoordinate()));

// Метод для вычисления координат точки пересечения двух прямых.
double[] intersectionPointCoordinate()
{
    string[] array = new string[4] { "k1", "b1", "k2", "b2" };
    double[] arrayCoordinateValues = new double[4];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.WriteLine($"Прямые заданы уравнениями вида y = k1 * x + b1 и y = k2 * x + b2\nВведите значение {array[i]}");
        arrayCoordinateValues[i] = InputDouble(Console.ReadLine());
    }
    double[] intersectionPoint = new double[2];
    intersectionPoint[0] = (arrayCoordinateValues[3] - arrayCoordinateValues[1]) / (arrayCoordinateValues[0] - arrayCoordinateValues[2]);
    intersectionPoint[1] = (arrayCoordinateValues[0] * intersectionPoint[0] + arrayCoordinateValues[1]);
    return intersectionPoint;
}

// Метод для валидации вводимых параметров.
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
