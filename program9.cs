using System;
public class destroy
{
    public static void Main()
    {
        string str;
        int length = 0;
 
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        Console.Write("The characters of the string are  :  ");
        while (length <= str.Length - 1)
        {
            Console.Write("{0} ", str[length]);
            length++;
        }
        
    }
}