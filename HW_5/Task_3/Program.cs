// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// Задаём массив.
double[] array = new double[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100) + Math.Round(rand.NextDouble(), 2);
}
   
// Выводим исходный массив.
Console.WriteLine("[{0}]", string.Join(", ", array));

// Используем метод и выводим результат в консоль.
double difference = DifferenceNumbersArray(array);
Console.WriteLine(difference);

// Метод, который выводит в консоль разницу между максимальным и минимальным элементов массива.
double DifferenceNumbersArray(double[] array)
{
    double MinNum = array[0];
    double MaxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (MinNum > array[i])
        {
            MinNum = array[i];
        }
        else if (MaxNum < array[i])
        {
            MaxNum = array[i];
        }
    }
    return Math.Round(MaxNum - Math.Abs(MinNum), 2);
}