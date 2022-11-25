/* 
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
 */

Console.Write("Введите число: ");
string text = Console.ReadLine();
if (!int.TryParse (text, out int number))
{
    Console.WriteLine("Вы ввели не число!", number);
}
else
{
    int num = Convert.ToInt32(text);
    if (num / 100 < 1)
    {
        Console.WriteLine("Третьей цифры нет.");
    }
    else
    {
        int thirdNum = num;
        while(thirdNum / 100 > 1)
        {
            thirdNum /= 10;
        }
        thirdNum = thirdNum % 10;
        Console.WriteLine($"Третья цифра числа {num} - {thirdNum}");
    }
}