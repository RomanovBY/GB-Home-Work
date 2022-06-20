Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = 0;
int number1 = number;
int n1 = 0;
while (number > 0)
{
  n1 = number % 10;
  n = n*10 + n1;
  number = number/10;
}
  if (number1 == n)
  {
    Console.WriteLine("Это число является полиндромом!");
  }
  else 
  {
        Console.WriteLine("Это число не является полиндромом!");
  }
