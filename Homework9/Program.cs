//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N 
//рекурсивным методом.
//N = 4532 -> 4
int NumberOfDigits(int n)
{
    if (n / 10 > 0)
        return n/n + NumberOfDigits(n / 10);
    return n/n;
}
Console.Write("Введите значение: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumberOfDigits(a));

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
int SumNum(int n, int m)
{
    if (n == m)
        return n;
    else
        return n + SumNum(n + 1, m);
}

Console.Write("Input number 1: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int m = Convert.ToInt32(Console.ReadLine());

int result = SumNum(n, m);
Console.WriteLine($"Сумма элементов равна {result}");