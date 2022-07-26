//Вывести максимальное число из цифр введенного числа
// 453 - 543
// 3485 - 8543


Console.WriteLine("Эта программа выведет максимальное число из цифр, введеного вами числа.\nВведите число: ");
int num = int.Parse(Console.ReadLine());
char[] arr = num.ToString().ToCharArray();
Array.Sort(arr);
Array.Reverse(arr);
Console.WriteLine(arr);

