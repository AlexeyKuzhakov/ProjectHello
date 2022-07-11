/*
Консольная программа, где пользователь будет вводить 2 числа. 
Вывести равны ли числа, и если нет, то какое число больше
*/

Console.WriteLine("Введите первое число: ");
int a = int .Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int .Parse(Console.ReadLine());

if(a == b)
{
    Console.WriteLine("Числа равны");
}
else if(a > b)
{
    Console.WriteLine(a + " больше чем " + b);
}
else
{
    Console.WriteLine(b + " больше чем " + a);
}