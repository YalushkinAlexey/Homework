/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[] arrayA = new int[3];
        int[] arrayB = new int[3];
        Console.WriteLine("Будете вводить координаты или заполним автоматически? Y/N");
        ConsoleKey key = Console.ReadKey().Key;
        if (key == ConsoleKey.Y)
        {
            Console.WriteLine("Точка А ");
            PointManual(arrayA);
            Console.WriteLine("Точка B ");
            PointManual(arrayB);
            Console.Write("A (" + string.Join(", ", arrayA) + ")");
            Console.Write(",B (" + string.Join(", ", arrayB) + ")");
        }
        else if (key == ConsoleKey.N)
        {
            Console.WriteLine(" Генерируем координаты ");
            Console.Write("Точка А (");
            PointAuto(arrayA);
            Console.WriteLine(")");
            Console.Write("Точка B (");
            PointAuto(arrayB);
            Console.WriteLine(")");
        }
        Console.WriteLine(
            "Расстояние между точкой А и точкой В = " + Math.Round(Distanse(arrayA, arrayB), 2)
        );
    }

    public static void PointAuto(int[] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            arr[i] = new Random().Next(-10, 10);
        }
        Console.Write(string.Join(", ", arr));
    }

    public static void PointManual(int[] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static double Distanse(int[] arr1, int[] arr2)
    {
        double result = 0;
        for (int i = 0; i < 3; i++)
        {
            result += Math.Pow(arr1[i] - arr2[i], 2);
        }
        return Math.Sqrt(result);
    }
}
