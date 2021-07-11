using System;
class vvs 
{
public static void Main()
{
Console.WriteLine("Enter two string : ");
String str1 = Console.ReadLine();
String str2 = Console.ReadLine();
String str = " ";
str1 = str1 + str + str2;
String str3 = "Hello World";
Console.WriteLine(str1);
Console.WriteLine(str1.Length);
int x = String.Compare(str1,str2);
int y = String.Compare(str2,str1);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(str1.Equals(str3));
Console.WriteLine(str3.IndexOf('C'));
string str4 = str3.Replace('l','i');
string str5 = str3.Replace("Hello","Hi");
Console.WriteLine(str4);
Console.WriteLine(str5);
string str6 = str3.Substring(5);
string str7 = str3.Substring(5,2);
Console.WriteLine(str6);
Console.WriteLine(str7);
Console.WriteLine("Removing String:\t" + str3.Remove(9));
Console.WriteLine("UpperCased:\t" + str3.ToUpper());
Console.WriteLine("LowerCased:\t" + str3.ToLower());
Console.Read();
}
}


