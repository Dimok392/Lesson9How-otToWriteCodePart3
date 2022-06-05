// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.WriteLine(" Введите первое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int s = int.Parse(Console.ReadLine());
void PrintNumbers(int n,int s)
{
    if (n > s)
        return;
    Console.Write(n + " ");
    PrintNumbers(n + 1,s);
}
PrintNumbers(n,s);