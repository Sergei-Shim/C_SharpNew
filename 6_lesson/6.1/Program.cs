// 1. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int Rec(int a)
{
    if (a == 0)
    {
        return 0;
    }
    return Rec(a / 10) + a % 10;
}
int result = Rec(123);
Console.Write(result);
