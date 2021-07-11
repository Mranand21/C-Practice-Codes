using System;
class vvs
{
public static void Main()
{
int[] x = {10,31,34,67,89,2};
int[] temp = x;
Console.WriteLine("Original Array: ");
foreach(int i in x)
{
Console.Write(i + " ");
}
Console.WriteLine();
Array.Reverse(temp);
Console.WriteLine("Reversed Array: ");
foreach(int i in temp)
{
Console.Write(i +  " ");
}
Console.WriteLine();
Array.Sort(x);
Console.WriteLine("Sort Array: ");
foreach(int i in temp)
{
Console.Write(i + " ");
}
Console.WriteLine();
Console.ReadKey();
}
}