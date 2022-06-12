Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index<N+1)
{
    if (index % 2 == 0)
    {
        Console.Write(index + ",");
        index = index + 1;
    }
    else 
{
    index = index + 1;
}
}
Console.WriteLine();