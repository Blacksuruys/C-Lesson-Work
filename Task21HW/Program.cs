double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return dist;
}



Console.WriteLine("Введите координаты первой точки");
Console.WriteLine("x =");
int xcor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int zcor1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.WriteLine("x =");
int xcor2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y =");
int ycor2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("z =");
int zcor2 = Convert.ToInt32(Console.ReadLine());

double distanse = Distanse(xcor1, ycor1, zcor1, xcor2, ycor2, zcor2);
double distanseRound = Math.Round(distanse, 3);
Console.WriteLine($"Рвсстояние в 3D = {distanseRound}");




