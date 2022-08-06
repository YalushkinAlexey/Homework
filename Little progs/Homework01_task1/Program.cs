/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
int max, min;
Console.WriteLine("введите первое число");
int numberOne = int.Parse(Console.ReadLine());     // вводим 1е число
Console.WriteLine("введите второе число");
int numberSecond = int.Parse(Console.ReadLine());   // вводим 2е число
Console.Write("число " + (numberOne > numberSecond ? numberOne : numberSecond) + " больше числа " + (numberOne > numberSecond ? numberSecond : numberOne));  // выводим 
