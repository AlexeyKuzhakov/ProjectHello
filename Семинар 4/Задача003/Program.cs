﻿// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(Multiply(a));



int Multiply(int n)
{
    int res = 1;
    for (int i = 1; i <= a; i++)
    {
        res = res * i;
    }
    return res;
}
