using System;
class vvs
{
static void Change(int m)
{
m = m+10;
Console.WriteLine("m="+m);
}
public static void Main()
{
int x=100;
Change(x);
Console.WriteLine("x="+x);
}
}