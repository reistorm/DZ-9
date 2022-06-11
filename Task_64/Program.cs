// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());
void NaturalNumber(int num)
{
    if ( num > 0)
    {
    NaturalNumber(num - 1);
    Console.Write("{0} ", num);
    }
}

NaturalNumber(num);