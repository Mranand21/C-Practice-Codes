using System;
class program4
{
public static void Main(string[] args)
{
Console.WriteLine("Enter the String:");
string s=Console.ReadLine();
string[] a =s.Split(' ');
Array.Reverse(a);
Console.WriteLine("Reverse String is:");
for(int i=0;i<=a.Length-1;i++)
{
Console.Write(a[i]+""+' ');
}
Console.ReadKey();
}
}
