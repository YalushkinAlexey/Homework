/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
Console.Write("введите размерность массива NxN,  N = ");

int n = int.Parse(Console.ReadLine());
int [,] arr = new int [n,n];

int count = 01;
FillSpiral(arr, n);         
PrintArray(arr);
RotateAr(arr);
RotateRa(arr);

int [,] FillSpiral(int[,]arr, int n)
{
    for (int dX = 0; dX < n - 1; dX++)
    {
        // слева направо
        for (int i = 0 + dX; i < n - dX; i++)
        {
            arr[0 + dX, i] = count;
            count++;
        }
        count--;
        //сверху вниз
        for (int i = 0 + dX; i < n - dX; i++)
        {
            arr[i, n - 1 - dX] = count;
            count++;
        }
        count--;
        // справа влево
        for (int i = n - 1 - dX; i >= 0 + dX; i--)
        {
            arr[n - 1 - dX, i] = count;
            count++;
        }
        count--;
        // снизу вверх
        for (int i = n - 1 - dX ; i > 0 + dX ; i--)
        {
            arr[i , 0 + dX] = count;
            count++;
        } 
    }
    return arr;
}

void PrintArray(int[,]array)
{
    for(int i = 0; i < n; i++)
    {
        for (int j = 0;  j < n; j++)
        {
            Console.Write(" {0:D2}", arr[i,j] );
        }
        Console.WriteLine();
    }
}

int[,] RotateAr(int [,] array)              //поворот по часовой на 90
{   
    Console.WriteLine("Повернем по часовой стрелке на 90");
     for(int i = 0; i < n; i++)
    {
        for (int j = n - 1; j >= 0; j--)
        {
            Console.Write(" {0:D2}",array[j, i]);
        }
        Console.WriteLine();
    }
    return array;
}

int[,] RotateRa(int [,] array)              //поворот против часовой на 90
{   
    Console.WriteLine("Повернем против часовой стрелки на 90");
     for(int i = n -1; i >= 0 ; i--)
    {
        for (int j = 0; j < n; j++)
        {
            
            Console.Write(" {0:D2}",array[j, i]);
        }
        Console.WriteLine();
    }
    return array;
}

