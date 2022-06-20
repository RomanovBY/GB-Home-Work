Console.WriteLine("Введите число N: ");
int count = 1;
int n = Convert.ToInt32(Console.ReadLine());

int Cube (int a)
{
    return a * a * a;
}

while (count < n) 
{
  int result = Cube(count);
  count++;
  Console.Write(result + ", ");
}
Console.WriteLine (Cube (n));
