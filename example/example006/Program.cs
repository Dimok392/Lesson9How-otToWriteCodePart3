// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 6; N = 2. -> "6, 5, 4, 3, 2"
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.WriteLine(" Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());
void PrintNumbers(int m, int n)
{
    if (m == 0)
        return;
    if (m > n )
    {
        PrintNumbers(m - 1, n);
    }
    if (m < n )
    {
        PrintNumbers(m + 1, n);
    }
       Console.Write(m + " ");
}
PrintNumbers(n, m);

// Console.WriteLine(" Введите первое число");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите конечное число");
// int n = int.Parse(Console.ReadLine());
// void PrintNumbers(int m, int n)
// {
//     int saveM = 0;
//     if (m == 0)
//         return;
//     if (m > n)
//     {
//         saveM = m - 1;
//     }
//     if (m < n)
//     {
//         saveM = m + 1;
//     }
//     Console.Write(m + " ");
//     PrintNumbers(saveM, n);
// }
// PrintNumbers(m, n);



