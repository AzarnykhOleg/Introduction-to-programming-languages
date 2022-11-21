/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
a = -9 b = -3->max = -3
*/

Console.Write("Введите первое число: ");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num_2 = Convert.ToDouble(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine($"{num_1} больше {num_2}");
}
else if (num_1 < num_2)
{
    Console.WriteLine($"{num_2} больше {num_1}");
}
else
{
    Console.WriteLine("Числа равны");
}


