using System;
class vvs
{
static void Square(int x , out int y)
{
y = x*x;
}
public static void Main()
{
int m;
Square(10,out m);
Console.WriteLine("m="+m);
}
}