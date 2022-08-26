
// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
//  Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
//int m = 3;
//int n = 4;
int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = i+j;
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}

/*
Задача 2: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

// Console.Clear();
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [m,n];
// QuadArray(FillArray(array));

// int[,] FillArray(int [,] array)                        //заполнение массива
// {   
//     for(int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i,j] = new Random().Next(0, 10);
//             Console.Write("["+array[i, j]+ "] ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return array;
// }

// int [,] QuadArray(int[,]array)                         // индексы начинаются с 0, если кто забыл
// {
//     for(int i = 0; i < m; i++ )
//     {
//         for(int j = 0; j < n; j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0 )              // выбираем 0, 2, 4, 6
//             {
//                 array[i,j] = array[i,j] * array[i,j];
                
//             }
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
    
//     }
//     return array;
// }

//Ноль делится не только на 2, он делится на все степени двойки. 
//В этом смысле, 0 является «наиболее чётным» числом из всех чисел.

