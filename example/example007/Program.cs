// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine(" Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int n = int.Parse(Console.ReadLine());
int PrintNumbers(int m, int n)
{
    int summ = 0;
    if (m == 0)
        return ;
    if (m > n)
    {
       int summa=summa+ PrintNumbers(m - 1, n);
       return summa;
    }
    if (m < n)
    {
        int summa=summa+ PrintNumbers(m + 1, n);
        return summa;
    }
    Console.Write(m + " ");
    Console.WriteLine(summa);


}
int summ = PrintNumbers(n, m);
Console.WriteLine(summ);