﻿/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

Console.WriteLine("Эта программа выводит натуральные числа между заданными значениями.");
Console.WriteLine("Введите начальное и последнее значения через пробел и нажмите enter: ");
string[] input = Console.ReadLine().Split();
int m = int.Parse(input[0]);
int n = int.Parse(input[1]);
NaturalNum(m, n);

void NaturalNum(int start, int end)
{
    if (start > end)
    {
        return;
    }
    Console.Write(start + " ");
    start++;
    NaturalNum(start, end);
}
