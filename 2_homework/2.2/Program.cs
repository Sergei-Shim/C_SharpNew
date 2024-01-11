int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);
if (x > 0 && y > 0){Console.WriteLine("one");}
if (x < 0 && y > 0){Console.WriteLine("two");}
if (x < 0 && y < 0){Console.WriteLine("three");}
if (x > 0 && y < 0){Console.WriteLine("four");}
else {Console.WriteLine(x == 0 && y == 0);}