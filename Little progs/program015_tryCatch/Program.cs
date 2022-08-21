/*

Метод int.TryParse(string s, out int result) проверяет, можно ли получить число из строки. 
Если это возможно - возвращает true и полученное число out-параметром, 
иначе возвращает false результатом и default(int) out-параметром.

Try  - Catch
TryParse           
*/

Console.Clear();
int TypoText()
{
    string stroka = "123";
    bool text = int.TryParse(stroka, out int result);
    return result;
}

int result = TypoText();

try
{
    object str = Console.ReadLine();
    int num = Convert.ToInt32(str);
    Console.WriteLine(num*2 + " " + result);
}
catch (Exception e)
{
    Console.WriteLine("так не пойдет");
}

