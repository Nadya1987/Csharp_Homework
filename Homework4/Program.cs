//Задача1. Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе. 
//452 -> 11
//82 -> 10
//9012 -> 12
/*
  int Sum(int num)
  {
    int sot = 0;
    int result = 0;

    for (int i = 0; i < num; i++)
    {
      sot = num - num % 10;
      result = result + (num - sot);
      num = num / 10;
    }
   return result;
  }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = Sum(num);
Console.WriteLine("Сумма цифр в числе: " + sum);*/



//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] newArray = new int [size];

    Console.WriteLine("Введите элементы массива': ");
    for(int i = 0; i< size; i++)
    {
        Console.Write($"Введите {i + 1} элемент: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
ShowArray(array);