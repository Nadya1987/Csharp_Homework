
int number;

Console.Write("Привет! Введи любое число ");
number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Это чётное число");
}
else
{
   Console.WriteLine("Это нечётное число ");
}