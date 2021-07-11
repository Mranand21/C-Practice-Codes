using System;
public class vvs
{
public static void Main(String[] args)
{
string str;
Console.Write("Enter a string");
str = Console.ReadLine();
Console.Write("Individual characters");
for(int i = 0; i<str.Length;i++)
{
Console.WriteLine(str[i]+" ");
}
}
}
