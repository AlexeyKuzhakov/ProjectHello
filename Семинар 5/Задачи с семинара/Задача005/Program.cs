﻿/*
[1,3,5,7]
[2,4,6,8,9]
->
[1,2,3,4,5,6,7,8]

[]
*/

int[] array1 = {1,3,5,7};
int[] array2 = {2,4,6,8};

for (int i = 0; i < array1.Length; i++) 
{
    Console.Write(array1[i] + " ");
    Console.Write(array2[i] + " ");
}
