
using System.Text;
using System.Collections.Generic;
using _02UnderstandingTypes;
using System.IO;
/*
* size and min and max values
* sbyte, byte, short, ushort, int, uint, long,ulong, float, double, and decimal
*/
Console.WriteLine("sizeof(sbyte): {0} min:{1} max: {2}", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
Console.WriteLine("sizeof(byte): {0} min:{1} max: {2}", sizeof(byte), byte.MinValue, byte.MaxValue);
Console.WriteLine("sizeof(short): {0} min:{1} max: {2}", sizeof(short), short.MinValue, short.MaxValue);
Console.WriteLine("sizeof(ushort): {0} min:{1} max: {2}", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
Console.WriteLine("sizeof(int): {0} min:{1} max: {2}", sizeof(int), int.MinValue, int.MaxValue);
Console.WriteLine("sizeof(uint): {0} min:{1} max: {2}", sizeof(uint), uint.MinValue, uint.MaxValue);
Console.WriteLine("sizeof(long): {0} min:{1} max: {2}", sizeof(long), long.MinValue, long.MaxValue);
Console.WriteLine("sizeof(ulong): {0} min:{1} max: {2}", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
Console.WriteLine("sizeof(float): {0} min:{1} max: {2}", sizeof(float), float.MinValue, float.MaxValue);
Console.WriteLine("sizeof(double): {0} min:{1} max: {2}", sizeof(double), double.MinValue, double.MaxValue);
Console.WriteLine("sizeof(decimal): {0} min:{1} max: {2}", sizeof(decimal), decimal.MinValue, decimal.MaxValue);


TimeConversion timeConversion = new TimeConversion();

timeConversion.TimeCon(100);


//FizzBuzz f = new FizzBuzz();

//f.FizzBuzzGame(30);

//Print_a_PyramidGame py = new Print_a_PyramidGame();
//py.Pyramid(5);


//CountingGame co = new CountingGame();
//co.Counting(4);

//RandomNumberGame ra = new RandomNumberGame();

//ra.RandomNumber();

Greeting g = new Greeting(DateTime.Now);