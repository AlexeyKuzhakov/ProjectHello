/*
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координату х1 ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1 ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату х2 ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2 ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Длина отрезка = " + GetLength(x1,y1,x2,y2));




double GetLength(int x1, int y1, int x2 , int y2)
{
    double Distance = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    return Distance;
}
