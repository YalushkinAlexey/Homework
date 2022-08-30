/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
MinSumOfLineArray(array);

int[,] FillArray(int[,] array) //заполнение массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)   // печать массива
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumOfLineArray(int[,]array)
{
    int minSum = int.MaxValue;
    int minRow = m;
    int sum = 0;
    for (int i = 0; i < m; i++)
    {   
        sum = SumLineElements(array, i);
        if(minSum > sum) 
        { 
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Минимальная сумма элементов  = {minSum} в строке {minRow} ");
}

int SumLineElements(int[,]array, int row)
{
    int sum = 0;
    for (int j = 0 ; j < n; j++)
    {
        sum += array[row , j];
    }
    Console.WriteLine($"trololo {sum}");
    return sum;
}



