/*
Дано двузначное число. Определить:
а) какая из его цифр больше: первая или вторая;
б) одинаковы ли его цифры.
 */

Console.WriteLine("Введите двузначное число: ");
int n = int.Parse(Console.ReadLine());

int a = n / 10;
int b = n % 10;

if(a > b)
{
    Console.WriteLine("Первая цифра введеного числа больше второй");
}
else if(a < b)
{
    Console.WriteLine("Вторая цифра введеного числа больше первой");
}
else
{
    Console.WriteLine("Цифры введеного числа равны");
}