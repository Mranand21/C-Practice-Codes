using System;
class one
{
public static void Main()
{
int a ;
 int c = 0;
float r;
Console.WriteLine("Enter a number");
a = Convert.ToInt32(Console.ReadLine());
while(a>0)
{
r = a%10;
if (r==1)
{
c++;
}
a=a/10;
}
Console.WriteLine("Number of 1 is");
Console.Write(c);
}
}
