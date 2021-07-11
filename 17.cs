using System;
class ele
{
static void Parray(params int[] arr)
{
Console.Write("Array elements are:");
foreach(int i in arr)
{
Console.Write(" "+i);
Console.WriteLine();
}
}
public static void Main()
{
int[] x= {11,22,33};
Parray(x);
Parray();
Parray(110,220);
}
}
