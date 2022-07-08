int a = 1; //first friend speed
int b = 2; //second friend speed
int d = 5; // dog spees
int friend = 2;
int count = 0;
int time = 0;

Console.Write("Введите дистанцию ");
int distance = Convert.ToInt32(Console.ReadLine());

while(distance > 10)
{
    if (friend == 1)
    {
        time = distance / (d - a);
        friend = 2;
    }

    if (friend == 2)
    {
        time = distance / (d + b);
        friend = 1;
    }

distance = distance - (b - a) * time;
count = count +1;
}

Console.WriteLine("Собака пробежит " + distance + " раз");