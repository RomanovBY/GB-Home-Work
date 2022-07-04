int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length;i++)
{
    array[i] = new Random().Next(100,1000);
}


PrintArray(array);
void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2==0)
        count++;
}
Console.WriteLine($"Количество четных чисел в массиве = {count}");