using System;
delegate void multidelegate();
class muld
{
static public void display()
{
Console.WriteLine("MARSHALL");
}
static public void print()
{
Console.WriteLine("DIT UNIVERSITY");
}
}
class vvs 
{
public static void Main()
{
multidelegate ob1 = new multidelegate(muld.display);
multidelegate ob2 = new multidelegate(muld.print);
multidelegate ob3 = ob2+ob1;
multidelegate ob4 = ob1+ob2;
multidelegate ob5 = ob3-ob2;
ob3();
ob4();
ob5();
}
}

