char[,] charArr = new char[,] { {'R','e','a','d'}, {'L','i','n','e'}};
string result = Concat(charArr);
Console.WriteLine(result);

string Concat(char[,] arr)
{
    string result = " ";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result += arr[i, j];    
        }
    }
    return result;
}

