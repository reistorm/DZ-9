// // Напишите программу вычисления функции Аккермана 
// // с помощью рекурсии. 
// //Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return Akkerman(m - 1, n);
    if (n > 0 && m > 0) return Akkerman(m, n - 1);
}
void Main()
{
    Console.WriteLine(Akkerman(1, 2));
    Console.WriteLine(Akkerman(2, 5));
}
