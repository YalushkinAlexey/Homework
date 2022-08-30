﻿/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/


Console.Clear();
Console.Write("M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
DigitInRange(m);

int DigitInRange(int m)
{
    if (m == n )
    {
        Console.Write(n);
        return n;
    }
    else 
    Console.Write(m + ", ");
    return DigitInRange(m + 1);

}
