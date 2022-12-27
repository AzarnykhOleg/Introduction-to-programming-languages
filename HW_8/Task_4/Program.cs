/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1) */


int[,,] array3Darray = CreatingRandomArray(3, 3, 3);
OutputArrayToConsole(array3Darray);


// Метод для создания трёхмерного массива размером M x N x K, заполненного неповторяющимися двузначными числами.
int[,,] CreatingRandomArray(int m, int n, int k)
{
    int arraySize = m * n * k;
    if (arraySize < 90)
    {
        int[,,] array = new int[m, n, k];
        int i = m;
        int j = n;
        int z = k;
        Random num = new Random();
        List<int> numbersOfArray = new List<int>();
        {
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    for (z = 0; z < k; z++)
                    {
                        int number = Convert.ToInt32(num.Next(10, 100));
                        if (!numbersOfArray.Contains(number))
                        {
                            numbersOfArray.Add(number);
                            array[i, j, z] = number;
                        }
                        else
                        {
                            z -= 1;
                        }
                    }
                }
            }
        }
        return array;
    }
    else
    {
        throw new Exception($"Массив невозможно заполнить неповторяющимися двузначными числами, т.к он состоит из {arraySize} элементов");
    }
}


// Метод для построчного вывода массива в консоль с добавлением индекса каждого элемента.
void OutputArrayToConsole(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})      ");
            }
            Console.WriteLine();
        }
    }
}