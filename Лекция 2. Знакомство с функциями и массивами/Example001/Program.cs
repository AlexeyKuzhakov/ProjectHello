//Поиск максимального числа с помощью функции

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 2;
int c1 = 45;

int a2 = 20;
int b2 = 341;
int c2 = 400;

int a3 = 1;
int b3 = 28;
int c3 = 15;

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);