/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Clear();
int count = 0;
int number = 0;
string str = Console.ReadLine();
string strForPrint = "";

while (IsNextInt(str)) //Цикл будет выполнятся пока на входе числа
{
    strForPrint = strForPrint + str + ", "; //Соединяем все числа в одну строчку
    number = Convert.ToInt32(str);
    if (number > 0)
    {
        count++;
    } // Если больше нуля, увеличим счетчик ^по заданию
    str = Console.ReadLine();
}
Console.Write(strForPrint);
Console.Write("из них > 0   -->> " + count);

Boolean IsNextInt(string str) //Функция принимает на вход значение str и выдает true если это число
{
    int number;
    if (int.TryParse(str, out number))
    {
        return (true);
    }
    return false;
}