//3.Задайте произвольную строку. Выясните, является
// ли она палиндромом

bool Palindrome(string word)
{
    int size = word.Length;
    for (int i = 0; i < size / 2; i++)
    {
        if (word[i] != word[size - 1 - i])
            return false;
    }
    return true;
}

Console.Write("Ввести строку: ");
string str = Console.ReadLine()!;

bool result = Palindrome(str);
Console.WriteLine($"Строка - палиндром - {result}"); 
