﻿void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index < lenght)
    {
        collection[index]= new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);
Console.WriteLine();

int pos = IndexOf(Array, 5);
Console.WriteLine(pos);



