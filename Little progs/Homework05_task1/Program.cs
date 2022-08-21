/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
void NumbersOfEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("Четных чисел - " + count);
}

Console.Clear();
Console.Write("Задайте размер массива N = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 1)
{
    Console.WriteLine("Маааалавато будет. Ставим N = 5");
    n = 5;
}
int[] array = new int[n];
NumbersOfEven(Fillarray(array));
