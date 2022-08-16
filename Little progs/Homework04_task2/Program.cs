/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

string str = Console.ReadLine();
sumOfNumbers(str);
void sumOfNumbers(string str){
    Console.WriteLine(str.ToCharArray().Select(ch => (int)ch - 48).ToArray().Sum());
}