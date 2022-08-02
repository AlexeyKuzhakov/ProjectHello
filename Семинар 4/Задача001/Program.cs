//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.WriteLine("ВВедите число");
int a = int.Parse(Console.ReadLine());
int numbersSum = 0;

for(int i = 1; i <=a; i++)
{
    numbersSum = numbersSum + i;
}
Console.WriteLine(numbersSum);
