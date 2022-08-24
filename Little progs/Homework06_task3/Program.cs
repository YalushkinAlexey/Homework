/*
Задайте двумерный массив со случайными числами от -10 до 10. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();
Console.WriteLine("вводим кол-во строк, затем кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int [ , ] array = new int [n , m];
DiagSum(FillArray(array));



int[,] FillArray(int [,] array)                        //заполнение массива
{   
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random().Next(-10, 10);
            Console.Write("["+array[i, j]+ "] ");
        }
        Console.WriteLine();
    }
    return array;
}

void DiagSum (int [,] array)
{
    string str ="";
    int sum = 0;
    int len = 0;
    if (n > m ) {len = m;}
    else len = n;
    for (int i = 0; i < len; i++)
    {
        sum += array[i,i];
        str = str + ", " + array[i,i];
    }
    Console.WriteLine("Элементы главной диагонали"+ str);
    Console.WriteLine("Сумма элементов главной диагонали ="+ sum);
}