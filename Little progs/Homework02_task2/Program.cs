/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число");
string str = Convert.ToString(Console.ReadLine());
int i = 0;
foreach (char c in str)
{
    if (char.IsDigit(c))
    {
        i++;
    }
    if (i == 3)
    {
        Console.WriteLine("Третья цифра : " + c);
        return;
    }
}
Console.WriteLine("третьей цифры нет");
