/* 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 */

Console.Write("Введите первое число: ");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num_2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num_3 = Convert.ToDouble(Console.ReadLine());

double max_num = num_1;
if (num_2 > max_num)
{
    max_num = num_2;
}
if (num_3 > max_num)
{
    max_num = num_3;
}

Console.WriteLine($"Максимальное из введённых чисел: {max_num}");