/* 
In the Chapter02 solution, create a console app project named Exercise_Numbers 
that outputs the number of bytes in memory that each of the following number 
types uses and the minimum and maximum values they can have: 
sbyte, byte, short, ushort, int, uint, long, ulong, 
Int128, UInt128, Half, float, double, and decimal.
 */

var dashes = new string('-', 103);
Console.WriteLine(dashes); 
Console.WriteLine("Type      Byte(s) of Memory                            Min                                          Max");
Console.WriteLine(dashes); 
Console.WriteLine($"sbyte     {sizeof(sbyte), -3}{sbyte.MinValue,45}{sbyte.MaxValue,45}");
Console.WriteLine($"byte      {sizeof(byte), -3}{byte.MinValue,45}{byte.MaxValue,45}");
Console.WriteLine($"short     {sizeof(short), -3}{short.MinValue,45}{short.MaxValue,45}");
Console.WriteLine($"ushort    {sizeof(ushort), -3}{ushort.MinValue,45}{ushort.MaxValue,45}");
Console.WriteLine($"int       {sizeof(int), -3}{int.MinValue,45}{int.MaxValue,45}");
Console.WriteLine($"uint      {sizeof(uint), -3}{uint.MinValue,45}{uint.MaxValue,45}");
Console.WriteLine($"long      {sizeof(long), -3}{long.MinValue,45}{long.MaxValue,45}");
Console.WriteLine($"ulong     {sizeof(ulong), -3}{ulong.MinValue,45}{ulong.MaxValue,45}");
unsafe
{
    Console.WriteLine($"Int128    {sizeof(Int128), -3}{Int128.MinValue,45}{Int128.MaxValue,45}");
    Console.WriteLine($"UInt128   {sizeof(UInt128), -3}{UInt128.MinValue,45}{UInt128.MaxValue,45}");
    Console.WriteLine($"Half      {sizeof(Half), -3}{Half.MinValue,45}{Half.MaxValue,45}");
}
Console.WriteLine($"float     {sizeof(float), -3}{float.MinValue,45}{float.MaxValue,45}");
Console.WriteLine($"double    {sizeof(double), -3}{double.MinValue,45}{double.MaxValue,45}");
Console.WriteLine($"decimal   {sizeof(decimal), -3}{decimal.MinValue,45}{decimal.MaxValue,45}");