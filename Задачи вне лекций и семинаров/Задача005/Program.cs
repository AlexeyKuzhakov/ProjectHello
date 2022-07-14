// Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.

Console.Write("Введите двузначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 10 || num > 99)
{
    Console.WriteLine(num + " не двузначное число");
}
else
{
    int second = num % 10;
    int first = num / 10;
    Console.WriteLine("Число после перестановки цифр: " + second + first);
}