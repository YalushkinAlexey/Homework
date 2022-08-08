//Галочка
// 


internal class Program
{

 private static void Main(string[] args)
    {
        Console.Clear();
        int n = 25, m = 91;                             // Размерность массива
        char[ , ] arr = new char[n , m];                // инициализация массива символов

        for (int i = 0; i < n; i++)                     // запускаем внешний цикл  ось OY
        {
            for (int j = 0; j < m; j++)                 // запускаем внутренний цикл ось ОХ
            {
                if (j == m/2 - i || j == m/2 + i)       // Условие заполнения елочки
                arr[i , j] = '^';                       // в ячейку с определенным индексом (по условию) закидываем значение
                
                Console.Write(arr[i , j] + " ");        // выводим в терминал
            }
            Console.WriteLine(" ");                     // этот нужен чтобы перескочить на новую строку
        }
    }
}