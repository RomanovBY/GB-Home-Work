int Input (string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Input ("Введите координату x1:");
int x2 = Input ("Введите координату x2:");
int y1 = Input ("Введите координату y1:");
int y2 = Input ("Введите координату y2:");
int z1 = Input ("Введите координату z1:");
int z2 = Input ("Введите координату x2:");

int LineX = x2 - x1;
int LineY = y2 - y1;
int LineZ = z2 - z1;
double result = Math.Sqrt(LineX*LineX + LineY*LineY + LineZ*LineZ);

Console.WriteLine("Расстояние между точек в 3D пространстве = " + result);