// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine(" Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());
    if (m>n)
{
    int save;
    save=m;
    m=n;
    n=save;
}
int PrintNumbers(int m, int n)
{
    if (m > n ) return 0;
    Console.Write(m + " ");
    return m+ PrintNumbers(m + 1, n);
}
int summ = PrintNumbers(m, n);
Console.WriteLine();
Console.WriteLine(summ);