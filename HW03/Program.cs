/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int newnum = 0;
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num;

while (i > 0)
{
    newnum = i % 10;
    Console.Write(newnum);
    i = i / 10;
}
if (newnum == num) 
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число НЕ является палиндромом");
}





/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 
*/

/*
int[] array = new int[3];

int[] point1 = new int[3];
int i = 0;
Console.WriteLine("Введите координаты точки х: ");
while (i < 3)
{
    point1[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}

int[] point2 = new int[3];
int j = 0;
Console.WriteLine("Введите координаты точки y: ");
while (j < 3)
{
    point2[j] = Convert.ToInt32(Console.ReadLine());
    j++;
}


x1 = point2[0];
y1 = point1[0];
x2 = point2[1];
y2 = point1[1];
x3 = point2[2];
y3 = point1[2];


double sum = Math.Sqrt(double d);
double a= (double Math.Pow(x1 - y1) + double Math.Pow(double x2, double y2)+ double Math.Pow(double x3, double y3));
*/


/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
    if (i % 1 != 1)
    {
        Console.Write(i * i * i + ", ");
    }
 i ++;
}
*/



