//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int PositiveNum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sum++;

    return sum;
}

Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
int sum = PositiveNum(array);
Console.WriteLine("Чисел больше нуля: " + sum);




//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;

if (k1 == k2 && b1 != b2) Console.WriteLine("Эти прямые - параллельные");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
    Console.WriteLine("x:" + x + " " + "y:" + y);
}

