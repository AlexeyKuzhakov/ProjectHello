/*
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

Console.Write("Введите координаты x ");
int xInput = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y ");
int yInput = int.Parse(Console.ReadLine());

int result = getQuarter(xInput, yInput);
Console.WriteLine("Координаты находятся в четверти " + result);

int getQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }
    return 0;
}
