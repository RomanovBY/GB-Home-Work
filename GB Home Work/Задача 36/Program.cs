int[] array = new int[5];
int SUM = 0;
int count = array.Length;

for (int i = 0; i < count;i++)
{
    array[i] = new Random().Next(1,100);
}
void PrintArray (int[] array)
{
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);

for (int i = 0; i < count;i++)
{
    if (i %2==1)
       SUM = SUM + array[i];
}
    Console.WriteLine($"Сумма нечетных элментов в массиве - {SUM}");


  
