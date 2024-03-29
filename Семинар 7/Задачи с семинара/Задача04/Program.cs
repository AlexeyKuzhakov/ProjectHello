﻿// Найти сумму элементов по диагонали

int[,] array =
{
    { 1, 4, 7, 2},
    { 5, 9, 2, 3},
    { 8, 4, 2, 4}
};

Console.WriteLine($"Сумма = {SumDiagonal(array)}");

static int SumDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += array[i, j];
            }
        }
    }
    return sum;
}