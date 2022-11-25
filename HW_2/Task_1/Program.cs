/*/* 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */

Console.Write("Введите трёхзначное число: ");
string text = Console.ReadLine();
if (!int.TryParse (text, out int number))
{
    Console.WriteLine("Вы ввели не число!", number);
}
else
{
    int num = Convert.ToInt32(text);
    if (num / 1000 >= 1 | num / 100 < 1)
{
    Console.WriteLine("Введено НЕ трёхзначное число!");
}
else
{
    int secondNum = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {num} => {secondNum}");
}
}


