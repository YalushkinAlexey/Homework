/*
Задача 1: Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


Задача 2: Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
Console.Clear();
int[] array = new int[10];

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

void PlusMinus(int[] array)
{
    int minus = 0; //sec
    int plus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            minus += array[i];
        }
        else
        {
            plus += array[i];
        }
    }
    Console.WriteLine("сумма положительных " + plus + "\nсумма отрицательных = " + minus);
}
PlusMinus( Fillarray (array));
*/


Console.Clear();
int[] array = new int[10];
Exchange(Fillarray(array));

void Exchange(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    Console.WriteLine(string.Join(", ", array));
}

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

