﻿/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[8];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 100);
    Console.Write(arr[i]);
    if (i < arr.Length - 1)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write("]");
    }
}
