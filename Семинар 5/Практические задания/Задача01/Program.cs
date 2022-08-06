/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] getArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

Console.WriteLine("Введите количество эллементов массива: ");
int lenght = int.Parse(Console.ReadLine());
int[] arr = getArray(lenght);
int chet = 0;

for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
        if(arr[i] % 2 == 0)
        {
            chet++;
        }
    }

Console.WriteLine();
Console.WriteLine("Четных чисел в массиве: " + chet);