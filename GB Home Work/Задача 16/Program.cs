int firstNumber = Input("Введите первое число: ");
int secondNumber = Input("Введите второе число: ");

int firstNumberSquare = firstNumber * firstNumber;
int secondNumberSquare = secondNumber * secondNumber;

if (firstNumber == secondNumberSquare || secondNumber == firstNumberSquare)
{
    if (firstNumber == secondNumberSquare)
    {
        Console.WriteLine(firstNumber + " является квадратом " + secondNumber);

    }
    else 
    {
        Console.WriteLine(secondNumber + " является квадратом " + firstNumber);

    }
}
else 
{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");

}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
