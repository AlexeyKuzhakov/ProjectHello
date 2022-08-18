// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк и столбцов массива через запятую: ");
string[] input = Console.ReadLine().Split(',');
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myarray = GetArray(row, col);
PrintArray(myarray);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < myarray.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        avarage = (avarage + myarray[i, j]);
    }
    avarage = avarage / row;
    avarage = Math.Round(avarage, 1);
    Console.Write(avarage + "\t");
}



int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 50);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}