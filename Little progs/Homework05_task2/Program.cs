/*
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] Fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    Console.WriteLine(string.Join(", ", array));
    return array;
}
void SumOfNotEven(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine("Сумма элементов на нечетных позициях = " + sum);
}

Console.Clear();
Console.Write("Задайте размер массива N = ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 1)
{
    Console.WriteLine("Маааалавата будет. Ставим N = 5");
    n = 5;
}
int[] array = new int[n];
SumOfNotEven(Fillarray(array));
