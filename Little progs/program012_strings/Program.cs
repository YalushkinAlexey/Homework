/* Валидация email и имени

*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        string name;
        string email;
        Console.WriteLine("введите имя");
        name = Console.ReadLine();
        string[] names = new string[]{"Alexey",
                            "Ivan",
                            "Pavel",
                            "Dmitry",
                            "Michail"};
        Console.WriteLine(names.Contains(name) ? "Привет, " + name : "Who are you ?");         // сравниваем имя с заранее заданными
        Console.WriteLine("введите e-mail ");
        email = Console.ReadLine();
        if (IsValidEmail(email))                                                                // запускаем проверку е мэйла
        {
            Console.WriteLine("Привет, " + name + " Ваш e-mail:"+email);
        } 
        else {Console.WriteLine("И звать никак и почта кривая");}

    }

    static Boolean IsValidEmail(string email)                                               //собственно сама процедура валидации мэйла
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);                      

            if (addr.Address == email) {
                Console.WriteLine("Норм адрес");
                return true;
            }
        }
        catch
        {
            Console.WriteLine("Неверный адрес");
            return false;
        }
        return false;
    }
}