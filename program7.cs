using System;
public class Program7
{
   public static void Main() {
      int count=0;
      int[] num=new int[] {1,9,3,1,5,6,1};
         for(int j=0;j<7;j++) {
         if (num[j]== 1) {
            count++;
         }
      }
      Console.WriteLine("Number of 1's: ");
      Console.WriteLine(count);
     }
}