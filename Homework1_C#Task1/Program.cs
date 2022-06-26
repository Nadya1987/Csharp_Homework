int numA, numB;

Console.Write("Введите первое число ");
numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
        Console.Write("Большее число " + numA + ", а меньшее число " + numB );
}
else
{
    Console.Write("Большее число " + numB + ", а меньшее число " + numA );
}

