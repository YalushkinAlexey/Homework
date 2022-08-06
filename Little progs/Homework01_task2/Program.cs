/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/
Console.WriteLine("введите 3 числа по одному ");
int numberA = Convert.ToInt32(Console.ReadLine());      // считываем три числа
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
int max = numberA;                                      // присваиваем значение первого числа переменной max
if (numberB > max ) {                                   // если второе число больше max, то присвоим max значение второго числа
    max = numberB;  
}
if (numberC > max ) {                                   // если третье число больше max, то присвоим max значение третьего числа
    max = numberC;
}
Console.Write("максимальное число : " + max);           // выведем в консоль значение max
