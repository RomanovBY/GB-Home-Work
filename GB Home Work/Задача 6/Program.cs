Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if(N % 2 == 0)
{
   Console.WriteLine(N + " - четное число");
}
else
{
    Console.WriteLine(N + " - нечетное число");
}