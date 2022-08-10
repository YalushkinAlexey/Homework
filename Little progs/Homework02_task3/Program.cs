/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("введите порядковый номер дня недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber <= 0 || dayNumber > 7)
{
    Console.WriteLine("в неделе 7 дней, вы не правильно ввели номер");
}
else
{
    Console.WriteLine(dayNumber >= 6 ? "да, это выходной" : "пора идти на работу");
}
