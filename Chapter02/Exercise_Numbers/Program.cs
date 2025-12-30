/* 
In the Chapter02 solution, create a console app project named Exercise_Numbers 
that outputs the number of bytes in memory that each of the following number 
types uses and the minimum and maximum values they can have: 
sbyte, byte, short, ushort, int, uint, long, ulong, 
Int128, UInt128, Half, float, double, and decimal.
 */

var dashes = new string('-', 73);
Console.WriteLine(dashes); 
Console.WriteLine("Type      Byte(s) of Memory             Min                           Max");
Console.WriteLine(dashes); 
Console.WriteLine($"sbyte     {sizeof(sbyte), -3}{sbyte.MinValue,30}{sbyte.MaxValue,30}");
Console.WriteLine($"byte      {sizeof(byte), -3}{byte.MinValue,30}{byte.MaxValue,30}");
Console.WriteLine($"short     {sizeof(short), -3}{short.MinValue,30}{short.MaxValue,30}");
Console.WriteLine($"ushort    {sizeof(ushort), -3}{ushort.MinValue,30}{ushort.MaxValue,30}");
Console.WriteLine($"int       {sizeof(int), -3}{int.MinValue,30}{int.MaxValue,30}");
Console.WriteLine($"uint      {sizeof(uint), -3}{uint.MinValue,30}{uint.MaxValue,30}");
Console.WriteLine($"long      {sizeof(long), -3}{long.MinValue,30}{long.MaxValue,30}");
Console.WriteLine($"ulong     {sizeof(ulong), -3}{ulong.MinValue,30}{ulong.MaxValue,30}");
Console.WriteLine($"Int128    {sizeof(Int128), -3}{Int128.MinValue,30}{Int128.MaxValue,30}");