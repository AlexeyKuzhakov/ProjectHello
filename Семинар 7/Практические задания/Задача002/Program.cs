// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите количество строк и столбцов через пробел: ");
string[] input = Console.ReadLine().Split();
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myarray = GetArray(row, col);
PrintArray(myarray);

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

Console.WriteLine("Введите значение позиции через пробел: ");
string[] position = Console.ReadLine().Split();
int line = int.Parse(position[0]);
int column = int.Parse(position[1]);

if (line > myarray.GetLength(0) || column > myarray.GetLength(1))
{
    Console.WriteLine("Значение позиции за пределами массива.");
}
else
{
    Console.WriteLine("В " + line + " строке и " + column + "столбце, находится " + myarray[line - 1, column - 1]);
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();

    }
}
Console.WriteLine();