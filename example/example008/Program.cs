// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
Console.WriteLine(" Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());
int FunctionAckerman(int m, int n)
{
    int acherm = 0;
    if (m < 0 && n < 0) return 0;
    if (m == 0)
    {
        acherm = n + 1;
        return acherm;
    }
    if (m > 0 && n == 0)
    {
        acherm = FunctionAckerman(m - 1, 1);
        return acherm;
    }
    if (m > 0 && n > 0)
    {
        acherm = FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
        return acherm;
    }
    return acherm;
}
int acherman = FunctionAckerman(m, n);
Console.WriteLine(acherman);

