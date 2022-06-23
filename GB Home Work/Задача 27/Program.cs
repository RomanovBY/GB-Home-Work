Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int b = a;

while (a > 0)
{
    b = a % 10;
    sum = sum + b;
    a = a / 10;
}

Console.WriteLine(sum);