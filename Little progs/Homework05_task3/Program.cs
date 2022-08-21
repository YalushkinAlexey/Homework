/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}

void MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine("max - min = " + (max - min));
}

Console.Clear();
Console.Write("Задайте размер массива N = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n <= 1) 
{
    Console.WriteLine("Маааалавата будет. Ставим N = 5");
    n = 5;
}
double[] array = new double[n];
MinMax(FillArray(array));
