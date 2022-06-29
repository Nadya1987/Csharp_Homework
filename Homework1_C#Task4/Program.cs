
int number;

Console.Write("Привет! Введи любое число ");
number = Convert.ToInt32(Console.ReadLine());

while (number > 1)
{
    if(number % 2 == 0)
    {
        Console.Write("Вот такие чётные числа " + number);
        number = number + 1;
    }

}
