Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <=7 && number >=1)
{
    if(number <=5)
Console.WriteLine("Это рабочий день");
     else
     {
        Console.WriteLine("Это выходной день");
     }
}
else 
{
    Console.WriteLine("Такого дня не существует");
   
}
