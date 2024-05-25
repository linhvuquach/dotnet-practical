/*** Characteristics of the integral types ***/

sbyte a = 5;
byte b = 5;
short c = 5;
ushort d = 5;
int e = 5;
uint f = 5;
long g = 5;
ulong h = 5;
nint i = 5;
nuint j = 5;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(f);
Console.WriteLine(g);
Console.WriteLine(h);
Console.WriteLine(i);
Console.WriteLine(j);

/*** Integer literals ***/

Console.WriteLine("Integer literals");
var decimalLiteral = 5;
var binaryLiteral = 0b_0101;
var hexLiteral = 0x5A;

var monday_to_thurday = 0b_1111000;

Console.WriteLine(decimalLiteral);
Console.WriteLine(binaryLiteral);
Console.WriteLine(hexLiteral);

/*** Native sized integers***/
Console.WriteLine("Native sized integers");
Console.WriteLine($"size of nint = {sizeof(int)}");
Console.WriteLine($"int.minValue = {int.MinValue}");
Console.WriteLine($"int.maxValue = {int.MaxValue}");