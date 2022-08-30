﻿/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.WriteLine(
    "Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором;\n в этом случае говорят, что матрицы согласованы"
);
Console.WriteLine("Введите размерность матриц А(m * n) и B(n * m)");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int[,] matrixA = new int[m, n];
int[,] matrixB = new int[n, m];

Console.Write("Введите значения матрицы А\n");
matrixA = ArrayEnter(m, n);
Console.Write("Введите значения матрицы B\n");
matrixB = ArrayEnter(n, m);
Console.WriteLine();

Console.WriteLine("Матрица А");
PrintArray(matrixA);
Console.WriteLine("Матрица B");
PrintArray(matrixB);
Console.WriteLine("Результирующая матрица ");
PrintArray(ProdArray(matrixA, matrixB));


int[,] ProdArray(int[,] arA, int[,]arB)                                     //ф-ия расчета итоговой матрицы
{
    int [,] prod =new int [arA.GetLength(0), arB.GetLength(1)];
    for (int i = 0; i < arA.GetLength(0); i++)
        {
            for (int j = 0; j < arB.GetLength(1); j++)
            {
                for (int k = 0; k < arB.GetLength(0); k++)
                {
                    prod[i,j] += arA[i,k] * arB[k,j];                       //расчитываем эл-т результ. матр.
                }
            }
        }
    return prod;
}

int[,] ArrayEnter(int x, int y)                                             //Запрашиваем с клав-ры значения матрицы
{
    int [,] array = new int [x, y];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"[{i + 1}:{j + 1}] = ");
            array[i,j] = int.Parse(Console.ReadLine());
        }
    }
    return array;
}

void PrintArray(int[,] array)   // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

