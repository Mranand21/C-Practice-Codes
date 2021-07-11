using System;
class Program6
 {
 static void Main(string[] args)
 {
     int year;
     double principal,rate, interest;
     Console.Write("Enter The Amount : ");
     principal=Convert.ToDouble(Console.ReadLine());
     Console.Write("Enter The Number of Years : ");
     year=Convert.ToInt32(Console.ReadLine());
     Console.Write("Enter the Rate Of Interest : ");
     rate=Convert.ToDouble(Console.ReadLine());
     interest=principal*year*rate/100;
     Console.WriteLine("Simple Interest is:"+interest);
 }
 }