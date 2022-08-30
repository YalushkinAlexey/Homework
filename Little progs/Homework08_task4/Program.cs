/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Clear();

Console.Write("Размеры массива (AxBxC) в студию: \nA = ");
int a = int.Parse(Console.ReadLine());
Console.Write("B = ");
int b = int.Parse(Console.ReadLine());
Console.Write("C = ");
int c = int.Parse(Console.ReadLine());
int [,,] array = new int [a,b,c];
PrintArrayXYZ(FillArrayXYZ(array));

int [,,] FillArrayXYZ(int[,,]array)     //заполнение массива псевдослучайными числами в диапазоне 100 >= x > 1000
{
    for (int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            for(int k = 0; k < c; k++)
            {
                array[i,j,k] = new Random().Next(100, 1000);
            }
        }
    }
    return array;
}

void PrintArrayXYZ(int[,,]array)    //вывод в консоль результатов, согласно условию
{
    for (int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            for(int k = 0; k < c; k++)
            {
                Console.WriteLine($"число {array[i,j,k]}({i}:{j}:{k})");
            }
        }
    }
}
