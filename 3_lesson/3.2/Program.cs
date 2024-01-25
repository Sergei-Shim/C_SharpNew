
int[] array = {6, 4, -2, 1, -8, 2, -4, 7, -9};


for(int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write($"{array[i]} ");
}