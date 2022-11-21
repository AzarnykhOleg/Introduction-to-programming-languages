/* 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
 */

Console.Write("Введите число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (num_1 <= 1 & num_1 >= -1)
{
    Console.WriteLine("Введено недопустимое значение. Задача невыполнима!");
}
else if (num_1 > 1)
{
    while (count <= num_1 / 2)
    {
        Console.WriteLine(count * 2);
        count++;
    }
}
else
{
    count = -1;
    while (count >= num_1 / 2)
    {
        Console.WriteLine(count * 2);
        count--;
    }
}