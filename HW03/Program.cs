/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

/*
int x = 0;
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = num;
int num2 = 0;
int newnum = 0;

while (i > 0)
{
    x = i % 10;
    Console.Write(x);
    num2 = num2 * 10 + x;
    i = i / 10;
}
newnum = num2;
if (newnum == num) 
{
    Console.Write(" Число является палиндромом");
}
else
{
    Console.Write(" Число НЕ является палиндромом");
}
*/




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


double x1 = point2[0];
double y1 = point1[0];
double x2 = point2[1];
double y2 = point1[1];
double x3 = point2[2];
double y3 = point1[2];

double distance = Math.Sqrt(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2) + Math.Pow(x3 - y3, 2));
Console.Write($"Расстояние между двумя точками: {distance}");
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



