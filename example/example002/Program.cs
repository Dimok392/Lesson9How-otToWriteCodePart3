// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine(" Введите первое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int s = int.Parse(Console.ReadLine());
void PrintNumbers(int n,int s)
{
    if (n > s)
        return;
    // Console.WriteLine(s);
    Console.Write(n + " ");
    PrintNumbers(n + 1,s);
}
PrintNumbers(n,s);