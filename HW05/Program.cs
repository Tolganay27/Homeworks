/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

/*
int[] array2 = new int[4];
int length = array2.Length;
int i = 0;
int index = 0;
int result = 0;
Console.Write("[");
while(index < length)
{
    array2[i] = new Random().Next(101, 1000);
    index++;
    Console.Write($"{array2[i]}, ");
    if (array2[i] % 2 == 0)
    {
        result = result + 1;
    }
}
Console.WriteLine("]");
Console.WriteLine(result);
*/






/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
int[] array2 = new int[6];
int length = array2.Length;
int i = 0;
int index = 0;
int sum = 0;

Console.Write("[");
while(index < length)
{
    array2[i] = new Random().Next(101, 1000);
    index++;
    Console.Write($"{array2[i]}, ");
    if (index % 2 == 0)
    {
        sum = sum + array2[i];
    }
}
Console.WriteLine("]");
Console.WriteLine(sum);
*/



/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

/*
int[] array2 = new int[5];
int length = array2.Length;
int i = 0;
int index = 0;
int result = 0;
int min = 100;
int max = 0;
Console.Write("[");
while(index < length)
{
    array2[i] = new Random().Next(1, 100);
    index++;
    Console.Write($"{array2[i]}, ");
    if (array2[i] < min) min = array2[i];
    if (array2[i] > max) max = array2[i];
    result = max - min;
}
Console.WriteLine("]");
Console.WriteLine(result);
*/
