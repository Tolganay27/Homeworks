/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


/*
Console.WriteLine("Введите число: ");
float num1 = Convert.ToInt32(Console.ReadLine());
float num2 = Convert.ToInt32(Console.ReadLine());
float sum = MathF.Pow(num1, num2);
Console.WriteLine($"{sum}");
*/



/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/


/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num3 = 0;
int num2 = 0;
while (num > 0)
{
    num2 = num % 10;
    num = num / 10;
    num3 = num3 + num2;
}

Console.Write("Сумма всех чисел: ");
Console.Write(num3);
*/






/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


/*
int[] array2 = new int[8];
int length = array2.Length;
int i = 0;
int index = 0;
Console.Write("[");
while(index < length)
{
    array2[i] = new Random().Next(1, 20);
    index++;
    Console.Write($"{array2[i]}, ");
}
Console.Write("]");
*/



