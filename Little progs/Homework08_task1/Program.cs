/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Clear();
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
for (int i = 0; i < m; i++)
{
    SortLineOfArray(array, i);
}

PrintArray(array);

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

int[,] SortLineOfArray(int[,] arr, int line)    // сортировка
{   
    int[] tempArray = new int[n];
    tempArray = ToTempArray(arr, line, tempArray);
    
    Array.Sort(tempArray);
    Array.Reverse(tempArray);
    return ToNormalArray(tempArray, line, array);
    
}

int[] ToTempArray(int[,] array, int row, int[] tempArray)   // перекидываем по строчно  во временный массив
{   
    for (int j = 0; j < n; j++)
    {
        tempArray[j] = array[row, j];
    }
    return tempArray;
}

int[,] ToNormalArray(int[] tempArray, int row, int [,] array)  // возвращаем отсортиванные значения
{
    for (int j = n -1 ; j >= 0; j--)
    {
        array[row, j] = tempArray[j];
    }
    return array;
}
