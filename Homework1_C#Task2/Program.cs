
int num1, num2, num3;

Console.Write("Введите первое число ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) 
{
    max = num1;
}
if (num2 > max) 
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.Write("Максимальное число "+ max);
