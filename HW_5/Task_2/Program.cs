// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// Задаём массив.
int[] array = new int[4];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
}
   
// Выводим исходный массив.
Console.WriteLine("[{0}]", string.Join(", ", array));

// Используем метод и выводим результат в консоль.
int sum = SumOddElementsArray(array);
Console.WriteLine(sum);

// Метод, который выводит в консоль сумму элементов, стоящих на нечётных индексах в массиве.
int SumOddElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length - 1; i += 2)
    {
        sum += array[i];
    }
    return sum;
}