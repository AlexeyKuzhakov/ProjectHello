﻿/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int res = 0;

for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if(arr[i] > 0)
        {
            res++;
        }
    }

Console.WriteLine();
Console.WriteLine("Чисел больше нуля: " + res);