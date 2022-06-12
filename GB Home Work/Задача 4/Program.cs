Console.Write("Введите 1-ое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(max<number2)
{
    max = number2;
    if(max<number3)
{
    max = number3;
    Console.WriteLine(number3 + " - максимальное число");
}
    else
    {
        Console.WriteLine(number2 + " - максимальное число");
    }
}
else 
{
    max = number1;
    if(max<number3)
    {
        max = number3;
        Console.WriteLine(number3 + " - максимальное число");
    }
    else 
    {
        max = number1;
        Console.WriteLine(number1 + " - максимальное число");
    }
}