using System;
class Program2
{​​​​
public static void Main(string[] args)
{​​​​
int[] Roll = new int[5];
string[] Branch = new string[10];
string[] Name =new string[10];
Console.WriteLine("Enter details of 5 students");
for(int i=0;i<5;i++)
{​​​​
    Roll[i] = Convert.ToInt32(Console.ReadLine());
    Branch[i] = Console.ReadLine();
    Name[i] = Console.ReadLine();
}​​​​
Console.WriteLine("Details of students are:");
for (int i = 0; i < 5; i++)
{​​​​
    Console.Write(Roll[i]+" ");
    Console.Write(Branch[i]+" ");
    Console.Write(Name[i]+" ");
}​​​​
 
}​​​​
}​​​​