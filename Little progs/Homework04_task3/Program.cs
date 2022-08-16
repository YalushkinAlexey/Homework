/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
string text = " Напишите программу, которая задаёт массив из (n) элементов и выводит их на экран.";
Console.WriteLine(text);
Console.Write("\n размерность массива - ");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 0)
{
    Console.WriteLine(" Массив должен иметь длину больше 0 ");
}
else
    Massivchik(n);

void Massivchik(int n)
{
    int[] array = new int[n];
    Console.Write("[");
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    Console.Write(string.Join(", ", array));
    Console.Write("]");
}
