/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

*/

internal partial class Program
{
    private static void Main(string[] args)
    {
        // Палиндром слово читающееся в обратном порядке с сохранением смысла.

        Console.Clear();
        Console.WriteLine("Введите слово ");
        string str = Convert.ToString(Console.ReadLine()).ToLower();
        string str2 = ReverseString(str).ToLower();
        Console.WriteLine(str.Equals(str2) ?"Палиндром" : "Не палиндром");
    }
    public static string ReverseString(string str)
    {
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }
}