// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.WriteLine(" Введите первое число");
int n = int.Parse(Console.ReadLine());
int SummNumbers(int n)
{
    if (n == 0) return 0;
    Console.Write(n%10 + " ");
    int summa=SummNumbers(n/10);
    return summa+n%10 ;
}
int summ = SummNumbers(n);
Console.WriteLine(summ);