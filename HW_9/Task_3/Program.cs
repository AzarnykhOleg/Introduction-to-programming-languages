/*Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */


Console.WriteLine(CalcAckFunc(2, 3));

static uint CalcAckFunc(uint n, uint m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n != 0) && (m == 0))
    {
        return CalcAckFunc(n - 1, 1);
    }
    else
    {
        return CalcAckFunc(n - 1, CalcAckFunc(n, m - 1));
    }
}