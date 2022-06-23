
int[] array = new int[8];

PrintArray(array);

void PrintArray(int[] aray)
{
    for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + " ");
}
Console.WriteLine(" ");
}
