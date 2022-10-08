/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/* Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 100;
int num2 = num1 / 10;

Console.Write(num2); */




/* Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

3267912 -> 6 */

/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100) 
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int num2 = num / 1;
    int num3 = num2 % 10;
    Console.Write("Третье число: ");
    Console.Write(num3);
}
else Console.Write("Третьей цифры нет");
*/





/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

/* Console.WriteLine("Введите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 5)
{
    Console.Write("Рабочий день");
}
if (day >= 6 && day <= 7)
{
    Console.Write("Выходной день");
}
if (day > 7)
{
    Console.WriteLine("Неверно введен день");
}
*/



