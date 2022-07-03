
// Task1
/*
int SecondNumber(int num)
{
    int dec = num % 100;

    int result = dec / 10;
    return result;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int second = SecondNumber(number);
Console.WriteLine(second);*/

//Task2    

/*void ThirdNum(int num)
{
    int ed = num % 10;
    
    if(num > 100 && ed >= 0) Console.WriteLine("Третья цифра: " + ed);
    if(num < 100) Console.WriteLine("Третьей цифры нет. ");
}

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

ThirdNum(num);*/


//Task3


void ShowOutput (int day)
{
    if(day >= 1 && day <= 5) Console.WriteLine("К сожалению, это не выходной...");
    if(day >= 6 && day <= 7) Console.WriteLine("УРА, ВЫХОДНОЙ!");
    if(day > 7) Console.WriteLine("Такого дня еще нет");
}

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

ShowOutput (day);
