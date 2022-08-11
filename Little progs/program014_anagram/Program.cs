// Анаграммы

Console.Clear();
Console.WriteLine("введите 2 слова, ");
string str = Convert.ToString(Console.ReadLine()).ToLower();
string str2 = Convert.ToString(Console.ReadLine()).ToLower();
bool flag = true;
if (str.Length != str2.Length){Console.WriteLine("не анаграмма");}
else
{           // КОТ   -  ТОК
    foreach(char c in str)
    {
        if (!str2.Contains(c))
        {
            flag = false;
        }
    }
    Console.WriteLine(flag == true ? "да, это анаграмма": "не анаграмма" );
}
