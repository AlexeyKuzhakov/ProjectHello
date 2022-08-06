/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
пример:
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Введите чило A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

int degree = 1;

for (int i = 0; i < b; i++)
{
    degree = degree * a;
}

Console.WriteLine(a + " в натуральной степени " + b + " = " + degree);