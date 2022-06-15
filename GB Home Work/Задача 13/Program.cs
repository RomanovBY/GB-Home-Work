int number = new Random().Next(0, 100000);
Console.WriteLine(number);

if(number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else 
{
    while(number>999)
    {
        number = number / 10;
    }
    int result = number % 100 % 10;
    Console.WriteLine(result);
}