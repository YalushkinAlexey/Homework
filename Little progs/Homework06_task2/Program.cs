/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


Console.Clear();
string msg =
    "На ввод необходимо подать значения параметров для уравнений. Значения типа double. Выход округляем до 2 знака.";
Console.WriteLine(msg);
Console.WriteLine();
Console.WriteLine("Введите коэф ур-ий b1, k1, b2, k2, для уравнений вида y=k1*x + b1 ");
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
bool isParal = false;
bool isSame = false;
CrossPoint(b1, k1, b2, k2);

void CrossPoint(double b1, double k1, double b2, double k2)
{
    if (b2 == b1 && k1 == k2)
    {
        isSame = true;
        Console.WriteLine("Прямые совпадают");
    }
    if (k1 == k2)
    {
        isParal = true;
        Console.WriteLine("Параллельные прямые");
        return;
    }
    Console.WriteLine(
        "Точка персечения : " + Math.Round((b2 - b1) / (k1 - k2), 2) + "; " + Math.Round((5 * (b2 - b1) / (k1 - k2) + 2),2)
    );
}
