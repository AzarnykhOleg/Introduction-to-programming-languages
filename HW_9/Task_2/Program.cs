/* Задача 66:
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine(FindsSumNumbersFromMtoN(3, 8));

int FindsSumNumbersFromMtoN(int m, int n)
{
    if (m == 0)
    {
        return (n * (n + 1)) / 2;
    }
    else if (n == 0)
    {
        return (m * (m + 1)) / 2;
    }
    else if (m == n)
    {
        return m;
    }
    else if (m < n)
    {
        return n + FindsSumNumbersFromMtoN(m, n - 1);
    }
    else
    {
        return n + FindsSumNumbersFromMtoN(m, n + 1);
    }
}