/* 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
 */

Console.Write("Введите число: ");
double num_1 = Convert.ToDouble(Console.ReadLine());

if (num_1 == 0)
{
    Console.WriteLine("Это же ноль!");
}
else if (num_1 % 2 == 0)
{
    Console.WriteLine($"{num_1} - чётное число");
}
else
{
    Console.WriteLine($"{num_1} - нечётное число");
}