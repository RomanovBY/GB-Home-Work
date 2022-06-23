int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int a = Input ("Введите число A: ");
int b = Input ("Введите число B: ");
int sum = 1;
for(int i = 1; i <= b; i++)
{
  sum = sum * a;
}
Console.WriteLine(sum);
