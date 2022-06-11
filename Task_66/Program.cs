// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов
// в промежутке от M до N. Выполнить с помощью рекурсии.

Console.Write("Задайте число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber1(int m, int n)
{
    if (m > n) return;

    NaturalNumber1(m, n - 1);
    Console.Write($"{n} ");
}
void NaturalNumber2(int n, int m)
{    if (n > m) return;

    NaturalNumber2(n, m - 1);
    Console.Write($"{m} ");
}
if (m < n) NaturalNumber2(m, n);
if (n < m) NaturalNumber1(n, m);