// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Задаём массив.
int[] array = new int[15];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}
   
// Выводим исходный массив.
Console.WriteLine("[{0}]", string.Join(", ", array));

// Используем метод и выводим результат в консоль.
int count = NumberEvenNumbersArray(array);
Console.WriteLine(count);

// Метод, который выводит в консоль количество чётных чисел в массиве.
int NumberEvenNumbersArray (int [] array)
{
    count = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        } 
    }
    return count;
}