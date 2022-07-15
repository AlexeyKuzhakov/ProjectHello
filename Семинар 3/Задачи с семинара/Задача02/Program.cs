/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.Write("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Ответ: " + foundXY(num));
string foundXY (int a)
{
 if(a == 1)
 {
    return "x > 0 & y > 0";
 }
 if(a == 2)
 {
    return "x < 0 & y > 0";
 }
 
 if(a == 3)
 {
    return "x < 0 & y < 0";
 }
 
 if(a == 4)
 {
    return "x > 0 & y < 0";
 }
 return "Ошибка. Введите от 1 до 4";
}
