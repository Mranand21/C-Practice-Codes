using System;
class Library
{
 struct book
{
 public String bn;
 public String an;
 public String pn;
 public String tp;
 public int pr;
 public int ed;
};

 public static void Main()
{
 book b1;
 book b2;
 book b3;
 int ch;
 Console.WriteLine(" --LIBRARY-- ");
 b1.bn="NCERT Physics";
 b1.an="NCERT";
 b1.pn="CBSE";
 b1.pr=550;
 b1.ed=11;
 b1.tp="Physics";
 b2.bn="NCERT Chemistry";
 b2.an="NCERT";
 b2.pn="CBSE";
 b2.pr=400;
 b2.ed=9;
 b2.tp="Chemistry";
 b3.bn="NCERT Mathematics";
 b3.an="NCERT";
 b3.pn="CBSE";
 b3.pr=620;
 b3.ed=15;
 b3.tp="Maths";
 Console.WriteLine(" ~MAIN MENU~ ");
 Console.WriteLine(" 1.Add Book ");
 Console.WriteLine(" 2.Search Book ");
 Console.WriteLine(" 3.Delete Book ");
 Console.WriteLine(" 4.Exit ");
 Console.WriteLine(" Enter your choice ");
 ch=Convert.ToInt32(Console.ReadLine());
 switch(ch)
{
 case 1:
 Console.WriteLine(" ~ADD BOOK MENU~ ");
 Console.WriteLine(" 1.Author ");
 Console.WriteLine(" 2.Publisher ");
 Console.WriteLine(" 3.Topic ");
 Console.WriteLine(" 4.Back to main menu ");
 break;
 case 2:
 Console.WriteLine(" ~SEARCH BOOK MENU~ ");
 Console.WriteLine(" 1.Author ");
 Console.WriteLine(" 2.Publisher ");
 Console.WriteLine(" 3.Topic ");
 Console.WriteLine(" 4.Back to main menu ");
 break;
 case 3:
 Console.WriteLine(" ~DELETE BOOK MENU~ ");
 Console.WriteLine(" 1.Author ");
 Console.WriteLine(" 2.Publisher ");
 Console.WriteLine(" 3.Topic ");
 Console.WriteLine(" 4.Back to main menu ");
 break;
 case 4:
 break;
 default:
 Console.WriteLine("Wrong Choice");
 break;
 }
}
}