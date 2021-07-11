using System;
class simple
{
 public static void Main(string[] args)
 {
 double p,r,t,si=0;
 Console.WriteLine("Enter Principal, Rate and Time ");
 p=Convert.ToDouble(Console.ReadLine());
 r=Convert.ToDouble(Console.ReadLine());
 t=Convert.ToDouble(Console.ReadLine());
 si=(p*r*t*.01);
Console.WriteLine("Calculated Simple Interest ="+si);
}
}