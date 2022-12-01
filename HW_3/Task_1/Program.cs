/*/* 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
 */
int num = InputNum();
Console.Write(IsPalindrome(num));



int InputNum()
{
    Console.Write("Введите пятизначное число => ");
    string text = Console.ReadLine();
    if (!int.TryParse(text, out int number))
    {
        Console.WriteLine("Вы ввели НЕ число!", number);
        return -1;
    }
    else
    {
        int num = Convert.ToInt32(text);
        if (num / 100000 >= 1 | num / 10000 < 1)
        {
            Console.WriteLine("Введено НЕ пятизначное число!");
            return -1;
        }
        else
        {
            return num;
        }
    }
}


string IsPalindrome(int num)
{
    int num_1 = num / 10000;
    int num_2 = (num - num_1 * 10000) / 1000;
    int num_4 = (num / 10) % 10;
    int num_5 = num % 10;
    if (num == -1)
    {
        return ($"Ошибка ввода.");
    }
    else if (num_1 == num_5 & num_2 == num_4)
    {
        return ($"Число {num} - палиндром.");
    }
    else
    {
        return ($"Число {num} - НЕ палиндром.");
    }
}

