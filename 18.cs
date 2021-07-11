using System;
class vvs
{
static void Swap( int x, int y)
{
int temp = x;
x=y;
y = temp;
}
public static void Main()
{
int m=100;
int n=200;
Console.WriteLine("Before Swapping:");
Console.WriteLine("m="+m);
Console.WriteLine("n="+n);
Swap( m, n);
Console.WriteLine("After Swapping");
Console.WriteLine("m="+m);
Console.WriteLine("n="+n);
}
}
