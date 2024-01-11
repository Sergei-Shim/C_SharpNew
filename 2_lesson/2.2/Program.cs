int a = int.Parse(Console.ReadLine()!);
int SecondNumber = a / 10 % 10;
int ThirdNumber = a % 10;
Console.WriteLine (Math.Pow(SecondNumber,ThirdNumber));
