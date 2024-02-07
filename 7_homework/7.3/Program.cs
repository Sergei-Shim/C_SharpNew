//Задача 3: Задайте произвольный массив. Выведете его элементы, 
//начиная с конца. Использовать рекурсию, не использовать циклы.
//int[] arr = {10, 4, 6, 1, 5, 9. 3};

class Program

{

    static void Main(string[] args)

    {

        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReverse(array, array.Length - 1);

    }

    static void PrintArrayReverse(int[] arr, int index)

    {

        if (index < 0)

        {

            return;

        }
    
        Console.WriteLine(arr[index]);
        PrintArrayReverse(arr, index - 1);

    }
}


