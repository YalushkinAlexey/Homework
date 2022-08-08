// Elochka 
// Developers by Konkov M.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int n = 5, m = 9;                             // Размерность массива
        int[ , ] arr = new int[n , m];                  // инициализация массива

        for (int i = 0; i < n; i++)                     // запускаем внешний цикл  ось OY
        {
            for (int j = 0; j < m; j++)                 // запускаем внутренний цикл ось ОХ
            {
                if (j >= m/2 - i && j <= m/2 + i)       // Условие заполнения елочки
                arr[i , j] = 1;                         // в ячейку с определенным индексом (по условию) закидываем значение
                
                Console.Write(arr[i , j] + " ");        // выводим в терминал
            }
            Console.WriteLine(" ");                     // этот нужен чтобы перескочить на новую строку
        }
    }
}