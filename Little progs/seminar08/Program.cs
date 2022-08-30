/*
Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2

Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

Console.Clear();

int m = 4;
int n = 4; 
int [,] ar = new int [m,n];
int [,] arMin = new int [m-1,n-1];
// int [,] arMin = new int [m, n];

FillArray(ar);
PrintArray(ar);
SortArr(ar );


int [,] SortArr(int[,]ar)
{
    int min = ar[0,0];
    int minI = 0;
    int minJ = 0;
    int x = 0;
    int y = 0;
    
    for (int i = 0; i < m; i++ )
    {
        for (int j = 0; j < n; j++)
        {
            if (min > ar[i,j])
            {
                min = ar[i,j];
                minI = i;
                minJ = j;
            }
        }
    }
    for (int i = 0; i < m; i++ )
    {   
        if (i == minI){continue;}
        for (int j = 0; j < n; j++)
        {
            if (j == minJ){continue;}     
            arMin[y,x] = ar[i,j];
            Console.Write(arMin[y,x]+ " ");
            x++;
        }
        y++;
        x=0;
        Console.WriteLine();
    }
    return ar;
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
