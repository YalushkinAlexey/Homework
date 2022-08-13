/*
Arrays rotate
*/

Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int [ , ] array = new int [n , m];
FillAr(array);
RotateAr(array);
RotateRa(array);
int[,] FillAr(int [,] array)                        //заполнение массива
{
    
    
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random().Next(0, 10);
            Console.Write(array[i, j]+ " ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] RotateAr(int [,] array)              //поворот по часовой на 90
{   
    Console.WriteLine();
     for(int i = 0; i < n; i++)
    {
        for (int j = m - 1; j >= 0; j--)
        {
            
            Console.Write(array[j, i]+ " ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] RotateRa(int [,] array)              //поворот против часовой на 90
{   
    Console.WriteLine();
     for(int i = n -1; i >= 0 ; i--)
    {
        for (int j = 0; j < m; j++)
        {
            
            Console.Write(array[j, i]+ " ");
        }
        Console.WriteLine();
    }
    return array;
}