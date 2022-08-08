


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите размер массива m * n, ");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int[ , ] arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {

                 arr[i , j] = new Random().Next(0, 9);
                 Console.Write(arr[i , j] + " ");
                 if (IsSimple(arr[i , j]))                          // вызов функции проверки на простое или нет
                 {
                    sum += arr[i, j];                               // если число простое, то добавим в сумму
                 }
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("Сумма всех простых чисел = " + sum);

    }

    static Boolean IsSimple(int chislo)                      // описание подпрограммы (функции )  тип - Boolean, на вход принимает параметры int
    {
        for (int i = 2; i <= Math.Sqrt(chislo); i ++)
        {
            if (chislo % i == 0){ return false;}             // число не простое
        }
        return true;                                         // число простое
    }
}
