/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] getArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

Console.WriteLine("Введите количество эллементов массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] arr = getArray(lenght);
int sum = 0;


for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
    if (i % 2 != 0)
    {
        sum = sum + arr[i];
    }
}

Console.WriteLine();
Console.WriteLine("Суммма элементов на нечетных позициях: " + sum);