/*
Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()); // Первое число
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()); // Второе число

if (a > b)
{
    Console.WriteLine("Максимальное число " + a);
}
else
{
    Console.WriteLine("Максимальное число " + b);
}