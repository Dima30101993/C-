Console.WriteLine("Введите координаты первой точки:");
Console.Write("X: ");
int x1Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z1Coord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X: ");
int x2Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2Coord = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int z2Coord = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1Coord, y1Coord, z1Coord, x2Coord, y2Coord, z2Coord);
double finish = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между двух точек в 3D пространстве {finish}");

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
    return dis; 
}