/*
Написать программу, которая на вход получает массив данных от пользователя через запятую и на выходе выдаёт массив состоящий из четных чисел
пример:
1,2,3,4,5,6,7,8 => 2 4 6 8
*/
string str = Console.ReadLine();
char[] charArr = new char[str.Length];
charArr = str.ToCharArray();
str = "";
for (int i = 0; i < charArr.Length; i++)
{
    if (charArr[i] == ',')
    {
        continue;
    }
    if (charArr[i] % 2 == 0)
    {
        str += charArr[i] + " ";
    }
}
char [] array = str.ToCharArray();
Console.WriteLine(str);

