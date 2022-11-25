/* 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
 */


Console.Write("Введите порядковый номер дня недели: ");
string text = Console.ReadLine();
if (!int.TryParse (text, out int number))
{
    Console.WriteLine("Вы ввели не число!", number);
}
else
{
    int num = Convert.ToInt32(text);
    if (num > 7 | num < 1)
{
    Console.WriteLine("Такого дня недели не существует");
}
else if (num == 6 | num == 7)
{

    Console.WriteLine("Ура! Выходной!");
}
else
{
    Console.WriteLine("Будни...");
}
}