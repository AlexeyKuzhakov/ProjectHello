/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Эта программа выводит сумму натуральных чисел между заданными значениями.");
Console.WriteLine("Введите начальное и последнее значения через пробел и нажмите enter: ");
string[] input = Console.ReadLine().Split();
int start = int.Parse(input[0]);
int end = int.Parse(input[1]);
Console.WriteLine("Ссума натуральных чисел равна: " + GetSum(start, end));

int GetSum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + GetSum(++start, end);
}