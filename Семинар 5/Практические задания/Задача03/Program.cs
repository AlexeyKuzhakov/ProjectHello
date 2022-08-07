/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] getArray(int n)
{
    double[] arr = new double[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 100) + rnd.NextDouble();
    }
    return arr;
}



Console.WriteLine("Введите количество эллементов массива: ");
int lenght = int.Parse(Console.ReadLine());
double[] arr = getArray(lenght);
double min = arr[0];
double max = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(Math.Round(arr[i], 2) + " ");
}

for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
    }
}

for (int i = 0; i < arr.Length; i++)
{
    if (max < arr[i])
    {
        max = arr[i];
    }
}

Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным числом: " + Math.Round(max - min, 2));