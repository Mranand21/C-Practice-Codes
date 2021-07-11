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
b1.bn="Physics";
b1.an="DEV";
b1.pn="CHAND";
b1.pr=570;
b1.ed=15;
b1.tp="Wave";
b2.bn="Chemistry";
b2.an="SUNIL";
b2.pn="SELINA";
b2.pr=480;
b2.ed=21;
b2.tp="Water";
b3.bn="Mathematics";
b3.an="JACOB";
b3.pn="NCERT";
b3.pr=980;
b3.ed=19;
b3.tp="Mode";
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
book b4;
int c1;
Console.WriteLine(" 1.Author ");
Console.WriteLine(" 2.Publisher ");
Console.WriteLine(" 3.Topic ");
Console.WriteLine(" 4.Back to main menu ");
c1=Convert.ToInt32(Console.ReadLine());
if(c1==1)
{
b4.an=Console.ReadLine();
Console.WriteLine("Book Author added");
}
if(c1==2)
{
b4.pn=Console.ReadLine();
Console.WriteLine("Book Publisher added");
}
if(c1==3)
{
b4.tp=Console.ReadLine();
Console.WriteLine("Book Topic added");
}
if(c1==4)
{
break;
}
break;
case 2:
int c2;
String s;
Console.WriteLine(" ~SEARCH BOOK MENU~ ");
Console.WriteLine(" 1.Author ");
Console.WriteLine(" 2.Publisher ");
Console.WriteLine(" 3.Topic ");
Console.WriteLine(" 4.Back to main menu ");
c2=Convert.ToInt32(Console.ReadLine());
if(c2==1)
{
Console.WriteLine("Search Author");
s=Console.ReadLine();
if(s==b1.an || s==b3.an || s==b2.an)
Console.WriteLine("Found");
else
Console.WriteLine("Not Found");
}
if(c2==2)
{
Console.WriteLine("Search Publisher");
s=Console.ReadLine();
if(s==b1.pn || s==b3.pn || s==b2.pn)
Console.WriteLine("Found");
else
Console.WriteLine("Not Found");
}
if(c2==3)
{
Console.WriteLine("Search Topic");
s=Console.ReadLine();
if(s==b1.tp || s==b3.tp || s==b2.tp)
Console.WriteLine("Found");
else
Console.WriteLine("Not Found");
}
if(c2==4)
{
break;
}
break;
case 3:
int c3;
String str;
Console.WriteLine(" ~DELETE BOOK MENU~ ");
Console.WriteLine(" 1.Author ");
Console.WriteLine(" 2.Publisher ");
Console.WriteLine(" 3.Topic ");
Console.WriteLine(" 4.Back to main menu ");
c3=Convert.ToInt32(Console.ReadLine());
if(c3==1)
{
Console.WriteLine("Delete Author");
str=Console.ReadLine();
if(str==b1.an || str==b2.an || str==b3.an)
{
b1.an="";
b2.an="";
b3.an="";
Console.WriteLine("Author Deleted");
}
else
Console.WriteLine("Author Not Found");
}
if(c3==2)
{
Console.WriteLine("Delete Publisher");
str=Console.ReadLine();
if(str==b1.pn || str==b2.pn || str==b3.pn)
{
b1.pn="";
b2.pn="";
b3.pn="";
Console.WriteLine("Publisher Deleted");
}
else
Console.WriteLine("Publisher Not Found");
}
if(c3==3)
{
Console.WriteLine("Delete Topic");
str=Console.ReadLine();
if(str==b1.tp || str==b2.tp || str==b3.tp)
{
b1.tp="";
b2.tp="";
b3.tp="";
Console.WriteLine("Topic Deleted");
}
else
Console.WriteLine("Topic Not Found");
}
if(c3==4)
{
break;
}
break;
case 4:
break;
default:
Console.WriteLine("Wrong Choice");
break;
}
}
}