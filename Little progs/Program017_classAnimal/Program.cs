/*
Class
*/

internal class Program
{
    class Animal        // Создаем класс Animal
    {
        string typeAnimal = "zzz";          // конструктор объекта в классе   ... тип животины
        string nameAnimal;                                                  // имя животного
        bool hvost;                                                         // есть ли хвост
        bool IsSwim;                                                        // умеет ли плавать
        bool IsFly;                                                         // летает?
        bool IsWalk;                                                        // ходит

        public void printAnimal()                                           // вывод в терминал 
        {
            Console.WriteLine(
                $"тип - {typeAnimal};  кличка - {nameAnimal}; есть хвост? - {hvost}; плавает - {IsSwim}; летает - {IsFly}; ходит - {IsWalk}"
            );
        }
        public static void Main(string[] args)                                 // основная программа
        {
            Console.WriteLine("Введите тип животного, и затем его кличку");
            Animal zoo = new Animal();                                          // Создание объект. Назвали объект zoo           
            zoo.typeAnimal = Console.ReadLine();                                // считываем тип животного 
            string? nameAnimal = Console.ReadLine();                            // имя животного
            zoo.nameAnimal = nameAnimal;                                        // присваиваем имя нашему животному из объекта класс животного
            zoo.IsWalk = true;                                                  
            zoo.hvost = true;
            zoo.printAnimal();                                                  // вызываем функцию из класса Animal
        }
    }
}
