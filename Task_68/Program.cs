// // Напишите программу вычисления функции Аккермана 
// // с помощью рекурсии. 
// //Даны два неотрицательных числа m и n.
int n = int.Parse(Console.ReadLine());
    int m = int.Parse(Console.ReadLine());
int recursion(int m, int n)
{
    // Базовый случай
    if (m == 0) return n + 1;
    // Шаг рекурсии / рекурсивное условие
    else if (n == 0 && m > 0) return recursion(m - 1, 1);
    // Шаг рекурсии / рекурсивное условие
    else return recursion(m - 1, recursion(m, n - 1));

}
int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}


    Console.Write(recursion(m, n)); // вызов рекурсивной функции
    Console.Write(Ack(m, n)); // вызов рекурсивной функции



// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     if (n == 0 && m > 0) return Akkerman(m - 1, n);
//     if (n > 0 && m > 0) return Akkerman(m, n - 1);
// }
// void Main()
// {
//     Console.WriteLine(Akkerman(1, 2));
// }
