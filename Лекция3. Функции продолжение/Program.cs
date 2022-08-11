//Метод 1 ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор: Алексей");
}
Method1();

//Метод 2 ничего не возвращает, но принимает аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Тест", count: 4);

//Метод3 Возвращает но не принимает аргументов
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Метод 4 Возвращает и принимает аргументы
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "Метод4 ");
Console.WriteLine(res);

//Цикл for
string MethodFor(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string resFor = MethodFor(10, "Цикл for ");
Console.WriteLine(resFor);

// Цикл в цикле
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}