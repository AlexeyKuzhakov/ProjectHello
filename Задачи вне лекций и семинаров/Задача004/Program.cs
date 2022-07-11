/*
Дано трехзначное число. Определить, какая из его цифр больше:
а) первая или последняя;
б) первая или вторая;
в) вторая или последняя.
 */

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int a = n / 100;
int x = n / 10;
int b = x % 10;
int c = n % 10;

if(a > c)
{
    Console.WriteLine("Первая цифра больше последней");
}
else if(a < c)
{
    Console.WriteLine("Последняя цифра больше первой");
}    
else
{
    Console.WriteLine("Первая и последняя цифры равны");
}

if(a > b)
{
    Console.WriteLine("Первая цифра больше второй");
}
else if(a < b)
{
    Console.WriteLine("Вторая цифра больше первой");
}   
else
{
    Console.WriteLine("Первая и вторая цифры равны");
}

if(b > c)
{
    Console.WriteLine("Вторая цифра больше последней");
}
else if (b < c)
{
    Console.WriteLine("Последняя цифра больше второй");
}   
else
{
    Console.WriteLine("Вторая и последняя цифры равны");
}