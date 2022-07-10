//Задача1. Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе.

int[] FindSum(int size)
{
    int[] newArray = new int[size];

    int sum = 0;

    for(int i = 0; i < size; i++)
        sum += i;
        
    return newArray; 

}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = FindSum(array);
ShowArray(array);

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] Massiv(int size)
{
  int[]newArray = new int[size];
  
  return newArray;
}

Console.Write("Задайте массив: ");
int massiv = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("[" + massiv + "]");