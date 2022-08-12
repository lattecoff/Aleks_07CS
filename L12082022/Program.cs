// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool mybool = false;
sbyte mysbyte = -100;
short myshort = -200;
int myint = 300;
long mylong = 400;
byte mybyte = 255;
ushort myushort = 500;
ulong myulong = 100;
double mydouble = 200.77;
float myfloat = 155.60f;
char mychar = 'a';
decimal mydecimal = 29.99m;
string mystring = "hello";

Console.WriteLine(mybool.GetType() + " " + sizeof(bool) +"bytes" + " " + mybool);
Console.WriteLine(mysbyte.GetType() + " " + sizeof(sbyte) + "bytes" + " " + mysbyte);
Console.WriteLine(myshort.GetType() + " " + sizeof(short) + "bytes" + " " + myshort);
Console.WriteLine(myint.GetType() + " " + sizeof(int) + "bytes" + " " + myint);
Console.WriteLine(mylong.GetType() + " " + sizeof(ulong) + "bytes" + " " + mylong);
Console.WriteLine(mybyte.GetType() + " " + sizeof(byte) + "bytes" + " " + mybyte);
Console.WriteLine(myushort.GetType() + " " + sizeof(ushort) + "bytes" + " " + myushort);
Console.WriteLine(myulong.GetType() + " " + sizeof(ulong) + "bytes" + " " + myulong);
Console.WriteLine(mydouble.GetType() + " " + sizeof(double) + "bytes" + " " + mydouble);
Console.WriteLine(myfloat.GetType() + " " + sizeof(float) + "bytes" + " " + myfloat);
Console.WriteLine(mychar.GetType() + " " + sizeof(char) + "bytes" + " " + mychar);
Console.WriteLine(mydecimal.GetType() + " " + sizeof(decimal) + "bytes" + " " + mydecimal);
Console.WriteLine(mystring.GetType() + " " + mystring);
