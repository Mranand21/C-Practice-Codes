using System;
struct Rectangle
{
int a,b;
public Rectangle(int x, int y)
{
a = x;
b = y;
}
public int Area()
{
return(a*b);
}
public void Display()
{
Console.WriteLine("Area="+Area());
}
}
class TestRectangle
{
public static void Main()
{
Rectangle rect = new Rectangle(10,20);
rect.Display();
}
}