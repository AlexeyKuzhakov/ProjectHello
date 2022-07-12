/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

Console.Write("Введите первое число: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = int.Parse(Console.ReadLine());


if (IsSqr(first, second))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


bool IsSqr(int num1, int num2)
{
    if (num1 * num1 == num2 || num2 * num2 == num1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
