/*
Задача 3: Задайте массив из 8 случайных чисел. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да
Задача 4: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 12*
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-5, 3);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

void IsHere(int [] array, int x)
{
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] == x)  
        { 
            Console.WriteLine("Да, присутствует");
            return;
        }
    }
    Console.WriteLine("нет такого");

}
Console.Clear();
int [] array = new int[8];
Console.WriteLine("искомое число - ");
int x = Convert.ToInt32(Console.ReadLine());
IsHere(Fillarray(array), x);


/*
int[] Fillarray(int[] array)
{   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 200);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
void NameOfVoid(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100){count ++;}
    }
    Console.WriteLine(count);
}
Console.Clear();
int [] array = new int [12];
NameOfVoid(Fillarray(array));
*/
