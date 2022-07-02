
// Task 1
/*void Palindrom (int number)
{
    int dectys = number / 10000;
    int tys = number / 1000;
    int ed = number % 10;

    if(dectys == ed || tys == dectys * 10) Console.WriteLine("Это палиндром!");
        else Console.WriteLine("Не палиндром");
}

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);*/

//Task2

void Cube(int num) 
{ 
     int current = 1; 
     while (current <= num) 
     { 
        int cube = current * current * current; 
        Console.Write(cube + " "); 
        current++; 
     } 
} 

Console.WriteLine("Введите число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 
Cube(number); 

