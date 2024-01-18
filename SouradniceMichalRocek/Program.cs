using SouradniceMichalRocek;

Coord c1 = new Coord(10, 15);
Coord c2 = new Coord(9, 10);

Console.WriteLine(c1 < c2); // False
Console.WriteLine(c2.Equals(c2)); // True
if (c1 > c2) { Console.WriteLine("haha"); }
Console.WriteLine(c1 + c2);
Console.WriteLine(c1 - c2);
Console.WriteLine(c1 * 2);
Console.WriteLine(2 * c1);
Console.WriteLine(c1 / 2);