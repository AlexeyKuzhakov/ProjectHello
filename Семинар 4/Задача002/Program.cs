// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
/*
string num = Console.ReadLine();
int len = num.Length;
Console.WriteLine(len);
*/
int num = int.Parse(Console.ReadLine());
int i = 0;
while(num != 0 )
{
    num = num / 10;
    i++;
}
Console.Write(i);
