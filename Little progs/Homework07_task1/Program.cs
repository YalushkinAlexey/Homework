/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();
Console.WriteLine("вводим кол-во строк, затем кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
double [ , ] array = new double [n , m];
FillArray(array);

double[,] FillArray(double [,] array)                        //заполнение массива
{   
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = Math.Round(GetRandomeNumber(-100, 100),1);
            Console.Write("["+array[i, j]+ "] ");
        }
        Console.WriteLine();
    }
    return array;
}

double GetRandomeNumber(double minimum, double maximum)             //генерируем число типа double
{
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}