//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.    0,5 7 -2 -0,2    1 -3,3 8 -9,9   8 7,8 -7,1 9
/* ЗАДАЧА РЕШЕНА
double[,] CreateRandom2dArray(int rows, int columns)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().NextDouble() * 40.06-20.05;

    return newArray;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);
*/



//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив: //1 4 7 2 //5 9 2 3   //8 4 2 4   //17 -> такого числа в массиве нет

/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next();

    return newArray;
}

void Show2dArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}


int FindEl(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    if (rows > array.GetLength(0) || columns > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента {rows} строки и {columns} столбца равно {array[rows - 1, columns - 1]}");
    }
}


Console.Write("Input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

FindEl(rows, columns);*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
//в каждом столбце.
//Например, задан массив:  1 4 7 2;  5 9 2 3; 8 4 2 4; 
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[] ASum(int[,] array)
{   
    double[] newArray = new double[array.GetLength(1)];
    double sum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {   
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
        }
       
       newArray[i] = sum / array.GetLength(0);
    }
    return newArray;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.Write("Среднее арифметическое элементов в каждом столбце: ");
Show2dArray(ASum(myArray));*/
