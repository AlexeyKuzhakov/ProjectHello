/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.Write("Введите Y координату первой прямой: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X координату первой прямой: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите Y координату второй прямой: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите X координату второй прямой: ");
double x2 = Convert.ToDouble(Console.ReadLine());

double x = (x1 - y1) / (y2 - x2);
double y = y2 * ((x1 - y1) / (x2 - y2)) + y1;
Console.Write("Точка пересечения прямых: " + Math.Round(x, 2));
Console.Write("; ");
Console.Write(Math.Round(y, 2));
