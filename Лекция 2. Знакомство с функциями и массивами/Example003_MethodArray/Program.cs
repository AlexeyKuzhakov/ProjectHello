/*
Имеется одномерный массив array из n элементов, требуется найти 
элемени массива равный find
*/

int[] array = { 13, 22, 73, 46, 50, 46, 17, 22, 48 };
int n = array.Length;
int find = 22;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}