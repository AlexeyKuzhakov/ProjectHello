﻿Console.Write("Введите скорость первого друга: ");
int a = int.Parse(Console.ReadLine()); // Скорость первого друга

Console.Write("Введите скорость второго друга: ");
int b = int.Parse(Console.ReadLine()); // Скорость второго друга

Console.Write("Введите скорость собаки: ");
int d = int.Parse(Console.ReadLine()); // Скорость собаки

Console.Write("На каком расстоянии друзья встретятся?  ");
int x = int.Parse(Console.ReadLine()); // Расстояние на котором закончить цикл

int friend = 2;
int count = 0;
int time = 0;

Console.Write("Введите дистанцию: ");
int distance = int.Parse(Console.ReadLine()); //Дистанция между друзьями

while(distance > x)
{
    if (friend == 1)
    {
        time = distance / (a + d);
        friend = 2;
    }

    else
    {
        time = distance / (b + d);
        friend = 1;
    }

distance = distance - (b + a) * time;
count = count +1;

}

Console.WriteLine("Собака пробежит " + count + " раз");
