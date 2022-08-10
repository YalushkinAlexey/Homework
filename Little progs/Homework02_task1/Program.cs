/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
// Работает и с отрицательными значениями

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) <= 99 || Math.Abs(number) >= 1000)
{
    Console.WriteLine("число не соответствует условию");
}
else
{
    Console.WriteLine(Math.Abs(number % 100 / 10));
}
