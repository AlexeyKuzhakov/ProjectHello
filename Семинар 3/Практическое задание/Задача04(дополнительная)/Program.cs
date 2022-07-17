/*
Напишите программу для вычисления площади круга, прямоугольника и треугольника. 
Ввод данных осуществляется в диалоговом режиме. 
На первом шаге у пользователя запрашивается фигура, площадь которой нужно вычислить. 
На втором шаге пользователь вводит параметры, необходимые для рассчета. Затем, выводится результат.
*/

Console.WriteLine("Эта программа находит площадь фигур: \n 1. Круг \n 2. Прямоугольник \n 3. Треугольник");

Console.Write("Для выбора фигуры введите ее номер: ");
int figure = int.Parse(Console.ReadLine());

if (figure == 1)
{
    Console.WriteLine("Выберете способ расчетов: \n 1. По диаметру \n 2. По радиусу \n 3. По длине окружности");
 
    Console.Write("Для выбора способа введите его номер: ");
    int way = int.Parse(Console.ReadLine());
    if (way == 1)
    {
        Console.Write("Введите диаметр: ");
        double diam = double.Parse(Console.ReadLine());
        Console.Write("Площадь круга равна " + Math.Round((Math.PI * diam * diam / 4), 2));
    }
    else if (way == 2)
    {
        Console.Write("Введите радиус: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Площадь круга равна " + Math.Round((Math.PI * radius * radius), 2));
    }
    else if (way == 3)
    {
        Console.Write("Введите длину окружности: ");
        double len = double.Parse(Console.ReadLine());
        Console.Write("Площадь круга равна " + Math.Round(Math.PI * Math.Pow(len / (2 * Math.PI), 2)));
    }
    else
    {
        Console.WriteLine("Был выбран несуществующий способ!");
    }
}

else if (figure == 2)
{
    Console.Write("Введите длину стороны A: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите длину стороны B: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Площадь прямоугольника равна " + Math.Round(a * b), 2);
}

else if (figure == 3)
{
    Console.Write("Введите длину стороны A: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите длину стороны B: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Введите длину стороны C: ");
    double c = double.Parse(Console.ReadLine());
    double p = (a + b + c) / 2;
    double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    Console.Write("Площадь треугольника равна " + Math.Round(s), 2);
}

else
{
    Console.WriteLine("Была выбрана несуществующяя фигура!");
}