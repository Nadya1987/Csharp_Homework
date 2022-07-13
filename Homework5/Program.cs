//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size]; 

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);

    return newArray;
}

int PositiveNum(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;

    return count;
}

void ShowArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size);
ShowArray(array);
Console.WriteLine("Количество четных чисел " + PositiveNum(array));


//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] CreateRandomArray(int size, int min, int max)
{
  int[] newArray = new int [size];

  for(int i = 0; i < size; i++)
    {
      newArray[i] = new Random().Next(min, max + 1);
    }
    return newArray;
}

int SumEl(int[] array)
{
  int sum = 0;
  for(int i = 1; i < array.Length; i++)
  {
    sum += array[i];
    i = i + 1;
  }
  return sum;
}

void ShowArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int sumel = SumEl(array);
Console.WriteLine("Сумма элементов, стоящих на нечётных позициях " + sumel);

//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
//[3 7 22 2 78] -> 76

double[] CreateRandomArray(double size)
{
  double[] array = new double[3];
  
  for(int i = 0; i < size; i++)
    array[i] = new Random().NextDouble();

  return array;
}

double Max(double[] array)
{
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
      {
        if(max < array[i]) max = array[i];
      }
      
    return max;
}

double Min(double[] array)
{
    double min = array[0];

    for( int i = 1; i < array.Length; i++)
      {
        if(min > array[i]) min = array[i];
      }
      
    return min;
}

void ShowArray(double[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
double size = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
double max = Convert.ToDouble(Console.ReadLine());

double[] array = CreateRandomArray(size);
ShowArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + (Max(array) - Min(array)));



//Задача 3 c INT: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива. 
//[3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int min, int max)
{
  int[] array = new int[size];
  
  for(int i = 0; i < size; i++)
    array[i] = new Random().Next(min, max);

  return array;
}

int Max(int[] array)
{
    int max_el = array[0];

    for(int i = 1; i < array.Length; i++)
      {
        if(max_el < array[i]) max_el = array[i];
      }
      
    return max_el;
}

int Min(int[] array)
{
    int min_el = array[0];

    for(int i = 1; i < array.Length; i++)
      {
        if(min_el > array[i]) min_el = array[i];
      }
      
    return min_el;
}

void ShowArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + (Max(array) - Min(array)));
*/