// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 


Console.WriteLine(" Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите первое число");
int b = int.Parse(Console.ReadLine());
int ProizNumbers(int a,int b)
{
    if (b<1) return 1;
    return a*ProizNumbers(a,b-1);
}
int proiz = ProizNumbers(a,b);
Console.WriteLine(proiz);
